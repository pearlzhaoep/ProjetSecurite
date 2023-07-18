namespace ProjetSecurite
{
    partial class ModifierPW
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label12 = new Label();
            confirmationTextBox = new TextBox();
            label11 = new Label();
            pwTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            currentPWTextBox = new TextBox();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCreate = new Button();
            buttonQuitter = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.39286F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6071434F));
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(label12, 1, 5);
            tableLayoutPanel1.Controls.Add(confirmationTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(label11, 1, 3);
            tableLayoutPanel1.Controls.Add(pwTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(currentPWTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Location = new Point(108, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(566, 291);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(3, 203);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 2;
            label2.Text = "Confirmation";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.WindowFrame;
            label12.Location = new Point(220, 240);
            label12.Name = "label12";
            label12.Size = new Size(241, 20);
            label12.TabIndex = 18;
            label12.Text = "doit correspondre au mot de passe";
            label12.Visible = false;
            // 
            // confirmationTextBox
            // 
            confirmationTextBox.Anchor = AnchorStyles.Left;
            confirmationTextBox.Location = new Point(220, 202);
            confirmationTextBox.Name = "confirmationTextBox";
            confirmationTextBox.PasswordChar = '*';
            confirmationTextBox.Size = new Size(332, 27);
            confirmationTextBox.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoEllipsis = true;
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.WindowFrame;
            label11.Location = new Point(220, 144);
            label11.Name = "label11";
            label11.Size = new Size(309, 40);
            label11.TabIndex = 17;
            label11.Text = "Alphanumeriques min 8, nombres, caractères spéciaux, majuscules et minuscules.";
            label11.Visible = false;
            // 
            // pwTextBox
            // 
            pwTextBox.Anchor = AnchorStyles.Left;
            pwTextBox.Location = new Point(220, 106);
            pwTextBox.Name = "pwTextBox";
            pwTextBox.PasswordChar = '*';
            pwTextBox.Size = new Size(332, 27);
            pwTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(3, 107);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 1;
            label1.Text = "Nouveau mot de passe";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(171, 25);
            label3.TabIndex = 21;
            label3.Text = "Mot de passe actuel";
            // 
            // currentPWTextBox
            // 
            currentPWTextBox.Anchor = AnchorStyles.Left;
            currentPWTextBox.Location = new Point(220, 10);
            currentPWTextBox.Name = "currentPWTextBox";
            currentPWTextBox.PasswordChar = '*';
            currentPWTextBox.Size = new Size(332, 27);
            currentPWTextBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(220, 48);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 23;
            label4.Text = "Mot de passe incorrect.";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonCreate, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonQuitter, 1, 0);
            tableLayoutPanel2.Location = new Point(328, 389);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(356, 55);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Right;
            buttonCreate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ActiveCaptionText;
            buttonCreate.Location = new Point(52, 3);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(123, 49);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Modifier";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Anchor = AnchorStyles.Right;
            buttonQuitter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuitter.Location = new Point(246, 3);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(107, 49);
            buttonQuitter.TabIndex = 4;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // ModifierPW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 506);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "ModifierPW";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModifierPW";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label11;
        private Label label12;
        private TextBox pwTextBox;
        private TextBox confirmationTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonCreate;
        private Button buttonQuitter;
        private Label label3;
        private TextBox currentPWTextBox;
        private Label label4;
    }
}