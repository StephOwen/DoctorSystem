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
            cnDB.Open();
            SqlCommand cmUser = new SqlCommand();
            cmUser.Connection = cnDB;
            cmUser.CommandType = CommandType.Text;
            cmUser.CommandText = "Select AccessID from Access where Username = '" + user + "' AND Password = '" + userPass + "'";
            SqlDataReader userCheck = cmUser.ExecuteReader();

            if (userCheck.HasRows)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            userCheck.Close();
            cnDB.Close();

            return check;
        }
    }
}
