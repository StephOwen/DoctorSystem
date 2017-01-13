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
    class Appointment
    {
        private int appID;
        private string fname;
        private string sname;
        private string dr;
        private DateTime appDate;
        private DateTime appTime;

        public int AppointmentID
        {
            get
            {
                return appID;
            }
            set
            {
                appID = value;
            }
        }

        public string Forename
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string Surname
        {
            get
            {
                return sname;
            }
            set
            {
                sname = value;
            }
        }

        public string Doctor
        {
            get
            {
                return dr;
            }
            set
            {
                dr = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return appDate;
            }
            set
            {
                appDate = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return appTime;
            }
            set
            {
                appTime = value;
            }
        }

        public void AddNewApp()
        {

            string DoctorsCS = ConfigurationManager.ConnectionStrings["DoctorsCS"].ConnectionString;

            SqlConnection cnDB = new SqlConnection(DoctorsCS);
            cnDB.Open();
            SqlCommand cmApp = new SqlCommand();
            cmApp.Connection = cnDB;
            cmApp.CommandType = CommandType.Text;
            cmApp.CommandText = "INSERT INTO Appointment(Forename, Surname, Doctor, Date, Time) VALUES('"
                + fname + "','" + sname + "','" + dr
                + "'," + "'" + appDate + "','"
                + appTime + "')";
            cmApp.ExecuteNonQuery();
            cmApp.CommandText = "Select MAX(AppointmentID) FROM Appointment";
            appID = (int)cmApp.ExecuteScalar();
            cnDB.Close();
        }
    }
}
