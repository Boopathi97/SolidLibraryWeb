using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidLibiary;

namespace SolidLibiaryDataLayer
{
    public class DLProject
    {
        public void AddProject(ELProject elProject, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd =
                    new SqlCommand
                    ("EXEC AddProject " +
                            "@Name, " +
                            "@Creator, " +
                            "@CreatedAt, " +
                            "@Modifier, " +
                            "@ModifiedAt", conn);
                cmd.Parameters.Add(new SqlParameter("Name", elProject.Name));
                cmd.Parameters.Add(new SqlParameter("Creator", elProject.Creator));
                cmd.Parameters.Add(new SqlParameter("CreatedAt", elProject.CreatedAt));
                cmd.Parameters.Add(new SqlParameter("Modifier", elProject.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", elProject.ModifiedAt));
                cmd.ExecuteNonQuery();
            }
        }
        public List<ELProject> SelectAllProject(string connectionString)
        {
            List<ELProject> projectList = new List<ELProject>();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectAllProject", conn);


                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ELProject obj = new ELProject();
                        obj.Id = Guid.Parse(reader[0].ToString());
                        obj.Name = (reader[1].ToString());
                        obj.Creator = Guid.Parse(reader[2].ToString());
                        obj.CreatedAt = DateTime.Parse(reader[3].ToString());
                        obj.Modifier = Guid.Parse(reader[4].ToString());
                        obj.ModifiedAt = DateTime.Parse(reader[5].ToString());

                        projectList.Add(obj);

                    }
                }

            }
            return projectList;
        }
        public void UpdateProject(ELProject eLProject, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC UpdateProject @ProjectId,@Name,@Modifier,@ModifiedAt", conn);
                cmd.Parameters.Add(new SqlParameter("ProjectId", eLProject.Id));
                cmd.Parameters.Add(new SqlParameter("Name", eLProject.Name));
                cmd.Parameters.Add(new SqlParameter("Modifier", eLProject.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLProject.ModifiedAt));
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteProject(ELProject eLProject, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC DeleteProject @ProjectId", conn);
                cmd.Parameters.Add(new SqlParameter("ProjectId", eLProject.Id));
                cmd.ExecuteNonQuery();
            }
        }
        public ELProject SelectProject(ELProject eLProject, string connectionString)
        {
            ELProject objProject = new ELProject();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectProject @ProjectId", conn);
                cmd.Parameters.Add(new SqlParameter("ProjectId", eLProject.Id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        objProject.Id = Guid.Parse(reader[0].ToString());
                        objProject.Name = (reader[1].ToString());
                        objProject.Creator = Guid.Parse(reader[2].ToString());
                        objProject.CreatedAt = DateTime.Parse(reader[3].ToString());
                        objProject.Modifier = Guid.Parse(reader[4].ToString());
                        objProject.ModifiedAt = DateTime.Parse(reader[5].ToString());
                    }
                }

            }
            return objProject;
        }

        //public void AddCustomer(ELCustomer eLCustomer,string connectionString)
        //{
        //    using(SqlConnection conn = new SqlConnection())
        //    {
        //        conn.ConnectionString = connectionString;
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("EXEC AddCustomer @Name,@ProjectId,@Creator,@CreatedAt,@Modifier,@ModifiedAt",conn);
        //        cmd.Parameters.Add(new SqlParameter("Name", eLCustomer.Name));
        //        cmd.Parameters.Add(new SqlParameter("ProjectId",eLCustomer.objProject.Id));
        //        cmd.Parameters.Add(new SqlParameter("Creator", eLCustomer.Creator));
        //        cmd.Parameters.Add(new SqlParameter("CreatedAt", eLCustomer.CreatedAt));
        //        cmd.Parameters.Add(new SqlParameter("Modifier", eLCustomer.Modifier));
        //        cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLCustomer.ModifiedAt));
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public List<ELCustomer> SelectAllCustomer(string connectionString) { 
        //    List<ELCustomer> customerList = new List<ELCustomer>();
        //    using(SqlConnection conn = new SqlConnection())
        //    {
        //        conn.ConnectionString = connectionString;
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("EXEC SelectAllCustomer", conn);
        //        using(SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                ELCustomer objCustomer = new ELCustomer();
        //                objCustomer.Id = Guid.Parse(reader[0].ToString());
        //                objCustomer.Name = (reader[1].ToString());
        //                objCustomer.objProject.Id = Guid.Parse(reader[2].ToString());
        //                objCustomer.Creator = Guid.Parse(reader[3].ToString());
        //                objCustomer.CreatedAt =DateTime.Parse(reader[4].ToString());
        //                objCustomer.Modifier = Guid.Parse(reader[5].ToString());
        //                objCustomer.ModifiedAt = DateTime.Parse(reader[6].ToString());
        //                customerList.Add(objCustomer);
        //            }
        //        }
        //    }
        //    return customerList;
        //}

        //public void UpdateCustomer(ELCustomer eLCustomer,string connectionString)
        //{
        //    using(SqlConnection conn = new SqlConnection())
        //    {
        //        conn.ConnectionString = connectionString;
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("EXEC UpdateCustomer @CustomerId,@Name,@ProjectId,@Modifier,@ModifiedAt", conn);
        //        cmd.Parameters.Add(new SqlParameter("CustomerId", eLCustomer.Id));
        //        cmd.Parameters.Add(new SqlParameter("Name", eLCustomer.Name));
        //        cmd.Parameters.Add(new SqlParameter("ProjectId", eLCustomer.objProject.Id));
        //        cmd.Parameters.Add(new SqlParameter("Modifier", eLCustomer.Modifier));
        //        cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLCustomer.ModifiedAt));
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public void DeleteCustomer(ELCustomer eLCustomer,string connectionString)
        //{
        //    using(SqlConnection conn = new SqlConnection())
        //    {
        //        conn.ConnectionString = connectionString;
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("EXEC DeleteCustomer @CustomerId",conn);
        //        cmd.Parameters.Add(new SqlParameter("CustomerId", eLCustomer.Id));
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        //public ELCustomer SelectCustomer(ELCustomer eLCustomer, string connectionString)
        //{
        //    ELCustomer objCustomer = new ELCustomer();
        //    using (SqlConnection conn = new SqlConnection())
        //    {

        //        conn.ConnectionString = connectionString;
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("EXEC SelectCustomer @CustomerId",conn);
        //        cmd.Parameters.Add(new SqlParameter("CustomerId", eLCustomer.Id));
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                objCustomer.Id = Guid.Parse(reader[0].ToString());
        //                objCustomer.Name = (reader[1].ToString());
        //                objCustomer.objProject.Id  = Guid.Parse(reader[2].ToString());
        //                eLCustomer.Creator = Guid.Parse(reader[3].ToString());
        //                objCustomer.CreatedAt = DateTime.Parse(reader[4].ToString());
        //                objCustomer.Modifier = Guid.Parse(reader[5].ToString());
        //                objCustomer.ModifiedAt = DateTime.Parse(reader[6].ToString());
        //            }
        //        }
        //    }
        //    return objCustomer;
        //}
    }
}
