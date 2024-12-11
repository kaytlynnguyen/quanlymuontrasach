using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
using System.Configuration;
using System.Threading.Tasks;

namespace DAL
{
    public class CuonSachDAL
    {
        private string connectionString = "your_connection_string_here";

        public TuaSach GetCuonSachById(string maSach)
        {
            TuaSach cuonSach = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TuaSach WHERE MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSach", maSach);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cuonSach = new TuaSach
                    {
                        MaSach = reader["MaSach"].ToString(),
                        TenSach = reader["TenSach"].ToString(),
                        SoLuongConLai = int.Parse(reader["SoLuongConLai"].ToString())

                    };
                }
            }
            return cuonSach;
        }
    }


}