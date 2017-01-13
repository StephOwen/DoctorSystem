using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem
{
    class Doctor
    {
        private int drID;
        private string drName;

        public int DoctorID
        {
            get
            {
                return drID;
            }
            set
            {
                drID = value;
            }
        }

        public string DoctorName
        {
            get
            {
                return drName;
            }
            set
            {
                drName = value;
            }
        }
    }
}
