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

        private void btnCheck_Click(object sender, EventArgs e)//The following code will run when the check button is clicked
        {
            if ((txtFname.Text == "") || (txtSname.Text == ""))//If the forename and surname textboxes are empty the following code will run
            {
                MessageBox.Show("Please ensure you have entered both the patient's forename and surname.");//Shows a messagebox containing an error message
            }
            else if ((txtFname.Text == "Becky") && (txtSname.Text == "Hughes"))//This is for test data purposes. This checks the values of the textboxes and if they are equal to Becky Hughes the following code will run
            {
                lblRegister.Visible = true;//This will make a label visible to the user confirming their is a booking
            }
            else
            {
                lblNoApp.Visible = true;
                imgCross.Visible = true;
                //This makes the image and label above visible to the user if the textboxes do contain the data required
            }
        }
    }
}
