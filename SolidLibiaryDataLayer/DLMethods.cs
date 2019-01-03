using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidLibiary;


namespace SolidLibiaryDataLayer
{
    public class DLMethods
    {
        public void AddMethods(ELMethods eLMethods, string connectionString)
        {
            using(SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC AddMethods @Name,@ClassId,@Description,@MethodScope,@ReturnType,@Creator,@CreatedAt,@Modifier,@ModifiedAt",conn);
                cmd.Parameters.Add(new SqlParameter("Name",eLMethods.Name));
                cmd.Parameters.Add(new SqlParameter("ClassId", eLMethods.ClasssId));
                cmd.Parameters.Add(new SqlParameter("Description", eLMethods.Description));
                cmd.Parameters.Add(new SqlParameter("MethodScope", eLMethods.Scope));
                cmd.Parameters.Add(new SqlParameter("ReturnType", eLMethods.ReturnType));
                cmd.Parameters.Add(new SqlParameter("Creator", eLMethods.Creator));
                cmd.Parameters.Add(new SqlParameter("CreatedAt", eLMethods.CreatedAt));
                cmd.Parameters.Add(new SqlParameter("Modifier", eLMethods.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLMethods.ModifiedAt));
                cmd.ExecuteNonQuery();
            }
        }
        public List<ELMethods> SelectAllMethods(string connectionString)
        {
            List<ELMethods> methodList = new List<ELMethods>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectAllMethods", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ELMethods objMethod = new ELMethods();
                        objMethod.Id = Guid.Parse(reader[0].ToString());
                        objMethod.Name = (reader[1].ToString());
                        objMethod.ClasssId = Guid.Parse(reader[2].ToString());
                        objMethod.Description = (reader[3].ToString());
                        objMethod.Scope = (reader[4].ToString());
                        objMethod.ReturnType = (reader[5].ToString());
                        objMethod.Creator = Guid.Parse(reader[6].ToString());
                        objMethod.CreatedAt = DateTime.Parse(reader[7].ToString());
                        objMethod.Modifier = Guid.Parse(reader[8].ToString());
                        objMethod.ModifiedAt = DateTime.Parse(reader[9].ToString());
                        methodList.Add(objMethod);
                    }
                }
            }

            return methodList;
        }
        public void UpdateMethods(ELMethods eLMethods,string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC UpdateMethods @Id,@Name,@ClassId,@Description,@MethodScope,@ReturnType,@Modifier,@ModifiedAt", conn);
                cmd.Parameters.Add(new SqlParameter("Id", eLMethods.Id));
                cmd.Parameters.Add(new SqlParameter("Name", eLMethods.Name));
                cmd.Parameters.Add(new SqlParameter("ClassId", eLMethods.ClasssId));
                cmd.Parameters.Add(new SqlParameter("Description", eLMethods.Description));
                cmd.Parameters.Add(new SqlParameter("MethodScope",eLMethods.Scope));
                cmd.Parameters.Add(new SqlParameter("ReturnType", eLMethods.ReturnType));
                cmd.Parameters.Add(new SqlParameter("Modifier", eLMethods.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLMethods.ModifiedAt));
                
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteMethods(ELMethods eLMethods, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC DeleteMethods @Id", conn);
                cmd.Parameters.Add(new SqlParameter("Id", eLMethods.Id));
                cmd.ExecuteNonQuery();
            }
        }
        public ELMethods SelectMethods(ELMethods eLMethods, string connectionString)
        {
            ELMethods objMethods = new ELMethods();
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectMethods @Id", conn);
                cmd.Parameters.Add(new SqlParameter("Id", eLMethods.Id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objMethods.Id = Guid.Parse(reader[0].ToString());
                        objMethods.Name = (reader[1].ToString());
                        objMethods.ClasssId = Guid.Parse(reader[2].ToString());
                        objMethods.Description = (reader[3].ToString());
                        objMethods.Scope = (reader[4].ToString());
                        objMethods.ReturnType = (reader[5].ToString());
                        objMethods.Creator = Guid.Parse(reader[6].ToString());
                        objMethods.CreatedAt = DateTime.Parse(reader[7].ToString());
                        objMethods.Modifier = Guid.Parse(reader[8].ToString());
                        objMethods.ModifiedAt = DateTime.Parse(reader[9].ToString());
                    }
                }
            }
            return objMethods;
        }
    }
}
