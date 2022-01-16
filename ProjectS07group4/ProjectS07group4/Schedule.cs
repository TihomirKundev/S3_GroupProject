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
        public void UpdateSchedule(string day,string job)
        {
            this.Day = day;
            this.Job = job;
        }
    }
}
