using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBookingApp
{
    public partial class UserManagmentListAdmin : Form
    {
        public UserManagmentListAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FlightManagment().Show();
            this.Hide();  // Hides Form1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserManagmentListAdmin().Show();
            this.Hide();  // Hides Form1
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DestinationManagment().Show();
            this.Hide();  // Hides Form1
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BookingManagment().Show();
            this.Hide();  // Hides Form1
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ServiceManagmentAdmin().Show();
            this.Hide();  // Hides Form1
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new MessagesListAdmin().Show();
            this.Hide();  // Hides Form1
        }
    }
}
