using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSecurite
{
    public partial class CreateAccount : Form
    {
        private UserInfo newUser;
        public CreateAccount()
        {
            InitializeComponent();
            newUser = new UserInfo();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool checkNomTextBox()
        {
            bool isReady = false;
            string nomText = this.NomTextBox.Text;
            if (Util.checkInputAlphbet(nomText) && nomText.Length <= 20)
            {
                this.label7.Hide();
                newUser.Nom = nomText;
                isReady = true;
            }
            else
            {
                this.label7.ForeColor = Color.Red;
                this.label7.Show();
            }
            return isReady;
        }

        private bool checkPreNomTextBox()
        {
            bool isReady = false;
            string prenomText = this.prenomTextBox.Text;
            if (Util.checkInputAlphbet(prenomText) && prenomText.Length <= 20)
            {
                this.label8.Hide();
                newUser.Prenom = prenomText;
                isReady = true;
            }
            else
            {
                this.label8.ForeColor = Color.Red;
                this.label8.Show();
            }
            return isReady;
        }

        private bool checkUsernameTextBox()
        {
            bool isReady = false;
            string usernameText = this.UsernameTextBox.Text;
            if (Util.checkInputAlphNum(usernameText) && usernameText.Length <= 20)
            {
                this.label9.Hide();
                newUser.Username = usernameText;
                isReady = true;
            }
            else
            {
                this.label9.ForeColor = Color.Red;
                this.label9.Show();
            }
            return isReady;
        }

        private bool checkEmailTextBox()
        {
            bool isReady = false;
            string emailText = this.emailTextBox.Text;
            if (Util.checkEmail(emailText) && emailText.Length <= 30)
            {
                this.label10.Hide();
                newUser.Email = emailText;
                isReady = true;
            }
            else
            {
                this.label10.ForeColor = Color.Red;
                this.label10.Show();
            }
            return isReady;
        }

        private bool checkPasswordTextBox()
        {
            bool isReady = false;
            string password = this.pwTextBox.Text;
            if (Util.checkPassword(password) && password.Length >= 8)
            {
                this.label11.Hide();
                newUser.Password = password;
                isReady = true;
            }
            else
            {
                this.label11.ForeColor = Color.Red;
                this.label11.Show();
            }
            return isReady;
        }

        private bool checkConfirmPWTextBox()
        {
            bool isReady = false;
            string passwordConfirm = this.confirmationTextBox.Text;
            if (passwordConfirm.Equals(newUser.Password))
            {
                this.label12.Hide();
                isReady = true;
            }
            else
            {
                this.label12.ForeColor = Color.Red;
                this.label12.Show();
            }
            return isReady;
        }

        private bool checkForSubmit()
        {
            bool isReadyForSubmit = checkNomTextBox() && checkPreNomTextBox() && checkUsernameTextBox() && checkEmailTextBox() && checkPasswordTextBox() && checkConfirmPWTextBox();
            return isReadyForSubmit;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (checkForSubmit())
            {
                newUser.createSalt();
                newUser.computeHash();
                ConnextionBD connectionToAddNewUser = ConnextionBD.getInstance();
                if (connectionToAddNewUser.addUserToDB(newUser))
                {
                    MessageBox.Show("Votre compte a été creé avec succès");
                    this.Close();
                }
            }
        }
    }
}
