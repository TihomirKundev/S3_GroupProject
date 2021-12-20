using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Apartment
    {
        public int ID { get; private set; }
        public string Email { get; private set; }
        public int ApartmentID { get; private set; }
        public string Address { get; private set; }
        public double Price { get; private set; }
        public string PropertyType { get; private set; }
        public string Interior { get; private set; }
        public int Bedrooms { get; private set; }
        public int RoomsInApartment { get; private set; }
        public Apartment()
        {

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
        }
        public Apartment(int ID, string email,int apartmentID, string address,double price, string propertyType, string interior, int bedrooms, int roomsInApartment)
             : this(ID, address, price, propertyType, interior, bedrooms, roomsInApartment)
        {
            this.Email = email;
            this.ApartmentID = apartmentID;
        }
     
    }
}
