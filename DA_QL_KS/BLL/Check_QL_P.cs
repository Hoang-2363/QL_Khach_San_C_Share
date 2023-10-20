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
    class Check_QL_P
    {
        public static void Them_KH(TextBox txt_Ma_phong, TextBox txt_Ten_P, TextBox txt_Loai_phong, TextBox txt_Kieu_phong, TextBox txt_Tinh_trang, TextBox txt_Gia_phong, TextBox txt_Don_VT)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            con.Open();
            if (String.IsNullOrEmpty(txt_Ma_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Ten_P.Text.Trim())
                || String.IsNullOrEmpty(txt_Loai_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Kieu_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Tinh_trang.Text.Trim())
                || String.IsNullOrEmpty(txt_Gia_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Don_VT.Text.Trim()))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ma_phong = txt_Ma_phong.Text;
            string sql = "SELECT MA_PHONG FROM PHONG WHERE MA_PHONG = '" + ma_phong + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã phòng " + ma_phong + " đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            dr.Close();

            string ten_phong = txt_Ten_P.Text;
            string sql1 = "SELECT TEN_PHONG FROM PHONG WHERE TEN_PHONG = '" + ten_phong + "'";
            cmd = new SqlCommand(sql1, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tên phòng " + ten_phong + " đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            else
            {
                MessageBox.Show("Đã thêm phòng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into PHONG values ('" + txt_Ma_phong.Text + "', N'" + txt_Ten_P.Text + "', N'" + txt_Loai_phong.Text + "', N'" + txt_Kieu_phong.Text + "', N'" + txt_Tinh_trang.Text + "', '" + txt_Gia_phong.Text + "', N'" + txt_Don_VT.Text + "')";
                command.ExecuteNonQuery();
                txt_Ma_phong.Text = txt_Ten_P.Text = txt_Loai_phong.Text = txt_Kieu_phong.Text = txt_Tinh_trang.Text = txt_Gia_phong.Text = txt_Don_VT.Text = "";
            }
        }

        public static void Xoa_KH(TextBox txt_Ma_phong, TextBox txt_Ten_P, TextBox txt_Loai_phong, TextBox txt_Kieu_phong, TextBox txt_Tinh_trang, TextBox txt_Gia_phong, TextBox txt_Don_VT)
        {
            if (!string.IsNullOrEmpty(txt_Ma_phong.Text))
            {
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
                String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
                con.Open();

                if (String.IsNullOrEmpty(txt_Ma_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Ten_P.Text.Trim())
                || String.IsNullOrEmpty(txt_Loai_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Kieu_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Tinh_trang.Text.Trim())
                || String.IsNullOrEmpty(txt_Gia_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Don_VT.Text.Trim()))
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string ma_phong = txt_Ma_phong.Text;
                string sql = "SELECT MA_PHONG FROM PHONG WHERE MA_PHONG = '" + ma_phong + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == false)
                {
                    MessageBox.Show("Mã phòng " + txt_Ma_phong.Text + " không có !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr.Close();
                    return;
                }
                dr.Close();
                string sql2 = "SELECT MA_PHONG FROM THUE_PHONG WHERE MA_PHONG = '" + ma_phong + "'";
                cmd = new SqlCommand(sql2, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Mã phòng " + txt_Ma_phong.Text + " đang được thuê không thể xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Đã xóa phòng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "delete from PHONG where MA_PHONG= '" + ma_phong + "'";
                    command.ExecuteNonQuery();
                    txt_Ma_phong.Text = txt_Ten_P.Text = txt_Loai_phong.Text = txt_Kieu_phong.Text = txt_Tinh_trang.Text = txt_Gia_phong.Text = txt_Don_VT.Text = "";
                }
            }
        }

        public static void Sua_KH(TextBox txt_Ma_phong, TextBox txt_Ten_P, TextBox txt_Loai_phong, TextBox txt_Kieu_phong, TextBox txt_Tinh_trang, TextBox txt_Gia_phong, TextBox txt_Don_VT)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            if (String.IsNullOrEmpty(txt_Ma_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Ten_P.Text.Trim())
                || String.IsNullOrEmpty(txt_Loai_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Kieu_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Tinh_trang.Text.Trim())
                || String.IsNullOrEmpty(txt_Gia_phong.Text.Trim())
                || String.IsNullOrEmpty(txt_Don_VT.Text.Trim()))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ma_phong = txt_Ma_phong.Text;
            string sql = "SELECT MA_PHONG FROM PHONG WHERE MA_PHONG = '" + ma_phong + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == false)
                {
                    MessageBox.Show("Mã phòng " + ma_phong + " không có !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã sửa phòng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "update PHONG set TEN_PHONG=N'" + txt_Ten_P.Text + "', LOAI_PHONG=N'" + txt_Loai_phong.Text + "', KIEU_PHONG=N'" + txt_Kieu_phong.Text + "', TINH_TRANG=N'" + txt_Tinh_trang.Text + "', GIA_PHONG='" + txt_Gia_phong.Text + "', DON_VI_TINH=N'" + txt_Don_VT.Text + "' where MA_PHONG='" + txt_Ma_phong.Text + "'";
                    command.ExecuteNonQuery();
                    txt_Ma_phong.Text = txt_Ten_P.Text = txt_Loai_phong.Text = txt_Kieu_phong.Text = txt_Tinh_trang.Text = txt_Gia_phong.Text = txt_Don_VT.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close(); 
            }
        }

    }
}
