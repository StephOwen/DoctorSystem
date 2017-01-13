using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorAppointmentSystem
{
    public partial class frmArrival : Form
    {
        public frmArrival()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //The following code will run when the check button is clicked
            if ((txtFname.Text == "") || (txtSname.Text == ""))//If the forename and surname textboxes are empty the following code will run
            {
                MessageBox.Show("Please ensure you have entered both the patient's forename and surname.");//Shows a messagebox containing an error message
            }
        }
    }
}
