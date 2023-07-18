namespace ProjetSecurite
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeMessage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            changePWButton = new Button();
            buttonLogout = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeMessage
            // 
            welcomeMessage.Anchor = AnchorStyles.None;
            welcomeMessage.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(welcomeMessage, 2);
            welcomeMessage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeMessage.Location = new Point(178, 69);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(52, 28);
            welcomeMessage.TabIndex = 0;
            welcomeMessage.Text = "xxxx";
            welcomeMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(changePWButton, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonLogout, 1, 1);
            tableLayoutPanel1.Controls.Add(welcomeMessage, 0, 0);
            tableLayoutPanel1.Location = new Point(93, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(409, 209);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // changePWButton
            // 
            changePWButton.Anchor = AnchorStyles.None;
            changePWButton.Location = new Point(14, 170);
            changePWButton.Name = "changePWButton";
            changePWButton.Size = new Size(176, 36);
            changePWButton.TabIndex = 1;
            changePWButton.Text = "Modifier mot de passe";
            changePWButton.UseVisualStyleBackColor = true;
            changePWButton.Click += changePWButton_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.None;
            buttonLogout.Location = new Point(228, 170);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(156, 36);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Déconnecter";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 260);
            Controls.Add(tableLayoutPanel1);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label welcomeMessage;
        private TableLayoutPanel tableLayoutPanel1;
        private Button changePWButton;
        private Button buttonLogout;
    }
}