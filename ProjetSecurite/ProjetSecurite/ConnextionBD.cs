using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProjetSecurite
{
    internal class ConnextionBD
    {
        private static ConnextionBD singleton = null;
        private UserInfo userfetched;
        private ConnextionBD()
        {
        }
        public static ConnextionBD getInstance()
        {
            singleton = singleton ?? new ConnextionBD();
            return singleton;
        }
        
        private MySqlConnection connectToDB()
        {
            string DBconnectionPath = Path.Combine(Directory.GetCurrentDirectory(), "dbchemin.txt");
            string connectionString = File.ReadAllLines(DBconnectionPath)[0];
            MySqlConnection cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
            }
            catch(MySqlException e)
            {
                throw e;
            }
            return cnn;
        }
        public bool addUserToDB(UserInfo newUser)
        {
            bool isAdded = false;
            MySqlConnection cnn = null;
            try
            {
                cnn = connectToDB();
                string sql = "INSERT INTO autruchelogindata (nom, prenom, username, email, salt, hashedmotdepasse) VALUES (@nom, @prenom, @username, @email, @salt, @hashedmotdepasse)";
                MySqlCommand commande = new MySqlCommand(sql, cnn);
                commande.Parameters.AddWithValue("@nom", newUser.Nom);
                commande.Parameters.AddWithValue("@prenom", newUser.Prenom);
                commande.Parameters.AddWithValue("@username", newUser.Username);
                commande.Parameters.AddWithValue("@email", newUser.Email);
                commande.Parameters.AddWithValue("@salt", newUser.Salt);
                commande.Parameters.AddWithValue("@hashedmotdepasse", newUser.HashedPassword);
                commande.ExecuteReader();
                isAdded = true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show($"Impossible d'ajouter le nouveau utilisateur au serveur. {e.Message}");
            }
            finally
            {
                if(cnn != null)
                {
                    cnn.Close();
                }
            }
            return isAdded;
        }

        public bool updatePWToDB(UserInfo newPWUser)
        {
            bool isAdded = false;
            MySqlConnection cnn = null;
            try
            {
                cnn = connectToDB();
                string sql = "UPDATE autruchelogindata SET salt = @salt, hashedmotdepasse = @hashedmotdepasse WHERE id = @id";
                MySqlCommand commande = new MySqlCommand(sql, cnn);
                commande.Parameters.AddWithValue("@id", newPWUser.Id);
                commande.Parameters.AddWithValue("@salt", newPWUser.Salt);
                commande.Parameters.AddWithValue("@hashedmotdepasse", newPWUser.HashedPassword);
                commande.ExecuteReader();
                isAdded = true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Impossible d'ajouter le nouveau utilisateur au serveur. {e.Message}");
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            return isAdded;
        }

        public UserInfo fetchUserInfo(string username, string password)
        {
            userfetched = null;
            MySqlConnection cnn = null;
            try
            {
                cnn = connectToDB();
                string sql = "SELECT failedattempt, salt, hashedmotdepasse, lastlogintime, nom, prenom, id FROM autruchelogindata WHERE username = @username";
                MySqlCommand commande = new MySqlCommand(sql, cnn);
                commande.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = commande.ExecuteReader())
                {
                    reader.Read();
                    if (reader.HasRows)
                    {
                        userfetched = new UserInfo();
                        userfetched.FailedAttemp = reader.GetInt32(0);
                        userfetched.Salt = reader.GetString(1);
                        userfetched.HashedPassword = reader.GetString(2);
                        userfetched.LastLoginTime = reader.GetDateTime(3);
                        userfetched.Nom = reader.GetString(4);
                        userfetched.Prenom = reader.GetString(5);
                        userfetched.Id = reader.GetInt32(6);
                    }
                    else MessageBox.Show("Ce utilisateur n'existe pas.");
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Impossible de connecter. {e.Message}");
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
            if(userfetched != null)
            {
                validateLoginInfo(password);
            }
            return userfetched!;
        }
        private void validateLoginInfo(string passwordInput)
        {
            checkIfToUnlock(userfetched.LastLoginTime);
            if (userfetched.FailedAttemp >= 2)
            {
                MessageBox.Show("Votre compte a été verrouillé. Il sera déverrouillé 30 secondes après votre dernière tentative invalide. Ou vous pouvez contacter l'administration.");
                userfetched = null!;
            }
            else
            {
                string saltedInputPW = userfetched.Salt + passwordInput;
                compareHashing(saltedInputPW, userfetched.HashedPassword);
            }
        }

        private void updateTentative(int tentative, int id)
        {
            MySqlConnection cnn = null;
            try
            {
                cnn = connectToDB();
                string sql = "UPDATE autruchelogindata SET failedattempt = @failedattempt, lastlogintime = @lastlogintime WHERE id = @id";
                MySqlCommand commande = new MySqlCommand(sql, cnn);
                commande.Parameters.AddWithValue("@id", id);
                commande.Parameters.AddWithValue("@failedattempt", tentative);
                commande.Parameters.AddWithValue("@lastlogintime", DateTime.UtcNow);
                commande.ExecuteReader();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
        }

        private void checkIfToUnlock(DateTime lastLoginTime)
        {
            DateTime currentTime = DateTime.UtcNow;
            DateTime lockExpireTime = lastLoginTime.AddMinutes(0.5);
            if(DateTime.Compare(currentTime, lockExpireTime) >= 0)
            {
                updateTentative(0, userfetched.Id);
                userfetched.FailedAttemp = 0;
            }
        }


        private void compareHashing(string inputPW, string hashedPW)
        {
            string hashedInputPW = Util.hashing(inputPW);
            if (!hashedInputPW.Equals(hashedPW))
            {
                handleFailedAttempt();
            }
        }

        private void handleFailedAttempt()
        {
            userfetched.FailedAttemp++;
            updateTentative(userfetched.FailedAttemp, userfetched.Id);
            MessageBox.Show($"Mot de passe invalide. Il reste {3-userfetched.FailedAttemp} tentative(s) avant que votre compt soit verrouillé.");
            userfetched = null;
        }
    }
}
