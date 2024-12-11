using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocgiaDAL
    {
        private string connectionString = "your_connection_string_here";

        public DocGia GetDocGiaById(string maDocGia)
        {
            DocGia docGia = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DocGia WHERE MaDocGia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    docGia = new DocGia
                    {
                        MaDocGia = reader["MaDocGia"].ToString(),
                        TenDocGia = reader["TenDocGia"].ToString()
                    };
                }
            }
            return docGia;
        }
    }

}

