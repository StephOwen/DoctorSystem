using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem
{
    class Appointment
    {
        private int appID;
        private int timeID;
        private int patID;

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

        public int TimeSlotID
        {
            get
            {
                return timeID;
            }
            set
            {
                timeID = value;
            }
        }

        public int PatientID
        {
            get
            {
                return patID;
            }
            set
            {
                patID = value;
            }
        }
    }
}
