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
    public partial class Login : Form
    {
        public Login()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text=="Areej"&& textPassword.Text=="123")
            {

            }else { MessageBox.Show("The User name or Password you enterd is incorrect");
            
            textUsername.Clear();
                textPassword.Clear();

            
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
