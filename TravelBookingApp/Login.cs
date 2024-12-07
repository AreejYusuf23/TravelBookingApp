using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TravelBookingApp.Empolyer;
using TravelBookingApp.Traveller;

namespace TravelBookingApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Login Button Click
        {
          
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

            this.Hide(); // Hide the Login form
        }

        private void button2_Click(object sender, EventArgs e) // Cancel Button Click
        {
            Application.Exit(); // Close the application
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle click event for label1 if required
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Handle click event for label2 if required
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Optional: Handle group box enter event if required
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Collect username and password from the text boxes
            string username = txtUsername.Text.Trim();
            string password = textPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPassword.Focus();
                return;
            }

            // Database connection string
            string connectionString = "Data Source=DESKTOP-4O6DI2B\\SQLSERVER2022;Initial Catalog=AirLine;Persist Security Info=True;User ID=sa;Password=33420211;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to validate username and password, and fetch role information
                    string query = @"
                        SELECT r.role_name
                        FROM [Account] a
                        INNER JOIN [User_1] u ON a.user_id = u.user_id
                        INNER JOIN [User_Role] r ON u.role_id = r.role_id
                        WHERE a.username = @Username AND a.password = @Password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Login successful
                        string roleName = reader["role_name"].ToString();
                        MessageBox.Show($"Welcome, {username}! You are logged in as {roleName}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Navigate to the appropriate dashboard
                        NavigateToRolePage(roleName);
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
