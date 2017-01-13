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
            if ((txtFname.Text == "") || (txtSname.Text == ""))//Checks to make sure the forename and surname textboxes are not left blank
            {
                MessageBox.Show("Please ensure you have entered both the patient's forename and surname.");//If they are left blank an error message will show
            }
            else if ((txtFname.Text == "Becky") && (txtSname.Text == "Hughes") && (txtDOB.Text == "13/09/1993"))//This provides test data. If the textboxes match the test data the following code will run
            {
                lblRegister.Visible = true;
                btnSubmit.Visible = true;
                lblNoApp.Visible = false;
                imgCross.Visible = false;
                //This will make the submit button and the label confirming the appointment visible to the user and will ensure the error message is not visible
            }
            else//If the data does not match the test data the following code will run
            {
                lblNoApp.Visible = true;
                imgCross.Visible = true;
                //This will make the error message and image visible to the user
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)//When the submit button is clicked the following code will run
        {
            lblArrival.Visible = true;
            imgTick.Visible = true;
            lblRegister.Visible = false;
            //This will make the confirmation message and image visible to the user
        }
    }
}
