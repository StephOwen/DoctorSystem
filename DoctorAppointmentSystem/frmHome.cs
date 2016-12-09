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

        private void btnPatients_Click(object sender, EventArgs e)
        {
            frmPatient patientPage = new frmPatient();
            patientPage.Show();
            this.Close();
        }
    }
}
