using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TravelBookingApp.Empolyer;
using TravelBookingApp.Traveller;

namespace TravelBookingApp
{
    public partial class SignUp : Form
    {
        private static int accountCounter = 1; // Static counter for account IDs
        private static List<User> users = new List<User>(); // In-memory user list

        public SignUp()
        {
            InitializeComponent();
            LoadRoles(); // Populate dropdown with roles
        }

        private void LoadRoles()
        {
            roleComboBox.Items.Add("Admin");
            roleComboBox.Items.Add("Employer");
            roleComboBox.Items.Add("Traveler"); // Corrected spelling
            roleComboBox.SelectedIndex = 0; // Set default selected item
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Collect user input
            string firstName = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string username = usernameTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string selectedRole = roleComboBox.SelectedItem?.ToString();

            // Validate required fields
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstNameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastNameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                roleComboBox.Focus();
                return;
            }

            // Database connection string
            string connectionString = "Data Source=DESKTOP-4O6DI2B\\SQLSERVER2022;Initial Catalog=AirLine;Persist Security Info=True;User ID=sa;Password=33420211;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Retrieve role_id based on the selected role
                    string getRoleIdQuery = "SELECT role_id FROM User_Role WHERE role_name = @RoleName";
                    SqlCommand getRoleIdCmd = new SqlCommand(getRoleIdQuery, conn);
                    getRoleIdCmd.Parameters.AddWithValue("@RoleName", selectedRole);

                    object roleIdObj = getRoleIdCmd.ExecuteScalar();
                    if (roleIdObj == null)
                    {
                        MessageBox.Show("Error: Role not found in the database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop execution if no role_id is found
                    }

                    int roleId = Convert.ToInt32(roleIdObj);

                    // Generate a new user_id
                    int newUserId = GenerateNewUserId(conn);

                    // Insert the user into the User_1 table
                    string insertUserQuery = @"
                INSERT INTO [User_1] (user_id, username, first_name, last_name, email, phone, role_id)
                VALUES (@UserId, @Username, @FirstName, @LastName, @Email, @Phone, @RoleId)";

                    SqlCommand cmd = new SqlCommand(insertUserQuery, conn);
                    cmd.Parameters.AddWithValue("@UserId", newUserId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@RoleId", roleId);

                    cmd.ExecuteNonQuery();

                    // Show success message
                    MessageBox.Show($"User created successfully!\nRole: {selectedRole}\nID: {newUserId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to the role-specific page
                    NavigateToRolePage(selectedRole);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show($"Formatting Error: {formatEx.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateToRolePage(string role)
        {
            if (role == "Admin")
            {
                new UserManagmentListAdmin().Show();
            }
            else if (role == "Employer")
            {
               new EmployerDashboard().Show();
            }
            else if (role == "Traveler")
            {
                new BookFlight().Show();
            }

            // Close the current form
            this.Hide();
        }

        private int GenerateNewUserId(SqlConnection conn)
        {
            string query = "SELECT ISNULL(MAX(user_id), 0) + 1 FROM [User_1]";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
