namespace SalesMS.WinForms
{
    partial class LoginForm
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
            btnLogin = new Button();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCreateCustomer = new Label();
            chbxRememberMe = new CheckBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(268, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 49);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(268, 119);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(150, 31);
            tbUsername.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(268, 224);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(150, 31);
            tbEmail.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(268, 187);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(268, 78);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(203, 398);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 10;
            label3.Text = "don't have an accout ?";
            // 
            // lblCreateCustomer
            // 
            lblCreateCustomer.AutoSize = true;
            lblCreateCustomer.Location = new Point(416, 398);
            lblCreateCustomer.Name = "lblCreateCustomer";
            lblCreateCustomer.Size = new Size(94, 25);
            lblCreateCustomer.TabIndex = 11;
            lblCreateCustomer.Text = "create one";
            lblCreateCustomer.Click += lblCreateCustomer_Click;
            // 
            // chbxRememberMe
            // 
            chbxRememberMe.AutoSize = true;
            chbxRememberMe.Location = new Point(268, 284);
            chbxRememberMe.Name = "chbxRememberMe";
            chbxRememberMe.Size = new Size(154, 29);
            chbxRememberMe.TabIndex = 12;
            chbxRememberMe.Text = "Remember me";
            chbxRememberMe.UseVisualStyleBackColor = true;
            chbxRememberMe.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chbxRememberMe);
            Controls.Add(lblCreateCustomer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCreateCustomer;
        private CheckBox chbxRememberMe;
    }
}
