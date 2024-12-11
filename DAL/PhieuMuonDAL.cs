using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace DAL
{
    public class PhieuMuonDAL
    {
        private string connectionString = "your_connection_string_here";

        public bool AddPhieuMuon(PhieuMuon phieuMuon)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PhieuMuon (MaDocGia, MaCuonSach, NgayMuon, NgayTra) VALUES (@MaDocGia, @MaCuonSach, @NgayMuon, @NgayTra)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDocGia", phieuMuon.MaDocGia);
                cmd.Parameters.AddWithValue("@NgayMuon", phieuMuon.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", phieuMuon.NgayTra);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
