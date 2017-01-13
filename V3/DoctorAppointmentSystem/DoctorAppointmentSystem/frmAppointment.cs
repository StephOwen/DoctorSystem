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

            imgTick.Visible = true;
            lblUpdate.Visible = true;
            //Makes the above label and image visible to the user
        }


    }
}
