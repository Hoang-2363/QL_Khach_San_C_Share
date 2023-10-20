using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QL_KS.BLL
{
    class Check_CN_Thue_P
    {
        public static void thue_Phong(TextBox txtMa_TP, TextBox txtNgay_Den, ComboBox txt_Ma_KH, TextBox txtMa_NV, ComboBox txt_Ma_P)
        {
            SqlConnection connection1;
            SqlCommand command1;
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();

            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            con.Open();
            string ma_thp = txtMa_TP.Text.Trim();
            if (string.IsNullOrEmpty(txtNgay_Den.Text)
                || string.IsNullOrEmpty(txt_Ma_KH.Text)
                || string.IsNullOrEmpty(txt_Ma_P.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlCheckSDT = "SELECT MA_THUE_P FROM THUE_PHONG WHERE MA_THUE_P = @MA_THUE_P";
            SqlCommand cmd = new SqlCommand(sqlCheckSDT, con);
            cmd.Parameters.AddWithValue("@MA_THUE_P", ma_thp);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã thuê phòng " + ma_thp + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            else
            {
                string dateTimeInput = txtNgay_Den.Text;
                if (DateTime.TryParseExact(dateTimeInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDateTime))
                {
                    connection1 = new SqlConnection(str);
                    connection1.Open();
                    command1 = connection1.CreateCommand();
                    command1.CommandText = "INSERT INTO THUE_PHONG VALUES ('Ma_ThP_' + RIGHT('00' + CAST(NEXT VALUE FOR THP_Seq AS NVARCHAR(3)), 2), CONVERT(datetime, @NGAY_DEN + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103), @MA_KH, @MA_NV, @MA_PHONG, N'Đang thuê phòng');";
                    command1.Parameters.AddWithValue("@NGAY_DEN", txtNgay_Den.Text);
                    command1.Parameters.AddWithValue("@MA_KH", txt_Ma_KH.Text);
                    command1.Parameters.AddWithValue("@MA_NV", txtMa_NV.Text);
                    command1.Parameters.AddWithValue("@MA_PHONG", txt_Ma_P.Text);
                    command1.ExecuteNonQuery();

                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "UPDATE PHONG SET TINH_TRANG = N'Đã thuê' WHERE MA_PHONG = '" + txt_Ma_P.Text + "'";
                    command.ExecuteNonQuery();
                    txtMa_TP.Text = txtNgay_Den.Text = txt_Ma_KH.Text = txt_Ma_P.Text = "";
                }
                else
                {
                    MessageBox.Show("Định dạng ngày giờ không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
