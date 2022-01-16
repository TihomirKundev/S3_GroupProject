namespace ProjectS07group4
{
    public class Complaint
    {
        public int ID { get; private set; }
        public int ApartmentID { get; private set; }
        public string ComplaintMessage { get; private set; }

        public Complaint(int ID, int apartmentID, string complaintMessage)
        {
            this.ID = ID;
            this.ApartmentID = apartmentID;
            this.ComplaintMessage = complaintMessage;
        }
    }
}
