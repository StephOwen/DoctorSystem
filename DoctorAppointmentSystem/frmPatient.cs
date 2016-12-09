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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Patient addNew = new Patient();
            addNew.Fname = txtFname.Text;
            addNew.Sname = txtSname.Text;
            addNew.Address = txtStreet.Text;
            addNew.Town = txtTown.Text;
            addNew.County = txtCounty.Text;
            addNew.Postcode = txtPostcode.Text;
            addNew.DOB = DateTime.Parse(txtDOB.Text);
            addNew.AdditionalNotes = txtNotes.Text;

            addNew.AddNewPatient();
        }
    }
}
