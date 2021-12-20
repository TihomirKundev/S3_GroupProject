using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Project
{
    class UploadComplaintData
    {
        private readonly string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";
        public void sendComplaint(Complaint createComplaint)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ComplaintMessages values (@ApartmentID,@Complaint)", con);
            cmd.Parameters.AddWithValue("@ApartmentID", createComplaint.ApartmentID);
            cmd.Parameters.AddWithValue("@Complaint", createComplaint.ComplaintMessage);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Complaint> AllComplaints()
        {
            List<Complaint> complaints = new List<Complaint>();
            SqlConnection con = new SqlConnection(@dataLink);
            SqlCommand cmd = new SqlCommand("Select * from ComplaintMessages", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                int apartmentID = Convert.ToInt32(dr["ApartmentID"]);
                string complaint = Convert.ToString(dr["Complaint"]);
             
                complaints.Add(new Complaint(ID, apartmentID, complaint));
            }
            con.Close();
            return complaints;
        }
        public void DeleteComplainMessages(Complaint deleteComplaint) 
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ComplaintMessages WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", deleteComplaint.ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
