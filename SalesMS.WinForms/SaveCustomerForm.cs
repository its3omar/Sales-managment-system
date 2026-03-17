using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesMS.WinForms
{
    public partial class SaveCustomerForm : Form
    {
        private CustomerService _customerService;
        bool isUpdateMode = false;
        public SaveCustomerForm(CustomerService customerService)
        {
            InitializeComponent();

            _customerService = customerService;

            if (Session.currentCustomer != null)
            // إذا كان فورم التعديل
            {
                isUpdateMode = true;
                tbEmail.Text = Session.currentCustomer.Email;
                tbPhone.Text = Session.currentCustomer.Phone;
                tbName.Text = Session.currentCustomer.Name;
            }
            // ===== UI Styling Only =====



            this.BackColor = Color.FromArgb(15, 23, 42);

            this.tbName.BackColor = Color.FromArgb(241, 245, 249);
            tbName.BorderStyle = BorderStyle.FixedSingle;

            tbEmail.BackColor = Color.FromArgb(241, 245, 249);
            tbEmail.BorderStyle = BorderStyle.FixedSingle;

            tbPhone.BackColor = Color.FromArgb(241, 245, 249);
            tbPhone.BorderStyle = BorderStyle.FixedSingle;

            btnSaveUser.BackColor = Color.FromArgb(59, 130, 246);
            btnSaveUser.ForeColor = Color.White;
            btnSaveUser.FlatStyle = FlatStyle.Flat;
            btnSaveUser.FlatAppearance.BorderSize = 0;
            this.label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;




            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

       

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text)
              || string.IsNullOrEmpty(tbPhone.Text)
              || string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("One field or more are required!");
                return;
            }

            if (!isUpdateMode)
                    {
                        // إضافة عميل جديد
                        Customer c = new Customer { Email = tbEmail.Text, Phone = tbPhone.Text, Name = tbName.Text };
                        if (_customerService.AddNewCustomer(c))
                            MessageBox.Show("Customer Added Successfully");
                        else
                            MessageBox.Show("Unknown error occurred while adding customer, please try again");
                    }
            else if(isUpdateMode)
            {
                // تعديل العميل الحالي
                if (_customerService.UpdateCustomer(Session.currentCustomer.Id, tbName.Text, tbEmail.Text, tbPhone.Text))
                    MessageBox.Show("Customer Updated Successfully");
                else
                    MessageBox.Show("Unknown error occurred while updating customer, please try again");
            
            }
        }
    }
}