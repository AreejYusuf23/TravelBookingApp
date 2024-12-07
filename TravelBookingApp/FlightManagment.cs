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
    public partial class FlightManagment : Form
    {
        public FlightManagment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FlightMAdminEdit().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FlightManagment().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DestinationManagment().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BookingManagment().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ServiceManagmentAdmin().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new MessagesListAdmin().Show();
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
            new Message().Show();
        }

        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MessagesListAdmin() .Show();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new BookingManagment().Show();
        }
    }
}
