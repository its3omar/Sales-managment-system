namespace SalesMS.WinForms
{
    partial class AdminSaveProductForm
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
            tbProductName = new TextBox();
            tbCostPrice = new TextBox();
            tbSalePrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSaveProduct = new Button();
            label4 = new Label();
            btnBrowse = new Button();
            tbImagePath = new TextBox();
            SuspendLayout();
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(413, 39);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(150, 31);
            tbProductName.TabIndex = 0;
            // 
            // tbCostPrice
            // 
            tbCostPrice.Location = new Point(413, 125);
            tbCostPrice.Name = "tbCostPrice";
            tbCostPrice.Size = new Size(150, 31);
            tbCostPrice.TabIndex = 1;
            // 
            // tbSalePrice
            // 
            tbSalePrice.Location = new Point(413, 212);
            tbSalePrice.Name = "tbSalePrice";
            tbSalePrice.Size = new Size(150, 31);
            tbSalePrice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 42);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 3;
            label1.Text = "Product name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 125);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Cost price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 203);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Sale price";
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Location = new Point(296, 366);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(112, 72);
            btnSaveProduct.TabIndex = 6;
            btnSaveProduct.Text = "Save";
            btnSaveProduct.UseVisualStyleBackColor = true;
            btnSaveProduct.Click += btnSaveProduct_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 303);
            label4.Name = "label4";
            label4.Size = new Size(182, 25);
            label4.TabIndex = 7;
            label4.Text = "Set Image (optional) :";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(583, 303);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // tbImagePath
            // 
            tbImagePath.Location = new Point(413, 303);
            tbImagePath.Name = "tbImagePath";
            tbImagePath.Size = new Size(150, 31);
            tbImagePath.TabIndex = 9;
            // 
            // AdminSaveProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbImagePath);
            Controls.Add(btnBrowse);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSalePrice);
            Controls.Add(tbCostPrice);
            Controls.Add(tbProductName);
            Controls.Add(btnSaveProduct);
            Name = "AdminSaveProductForm";
            Text = "AdminCreateProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProductName;
        private TextBox tbCostPrice;
        private TextBox tbSalePrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSaveProduct;
        private Label label4;
        private Button btnBrowse;
        private TextBox tbImagePath;
    }
}