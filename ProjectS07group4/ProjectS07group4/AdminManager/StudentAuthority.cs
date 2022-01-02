using System;
using System.Collections.Generic;
using System.Data;
using ProjectS07group4.UploadData;
namespace ProjectS07group4.AdminManager
{
    public class StudentAuthority
    {
        private string[] randomPassword = new string[] { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "123456789", @"!@£$%^&*()#€" };
        private readonly UploadStudentData users = new UploadStudentData();
        private readonly UploadAgreementData agreements = new UploadAgreementData();
        private readonly UploadScheduleData schedules = new UploadScheduleData();
        public List<Users> AllUsersData { get; private set; }
        public StudentAuthority()
        {
            AllUsersData = users.AllUsers();
        }

        public void CreateUser(string email, string password, int apartmentID)
        {
            users.ModifyUsersData("Insert", 0, email, password, apartmentID);
            AllUsersData.Add(users.AllUsers()[AllUsersData.Count]);
        }
        public void UpdateUserData(int id, string email, string password, int apartmentID)
        {
            Users updateUser = new Users(id, email, password, apartmentID);
            int user = 0;
            for (int i = 0; i < AllUsersData.Count; i++)
            {
                if (AllUsersData[i].ID == id)
                {
                    user = i;
                    break;
                }
            }

            AllUsersData[user] = updateUser;
            users.ModifyUsersData("Update", id,email,password,apartmentID);
        }
        public void DeleteUserData(int id)
        {
            for (int i = 0; i < AllUsersData.Count; i++)
            {
                if (AllUsersData[i].ID == id)
                    AllUsersData.RemoveAt(i);
            }
            users.ModifyUsersData("Delete", id, "", "", 0);
        }
    
        public void DeleteAgreement(int id)
        {
            for (int i = 0; i < AllUsersData.Count; i++)
            {
                for(int j=0;j<AllUsersData[i].GetAgreements.Count;j++)
                if (AllUsersData[i].GetAgreements[j].ID == id)
                AllUsersData[i].GetAgreements.RemoveAt(j);
            }
            agreements.DeleteAgreementData(new Agreement(id, "", "", "", "", ""));
        }
       
        public void CreateNewSchedule(int apartmentID, int userID, string day, string job)
        {
            schedules.ModifyScheduleData("Insert", 0, apartmentID, userID, day, job);
            for(int i = 0; i < AllUsersData.Count; i++)
                if(AllUsersData[i].ID == userID)
                    AllUsersData[i] = users.AllUsers()[i];
        }

        public void UpdateScheduleData(int id, int apartmentID, int userID, string day, string job)
        {
            Schedule updateSchedule = new Schedule(id, apartmentID, userID, day, job);
            for (int i = 0; i < AllUsersData.Count; i++)
                for(int j=0;j<AllUsersData[i].GetSchedules.Count;j++)
                if (AllUsersData[i].GetSchedules[j].ID == id)
                {
                    AllUsersData[i].GetSchedules[j] = updateSchedule;
                    break;
                }
            
            schedules.ModifyScheduleData("Update", id,apartmentID,userID,day,job);
        }
        public void DeleteScheduleData(int id)
        {
            for (int i = 0; i < AllUsersData.Count; i++)
                for (int j = 0; j < AllUsersData[i].GetSchedules.Count; j++)
                    if (AllUsersData[i].GetSchedules[j].ID == id)
                    {
                        AllUsersData[i].GetSchedules.RemoveAt(j);
                    }
            
            schedules.ModifyScheduleData("Delete", id, 0, 0, "", "");
        }
        public List<String> ScheduleDataInfo(int id)
        {
            List<string> str = new List<string>();
            for (int i = 0; i < AllUsersData.Count; i++)
                for (int j = 0; j < AllUsersData[i].GetSchedules.Count; j++)
                    if (AllUsersData[i].GetSchedules[j].ID == id)
                {
                    str.Add(AllUsersData[i].GetSchedules[j].ID.ToString());
                    str.Add(AllUsersData[i].GetSchedules[j].ApartmentID.ToString());
                    str.Add(AllUsersData[i].GetSchedules[j].UserID.ToString());
                    str.Add(AllUsersData[i].GetSchedules[j].Day);
                    str.Add(AllUsersData[i].GetSchedules[j].Job);
                }
            return str;
        }
       
