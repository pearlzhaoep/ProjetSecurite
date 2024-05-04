namespace ProjetSecurite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Left = (this.Width - this.label1.Width) / 2;
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount createForm = new CreateAccount();
            createForm.ShowDialog();
            this.Show();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextbox.Text;
            string password = this.passwordTextbox.Text;
            ConnextionBD connectionLogin = ConnextionBD.getInstance();
            UserInfo userfetched = connectionLogin.fetchUserInfo(username, password);
            if (userfetched != null)
            {
                Profile newProfilePage = new Profile(userfetched);
                this.Hide();
                newProfilePage.ShowDialog();
                newProfilePage = null;
                this.usernameTextbox.Text = "";
                this.passwordTextbox.Text = "";
                this.Show();
            }
            
        }
    }
}