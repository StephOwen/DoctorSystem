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
            addNew.AdditionalNotes = txtNotes.Text;
            //The above sets up all the values to be added into the patient table using the textboxes on the form

            addNew.AddNewPatient();//Runs the add new patient method
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")//Checks to see if the ID textbox is blank
            {
                MessageBox.Show("Please ensure you enter a patient ID number.");//Prompts user with an error message
            }
            else//If the textbox is not left blank the following code will run
            {
                try
                {
                    Patient viewPatient = new Patient();//Sets up a new instance of the patient class
                    patientID = int.Parse(txtID.Text);//Sets the patient ID to equal what has been inputted in the textbox
                    viewPatient.GetPatByPatID(patientID);//Runs the viewPatient method

                    txtID.Text = txtID.Text;
                    txtFname.Text = viewPatient.Fname;
                    txtSname.Text = viewPatient.Sname;
                    txtStreet.Text = viewPatient.Address;
                    txtTown.Text = viewPatient.Town;
                    txtCounty.Text = viewPatient.County;
                    txtPostcode.Text = viewPatient.Postcode;
                    txtNotes.Text = viewPatient.AdditionalNotes;
                    //Sets the values to equal what has been inputted into the textboxes
                }
                catch (Exception ex)//Catches any exceptions
                {
                    MessageBox.Show("There has been an error. " + ex.Message);//Provides an error message
                }
            }
        }
    }
}
