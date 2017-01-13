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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Access checkLogIn = new Access();
            //checkLogIn.Username = txtUser.Text;
            //checkLogIn.Password = txtPassword.Text;

            //bool correctYN = checkLogIn.CheckUser(checkLogIn.Username, checkLogIn.Password);

            //if (correctYN == true)
            //{
                //Change the log in field to Y
                frmHome mainPage = new frmHome();
                mainPage.Show();
            //}
            //else
            //{
            //    lblError.Visible = true;
            //}
        }



        

    }
}
