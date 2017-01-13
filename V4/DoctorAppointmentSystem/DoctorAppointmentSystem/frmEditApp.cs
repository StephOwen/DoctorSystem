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
    public partial class frmEditApp : Form
    {
        public frmEditApp()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)//When the edit button is clicked the folowing code will run
        {
            btnEdit.Visible = false;
            btnSave.Visible = true;
            txtAppID.ReadOnly = false;
            txtDrName.ReadOnly = false;
            txtDate.ReadOnly = false;
            txtTime.ReadOnly = false;
            //This will make the save button visible and will change the textboxes to no longer be read only
        }

        private void btnSave_Click(object sender, EventArgs e)//when the save button is clicked the following code will run
        {
            lblUpdate.Visible = true;
            imgTick.Visible = true;
            txtAppID.ReadOnly = true;
            txtDrName.ReadOnly = true;
            txtDate.ReadOnly = true;
            txtTime.ReadOnly = true;
            //This will show a save message and image to the user and will make the textboxes read only
        }

        private void btnSearchID_Click(object sender, EventArgs e)//When the search button is clicked the following code will run
        {
            if ((txtFname.Text == "Becky") && (txtSname.Text == "Hughes") && (cboTime.Text != ""))//This provides test data and check that the time field is not left empty
            {
                txtAppID.Text = "212";
                txtDrName.Text = "Dr Patel";
                txtDate.Text = dtpDate.Text;
                txtTime.Text = cboTime.Text;
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
