using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBookingApp
{
    public partial class SignUp : Form
    {

         private static int accountCounter = 1; // Static counter for account IDs
    private static List<User> users = new List<User>(); // In-memory user list

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Implement any specific behavior when the role is changed
        }
        public SignUp()
        {
            InitializeComponent();
            PopulateRoles(); // Call the method to populate roles
        }
        private void PopulateRoles()
        {
            roleComboBox.Items.Add("Employer");
            roleComboBox.Items.Add("Traveller");
            roleComboBox.Items.Add("Admin");
            roleComboBox.SelectedIndex = 0; // Set default selected item
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {


            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string username = usernameTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string nationality = nationalityTextBox.Text;
            string passportNumber = passportNumberTextBox.Text;
            string cpr = cprTextBox.Text;
            string role = roleComboBox.SelectedItem.ToString(); // Get selected role

            User newUser = CreateAccount(firstName, lastName, email, username, phoneNumber, nationality, passportNumber, cpr, role);

            if (newUser != null)
            {
                MessageBox.Show($"Account created successfully! Your Account ID is: {newUser.AccountId}");
                this.Close(); // Close the sign-up form
            }
            else
            {
                MessageBox.Show("Failed to create account. Please try again.");
            }




            new UserManagmentListAdmin().Show();
            this.Hide();  // Hides Form1
        }
        private User CreateAccount(string firstName, string lastName, string email, string username, string phoneNumber, string nationality, string passportNumber, string cpr, string role)
        {
            User newUser = new User
            {
                AccountId = accountCounter++, // Assign and increment account ID
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Username = username,
                PhoneNumber = phoneNumber,
                Nationality = nationality,
                PassportNumber = passportNumber,
                Cpr = cpr,
                Role = role
            };

            users.Add(newUser); // Add user to the in-memory list
            return newUser; // Return the new user
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the sign-up form
        }

       
    }
}
