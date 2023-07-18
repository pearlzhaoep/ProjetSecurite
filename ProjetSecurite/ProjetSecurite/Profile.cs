using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSecurite
{
    public partial class Profile : Form
    {
        private UserInfo userAAfficher;
        public Profile(UserInfo user)
        {
            InitializeComponent();
            userAAfficher = user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            this.welcomeMessage.Text = $"Welcome {userAAfficher.Prenom}!";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePWButton_Click(object sender, EventArgs e)
        {
            ModifierPW changePW = new ModifierPW(userAAfficher);
            changePW.ShowDialog();
        }
    }
}
