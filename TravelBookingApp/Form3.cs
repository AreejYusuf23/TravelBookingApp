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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
 new MessagesListAdmin().Show();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookingManagment().Show();
        }
    }
}
