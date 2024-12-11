using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class phieumuontrasasch : Form
    {
        public phieumuontrasasch()
        {
            InitializeComponent();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBorrowControls();
            HideReturnControls();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReturnControls();
            HideBorrowControls();
        }

        private void ShowBorrowControls()
        {
            label_phieumuonsach.Visible = true;
            macuonsach.Visible = true;
            text_macuonsach.Visible = true;
            textbox_madocgia.Visible = true;
            datetime_ngaymuon.Visible = true;
            datetime_ngaytra.Visible = true;
            madocgia.Visible = true;
            ngaymuon.Visible = true;
            ngaytra.Visible = true;
            dongy_button.Visible = true;
            text_maphieumuon.Visible = false;
            maphieumuon.Visible = false;
            checkmaphieumuon_button.Visible = false;
            nhapngaytra.Visible = false;
            nhapngaytra_textbox.Visible = false;
        }

        private void HideBorrowControls()
        {
            label_phieumuonsach.Visible = false;
            macuonsach.Visible = false;
            text_macuonsach.Visible = false;
            textbox_madocgia.Visible = false;
            datetime_ngaymuon.Visible = false;
            datetime_ngaytra.Visible = false;
            madocgia.Visible = false;
            ngaymuon.Visible = false;
            ngaytra.Visible = false;
            dongy_button.Visible = false;
        }

        private void ShowReturnControls()
        {
            text_maphieumuon.Visible = true;
            phieutrasach.Visible = true;
            maphieumuon.Visible = true;
            checkmaphieumuon_button.Visible = true;
            nhapngaytra.Visible = true;
            nhapngaytra_textbox.Visible = true;
        }

        private void HideReturnControls()
        {
            text_maphieumuon.Visible = false;
            phieutrasach.Visible = false;
            maphieumuon.Visible = false;
            checkmaphieumuon_button.Visible = false;
            nhapngaytra.Visible = false;
            nhapngaytra_textbox.Visible = false;
        }

        private void dongy_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(macuonsach.Text) || string.IsNullOrWhiteSpace(textbox_madocgia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayMuon = datetime_ngaymuon.Value;
            DateTime ngayTra = datetime_ngaytra.Value;

            string connectionString = "Data Source=KAYTLYNNGUYEN;Initial Catalog=UEZ;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tạo mã phiếu mượn tự động
                    string maPhieuMuon = GenerateMaPhieuMuon(connection);

                    // Lưu thông tin phiếu mượn
                    string sql = "INSERT INTO PhieuMuon (MaPhieuMuon, MaDocGia, NgayMuon, NgayTra) VALUES (@MaPhieuMuon, @MaDocGia, @NgayMuon, @NgayTra)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                        command.Parameters.AddWithValue("@MaDocGia", textbox_madocgia.Text);
                        command.Parameters.AddWithValue("@NgayMuon", ngayMuon);
                        command.Parameters.AddWithValue("@NgayTra", ngayTra);

                        command.ExecuteNonQuery();
                    }

                    // Lưu thông tin chi tiết phiếu mượn
                    string sqlChiTiet = "INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaCuonSach, MaCTPM) VALUES (@MaPhieuMuon, @MaCuonSach, @MaCTPM)";
                    using (SqlCommand commandChiTiet = new SqlCommand(sqlChiTiet, connection))
                    {
                        commandChiTiet.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                        commandChiTiet.Parameters.AddWithValue("@MaCuonSach", macuonsach.Text);
                        commandChiTiet.Parameters.AddWithValue("@MaCTPM", GenerateMaCTPM(connection)); // Tạo mã chi tiết phiếu mượn tự động

                        commandChiTiet.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thông tin phiếu mượn đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GenerateMaPhieuMuon(SqlConnection connection)
        {
            // Lấy mã phiếu mượn lớn nhất hiện có
            string sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(MaPhieuMuon, 3, LEN(MaPhieuMuon) - 2) AS INT)), 0) + 1 FROM PhieuMuon";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                int nextId = (int)command.ExecuteScalar();
                return "PM" + nextId.ToString("D3"); // Tạo mã phiếu mượn mới
            }
        }

        private string GenerateMaCTPM(SqlConnection connection)
        {
            // Lấy mã chi tiết phiếu mượn lớn nhất hiện có
            string sql = "SELECT ISNULL(MAX(CAST(SUBSTRING(MaCTPM, 6, LEN(MaCTPM) - 5) AS INT)), 0) + 1 FROM ChiTietPhieuMuon";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                int nextId = (int)command.ExecuteScalar();
                return "CTPM" + nextId.ToString("D3"); // Tạo mã chi tiết phiếu mượn mới
            }
        }
    }
}
