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
    public partial class frmAppointment : Form
    {
        public frmAppointment()
        {
            InitializeComponent();
        }

        private void btnNewApp_Click(object sender, EventArgs e)
        {
            //Appointment addNew = new Appointment();
            //addNew.Forename = txtFname.Text;
            //addNew.Surname = txtSname.Text;
            //addNew.Doctor = cboDr.Text;
            //addNew.Date = DateTime.Parse(dtpDate.Text);
            //addNew.Time = DateTime.Parse(cboTime.Text);

            //addNew.AddNewApp();

            if ((txtFname.Text == "") || (txtSname.Text == "") || (cboDr.Text == "") || (dtpDate.Text == "") || (cboTime.Text == ""))//Checks to make sure that none of the textboxes are left blank
            {
                MessageBox.Show("Please ensure all required information has been inputted.");//If they are left blank an error message will show
            }
            else//If they are not left blank then the following code will run
            {
                imgTick.Visible = true;
                lblUpdate.Visible = true;
                //Makes the above label and image visible to the user
            }

        }


    }
}
