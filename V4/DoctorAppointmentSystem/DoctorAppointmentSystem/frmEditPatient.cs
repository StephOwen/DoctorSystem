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

        private void btnEdit_Click(object sender, EventArgs e)//When the edit button is clicked the following code wil run
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
            //This will make the save button visible to the user and make the search result textboxes no longer read only
        }

        private void btnSearchID_Click(object sender, EventArgs e)//When the search button is clicked
        {
            if ((txtFnameSearch.Text == "Beverley") && (txtSnameSearch.Text == "Owen"))//This is for test data purposes, if the textboxes match the data in the if statement the code below will run
            {
                txtFname.Text = "Beverley";
                txtSname.Text = "Owen";
                txtStreet.Text = "71 Pendyffryn";
                txtTown.Text = "Llandudno Junction";
                txtCounty.Text = "Conwy";
                txtPostcode.Text = "LL31 9AT";
                txtDOB.Text = "04/07/1965";
                //The textboxes in the search results section will be populated with the above values
            }
            else
            {
                MessageBox.Show("Patient not found.");//This will provide an error message
            }
        }

        private void btnSave_Click(object sender, EventArgs e)//When the user clicks the save button the following code will run
        {
            lblUpdate.Visible = true;
            imgTick.Visible = true;
            //This will make the label and image above visible to the user
        }


    }
}
