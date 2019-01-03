using SolidLibiary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidLibiaryDataLayer
{
    public class DLClass
    {
        public void AddClass(ELClass elclass, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("EXEC AddClass @Name,@ProjectId,@CustomerId,@Description,@ClassScope,@ClassPublicVariables,@Creator,@CreatedAt,@Modifier,@ModifiedAt", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("Name", elclass.Name));
                    cmd.Parameters.Add(new SqlParameter("ProjectId", elclass.projectId));
                    cmd.Parameters.Add(new SqlParameter("CustomerId", elclass.customerId));
                    cmd.Parameters.Add(new SqlParameter("Description", elclass.Description));
                    cmd.Parameters.Add(new SqlParameter("ClassScope", elclass.ClassScope));
                    cmd.Parameters.Add(new SqlParameter("ClassPublicVariables", elclass.ClassPublicVairables));
                    cmd.Parameters.Add(new SqlParameter("Creator", elclass.Creator));
                    cmd.Parameters.Add(new SqlParameter("CreatedAt", elclass.CreatedAt));
                    cmd.Parameters.Add(new SqlParameter("Modifier", elclass.Modifier));
                    cmd.Parameters.Add(new SqlParameter("ModifiedAt", elclass.ModifiedAt));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<ELClass> SelectAllClass(string connectionString)
        {

            List<ELClass> classList = new List<ELClass>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("EXEC SelectAllClass", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ELClass objClass = new ELClass();
                            objClass.Id = Guid.Parse(reader[0].ToString());
                            objClass.Name = reader[1].ToString();
                            objClass.projectId= Guid.Parse(reader[2].ToString());
                            objClass.customerId = Guid.Parse(reader[3].ToString());
                            objClass.Description = reader[4].ToString();
                            objClass.ClassScope = reader[5].ToString();
                            objClass.ClassPublicVairables = reader[6].ToString();
                            objClass.Creator = Guid.Parse(reader[7].ToString());
                            objClass.CreatedAt = DateTime.Parse(reader[8].ToString());
                            objClass.Modifier = Guid.Parse(reader[9].ToString());
                            objClass.ModifiedAt = DateTime.Parse(reader[10].ToString());

                            classList.Add(objClass);
                        }
                    }
                }

            }
            return classList;
        }
        public void UpdateClass(ELClass eLClass, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC UpdateClass @ClassId,@Name,@ProjectId,@CustomerId,@Description,@ClassScope,@ClassPublicVariables,@Modifier,@ModifiedAt", conn);
                cmd.Parameters.Add(new SqlParameter("ClassId", eLClass.Id));
                cmd.Parameters.Add(new SqlParameter("Name", eLClass.Name));
                cmd.Parameters.Add(new SqlParameter("ProjectId", eLClass.projectId));
                cmd.Parameters.Add(new SqlParameter("CustomerId", eLClass.customerId));
                cmd.Parameters.Add(new SqlParameter("Description", eLClass.Description));
                cmd.Parameters.Add(new SqlParameter("ClassScope", eLClass.ClassScope));
                cmd.Parameters.Add(new SqlParameter("ClassPublicVariables", eLClass.ClassScope));
                cmd.Parameters.Add(new SqlParameter("Modifier", eLClass.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLClass.ModifiedAt));
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteClass(ELClass eLClass, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC DeleteClass @ClassId", conn);
                cmd.Parameters.Add(new SqlParameter("ClassId", eLClass.Id));
                cmd.ExecuteNonQuery();
            }
        }
        public ELClass SelectClass(ELClass elclass, string connectionString)
        {
            ELClass objClass = new ELClass();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectClass @ClassId", conn);
                cmd.Parameters.Add(new SqlParameter("ClassId", elclass.Id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        objClass.Id = Guid.Parse(reader[0].ToString());
                        objClass.Name = (reader[1].ToString());
                        objClass.projectId = Guid.Parse(reader[2].ToString());
                        objClass.customerId = Guid.Parse(reader[3].ToString());
                        objClass.Description = (reader[4].ToString());
                        objClass.ClassScope = (reader[5].ToString());
                        objClass.ClassPublicVairables = (reader[6].ToString());
                        objClass.Creator = Guid.Parse(reader[7].ToString());
                        objClass.CreatedAt = DateTime.Parse(reader[8].ToString());
                        objClass.Modifier = Guid.Parse(reader[9].ToString());
                        objClass.ModifiedAt = DateTime.Parse(reader[10].ToString());
                    }
                }

            }
            return objClass;
        }
    }
    }
