using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidLibiary;
namespace SolidLibiaryDataLayer
{
    public class DLParameter
    {
        public void AddParameter(ELParameter eLParameter, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC AddParameter @Name, @MethodId, @ParameterScope, @ReturnType, @InputOrOutput, @Creator, @CreatedAt, @Modifier, @ModifiedAt", conn);
                cmd.Parameters.Add(new SqlParameter("Name", eLParameter.Name));
                cmd.Parameters.Add(new SqlParameter("MethodId", eLParameter.MethodId));
                cmd.Parameters.Add(new SqlParameter("ParameterScope", eLParameter.Scope));
                cmd.Parameters.Add(new SqlParameter("ReturnType", eLParameter.ReturnType));
                cmd.Parameters.Add(new SqlParameter("InputOrOutput", eLParameter.InputOrOutput));
                cmd.Parameters.Add(new SqlParameter("Creator", eLParameter.Creator));
                cmd.Parameters.Add(new SqlParameter("CreatedAt", eLParameter.CreatedAt));
                cmd.Parameters.Add(new SqlParameter("Modifier", eLParameter.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLParameter.ModifiedAt));
                cmd.ExecuteNonQuery();
            }
        }
        public List<ELParameter> SelectAllParameter(string connectionString)
        {
            List<ELParameter> parameterList = new List<ELParameter>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectAllParameter", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ELParameter objParameter = new ELParameter();
                        objParameter.Id = Guid.Parse(reader[0].ToString());
                        objParameter.Name = (reader[1].ToString());
                        objParameter.MethodId = Guid.Parse(reader[2].ToString());
                        objParameter.Scope = (reader[3].ToString());
                        objParameter.ReturnType = (reader[4].ToString());
                        objParameter.InputOrOutput = (reader[5].ToString());
                        objParameter.Creator = Guid.Parse(reader[6].ToString());
                        objParameter.CreatedAt = DateTime.Parse(reader[7].ToString());
                        objParameter.Modifier = Guid.Parse(reader[8].ToString());
                        objParameter.ModifiedAt = DateTime.Parse(reader[9].ToString());
                        parameterList.Add(objParameter);
                    }
                }
            }

            return parameterList;
        }
        public void UpdateParameter(ELParameter eLParameter, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC UpdateParameter @ParameterId, @Name, @MethodId, @ParameterScope, @ReturnType, @InputOrOutput, @Modifier, @ModifiedAt", conn);
                cmd.Parameters.Add(new SqlParameter("ParameterId", eLParameter.Id));
                cmd.Parameters.Add(new SqlParameter("Name", eLParameter.Name));
                cmd.Parameters.Add(new SqlParameter("MethodId", eLParameter.MethodId));
                cmd.Parameters.Add(new SqlParameter("ParameterScope", eLParameter.Scope));
                cmd.Parameters.Add(new SqlParameter("ReturnType", eLParameter.ReturnType));
                cmd.Parameters.Add(new SqlParameter("InputOrOutput", eLParameter.InputOrOutput));
                cmd.Parameters.Add(new SqlParameter("Modifier", eLParameter.Modifier));
                cmd.Parameters.Add(new SqlParameter("ModifiedAt", eLParameter.ModifiedAt));

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteParameter(ELParameter eLParameter, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC DeleteParameter @Id", conn);
                cmd.Parameters.Add(new SqlParameter("Id", eLParameter.Id));
                cmd.ExecuteNonQuery();
            }
        }
        public ELParameter SelectParameter(ELParameter eLParameter, string connectionString)
        {
            ELParameter objParameter = new ELParameter();
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = connectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC SelectPArameter @Id", conn);
                cmd.Parameters.Add(new SqlParameter("Id", eLParameter.Id));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objParameter.Id = Guid.Parse(reader[0].ToString());
                        objParameter.Name = (reader[1].ToString());
                        objParameter.MethodId = Guid.Parse(reader[2].ToString());
                        objParameter.Scope = (reader[3].ToString());
                        objParameter.ReturnType = (reader[4].ToString());
                        objParameter.InputOrOutput = (reader[5].ToString());
                        objParameter.Creator = Guid.Parse(reader[6].ToString());
                        objParameter.CreatedAt = DateTime.Parse(reader[7].ToString());
                        objParameter.Modifier = Guid.Parse(reader[8].ToString());
                        objParameter.ModifiedAt = DateTime.Parse(reader[9].ToString());
                    }
                }
            }
            return objParameter;
        }
    }
}
