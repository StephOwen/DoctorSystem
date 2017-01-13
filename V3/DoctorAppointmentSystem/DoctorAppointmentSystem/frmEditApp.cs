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
    public partial class frmEditApp : Form
    {
        public frmEditApp()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)//When the edit button is clicked the following information will run
        {
            btnCancel.Visible = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            //This will make the cancel, edit and save buttons visible to the user
        }

        private void btnSave_Click(object sender, EventArgs e)//When the save button is clicked the following code will run
        {
            lblUpdate.Visible = true;
            imgTick.Visible = true;
            //This will make the above label and image visible to the user
        }


    }
}
