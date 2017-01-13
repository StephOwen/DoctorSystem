using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem
{
    class TimeSlot
    {
        private int timeID;
        private DateTime dateSlot;
        private DateTime timeSlot;
        private int drID;
        private string available;

        public int TimeSotID
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

        public DateTime Date
        {
            get
            {
                return dateSlot;
            }
            set
            {
                dateSlot = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return timeSlot;
            }
            set
            {
                timeSlot = value;
            }
        }

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

        public string Available
        {
            get
            {
                return available;
            }
            set
            {
                available = value;
            }
        }
    }
}
