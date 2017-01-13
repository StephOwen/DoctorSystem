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
            patientOp.Show();//Opens the patient form when the Patients button is clicked
            this.Close();//Closes the home form
        }

        private void btnAv_Click(object sender, EventArgs e)
        {
            frmAvailability drAv = new frmAvailability();
            drAv.Show();//Opens the availability form
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();
            reports.Show();//Opens the report form
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            //frmAppOptions appointmentOptions = new frmAppOptions();
           // appointmentOptions.Show();
        }

        private void btnConsultation_Click(object sender, EventArgs e)
        {
            frmConsultation consultation = new frmConsultation();
            consultation.Show();//Opens the consultation form
        }




    }
}
