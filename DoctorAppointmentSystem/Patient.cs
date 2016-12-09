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
    class Patient
    {
        private int PatID;
        private string forename;
        private string surname;
        private DateTime DOfB;
        private string Street;
        private string mTown;
        private string mCounty;
        private string mPostcode;
        private string addNotes;

        public int PatientID
        {
            get
            {
                return PatID;
            }
            set
            {
                PatID = value;
            }
        }

        public string Fname
        {
            get
            {
                return forename;
            }
            set
            {
                forename = value;
            }
        }

        public string Sname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }


        public string Address
        {
            get
            {
                return Street;
            }
            set
            {
                Street = value;
            }
        }

        public string Town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }

        public string County
        {
            get
            {
                return mCounty;
            }
            set
            {
                mCounty = value;
            }
        }

        public string Postcode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                mPostcode = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return DOfB;
            }
            set
            {
                DOfB = value;
            }
        }

        public string AdditionalNotes
        {
            get
            {
                return addNotes;
            }
            set
            {
                addNotes = value;
            }
        }


        public void AddNewPatient()
        {

            string DoctorsCS = ConfigurationManager.ConnectionStrings["DoctorsCS"].ConnectionString;

            SqlConnection cnDB = new SqlConnection(DoctorsCS);
            cnDB.Open();
            SqlCommand cmPatient = new SqlCommand();
            cmPatient.Connection = cnDB;
            cmPatient.CommandType = CommandType.Text;
            cmPatient.CommandText = "INSERT INTO Patient(Fname, Sname, Address, Town, County, Postcode, DOB, AdditionalNotes) VALUES('"
                + forename + "','" + surname + "','" + Street
                + "'," + "'" + mTown + "','"
                + mCounty + "','" + mPostcode + "','" + DOfB + "','" + addNotes + "')";
            cmPatient.ExecuteNonQuery();
            cmPatient.CommandText = "Select MAX(PatientID) FROM Patient";
            PatID = (int)cmPatient.ExecuteScalar();
            cnDB.Close();
        }

    }
}
