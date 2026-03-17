namespace SalesMS.WinForms
{
    partial class AdminStatisticsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTotalStoreSales = new Label();
            lbCapitalOfStore = new Label();
            lblTotalStorePenifits = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblTotalCustomersCount = new Label();
            label12 = new Label();
            lblStoreProductsCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 34);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Current Sote Capital :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 119);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 1;
            label2.Text = "Current Total Store Sales :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 210);
            label3.Name = "label3";
            label3.Size = new Size(228, 25);
            label3.TabIndex = 2;
            label3.Text = "Current Total Store Penifits :";
            // 
            // lblTotalStoreSales
            // 
            lblTotalStoreSales.AutoSize = true;
            lblTotalStoreSales.Location = new Point(460, 119);
            lblTotalStoreSales.Name = "lblTotalStoreSales";
            lblTotalStoreSales.Size = new Size(22, 25);
            lblTotalStoreSales.TabIndex = 3;
            lblTotalStoreSales.Text = "0";
            // 
            // lbCapitalOfStore
            // 
            lbCapitalOfStore.AutoSize = true;
            lbCapitalOfStore.Location = new Point(460, 34);
            lbCapitalOfStore.Name = "lbCapitalOfStore";
            lbCapitalOfStore.Size = new Size(22, 25);
            lbCapitalOfStore.TabIndex = 4;
            lbCapitalOfStore.Text = "0";
            // 
            // lblTotalStorePenifits
            // 
            lblTotalStorePenifits.AutoSize = true;
            lblTotalStorePenifits.Location = new Point(460, 210);
            lblTotalStorePenifits.Name = "lblTotalStorePenifits";
            lblTotalStorePenifits.Size = new Size(22, 25);
            lblTotalStorePenifits.TabIndex = 5;
            lblTotalStorePenifits.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(697, 34);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 6;
            label7.Text = "$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(697, 119);
            label8.Name = "label8";
            label8.Size = new Size(22, 25);
            label8.TabIndex = 7;
            label8.Text = "$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(697, 210);
            label9.Name = "label9";
            label9.Size = new Size(22, 25);
            label9.TabIndex = 8;
            label9.Text = "$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(111, 295);
            label10.Name = "label10";
            label10.Size = new Size(232, 25);
            label10.TabIndex = 9;
            label10.Text = "Current Total Goods Count :";
            // 
            // lblTotalCustomersCount
            // 
            lblTotalCustomersCount.AutoSize = true;
            lblTotalCustomersCount.Location = new Point(460, 394);
            lblTotalCustomersCount.Name = "lblTotalCustomersCount";
            lblTotalCustomersCount.Size = new Size(22, 25);
            lblTotalCustomersCount.TabIndex = 10;
            lblTotalCustomersCount.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(111, 394);
            label12.Name = "label12";
            label12.Size = new Size(257, 25);
            label12.TabIndex = 11;
            label12.Text = "Current Total Store Customers :";
            // 
            // lblStoreProductsCount
            // 
            lblStoreProductsCount.AutoSize = true;
            lblStoreProductsCount.Location = new Point(460, 295);
            lblStoreProductsCount.Name = "lblStoreProductsCount";
            lblStoreProductsCount.Size = new Size(22, 25);
            lblStoreProductsCount.TabIndex = 12;
            lblStoreProductsCount.Text = "0";
            // 
            // AdminStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStoreProductsCount);
            Controls.Add(label12);
            Controls.Add(lblTotalCustomersCount);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblTotalStorePenifits);
            Controls.Add(lbCapitalOfStore);
            Controls.Add(lblTotalStoreSales);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminStatisticsForm";
            Text = "AdminStatisicsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotalStoreSales;
        private Label lbCapitalOfStore;
        private Label lblTotalStorePenifits;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblTotalCustomersCount;
        private Label label12;
        private Label lblStoreProductsCount;
    }
}