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
            Access checkLogIn = new Access();//Sets an instance from the access class
            checkLogIn.Username = txtUser.Text;//Sets the username to equal the input from the username textbox
            checkLogIn.Password = txtPassword.Text;//Sets the Password to equal the input from the password textbox

            bool correctYN = checkLogIn.CheckUser(checkLogIn.Username, checkLogIn.Password);//Passes the username and password values into the CheckUser method and sets the result equal to the correctYN value

            if (correctYN == true)
            {
                //Change the log in field to Y
                frmHome mainPage = new frmHome();//If the correctYN value is true the home page will open
                mainPage.Show();
            }
            else
            {
                lblError.Visible = true;//If the correctYN value is false then an error message will become visible
            }
        }



        

    }
}
