using System.Collections.Generic;
namespace ProjectS07group4 
{
    public class Apartment : UploadData.UploadComplaintData
    {
        
        public int ID { get; private set; }
        public string Address { get; private set; }
        public double Price { get; private set; }
        public string PropertyType { get; private set; }
        public string Interior { get; private set; }
        public int Bedrooms { get; private set; }
        public int RoomsInApartment { get; private set; }
        protected internal List<Complaint> apartmentComplaints
        {
            get;
            private set;
        }
        public void UpdateApartment(string address, double price, string propertyType, string interior, int bedrooms, int roomsInApartment)
        {
            this.Address = address;
            this.Price = price;
            this.PropertyType = propertyType;
            this.Interior = interior;
            this.Bedrooms = bedrooms;
            this.RoomsInApartment = roomsInApartment;
        }
        
        public Apartment(int ID, string address, double price, string propertyType, string interior, int bedrooms, int roomsInApartment)
        {
            this.ID = ID;
            this.Address = address;
            this.Price = price;
            this.PropertyType = propertyType;
            this.Interior = interior;
            this.Bedrooms = bedrooms;
            this.RoomsInApartment = roomsInApartment;
            this.apartmentComplaints = this.GetApartmentComplaints(this);

        }
     
        public void DeleteComplaintData(int id)
        {
            for (int i = 0; i < apartmentComplaints.Count; i++)
            {
                if (apartmentComplaints[i].ID == id)
                {
                    this.DeleteComplainMessages(apartmentComplaints[i]);
                    apartmentComplaints.RemoveAt(i);
                }
            }
        }

    }
}
