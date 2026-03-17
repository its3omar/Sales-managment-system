namespace SalesMS.WinForms
{
    partial class SMainForm
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
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem1 = new ToolStripMenuItem();
            editAccountInfoToolStripMenuItem = new ToolStripMenuItem();
            miLogOut = new ToolStripMenuItem();
            miDeleteMyAccount = new ToolStripMenuItem();
            label1 = new Label();
            lblBalance = new Label();
            label3 = new Label();
            btnDeposite = new Button();
            btnMainShop = new Button();
            btnOrders = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(826, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountToolStripMenuItem1 });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(84, 29);
            accountToolStripMenuItem.Text = "Setting";
            // 
            // accountToolStripMenuItem1
            // 
            accountToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { editAccountInfoToolStripMenuItem, miLogOut, miDeleteMyAccount });
            accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            accountToolStripMenuItem1.Size = new Size(179, 34);
            accountToolStripMenuItem1.Text = "Account";
            // 
            // editAccountInfoToolStripMenuItem
            // 
            editAccountInfoToolStripMenuItem.Name = "editAccountInfoToolStripMenuItem";
            editAccountInfoToolStripMenuItem.Size = new Size(261, 34);
            editAccountInfoToolStripMenuItem.Text = "Edit account info";
            editAccountInfoToolStripMenuItem.Click += editAccountInfoToolStripMenuItem_Click;
            // 
            // miLogOut
            // 
            miLogOut.Name = "miLogOut";
            miLogOut.Size = new Size(261, 34);
            miLogOut.Text = "Log out";
            miLogOut.Click += miLogOut_Click;
            // 
            // miDeleteMyAccount
            // 
            miDeleteMyAccount.Name = "miDeleteMyAccount";
            miDeleteMyAccount.Size = new Size(261, 34);
            miDeleteMyAccount.Text = "Delete my account";
            miDeleteMyAccount.Click += miDeleteMyAccount_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(500, 33);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Balance : ";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(626, 33);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(22, 25);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(777, 33);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 2;
            label3.Text = "$";
            // 
            // btnDeposite
            // 
            btnDeposite.Location = new Point(707, 83);
            btnDeposite.Name = "btnDeposite";
            btnDeposite.Size = new Size(92, 47);
            btnDeposite.TabIndex = 3;
            btnDeposite.Text = "Deposite";
            btnDeposite.UseVisualStyleBackColor = true;
            btnDeposite.Click += btnDeposite_Click_1;
            // 
            // btnMainShop
            // 
            btnMainShop.Location = new Point(177, 115);
            btnMainShop.Name = "btnMainShop";
            btnMainShop.Size = new Size(151, 75);
            btnMainShop.TabIndex = 4;
            btnMainShop.Text = "Shop";
            btnMainShop.UseVisualStyleBackColor = true;
            btnMainShop.Click += btnMainShop_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(177, 196);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(151, 73);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "My Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // button1
            // 
            button1.Location = new Point(177, 275);
            button1.Name = "button1";
            button1.Size = new Size(151, 66);
            button1.TabIndex = 6;
            button1.Text = "My Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(826, 450);
            Controls.Add(button1);
            Controls.Add(btnOrders);
            Controls.Add(btnMainShop);
            Controls.Add(btnDeposite);
            Controls.Add(label3);
            Controls.Add(lblBalance);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SMainForm";
            Text = "SMainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem1;
        private ToolStripMenuItem editAccountInfoToolStripMenuItem;
        private ToolStripMenuItem miLogOut;
        private ToolStripMenuItem miDeleteMyAccount;
        private Label label1;
        private Label lblBalance;
        private Label label3;
        private Button btnDeposite;
        private Button btnMainShop;
        private Button btnOrders;
        private Button button1;
    }
}