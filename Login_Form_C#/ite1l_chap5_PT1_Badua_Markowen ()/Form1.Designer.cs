namespace ite1l_chap5_PT1_Badua_Markowen___
{
    partial class frmLogIn
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(29, 124);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(29, 181);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(121, 117);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 27);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 179);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.AntiqueWhite;
            btnLogin.Location = new Point(121, 241);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.AntiqueWhite;
            btnCancel.Location = new Point(268, 241);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(164, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 31);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "LOGIN FORM";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += label1_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(451, 363);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log-In";
            Load += frmLogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
        private Label lblTitle;
    }
}