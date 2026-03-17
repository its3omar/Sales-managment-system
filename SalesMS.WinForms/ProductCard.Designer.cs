namespace SalesMS.WinForms
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picProductImage = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            btnSelectProduct = new Button();
            btnCancel = new Button();
            btnIncreaseByOne = new Button();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            SuspendLayout();
            // 
            // picProductImage
            // 
            picProductImage.Dock = DockStyle.Top;
            picProductImage.Location = new Point(0, 0);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(170, 120);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 0;
            picProductImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.Location = new Point(-1, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(168, 38);
            lblName.TabIndex = 1;
            lblName.Text = "Product name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblPrice.Location = new Point(74, 161);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(27, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "0$";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelectProduct
            // 
            btnSelectProduct.Location = new Point(0, 227);
            btnSelectProduct.Name = "btnSelectProduct";
            btnSelectProduct.Size = new Size(177, 33);
            btnSelectProduct.TabIndex = 3;
            btnSelectProduct.Text = "Add to cart";
            btnSelectProduct.UseVisualStyleBackColor = true;
            btnSelectProduct.Click += btnSelectProduct_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(0, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(34, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "X";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnIncreaseByOne
            // 
            btnIncreaseByOne.BackColor = Color.FromArgb(0, 192, 0);
            btnIncreaseByOne.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnIncreaseByOne.ForeColor = SystemColors.ControlLightLight;
            btnIncreaseByOne.Location = new Point(40, 186);
            btnIncreaseByOne.Name = "btnIncreaseByOne";
            btnIncreaseByOne.Size = new Size(37, 37);
            btnIncreaseByOne.TabIndex = 6;
            btnIncreaseByOne.Text = "+";
            btnIncreaseByOne.UseVisualStyleBackColor = false;
            btnIncreaseByOne.Visible = false;
            btnIncreaseByOne.Click += btnIncreaseByOne_Click;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnIncreaseByOne);
            Controls.Add(btnCancel);
            Controls.Add(btnSelectProduct);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(picProductImage);
            Margin = new Padding(10);
            Name = "ProductCard";
            Size = new Size(170, 265);
            Load += ProductCard_Load;
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProductImage;
        private Label lblName;
        private Label lblPrice;
        private Button btnSelectProduct;
        private Button btnCancel;
        private Button btnIncreaseByOne;
    }
}
