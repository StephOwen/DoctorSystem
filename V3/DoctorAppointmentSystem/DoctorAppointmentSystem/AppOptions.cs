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
    public partial class frmAppOptions : Form
    {
        public frmAppOptions()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)//When the new button is clicked the following code will run
        {
            frmAppointment newApp = new frmAppointment();
            newApp.Show();//Opens new appointment form
        }

        private void btnEdit_Click(object sender, EventArgs e)//When the edit button is clicked the folowing code will run
        {
            frmEditApp editApp = new frmEditApp();
            editApp.Show();//Opens edit appointment form
        }
    }
}
