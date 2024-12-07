using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelBookingApp
{
    public partial class UserManagmentListAdmin : Form
    {
        public UserManagmentListAdmin()
        {
            InitializeComponent();
        }

        // Form Load Event to Populate the DataGridView
        private void UserManagmentListAdmin_Load(object sender, EventArgs e)
        {
            LoadUsers(); // Fetch and display user data when the form loads
        }

        // Method to Load Users into DataGridView
        private void LoadUsers()
        {
            // Connection string to the database
            string connectionString = "Data Source=DESKTOP-4O6DI2B\\SQLSERVER2022;Initial Catalog=AirLine;Persist Security Info=True;User ID=sa;Password=33420211;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Debug: Check connection
                    MessageBox.Show("Connected to the database.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Query to fetch users and their roles
                    string query = @"
                        SELECT u.user_id, u.username, u.first_name, u.last_name, u.email, u.phone, r.role_name
                        FROM [User_1] u
                        INNER JOIN [User_Role] r ON u.role_id = r.role_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable userTable = new DataTable();
                    adapter.Fill(userTable);

                    // Debug: Check the number of rows fetched
                    MessageBox.Show($"Rows fetched: {userTable.Rows.Count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (userTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No users found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Bind the DataTable to the DataGridView
                    userDataGridView.DataSource = userTable;

                    // Adjust DataGridView properties
                    userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (userDataGridView.Columns.Contains("user_id"))
                    {
                        userDataGridView.Columns["user_id"].Visible = false; // Hide the user_id column
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

        // Optional: Handle DataGridView Cell Click Event
        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can implement additional functionality here, such as showing user details
        }

        // Navigation Buttons
        private void button2_Click(object sender, EventArgs e)
        {
            new FlightManagment().Show();
            this.Hide(); // Hides current form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserManagmentListAdmin().Show();
            this.Hide(); // Hides current form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DestinationManagment().Show();
            this.Hide(); // Hides current form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BookingManagment().Show();
            this.Hide(); // Hides current form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ServiceManagmentAdmin().Show();
            this.Hide(); // Hides current form
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides current form
        }

        // Menu Item Event Handlers
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void manageProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserManagmentListAdmin().Show();
        }

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DestinationManagment().Show();
        }

        private void postUpcomingFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FlightManagment().Show();
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServiceManagmentAdmin().Show();
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Uncomment when the Message form is implemented
            // new Message().Show();
        }

        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MessagesListAdmin().Show();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookingManagment().Show();
        }
    }
}
