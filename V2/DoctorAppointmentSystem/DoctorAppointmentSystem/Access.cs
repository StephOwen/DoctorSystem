using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace DoctorAppointmentSystem
{
    class Access
    {
        private int acID;
        private string user;
        private string userPass;
        private string jobRole;
        private string LogInYN;

        public int AccessID
        {
            get
            {
                return acID;
            }
            set
            {
                acID = value;
            }
        }

        public string Username
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }

        public string Password
        {
            get
            {
                return userPass;
            }
            set
            {
                userPass = value;
            }
        }


        public string Role
        {
            get
            {
                return jobRole;
            }
            set
            {
                jobRole = value;
            }
        }

        public string LogIn
        {
            get
            {
                return LogInYN;
            }
            set
            {
                LogInYN = value;
            }
        }

        public bool CheckUser(string user, string userPass)
        {
            bool check;
            string DoctorsCS = ConfigurationManager.ConnectionStrings["DoctorsCS"].ConnectionString;

            SqlConnection cnDB = new SqlConnection(DoctorsCS);
            cnDB.Open();//Opens the SQL connection
            SqlCommand cmUser = new SqlCommand();//
            cmUser.Connection = cnDB;
            cmUser.CommandType = CommandType.Text;
            cmUser.CommandText = "Select AccessID from Access where Username = '" + user + "' AND Password = '" + userPass + "'";//Selects the username and password which is the equivalent to what the user has input
            SqlDataReader userCheck = cmUser.ExecuteReader();

            if (userCheck.HasRows)//Checks that the table contains rows with this information
            {
                check = true;//Sets check variable to equal true if the table has these rows
            }
            else
            {
                check = false;//Otherwise sets check to false
            }

            userCheck.Close();
            cnDB.Close();//Closes data connection

            return check;//Returns check value
        }
    }
}