        public DataTable UsersSchedule()
        {
            DataTable dt = new DataTable();
            DataRow workRow;
            dt.Columns.Add("ID", typeof(int)); dt.Columns.Add("ApartmentID", typeof(int));
            dt.Columns.Add("UserID", typeof(int)); dt.Columns.Add("Day", typeof(string));
            dt.Columns.Add("Job", typeof(string)); 
            for (int i = 0; i < AllUsersData.Count; i++)
            {
                for(int j=0;j< AllUsersData[i].GetSchedules.Count; j++)
                {
                    workRow = dt.NewRow();
                    workRow[0] = AllUsersData[i].GetSchedules[j].ID; workRow[1] = AllUsersData[i].GetSchedules[j].ApartmentID;
                    workRow[2] = AllUsersData[i].GetSchedules[j].UserID; workRow[3] = AllUsersData[i].GetSchedules[j].Day;
                    workRow[4] = AllUsersData[i].GetSchedules[j].Job; 
                    dt.Rows.Add(workRow);
                }
               
            }
            return dt;
        }
        public DataTable UsersAgreement()
        {
            DataTable dt = new DataTable();
            DataRow workRow;
            dt.Columns.Add("ID", typeof(int)); dt.Columns.Add("CreatedUserID", typeof(string));
            dt.Columns.Add("ApartmentID", typeof(int)); dt.Columns.Add("AgreementForUserID", typeof(int));
            dt.Columns.Add("Agreement", typeof(string)); dt.Columns.Add("Process", typeof(string));
            dt.Columns.Add("StartDate", typeof(string)); dt.Columns.Add("EndDate", typeof(string));
            for (int i = 0; i < AllUsersData.Count; i++)
            {
                for (int j = 0; j < AllUsersData[i].GetAgreements.Count; j++)
                {
                    workRow = dt.NewRow();
                    workRow[0] = AllUsersData[i].GetAgreements[j].ID; workRow[1] = AllUsersData[i].GetAgreements[j].CreatedUserID;
                    workRow[2] = AllUsersData[i].GetAgreements[j].ApartmentID; workRow[3] = AllUsersData[i].GetAgreements[j].AgreementForUserID;
                    workRow[4] = AllUsersData[i].GetAgreements[j].AgreementText; workRow[5] = AllUsersData[i].GetAgreements[j].Process;
                    workRow[6] = AllUsersData[i].GetAgreements[j].StartDate; workRow[7] = AllUsersData[i].GetAgreements[j].EndDate;
                    dt.Rows.Add(workRow);
                }

            }
            return dt;
        }
        public DataTable UsersWithApartment()
        {
            DataTable dt = new DataTable();
            DataRow workRow;
            dt.Columns.Add("Email", typeof(string)); dt.Columns.Add("Apartment", typeof(int));
            dt.Columns.Add("Address", typeof(string)); dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("PropertyType", typeof(string)); dt.Columns.Add("Interior", typeof(string));
            dt.Columns.Add("Bedrooms", typeof(int)); dt.Columns.Add("RoomsInApartment", typeof(int));
            for (int i = 0; i < AllUsersData.Count; i++)
            {
                workRow = dt.NewRow();
                workRow[0] = AllUsersData[i].UserEmail; workRow[1] = AllUsersData[i].UserApartmentID;
                workRow[2] = AllUsersData[i].GetApartment.Address; workRow[3] = AllUsersData[i].GetApartment.Price;
                workRow[4] = AllUsersData[i].GetApartment.PropertyType; workRow[5] = AllUsersData[i].GetApartment.Interior;
                workRow[6] = AllUsersData[i].GetApartment.Bedrooms; workRow[7] = AllUsersData[i].GetApartment.RoomsInApartment;

                dt.Rows.Add(workRow);
            }
            return dt;
        }
        public string GeneratePassword(int passwordSize)
        {
            char[] _password = new char[passwordSize];
            string charSet = "";
            System.Random _random = new Random();
            int counter;

            if (true) charSet += randomPassword[0].ToLower();

            if (true) charSet += randomPassword[0];

            if (true) charSet += randomPassword[1];

            if (true) charSet += randomPassword[2];

            for (counter = 0; counter < passwordSize; counter++)
            {
                _password[counter] = charSet[_random.Next(charSet.Length - 1)];
            }
            return String.Join(null, _password);
        }
   
    }
}
