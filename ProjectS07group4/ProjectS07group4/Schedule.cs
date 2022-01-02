using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectS07group4
{
    public class Schedule
    {
        public int ID { get; private set; }
        public int ApartmentID { get; private set; }
        public int UserID { get; private set; }
        public string Day { get; private set; }
        public string Job { get; private set; }

        public Schedule(int ID, int apartmentID, int userID, string day, string job)
        {
            this.ID = ID;
            this.ApartmentID = apartmentID;
            this.UserID = userID;
            this.Day = day;
            this.Job = job;
        }
    }
}
