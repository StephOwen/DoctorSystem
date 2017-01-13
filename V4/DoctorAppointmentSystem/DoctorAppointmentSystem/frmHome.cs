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
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)//When the user clicks the log in button the following code will run
        {
            btnJones.Visible = false;
            btnPatel.Visible = false;
            btnAll.Visible = false;
            btnDrCosts.Visible = false;
            btnAddApp.Visible = false;
            btnAppEdit.Visible = false;
            btnCancel.Visible = false;
            btnAddPat.Visible = false;
            btnEditPat.Visible = false;
            btnViewPat.Visible = false;
            //This makes sure that specific buttons are not visible anytime someone logs in

            if ((txtUser.Text == "SmithPM") && (txtPassword.Text == "PM101"))//Check to see if it is the practice manager logging in
            {
                btnAv.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnApp.Visible = false;
                btnArrival.Visible = false;
                btnConsultation.Visible = false;
                lblError.Visible = false;
                txtUser.ReadOnly = true;
                txtPassword.ReadOnly = true;
                btnLogOut.Visible = true;
                gbButtons.Visible = true;
                //Shows all the buttons and areas that the practice manager should have acces to upon logging in

            }
            else if (((txtUser.Text == "PatelDR") && (txtPassword.Text == "DR101")) || ((txtUser.Text == "JonesDR") && (txtPassword.Text == "DR202")))//Check to see if it is one of the doctors logging in
            {
                btnAv.Visible = true;
                btnConsultation.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnApp.Visible = true;
                btnArrival.Visible = true;
                lblError.Visible = false;
                txtUser.ReadOnly = true;
                txtPassword.ReadOnly = true;
                btnLogOut.Visible = true;
                gbButtons.Visible = true;
                //Shows all the buttons and areas that the doctors should have acces to upon logging in
            }
            else if ((txtUser.Text == "WilliamsR") && (txtPassword.Text == "R101"))//Check to see if it is the receptionist logging in
            {
                btnApp.Visible = true;
                btnArrival.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnConsultation.Visible = false;
                btnAv.Visible = false;
                lblError.Visible = false;
                txtUser.ReadOnly = true;
                txtPassword.ReadOnly = true;
                btnLogOut.Visible = true;
                gbButtons.Visible = true;
                //Shows all the buttons and areas that the receptionist should have acces to upon logging in
            }
            else//If the username and password is incorrect the following code will run
            {
                lblError.Visible = true;//This will provide the user with an error message
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)//When the patient button is clicked the following code will run
        {
            btnViewPat.Visible = true;
            btnPatients.Visible = false;
            btnAv.Visible = false;
            btnApp.Visible = false;
            btnReports.Visible = false;
            btnConsultation.Visible = false;
            btnArrival.Visible = false;
            btnBack.Visible = true;
            //This will make the required buttons for this section visible.

            if (txtUser.Text == "WilliamsR")//If the user is the receptionist the following code will run
            {
                btnAddPat.Visible = true;
                btnEditPat.Visible = true;
                //This will make another two buttons visible that only the receptionist has access to
            }
            
        }



        private void btnReports_Click(object sender, EventArgs e)//When the reports button is clicked the folowing code will run
        {
            btnPatients.Visible = false;
            btnAv.Visible = false;
            btnApp.Visible = false;
            btnReports.Visible = false;
            btnConsultation.Visible = false;
            btnArrival.Visible = false;
            btnDrCosts.Visible = false;
            btnJones.Visible = true;
            btnPatel.Visible = true;
            btnAll.Visible = true;
            btnBack.Visible = true;
            //This will make the required buttons for this section visible.

            if (txtUser.Text == "PatelDR")//If the user is Dr Patel then the following code will run
            {
                btnJones.Visible = false;
                btnAll.Visible = false;
                btnDrCosts.Visible = false;
                //This ensures that the only report button visible is the one for Dr Patel's appointments

            }
            else if (txtUser.Text == "JonesDR")//If the user is Dr Jones then the following code will run
            {
                btnPatel.Visible = false;
                btnAll.Visible = false;
                btnDrCosts.Visible = false;
                //This ensures that the only report button visible is the one for Dr Jones' appointments
            }
            else if (txtUser.Text == "SmithPM")//If the user is the practice manager then the following code will run
            {
                btnDrCosts.Visible = true;//This makes the doctor cost report button visible
            }

        }

        private void btnApp_Click(object sender, EventArgs e)//When the appointment button is clicked the following code will run
        {
            btnPatients.Visible = false;
            btnAv.Visible = false;
            btnApp.Visible = false;
            btnReports.Visible = false;
            btnConsultation.Visible = false;
            btnArrival.Visible = false;
            btnCancel.Visible = true;
            btnBack.Visible = true;
            //This will make the required buttons for this section visible.

            if (txtUser.Text == "WilliamsR")//If the user is the receptionist the following code will run
            {
                btnAddApp.Visible = true;
                btnAppEdit.Visible = true;
                //This will make another two buttons visible that only the receptionist has access to
            }
            
        }



       

        private void btnBack_Click(object sender, EventArgs e)//When the back button is clicked the following code will run
        {
            btnAddPat.Visible = false;
            btnEditPat.Visible = false;
            btnViewPat.Visible = false;
            btnAddApp.Visible = false;
            btnAppEdit.Visible = false;
            btnCancel.Visible = false;
            btnJones.Visible = false;
            btnPatel.Visible = false;
            btnAll.Visible = false;
            btnDrCosts.Visible = false;
            btnBack.Visible = false;
            //This makes sure that the buttons not required are no longer visible

            if ((txtUser.Text == "SmithPM") && (txtPassword.Text == "PM101"))//Check to see if it is the practice manager logged on
            {
                btnAv.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnApp.Visible = false;
                btnArrival.Visible = false;
                btnConsultation.Visible = false;
                lblError.Visible = false;
                //Shows all the buttons and areas that the practice manager should have acces to upon logging in

            }
            else if (((txtUser.Text == "PatelDR") && (txtPassword.Text == "DR101")) || ((txtUser.Text == "JonesDR") && (txtPassword.Text == "DR202")))//Check to see if it is one of the doctors logged on
            {
                btnAv.Visible = true;
                btnConsultation.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnApp.Visible = true;
                btnArrival.Visible = true;
                lblError.Visible = false;
                //Shows all the buttons and areas that the doctors should have acces to upon logging in
            }
            else if ((txtUser.Text == "WilliamsR") && (txtPassword.Text == "R101"))//Check to see if it is the receptionist logged on
            {
                btnApp.Visible = true;
                btnArrival.Visible = true;
                btnPatients.Visible = true;
                btnReports.Visible = true;
                btnConsultation.Visible = false;
                btnAv.Visible = false;
                lblError.Visible = false;
                //Shows all the buttons and areas that the receptionist should have acces to upon logging in
            }
        }

        private void btnAv_Click(object sender, EventArgs e)
        {
            frmAvailability drAv = new frmAvailability();
            drAv.Show();//This opens the avilability form
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

        private void btnAddPat_Click(object sender, EventArgs e)
        {
            frmPatient patientPage = new frmPatient();
            patientPage.Show();//This opens the add patient form
        }

        private void btnEditPat_Click(object sender, EventArgs e)
        {
            frmEditPatient editPatient = new frmEditPatient();
            editPatient.Show();//This opens the edit patient form
        }

        private void btnViewPat_Click(object sender, EventArgs e)
        {
            frmViewPatient viewPatient = new frmViewPatient();
            viewPatient.Show();//This opens the view patient form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCancel cancelApp = new frmCancel();
            cancelApp.Show();//This opens the cancel appointment form
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            frmAppointment addApp = new frmAppointment();
            addApp.Show();//this opens the add appointment form
        }

        private void btnAppEdit_Click(object sender, EventArgs e)
        {
            frmEditApp editApp = new frmEditApp();
            editApp.Show();//This opens the edit appointment form
        }

        private void btnPatel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing report for all booked appointments for Dr Patel.");//Shows a message to the user when the Dr Patel's Appointments button is clicked
        }

        private void btnJones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing report for all booked appointments for Dr Jones.");//Shows a message to the user when the Dr Jones' Appointments button is clicked
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing report for all booked appointments for Colwyn Bay Doctor's Surgery.");//Shows a message to the user when the All Appointments button is clicked
        }

        private void btnDrCosts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing Doctor's cost report.");//Shows a message to the user when the Doctor Cost report button is clicked
        }

        private void btnLogOut_Click(object sender, EventArgs e)//When the log out button is clicked the following code will run
        {
            gbButtons.Visible = false;
            btnLogOut.Visible = false;
            txtPassword.ReadOnly = false;
            txtUser.ReadOnly = false;
            txtPassword.Text = "";
            txtUser.Text = "";
            btnBack.Visible = false;
            //This will make sure no buttons are visible to the user and will reset the log in so it is blank.
        }
    }
}
