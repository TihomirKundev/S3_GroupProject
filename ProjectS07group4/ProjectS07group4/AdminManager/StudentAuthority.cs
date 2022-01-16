using System;
using System.Collections.Generic;
using System.Data;
using ProjectS07group4.UploadData;
namespace ProjectS07group4.AdminManager
{
    public class StudentAuthority : GeneralUploadData
    {
        private string[] randomPassword = new string[] { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "123456789", @"!@£$%^&*()#€" };
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
            if(GetUser(id).UserApartmentID != apartmentID)
            {
                DeleteUserScheduleAndAgreement(id);
                GetUser(id).UserSchedule.Clear();
                GetUser(id).UserAgreements.Clear();
            }
            GetUser(id).UpdateUser(email,password,apartmentID);
            users.ModifyUsersData("Update", id,email,password,apartmentID);
        }
        public bool CheckForDuplicateEmails(string email)
        {
            bool check = false;
            foreach (Users x in AllUsersData)
                if (x.UserEmail == email)
                {
                    check = true;
                    break;
                }
            return check;
        }
        private Users GetUser(int id)
        {
            foreach (Users x in AllUsersData)
                if (x.ID == id)
                    return x;
            return null;
        }
        private void DeleteUserScheduleAndAgreement(int id)
        {
            Users userInfo = GetUser(id);
            for (int i = 0; i < userInfo.UserSchedule.Count; i++)
                if (userInfo.UserSchedule[i].UserID == id)
                    schedule.ModifyScheduleData("Delete", userInfo.UserSchedule[i].ID, 0, 0, "", "");
            for (int i = 0; i < userInfo.UserAgreements.Count; i++)
                if (userInfo.UserAgreements[i].CreatedUserID == id.ToString() || userInfo.UserAgreements[i].AgreementForUserID == id.ToString())
                    agreement.DeleteAgreementData(userInfo.UserAgreements[i]);
        }
        public void DeleteUserData(int id)
        {
       
            DeleteUserScheduleAndAgreement(id);

            for (int i = 0; i < AllUsersData.Count; i++)
                if (AllUsersData[i].ID == id)
                {
                    users.ModifyUsersData("Delete", id, "", "", 0);
                    AllUsersData.RemoveAt(i);
                    break;
                }
          
        }
        
        public void DeleteAgreement(int id)
        {
            for (int i = 0; i < AllUsersData.Count; i++)
            {
                for(int j=0;j<AllUsersData[i].UserAgreements.Count;j++)
                if (AllUsersData[i].UserAgreements[j].ID == id)
                    {
                        agreement.DeleteAgreementData(AllUsersData[i].UserAgreements[j]);
                        AllUsersData[i].UserAgreements.RemoveAt(j);
                        break;
                }
            }
        }
       
        public void CreateNewSchedule(int apartmentID, int userID, string day, string job)
        {
            schedule.ModifyScheduleData("Insert", 0, apartmentID, userID, day, job);
            for(int i = 0; i < AllUsersData.Count; i++)
                if(AllUsersData[i].ID == userID)
                    AllUsersData[i] = users.AllUsers()[i];
        }

        public void UpdateScheduleData(int id, int apartmentID, int userID, string day, string job)
        {
            for (int i = 0; i < AllUsersData.Count; i++)
                for(int j=0;j<AllUsersData[i].UserSchedule.Count;j++)
                if (AllUsersData[i].UserSchedule[j].ID == id)
                {
                    AllUsersData[i].UserSchedule[j].UpdateSchedule(day,job);
                        break;
                }
            
            schedule.ModifyScheduleData("Update", id,apartmentID,userID,day,job);
        }
        public void DeleteScheduleData(int id)
        {
            for (int i = 0; i < AllUsersData.Count; i++)
                for (int j = 0; j < AllUsersData[i].UserSchedule.Count; j++)
                    if (AllUsersData[i].UserSchedule[j].ID == id)
                    {
                        schedule.ModifyScheduleData("Delete", AllUsersData[i].UserSchedule[j].ID, 0, 0, "", "");
                        AllUsersData[i].UserSchedule.RemoveAt(j);
                        break;
                    }
        }
        
        public List<String> ScheduleDataInfo(int id)
        {
            List<string> str = new List<string>();
            for (int i = 0; i < AllUsersData.Count; i++)
                for (int j = 0; j < AllUsersData[i].UserSchedule.Count; j++)
                    if (AllUsersData[i].UserSchedule[j].ID == id)
                {
                    str.Add(AllUsersData[i].UserSchedule[j].ID.ToString());
                    str.Add(AllUsersData[i].UserSchedule[j].ApartmentID.ToString());
                    str.Add(AllUsersData[i].UserSchedule[j].UserID.ToString());
                    str.Add(AllUsersData[i].UserSchedule[j].Day);
                    str.Add(AllUsersData[i].UserSchedule[j].Job);
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
                for(int j=0;j< AllUsersData[i].UserSchedule.Count; j++)
                {
                    workRow = dt.NewRow();
                    workRow[0] = AllUsersData[i].UserSchedule[j].ID; workRow[1] = AllUsersData[i].UserSchedule[j].ApartmentID;
                    workRow[2] = AllUsersData[i].UserSchedule[j].UserID; workRow[3] = AllUsersData[i].UserSchedule[j].Day;
                    workRow[4] = AllUsersData[i].UserSchedule[j].Job; 
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
                for (int j = 0; j < AllUsersData[i].UserAgreements.Count; j++)
                {
                    workRow = dt.NewRow();
                    workRow[0] = AllUsersData[i].UserAgreements[j].ID; workRow[1] = AllUsersData[i].UserAgreements[j].CreatedUserID;
                    workRow[2] = AllUsersData[i].UserAgreements[j].ApartmentID; workRow[3] = AllUsersData[i].UserAgreements[j].AgreementForUserID;
                    workRow[4] = AllUsersData[i].UserAgreements[j].AgreementText; workRow[5] = AllUsersData[i].UserAgreements[j].Process;
                    workRow[6] = AllUsersData[i].UserAgreements[j].StartDate; workRow[7] = AllUsersData[i].UserAgreements[j].EndDate;
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
                
                if (AllUsersData[i].UserApartment != null)
                {
                    workRow = dt.NewRow();
                    workRow[0] = AllUsersData[i].UserEmail; workRow[1] = AllUsersData[i].UserApartmentID;
                    workRow[2] = AllUsersData[i].UserApartment.Address; workRow[3] = AllUsersData[i].UserApartment.Price;
                    workRow[4] = AllUsersData[i].UserApartment.PropertyType; workRow[5] = AllUsersData[i].UserApartment.Interior;
                    workRow[6] = AllUsersData[i].UserApartment.Bedrooms; workRow[7] = AllUsersData[i].UserApartment.RoomsInApartment;
                dt.Rows.Add(workRow);

                }
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
                _password[counter] = charSet[_random.Next(charSet.Length - 1)];
            
            return String.Join(null, _password);
        }

        public string GetAgreementInfo(int userCreatedId,int userForId)
        {
            string info = $"Agreement created by {GetUser(userCreatedId).ID}, {GetUser(userCreatedId).UserEmail}, {GetUser(userCreatedId).UserApartmentID}"+System.Environment.NewLine;
            if(GetUser(userForId) != null && GetUser(userCreatedId) != null)
            return info += $"Agreement for user {GetUser(userForId).ID}, {GetUser(userForId).UserEmail}, {GetUser(userForId).UserApartmentID}";
            return "Something went wrong";
        }
       
   
    }
}
