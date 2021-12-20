using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Project
{
    class UploadAgreementData
    {
        private readonly string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";
        public List<Agreement> agreementsConnectedToUser(int changeData)
        {
            List<Agreement> schedulesForUser = new List<Agreement>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd ;
            if(changeData==0)
            cmd = new SqlCommand("SELECT  s.ID,u.Username as ForFromUser, Agreement, Process, StartDate, EndDate FROM StudentAgreements s inner join UsersData u ON  s.AgreementForUserID = u.ID  WHERE CreatedUserID ='" + User.userID + "'", con);
            else
            cmd = new SqlCommand("SELECT  s.ID,u.Username as ForFromUser, Agreement, Process, StartDate, EndDate FROM StudentAgreements s inner join UsersData u ON  s.CreatedUserID= u.ID  WHERE AgreementForUserID ='" + User.userID + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]); ;
                string createdUserID = Convert.ToString(dr["ForFromUser"]);
                int apartmentID = 0;
                string agreementForUserID = "";
                string agreement = Convert.ToString(dr["Agreement"]);
                string process = Convert.ToString(dr["Process"]);
                string startDate = Convert.ToString(dr["StartDate"]);
                string endDate = Convert.ToString(dr["EndDate"]);

                schedulesForUser.Add(new Agreement(ID,createdUserID,apartmentID,agreementForUserID,agreement,process,startDate,endDate));
            }
            con.Close();
            return schedulesForUser;
        }
        public List<Agreement> allAgreements()
        {
            List<Agreement> agreements = new List<Agreement>();
            SqlConnection con = new SqlConnection(@dataLink);
            SqlCommand cmd = new SqlCommand("Select * From StudentAgreements", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                int createdUserID = Convert.ToInt32(dr["CreatedUserID"]);
                int apartmentID = Convert.ToInt32(dr["ApartmentID"]);
                int agreementForUserID = Convert.ToInt32(dr["AgreementForUserID"]);
                string agreement = Convert.ToString(dr["Agreement"]);
                string process = Convert.ToString(dr["Process"]);
                string startDate = Convert.ToString(dr["StartDate"]);
                string endDate = Convert.ToString(dr["EndDate"]);

                agreements.Add(new Agreement(ID, createdUserID.ToString(), apartmentID, agreementForUserID.ToString(), agreement, process, startDate, endDate));
            }
            con.Close();
            return agreements;
        }
        public void approveAgreement(int ID,string approvedNotApproved)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update StudentAgreements set Process=@Process where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Process", approvedNotApproved);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable usersInTheSameApartment()
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Username,ID FROM UsersData WHERE Apartment = '" + User.apartmentID + "' AND ID != '" + User.userID+ "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
  
        public void createAgreement(Agreement makeAgreement)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentAgreements values (@CreatedUserID,@ApartmentID, @AgreementForUserID," +
                "@Agreement,@Process, @StartDate,  @EndDate)", con);
            cmd.Parameters.AddWithValue("@CreatedUserID", User.userID);
            cmd.Parameters.AddWithValue("@ApartmentID", User.apartmentID);
            cmd.Parameters.AddWithValue("@AgreementForUserID", makeAgreement.AgreementForUserID);
            cmd.Parameters.AddWithValue("@Agreement", makeAgreement.AgreementText);
            cmd.Parameters.AddWithValue("@Process", "Waiting for respond");
            cmd.Parameters.AddWithValue("@StartDate", makeAgreement.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", makeAgreement.EndDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    
        public void deleteStudentAgreement(Agreement deleteAgr)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM StudentAgreements WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", deleteAgr.ID);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
