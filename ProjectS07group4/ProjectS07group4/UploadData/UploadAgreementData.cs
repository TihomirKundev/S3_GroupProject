using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace ProjectS07group4.UploadData
{
    class UploadAgreementData : DataBaseLink
    {
        public List<Agreement> AgreementsFromUser(User user)
        {
            List<Agreement> AgreementsConnectedToUser = new List<Agreement>();
            SqlConnection con = new SqlConnection(this.getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT  s.ID,u.Username as ForFromUser, Agreement, Process, StartDate, EndDate FROM StudentAgreements s inner join UsersData u ON  s.AgreementForUserID = u.ID  WHERE CreatedUserID ='" + user.UserIdentity + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]); ;
                string createdUserID = Convert.ToString(dr["ForFromUser"].ToString().
                    Substring(0, dr["ForFromUser"].ToString().IndexOf("@")));
                string agreement = Convert.ToString(dr["Agreement"]);
                string process = Convert.ToString(dr["Process"]);
                string startDate = Convert.ToString(dr["StartDate"]).ToString().Substring(0, dr["StartDate"].ToString().IndexOf(" "));
                string endDate = Convert.ToString(dr["EndDate"]).ToString().Substring(0, dr["EndDate"].ToString().IndexOf(" "));
                AgreementsConnectedToUser.Add(new Agreement(ID, createdUserID, agreement, process, startDate, endDate));
            }
            con.Close();
            return AgreementsConnectedToUser;
        }
        public List<Agreement> AgreementsForUser(User user)
        {
            List<Agreement> AgreementsConnectedToUser = new List<Agreement>();
            SqlConnection con = new SqlConnection(this.getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT  s.ID,u.Username as ForFromUser, Agreement, Process, StartDate, EndDate FROM StudentAgreements s inner join UsersData u ON  s.CreatedUserID= u.ID  WHERE AgreementForUserID ='" + user.UserIdentity + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]); ;
                string createdUserID = Convert.ToString(dr["ForFromUser"].ToString().
                Substring(0, dr["ForFromUser"].ToString().IndexOf("@"))); 
                string agreement = Convert.ToString(dr["Agreement"]);
                string process = Convert.ToString(dr["Process"]);
                string startDate = Convert.ToString(dr["StartDate"]).ToString().Substring(0, dr["StartDate"].ToString().IndexOf(" "));
                string endDate = Convert.ToString(dr["EndDate"]).ToString().Substring(0, dr["EndDate"].ToString().IndexOf(" ")); 

                AgreementsConnectedToUser.Add(new Agreement(ID, createdUserID, agreement, process, startDate, endDate));
            }
                con.Close();
            return AgreementsConnectedToUser;

        }
        public List<Agreement> GetAgreements(AdminManager.Users user)
        {
            List<Agreement> AgreementsConnectedToUser = new List<Agreement>();
            SqlConnection con = new SqlConnection(this.getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentAgreements WHERE CreatedUserID = '"+user.ID+"' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]); ;
                string createdUserID = Convert.ToString(dr["CreatedUserID"]);
                int apartment = Convert.ToInt32(dr["ApartmentID"]);
                int agreementForUserID = Convert.ToInt32(dr["AgreementForUserID"]);
                string agreement = Convert.ToString(dr["Agreement"]);
                string process = Convert.ToString(dr["Process"]);
                string startDate = Convert.ToString(dr["StartDate"]).ToString().Substring(0, dr["StartDate"].ToString().IndexOf(" "));
                string endDate = Convert.ToString(dr["EndDate"]).ToString().Substring(0, dr["EndDate"].ToString().IndexOf(" "));
                AgreementsConnectedToUser.Add(new Agreement(ID, createdUserID,apartment,agreementForUserID.ToString(), agreement, process, startDate, endDate));
            }
            con.Close();
            return AgreementsConnectedToUser;
        }

        public void CreateAgreement(Agreement makeAgreement, User user)
        {
            SqlConnection con = new SqlConnection(this.@getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentAgreements values (@CreatedUserID,@ApartmentID, @AgreementForUserID," +
                "@Agreement,@Process, @StartDate,  @EndDate)", con);
            cmd.Parameters.AddWithValue("@CreatedUserID", user.UserIdentity);
            cmd.Parameters.AddWithValue("@ApartmentID", user.UserApartmentID);
            cmd.Parameters.AddWithValue("@AgreementForUserID", makeAgreement.CreatedUserID);
            cmd.Parameters.AddWithValue("@Agreement", makeAgreement.AgreementText);
            cmd.Parameters.AddWithValue("@Process", "Waiting for respond");
            cmd.Parameters.AddWithValue("@StartDate", makeAgreement.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", makeAgreement.EndDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ApproveAgreement(Agreement agreement)
        {
            SqlConnection con = new SqlConnection(this.@getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("Update StudentAgreements set Process=@Process where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", agreement.ID);
            cmd.Parameters.AddWithValue("@Process", agreement.Process);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteAgreementData(Agreement deleteAgreement)
        {
            SqlConnection con = new SqlConnection(this.@getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM StudentAgreements WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", deleteAgreement.ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
