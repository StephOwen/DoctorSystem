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
            //Patient addNew = new Patient();
            //addNew.Fname = txtFname.Text;
            //addNew.Sname = txtSname.Text;
            //addNew.Address = txtStreet.Text;
            //addNew.Town = txtTown.Text;
            //addNew.County = txtCounty.Text;
            //addNew.Postcode = txtPostcode.Text;
            //addNew.DOB = DateTime.Parse(txtDOB.Text);
            //addNew.AdditionalNotes = txtNotes.Text;

            //addNew.AddNewPatient();

            var textBoxes = new TextBox[] { txtFname, txtSname, txtDOB, txtStreet, txtTown, txtCounty, txtPostcode};//This sets up a variable populated with the textboxes on the form
            if (textBoxes.Any(tb => tb.Text == String.Empty))//This checks to ake sure none of the textboxes are empty
            {
                MessageBox.Show("Please ensure all required information has been inputted.");//If a textbox is empty then an error message will appear
            }
            else
            {
                imgTick.Visible = true;
                lblUpdate.Visible = true;
                //This will provide confirmation message to the user so they know a new patient record has been added
            }
        }

    }
}
