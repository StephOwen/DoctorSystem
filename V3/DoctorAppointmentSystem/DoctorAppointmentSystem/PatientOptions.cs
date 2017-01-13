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
    public partial class frmPatientOptions : Form
    {
        public frmPatientOptions()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPatient patientPage = new frmPatient();
            patientPage.Show();//Opens the patient form
            this.Close();//Closes this form
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditPatient editView = new frmEditPatient();
            editView.Show();//Opens the edit/view patient form
        }
    }
}
