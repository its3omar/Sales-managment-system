namespace SalesMS.WinForms
{
    partial class SaveCustomerForm
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
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSaveUser = new Button();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(335, 272);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(150, 31);
            tbEmail.TabIndex = 0;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(335, 178);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(150, 31);
            tbPhone.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(335, 88);
            tbName.Name = "tbName";
            tbName.Size = new Size(150, 31);
            tbName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 91);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 5;
            label2.Text = "First name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 178);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 6;
            label3.Text = "Phone :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 272);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 7;
            label4.Text = "Email :";
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(351, 348);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(118, 59);
            btnSaveUser.TabIndex = 8;
            btnSaveUser.Text = "Save User";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // SaveCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Name = "SaveCustomerForm";
            Text = "SaveCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSaveUser;
    }
}