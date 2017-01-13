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
            cnDB.Open();//Opens database conneciton
            SqlCommand cmPatient = new SqlCommand();
            cmPatient.Connection = cnDB;
            cmPatient.CommandType = CommandType.Text;
            cmPatient.CommandText = "INSERT INTO Patient(Fname, Sname, Address, Town, County, Postcode, DOB, AdditionalNotes) VALUES('"
                + forename + "','" + surname + "','" + Street
                + "'," + "'" + mTown + "','"
                + mCounty + "','" + mPostcode + "','" + DOfB + "','" + addNotes + "')";//Inserts the values inputted by user into the patient table
            cmPatient.ExecuteNonQuery();
            cmPatient.CommandText = "Select MAX(PatientID) FROM Patient";
            PatID = (int)cmPatient.ExecuteScalar();
            cnDB.Close();//Close connection
        }

        public DataSet GetPatByPatID(int patID)
        {
            string DoctorsCS = ConfigurationManager.ConnectionStrings["DoctorsCS"].ConnectionString;//Retrieves the connection string
            DataSet dsPatient = new DataSet();//Creates dataset

            SqlConnection cnDB = new SqlConnection(DoctorsCS);
            cnDB.Open();//Opens connenction
            SqlCommand cmPatient = new SqlCommand();
            cmPatient.Connection = cnDB;
            cmPatient.CommandType = CommandType.Text;
            cmPatient.CommandText = "Select Fname, Sname, Address, Town, County, Postcode, DOB, AdditionalNotes, PatientID from Patient where PatientID = '" + patID + "'";
            //Selects fields from the patient table

            SqlDataAdapter daPatient = new SqlDataAdapter(cmPatient);//Creates data adapter
            daPatient.Fill(dsPatient);
            DataRow drPatient;//Creates data row
            drPatient = dsPatient.Tables[0].Rows[0];

            if (drPatient[0].ToString() == "")//If the data inputted by user cannot be found the following code will run
            {
                throw new Exception("Patient Not Found");//Provides patient not found message
            }
            else//If the data row is found then the following code will set the values using the data from that row from the patient table
            {
                forename = drPatient[0].ToString();
                surname = drPatient[1].ToString();
                DOfB = (DateTime)drPatient[2];
                Street = drPatient[3].ToString();
                mTown = drPatient[4].ToString();
                mCounty = drPatient[5].ToString();
                mPostcode = drPatient[6].ToString();
                addNotes = drPatient[7].ToString();
                PatID = (int)drPatient[8];
            }


            cnDB.Close();//Closes the connection
            return dsPatient;//Returns the dataset
        }

    }
}
