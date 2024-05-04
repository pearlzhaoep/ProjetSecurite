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
    public partial class ModifierPW : Form
    {
        private UserInfo userNewPW = new UserInfo();
        private UserInfo currentInfo;
        public ModifierPW(UserInfo currentUser)
        {
            InitializeComponent();
            currentInfo = currentUser;
            userNewPW.Salt = currentInfo.Salt;
            userNewPW.Id = currentInfo.Id;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkCurrentPWInput()
        {
            bool isReady = false;
            string currentPW = this.currentPWTextBox.Text;
            string inputHashed = Util.hashing(currentInfo.Salt + currentPW);
            if (inputHashed.Equals(currentInfo.HashedPassword))
            {
                this.label4.Hide();
                isReady = true;
            }
            else
            {
                this.label4.ForeColor = Color.Red;
                this.label4.Show();
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
                userNewPW.Password = password;
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
            if (passwordConfirm.Equals(userNewPW.Password))
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
            bool isReadyForSubmit = checkCurrentPWInput() && checkPasswordTextBox() && checkConfirmPWTextBox();
            return isReadyForSubmit;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (checkForSubmit())
            {
                userNewPW.computeHash();
                if (userNewPW.HashedPassword.Equals(currentInfo.HashedPassword))
                {
                    MessageBox.Show("Veuillez choisir un mot de passe different.");
                }
                else
                {
                    updatePWToBD();
                }
            }
        }

        private void updatePWToBD()
        {
            ConnextionBD connectionToAddNewUser = ConnextionBD.getInstance();
            if (connectionToAddNewUser.updatePWToDB(userNewPW))
            {
                MessageBox.Show("Votre mot de passe a été modifié avec succès");
                currentInfo.HashedPassword = userNewPW.HashedPassword;
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
