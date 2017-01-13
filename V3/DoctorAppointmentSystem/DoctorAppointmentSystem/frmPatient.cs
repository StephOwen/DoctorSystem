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
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        int patientID;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Patient addNew = new Patient();//Sets up a new instance of the patient class
            addNew.Fname = txtFname.Text;
            addNew.Sname = txtSname.Text;
            addNew.Address = txtStreet.Text;
            addNew.Town = txtTown.Text;
            addNew.County = txtCounty.Text;
            addNew.Postcode = txtPostcode.Text;
            addNew.DOB = DateTime.Parse(txtDOB.Text);
            addNew.AdditionalNotes = txtNotes.Text;//The above sets up all the values to be added into the patient table using the textboxes on the form

            addNew.AddNewPatient();//Runs the add new patient method
        }

    }
}
