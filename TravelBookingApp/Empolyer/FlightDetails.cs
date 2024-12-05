using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBookingApp.Empolyer
{
    public partial class FlightDetails : Form
    {
        public FlightDetails()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new EmployerDashboard().Show();
        }
    }
}
