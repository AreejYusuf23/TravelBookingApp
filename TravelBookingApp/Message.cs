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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
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
    }
}
