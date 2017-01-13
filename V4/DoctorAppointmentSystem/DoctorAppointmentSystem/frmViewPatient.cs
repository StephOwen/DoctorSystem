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
    public partial class frmViewPatient : Form
    {
        public frmViewPatient()
        {
            InitializeComponent();
        }

        private void btnSearchID_Click(object sender, EventArgs e)//When the search button is clicked then the following code will run
        {
            if ((txtFnameSearch.Text == "Beverley") && (txtSnameSearch.Text == "Owen"))//This is for test data purposes. If the textboxes match the data here then the following code will run
            {
                txtFname.Text = "Beverley";
                txtSname.Text = "Owen";
                txtStreet.Text = "71 Pendyffryn";
                txtTown.Text = "Llandudno Junction";
                txtCounty.Text = "Conwy";
                txtPostcode.Text = "LL31 9AT";
                txtDOB.Text = "04/07/1965";
                //This will populate the search result textboxes will the above data
            }
            else//If the textboxes do not match the test data then the following code will run
            {
                MessageBox.Show("Patient not found.");//This provides a patient not found message
            }
        }
    }
}
