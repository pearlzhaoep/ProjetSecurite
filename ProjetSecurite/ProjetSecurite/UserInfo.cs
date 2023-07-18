using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using K4os.Compression.LZ4.Encoders;

namespace ProjetSecurite
{
    public class UserInfo
    {
        private int id;
        private string nom;
        private string prenom;
        private string username;
        private string email;
        private string password;
        private string salt;
        private string hashedPassword;
        private int failedAttemp;
        private DateTime lastLoginTime;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Salt { get => salt; set => salt = value; }
        public string HashedPassword { get => hashedPassword; set => hashedPassword = value; }
        public int FailedAttemp { get => failedAttemp; set => failedAttemp = value; }
        public DateTime LastLoginTime { get => lastLoginTime; set => lastLoginTime = value; }

        public void computeHash()
        {
            HashedPassword = "";
            string saltedPassword = Salt + Password;
            HashedPassword = Util.hashing(saltedPassword);
        }

        public void createSalt()
        {
            Salt = Guid.NewGuid().ToString();
        }

    }
}
