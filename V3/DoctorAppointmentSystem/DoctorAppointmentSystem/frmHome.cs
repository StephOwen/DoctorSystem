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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //Check if user logged is doctor. If so make dr availability button visible.
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            frmPatientOptions patientOp = new frmPatientOptions();
            patientOp.Show();//This opens the patient form
            this.Close();//This will close this form
        }

        private void btnAv_Click(object sender, EventArgs e)
        {
            frmAvailability drAv = new frmAvailability();
            drAv.Show();//This opens the doctor availability form
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();
            reports.Show();//This opens the report form
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            frmAppOptions appOp = new frmAppOptions();
            appOp.Show();//This opens the appointment options form
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            frmConsultation consultation = new frmConsultation();
            consultation.Show();//This opens the consultation form
        }

        private void btnArrival_Click(object sender, EventArgs e)
        {
            frmArrival patArrival = new frmArrival();
            patArrival.Show();//This opens the register arrival form
        }

        private void btnLogIn_Click(object sender, EventArgs e)//When the log in button is clicked the following code will  run
        {
            //The following code allows for different access to different sections of the system
            if ((txtUser.Text == "SmithPM") && (txtPassword.Text == "PM101"))//If the user inputs the username and password of the practice manager the following code will run
            {
                btnAv.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnApp.Visible = false;
                btnArrival.Visible = false;
                btnConsultation.Visible = false;
                lblError.Visible = false;
                //This sets the correct buttons visible so the practice manager will only have access to specific areas

            }
            else if (((txtUser.Text == "PatelDR") && (txtPassword.Text == "DR101")) || ((txtUser.Text == "JonesDR") && (txtPassword.Text == "DR202")))//If the user inputs the username and password of one of the doctors the following code will run
            {
                btnAv.Visible = true;
                btnConsultation.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnApp.Visible = true;
                btnArrival.Visible = true;
                lblError.Visible = false;
                //This sets the correct buttons visible so the doctors will only have access to specific areas
            }
            else if ((txtUser.Text == "WilliamsR") && (txtPassword.Text == "R101"))//If the user inputs the username and password of the receptionist the following code will run
            {
                btnApp.Visible = true;
                btnArrival.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnConsultation.Visible = false;
                btnAv.Visible = false;
                lblError.Visible = false;
                //This sets the correct buttons visible so the receptionist will only have access to specific areas
            }
            else//If the password and username are not correct the following code will run
            {
                lblError.Visible = true;//This will show an error message to the user
            }
        }




    }
}
