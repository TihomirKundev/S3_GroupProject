﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace ProjectS07group4.UploadData
{
    public class UploadComplaintData : DataBaseLink
    {
        public void SendComplaint(int apartmentID,string message)
        {
            SqlConnection con = new SqlConnection(this.@getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ComplaintMessages values (@ApartmentID,@Complaint)", con);
            cmd.Parameters.AddWithValue("@ApartmentID", apartmentID);
            cmd.Parameters.AddWithValue("@Complaint", message);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Complaint> GetApartmentComplaints(Apartment apartment)
        {
            List<Complaint> complaints = new List<Complaint>();
            SqlConnection con = new SqlConnection(this.@getLink());
            SqlCommand cmd = new SqlCommand("Select * from ComplaintMessages WHERE ApartmentID ='"+apartment.ID+"'", con);
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
        public List<Complaint> AllComplaints()
        {
            List<Complaint> complaints = new List<Complaint>();
            SqlConnection con = new SqlConnection(this.@getLink());
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
            SqlConnection con = new SqlConnection(this.@getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ComplaintMessages WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", deleteComplaint.ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
