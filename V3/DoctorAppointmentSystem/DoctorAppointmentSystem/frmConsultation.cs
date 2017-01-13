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
    public partial class frmConsultation : Form
    {
        public frmConsultation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)//When the search button is clicked the following code will run
        {
            if ((txtFname.Text == "Becky") && (txtSname.Text == "Hughes") && (dtpConDate.Text == "10 January 2017") && (cboTime.Text == "11:00"))//This is for test data purposes
            {
                //If the textboxes contain the information above then the following code will run
                lblNotes.Visible = true;
                txtNotes.Visible = true;
                btnSave.Visible = true;
                //This will make the above label, textbox and button visible to the user
            }
            else//If the textboxes do not contain the correct information the following code will run
            {
                MessageBox.Show("Appointment not found.");//This will provide an error message
            }
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)//When the save button is clicked the following code will run
        {
            lblUpdate.Visible = true;
            imgTick.Visible = true;
            //This will make the label and image above visible to the user
        }
    }
}
