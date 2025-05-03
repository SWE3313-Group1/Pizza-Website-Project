using System;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsPizza
{
    public partial class LoginForm : Form
    {
      

        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(44, 62, 80);        
            //this.ForeColor = Color.WhiteSmoke;                 
            this.Font = new Font("Segoe UI", 10);              

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String phoneNumber = phoneNumberTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            //add validation later by checking JSON file
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both phone number and password.");
                return;
            }

            string filePath = "customers.json";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No customer records found. Please create an account first.");
                return;
            }

            string existingJson = File.ReadAllText(filePath);
            List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(existingJson) ?? new List<Customer>();

            Customer foundCustomer = customers.Find(c => c.PhoneNumber == phoneNumber);

            if (foundCustomer == null)
            {
                MessageBox.Show("Phone Number not found. Please check or create an account.");
                return;
            }
            if (foundCustomer.Password != password)
            {
                MessageBox.Show("Incorrect password. Please try again.");
                return;
            }

            MessageBox.Show($"Welcome back, {foundCustomer.FirstName}");

            this.Hide();

            MenuForm menuForm = new MenuForm(foundCustomer);
            menuForm.ShowDialog();

            this.Show();

          
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        { 
           
            CreateAccountForm createForm = new CreateAccountForm();
            createForm.Show();
            this.Hide();
        }
    }
}
