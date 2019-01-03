using SolidLibiary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SolidLibiaryDataLayer
{
    public class DLCustomer
    {
        public void AddCustomer(ELCustomer eLCustomer, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC AddCustomer @Name,@ProjectId,@Creator,@CreatedAt,@Modifier,@ModifiedAt", conn);
                cmd.Parameters.Add(new SqlParameter("Name", eLCustomer.Name));
                cmd.Parameters.Add(new SqlParameter("ProjectId", eLCustomer.projectId));
                cmd.Parameters.Add(new SqlParameter("Creator", eLCustomer.Creator));
                cmd.Parameters.Add(new SqlParameter("CreatedAt", eLCustomer.CreatedAt));
                cmd.Parameters.Add(new SqlParameter("Modifier", eLCustomer.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLCustomer.ModifiedAt));
                cmd.ExecuteNonQuery();
            }
        }

        public List<ELCustomer> SelectAllCustomer(string connectionString)
        {
            List<ELCustomer> customerList = new List<ELCustomer>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectAllCustomer", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ELCustomer objCustomer = new ELCustomer();
                        objCustomer.Id = Guid.Parse(reader[0].ToString());
                        objCustomer.Name = (reader[1].ToString());
                        objCustomer.projectId = Guid.Parse(reader[2].ToString());
                        objCustomer.Creator = Guid.Parse(reader[3].ToString());
                        objCustomer.CreatedAt = DateTime.Parse(reader[4].ToString());
                        objCustomer.Modifier = Guid.Parse(reader[5].ToString());
                        objCustomer.ModifiedAt = DateTime.Parse(reader[6].ToString());
                        customerList.Add(objCustomer);
                    }
                }
            }
            return customerList;
        }

        public void UpdateCustomer(ELCustomer eLCustomer, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC UpdateCustomer @CustomerId,@Name,@ProjectId,@Modifier,@ModifiedAt", conn);
                cmd.Parameters.Add(new SqlParameter("CustomerId", eLCustomer.Id));
                cmd.Parameters.Add(new SqlParameter("Name", eLCustomer.Name));
                cmd.Parameters.Add(new SqlParameter("ProjectId", eLCustomer.projectId));
                cmd.Parameters.Add(new SqlParameter("Modifier", eLCustomer.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLCustomer.ModifiedAt));
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(ELCustomer eLCustomer, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC DeleteCustomer @CustomerId", conn);
                cmd.Parameters.Add(new SqlParameter("CustomerId", eLCustomer.Id));
                cmd.ExecuteNonQuery();
            }
        }
        public ELCustomer SelectCustomer(ELCustomer eLCustomer, string connectionString)
        {
            ELCustomer objCustomer = new ELCustomer();
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectCustomer @CustomerId", conn);
                cmd.Parameters.Add(new SqlParameter("CustomerId", eLCustomer.Id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objCustomer.Id = Guid.Parse(reader[0].ToString());
                        objCustomer.Name = (reader[1].ToString());
                        objCustomer.projectId = Guid.Parse(reader[2].ToString());
                        objCustomer.Creator = Guid.Parse(reader[3].ToString());
                        objCustomer.CreatedAt = DateTime.Parse(reader[4].ToString());
                        objCustomer.Modifier = Guid.Parse(reader[5].ToString());
                        objCustomer.ModifiedAt = DateTime.Parse(reader[6].ToString());
                    }
                }
            }
            return objCustomer;
        }
    }
}
