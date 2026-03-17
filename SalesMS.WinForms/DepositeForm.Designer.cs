namespace SalesMS.WinForms
{
    partial class DepositeForm
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
            tbCardNumber = new TextBox();
            tbExpiryDate = new TextBox();
            tbCVV = new TextBox();
            tbAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // tbCardNumber
            // 
            tbCardNumber.Location = new Point(168, 62);
            tbCardNumber.Name = "tbCardNumber";
            tbCardNumber.Size = new Size(150, 31);
            tbCardNumber.TabIndex = 0;
           // 
            // tbExpiryDate
            // 
            tbExpiryDate.Location = new Point(168, 145);
            tbExpiryDate.Name = "tbExpiryDate";
            tbExpiryDate.Size = new Size(150, 31);
            tbExpiryDate.TabIndex = 1;
            // 
            // tbCVV
            // 
            tbCVV.Location = new Point(613, 62);
            tbCVV.Name = "tbCVV";
            tbCVV.Size = new Size(150, 31);
            tbCVV.TabIndex = 2;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(613, 145);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(150, 31);
            tbAmount.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 62);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 4;
            label1.Text = "Card number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 145);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 5;
            label2.Text = "Expiry date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 62);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 6;
            label3.Text = "CVV :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 145);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 7;
            label4.Text = "Enter Amount :";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(324, 279);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(141, 62);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += this.btnSubmit_Click;
            // 
            // DepositeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbAmount);
            Controls.Add(tbCVV);
            Controls.Add(tbExpiryDate);
            Controls.Add(tbCardNumber);
            Name = "DepositeForm";
            Text = "DepositeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCardNumber;
        private TextBox tbExpiryDate;
        private TextBox tbCVV;
        private TextBox tbAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSubmit;
    }
}