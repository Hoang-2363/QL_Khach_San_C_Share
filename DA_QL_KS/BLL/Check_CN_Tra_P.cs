using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QL_KS.BLL
{
    class Check_CN_Tra_P
    {
        public static void Tra_P(TextBox txt_Ma_TRP, TextBox txtNgay_Di, TextBox txtMa_Thue_Phong)
        {
            SqlConnection connection;
            SqlCommand command;
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            con.Open();
            string ma_trp = txt_Ma_TRP.Text.Trim();
            if (string.IsNullOrEmpty(txtNgay_Di.Text)
                || string.IsNullOrEmpty(txtMa_Thue_Phong.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlCheckSDT = "SELECT * FROM TRA_PHONG WHERE MA_TRA_P = @MA_TRA_P";
            SqlCommand cmd = new SqlCommand(sqlCheckSDT, con);
            cmd.Parameters.AddWithValue("@MA_TRA_P", ma_trp);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã trả phòng " + ma_trp + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            else
            {
                string dateTimeInput = txtNgay_Di.Text;
                if (KT_Nhap_Ngay(txtNgay_Di, txtMa_Thue_Phong))
                {
                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO TRA_PHONG VALUES ('Ma_TrP_' + RIGHT('00' + CAST(NEXT VALUE FOR TRP_Seq AS NVARCHAR(3)), 2), CONVERT(datetime, @NGAY_DI + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103), @MA_THUE_P, N'Chưa thanh toán');";
                    command.Parameters.AddWithValue("@NGAY_DI", txtNgay_Di.Text);
                    command.Parameters.AddWithValue("@MA_THUE_P", txtMa_Thue_Phong.Text);
                    command.ExecuteNonQuery();

                    string loadTinh_Trang = "UPDATE PHONG SET TINH_TRANG = N'Trống' WHERE MA_PHONG IN (SELECT MA_PHONG FROM THUE_PHONG where MA_THUE_P = '" + txtMa_Thue_Phong.Text + "')";
                    command.CommandText = loadTinh_Trang;
                    command.ExecuteNonQuery();
                    command = connection.CreateCommand();

                    string loadTinh_Trang_1 = "UPDATE THUE_PHONG SET TRANG_THAI = N'Đã trả phòng' WHERE MA_THUE_P = '" + txtMa_Thue_Phong.Text + "'";
                    command.CommandText = loadTinh_Trang_1;
                    command.ExecuteNonQuery();
                    command = connection.CreateCommand();
                    txtNgay_Di.Text = txtMa_Thue_Phong.Text = txt_Ma_TRP.Text = "";

                }
            }
        }

        public static bool KT_Nhap_Ngay(TextBox txtNgay_Di, TextBox ma_Thu_Phong)
        {
            DateTime ngayDi;
            if (DateTime.TryParseExact(txtNgay_Di.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayDi))
            {
                string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        DateTime ngayDenDateTime = GetNgayDen(connection, ma_Thu_Phong.Text);

                        if (ngayDenDateTime != DateTime.MinValue)
                        {
                            DateTime ngayLapDateTime = GetNgayLapHDDichVu(connection, ma_Thu_Phong.Text);

                            if (ngayLapDateTime != DateTime.MinValue)
                            {
                                if (ngayDi > ngayDenDateTime)
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Ngày đi phải trước ngày đến.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy ngày lập hóa đơn dịch vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ngày đến của thuê phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Định dạng ngày đi không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private static DateTime GetNgayDen(SqlConnection connection, string maThuPhong)
        {
            string query = "SELECT FORMAT(NGAY_DEN, 'dd/MM/yyyy') AS NGAY_DEN FROM THUE_PHONG WHERE MA_THUE_P = @MaThuPhong;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaThuPhong", maThuPhong);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string ngayDen = result.ToString();
                    if (DateTime.TryParseExact(ngayDen, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayDenDateTime))
                    {
                        return ngayDenDateTime;
                    }
                }

                return DateTime.MinValue;
            }
        }

        private static DateTime GetNgayLapHDDichVu(SqlConnection connection, string maThuPhong)
        {
            string query = "SELECT FORMAT(NGAY_LAP, 'dd/MM/yyyy') AS NGAY_LAP FROM HD_DICH_VU INNER JOIN PHONG ON HD_DICH_VU.MA_PHONG = PHONG.MA_PHONG INNER JOIN THUE_PHONG ON PHONG.MA_PHONG = THUE_PHONG.MA_PHONG WHERE HD_DICH_VU.MA_PHONG = (SELECT MA_PHONG FROM THUE_PHONG WHERE MA_THUE_P = @MaThuPhong) AND HD_DICH_VU.TRANG_THAI = N'Chưa thanh toán';";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaThuPhong", maThuPhong);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    string ngayLap = result.ToString();
                    if (DateTime.TryParseExact(ngayLap, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayLapDateTime))
                    {
                        return ngayLapDateTime;
                    }
                }

                return DateTime.MinValue;
            }
        }


        public static void Tao_HD_Tong_Hop(TextBox txt_Ma_TRP, TextBox txtMa_Thue_Phong)
        {
            SqlConnection connection;
            SqlCommand command;
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            con.Open();
            string ma_trp = txt_Ma_TRP.Text.Trim();
            if (string.IsNullOrEmpty(txtMa_Thue_Phong.Text) || string.IsNullOrEmpty(txt_Ma_TRP.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO HD_THANH_TOAN VALUES ('HD_TP' + RIGHT('00' + CAST(NEXT VALUE FOR HoaDonTP_Seq AS NVARCHAR(3)), 2), '" + txt_Ma_TRP.Text + "', null, GETDATE(), null);";
            command.ExecuteNonQuery();

            string loadTinh_Trang = "UPDATE TRA_PHONG SET TRANG_THAI = N'Đã thanh toán' WHERE MA_TRA_P = '" + txt_Ma_TRP.Text + "'";
            command.CommandText = loadTinh_Trang;
            command.ExecuteNonQuery();
            command = connection.CreateCommand();

            string loadTinh_Trang_1 = "UPDATE HD_DICH_VU SET TRANG_THAI = N'Đã thanh toán' WHERE HD_DICH_VU.MA_PHONG = (SELECT MA_PHONG FROM THUE_PHONG WHERE MA_THUE_P = '" + txtMa_Thue_Phong.Text + "') AND HD_DICH_VU.TRANG_THAI = N'Chưa thanh toán';";
            command.CommandText = loadTinh_Trang_1;
            command.ExecuteNonQuery();
            command = connection.CreateCommand();
        }
    }
}
