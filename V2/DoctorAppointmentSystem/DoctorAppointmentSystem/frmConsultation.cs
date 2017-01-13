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
    public partial class frmConsultation : Form
    {
        public frmConsultation()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //When the edit button is clicked the following code will run
            txtNotes.ReadOnly = false;//Sets the notes textbox to be no longer be read only
            btnEdit.Visible = false;//Makes the edit button no longer visible
            btnSave.Visible = true;//Makes the save button visible
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //When the search button is clicked the following code will run
            txtFname.ReadOnly = true;
            txtSname.ReadOnly = true;
            txtDate.ReadOnly = true;
            //The above textboxes will be set to be read only
        }
    }
}
