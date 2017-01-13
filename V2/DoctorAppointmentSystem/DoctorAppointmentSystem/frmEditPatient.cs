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
    public partial class frmEditPatient : Form
    {
        public frmEditPatient()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            txtFname.ReadOnly = false;
            txtSname.ReadOnly = false;
            txtStreet.ReadOnly = false;
            txtTown.ReadOnly = false;
            txtCounty.ReadOnly = false;
            txtPostcode.ReadOnly = false;
            txtDOB.ReadOnly = false;
            txtNotes.ReadOnly = false;

        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if ((txtFnameSearch.Text == "Beverley") && (txtSnameSearch.Text == "Owen"))
            {
                txtFname.Text = "Beverley";
                txtSname.Text = "Owen";
                txtStreet.Text = "71 Pendyffryn";
                txtTown.Text = "Llandudno Junction";
                txtCounty.Text = "Conwy";
                txtPostcode.Text = "LL31 9AT";
                txtDOB.Text = "04/07/1965";
            }
            else
            {
                MessageBox.Show("Patient not found.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblUpdate.Visible = true;
            imgTick.Visible = true;
        }


    }
}
