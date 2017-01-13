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
    public partial class frmAvailability : Form
    {
        public frmAvailability()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            imgTick.Visible = true;
            lblUpdate.Visible = true;
            //This will make the image and label above visible to the user when the save button is clicked
        }

        //Get dataset to show specific doctor availability. 
        //Have textbox to enter specific TimeSlotID, take them to another tab where they can edit their availability to Y/N.
    }
}
