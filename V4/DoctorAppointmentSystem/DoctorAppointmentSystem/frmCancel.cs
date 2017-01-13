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
    public partial class frmCancel : Form
    {
        public frmCancel()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)//when the cancel button is clicked the following message will run
        {
            lblCancel.Visible = true;
            btnNo.Visible = true;
            btnYes.Visible = true;
            //This provides the user with a message making sure they definitely want to cancel the appointment and yes and no butttons
        }

        private void btnYes_Click(object sender, EventArgs e)//If the yes button is clicked the following code will run
        {
            imgTick.Visible = true;
            lblUpdate.Visible = true;
            lblCancel.Visible = false;
            btnNo.Visible = false;
            btnYes.Visible = false;
            //Provides user with a confirmation message and makes the message giving them the option to cancel or not no longer visible 
        }

        private void btnNo_Click(object sender, EventArgs e)//When the no button is clicked the following code will run
        {
            lblCancel.Visible = false;
            btnNo.Visible = false;
            btnYes.Visible = false;
            //This will make the cancellation option (yes or no buttons) to no longer be visible to the user
        }

        private void btnSearchID_Click(object sender, EventArgs e)//When the search button is clicked the following code will run
        {
            if ((txtFname.Text == "Becky") && (txtSname.Text == "Hughes") && (cboTime.Text != ""))//This provides test data and check that the time field is not left empty
            {
                txtAppID.Text = "212";
                txtDrName.Text = "Dr Patel";
                //If the test data matches the textboxes then the above information will appear in the search results textboxes
            }
            else if ((dtpDate.Text == "") || (cboTime.Text == ""))//If the date or time field is left empty the following code will run
            {
                MessageBox.Show("Please ensure all fields have been filled in.");//Provides user with error message
            }
            else//If the textboxes do not match the test data then the following code will run
            {
                MessageBox.Show("Appointment not found");//Provides a appointment not found message
            }
        }


    }
}
