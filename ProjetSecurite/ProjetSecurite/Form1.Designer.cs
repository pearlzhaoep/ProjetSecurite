namespace ProjetSecurite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            createButton = new Button();
            connectButton = new Button();
            leaveButton = new Button();
            label2 = new Label();
            label3 = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(201, 26);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(421, 46);
            label1.TabIndex = 1;
            label1.Text = "L'autruche du chiffrement";
            // 
            // createButton
            // 
            createButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createButton.Location = new Point(278, 245);
            createButton.Name = "createButton";
            createButton.Size = new Size(138, 53);
            createButton.TabIndex = 2;
            createButton.Text = "Créer compt";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // connectButton
            // 
            connectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            connectButton.Location = new Point(449, 245);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(125, 54);
            connectButton.TabIndex = 3;
            connectButton.Text = "Connecter";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // leaveButton
            // 
            leaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            leaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            leaveButton.Location = new Point(606, 245);
            leaveButton.Name = "leaveButton";
            leaveButton.Size = new Size(112, 54);
            leaveButton.TabIndex = 4;
            leaveButton.Text = "Quitter";
            leaveButton.UseVisualStyleBackColor = true;
            leaveButton.Click += leaveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 106);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 4;
            label2.Text = "Nom d'utilisateur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 164);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 5;
            label3.Text = "Mot de passe";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTextbox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextbox.Cursor = Cursors.IBeam;
            usernameTextbox.Location = new Point(278, 106);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(353, 27);
            usernameTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextbox.Cursor = Cursors.IBeam;
            passwordTextbox.ForeColor = SystemColors.WindowText;
            passwordTextbox.Location = new Point(278, 164);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(353, 27);
            passwordTextbox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 333);
            Controls.Add(leaveButton);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(createButton);
            Controls.Add(label1);
            Controls.Add(connectButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autruche";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button createButton;
        private Button leaveButton;
        private Label label2;
        private Label label3;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button connectButton;
    }
}