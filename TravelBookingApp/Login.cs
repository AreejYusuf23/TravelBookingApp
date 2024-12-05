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
