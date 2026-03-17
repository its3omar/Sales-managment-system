namespace SalesMS.WinForms
{
    partial class ShopForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            lblBalance = new Label();
            label4 = new Label();
            lblCartContains = new Label();
            btnBuy = new Button();
            label5 = new Label();
            label3 = new Label();
            btnBack = new Button();
            tbSearch = new TextBox();
            label7 = new Label();
            lblReceipt = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(634, 409);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(596, 10);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "Balance :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(766, 10);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 2;
            label2.Text = "$";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = SystemColors.Control;
            lblBalance.ForeColor = SystemColors.ControlText;
            lblBalance.Location = new Point(682, 14);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(19, 25);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(652, 148);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 4;
            label4.Text = "Current Cart ";
            // 
            // lblCartContains
            // 
            lblCartContains.AutoSize = true;
            lblCartContains.Location = new Point(634, 258);
            lblCartContains.Name = "lblCartContains";
            lblCartContains.Size = new Size(0, 25);
            lblCartContains.TabIndex = 5;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(643, 379);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(121, 59);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(643, 80);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 8;
            label5.Text = "subtotal :";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(640, 182);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 10;
            label3.Text = "______________________";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DodgerBlue;
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(0, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 34);
            btnBack.TabIndex = 11;
            btnBack.Text = "◀";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(197, 7);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(280, 31);
            tbSearch.TabIndex = 12;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label7
            // 
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(483, 7);
            label7.Name = "label7";
            label7.Size = new Size(35, 29);
            label7.TabIndex = 13;
            label7.Text = "🔍";
            // 
            // lblReceipt
            // 
            lblReceipt.AutoSize = true;
            lblReceipt.BackColor = SystemColors.Control;
            lblReceipt.ForeColor = SystemColors.ControlText;
            lblReceipt.Location = new Point(682, 114);
            lblReceipt.Name = "lblReceipt";
            lblReceipt.Size = new Size(19, 25);
            lblReceipt.TabIndex = 14;
            lblReceipt.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(766, 114);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 15;
            label6.Text = "$";
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(lblReceipt);
            Controls.Add(label7);
            Controls.Add(tbSearch);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(btnBuy);
            Controls.Add(lblCartContains);
            Controls.Add(label4);
            Controls.Add(lblBalance);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "ShopForm";
            Text = "ShopForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label lblBalance;
        private Label label4;
        private Label lblCartContains;
        private Button btnBuy;
        private Label label5;
        private Label label3;
        private Button btnBack;
        private TextBox tbSearch;
        private Label label7;
        private Label lblReceipt;
        private Label label6;
    }
}