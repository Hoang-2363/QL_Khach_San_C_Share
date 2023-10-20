using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QL_KS.BLL
{
    class Check_Su_Dung_DV
    {
        public static void Them_DV(TextBox txtSo_Luong, TextBox txt_Ma_DV)
        {
            SqlConnection connection1;
            SqlCommand command1;
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            con.Open();
            int i;
            if (string.IsNullOrEmpty(txtSo_Luong.Text) || string.IsNullOrEmpty(txt_Ma_DV.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else if (!int.TryParse(txtSo_Luong.Text, out i) ) {
                MessageBox.Show("Hãy nhập số lượng là số nguyên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!int.TryParse(txtSo_Luong.Text, out i) && i <= 0)
            {
                MessageBox.Show("Hãy nhập số lượng lớn hơn 0 !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sqlCheckSDT = "SELECT * FROM DAT_DICH_VU WHERE MA_DV = @MA_DV AND MA_HD_DV IS NULL";
            SqlCommand cmd = new SqlCommand(sqlCheckSDT, con);
            cmd.Parameters.AddWithValue("@MA_DV", txt_Ma_DV.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close(); 
                MessageBox.Show("Mã dịch vụ " + txt_Ma_DV.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSo_Luong.Text = txt_Ma_DV.Text = "";
                return;
            }
            else
            {
                dr.Close(); 
                connection1 = new SqlConnection(str);
                connection1.Open();
                command1 = connection1.CreateCommand();
                command1.CommandText = "INSERT INTO DAT_DICH_VU VALUES (NULL, '" + txt_Ma_DV.Text + "', '" + txtSo_Luong.Text + "')";
                command1.ExecuteNonQuery();
            }
            txtSo_Luong.Text = txt_Ma_DV.Text = "";
        }
        
        public static void Sua_DV(TextBox txtSo_Luong, TextBox txt_Ma_DV)
        {
            SqlConnection connection1;
            SqlCommand command1;
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            con.Open();

            if (string.IsNullOrEmpty(txtSo_Luong.Text) || string.IsNullOrEmpty(txt_Ma_DV.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!int.TryParse(txtSo_Luong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Hãy nhập số lượng lớn hơn 0 và là số nguyên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else { 
                connection1 = new SqlConnection(str);
                connection1.Open();
                command1 = connection1.CreateCommand();
                command1.CommandText = "UPDATE DAT_DICH_VU SET SO_LUONG = @SoLuong WHERE MA_DV = @MaDV";
                command1.Parameters.AddWithValue("@SoLuong", txtSo_Luong.Text);
                command1.Parameters.AddWithValue("@MaDV", txt_Ma_DV.Text);
                command1.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtSo_Luong.Text = txt_Ma_DV.Text = "";
        }

        public static void Xoa_DV(TextBox txtSo_Luong, TextBox txt_Ma_DV)
        {
            SqlConnection connection1;
            SqlCommand command1;
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            int i;
            if (string.IsNullOrEmpty(txtSo_Luong.Text) || string.IsNullOrEmpty(txt_Ma_DV.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!int.TryParse(txtSo_Luong.Text, out i))
            {
                MessageBox.Show("Hãy nhập số lượng là số nguyên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!int.TryParse(txtSo_Luong.Text, out i) && i <= 0)
            {
                MessageBox.Show("Hãy nhập số lượng lớn hơn 0 !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                connection1 = new SqlConnection(str);
                connection1.Open();
                command1 = connection1.CreateCommand();
                command1.CommandText = "delete from DAT_DICH_VU where MA_DV= '" + txt_Ma_DV.Text + "'";
                command1.ExecuteNonQuery();
            }
            txtSo_Luong.Text = txt_Ma_DV.Text = "";
        }

        public static bool KT_Thoat()
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM DAT_DICH_VU WHERE MA_HD_DV IS NULL;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowCount = (int)command.ExecuteScalar();

                        if (rowCount > 0)
                        {
                            MessageBox.Show("Có dịch vụ chưa được thanh toán. Không thể thoát.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; 
                        }
                        else
                        {
                            return true; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false; 
            }
        }

        public static void Them_HD_DV(ComboBox txt_Ma_KH, ComboBox txt_Ma_P, TextBox txtMa_NV, TextBox txtNgay_Lap)
        {
            SqlConnection connection1;
            SqlCommand command1;
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            int i;
            if (string.IsNullOrEmpty(txt_Ma_KH.Text) || string.IsNullOrEmpty(txt_Ma_P.Text)
                || string.IsNullOrEmpty(txtMa_NV.Text) || string.IsNullOrEmpty(txtNgay_Lap.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string dateTimeInput = txtNgay_Lap.Text;
            if (DateTime.TryParseExact(dateTimeInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDateTime))
            {
                connection1 = new SqlConnection(str);
                connection1.Open();

                command1 = connection1.CreateCommand();
                command1.CommandText = "SELECT COUNT(MA_DV) FROM DAT_DICH_VU WHERE MA_HD_DV IS NULL";
                int numberOfUnbilledServices = (int)command1.ExecuteScalar();

                if (numberOfUnbilledServices > 0)
                {
                    connection1 = new SqlConnection(str);
                    connection1.Open();
                    command1 = connection1.CreateCommand();
                    command1.CommandText = "INSERT INTO HD_DICH_VU VALUES ('Ma_HD_DV' + RIGHT('00' + CAST(NEXT VALUE FOR HoaDonDV_Seq AS NVARCHAR(3)), 2), '" + txt_Ma_KH.Text + "', '" + txt_Ma_P.Text + "', '" + txtMa_NV.Text + "', CONVERT(datetime, '" + txtNgay_Lap.Text + "' + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103), N'Chưa thanh toán');";
                    command1.ExecuteNonQuery();
                    command1 = connection1.CreateCommand();
                    command1.CommandText = "SELECT TOP 1 MA_HD_DV FROM HD_DICH_VU ORDER BY MA_HD_DV DESC";
                    object result1 = command1.ExecuteScalar();

                    if (result1 != null)
                    {
                        string maHD = result1.ToString();
                        command1 = connection1.CreateCommand();
                        command1.CommandText = "UPDATE DAT_DICH_VU SET MA_HD_DV = @MA_HD_DV WHERE MA_HD_DV IS NULL;";
                        command1.Parameters.AddWithValue("@MA_HD_DV", maHD);
                        command1.ExecuteNonQuery();
                        connection1.Close();

                        MessageBox.Show("Đã lưu thành công hóa đơn dịch vụ !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy mua 1 hàng hóa mới lưu hóa đơn được !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Định dạng ngày không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
