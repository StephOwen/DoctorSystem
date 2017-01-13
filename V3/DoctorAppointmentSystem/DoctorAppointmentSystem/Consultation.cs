using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem
{
    class Consultation
    {
        private int conID;
        private int appID;
        private string appNotes;

        public int ConsultationID
        {
            get
            {
                return conID;
            }
            set
            {
                conID = value;
            }
        }

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

        public string Notes
        {
            get
            {
                return appNotes;
            }
            set
            {
                appNotes = value;
            }
        }
    }
}
