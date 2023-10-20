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
    class Check_QL_DV
    {
        public static void Them_KH(TextBox txt_Ma_DV, TextBox txt_Ten_DV, TextBox txt_Loai_DV, TextBox txt_Gia_DV, TextBox txt_DV)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            con.Open();

            if (String.IsNullOrEmpty(txt_Ma_DV.Text.Trim())
                || String.IsNullOrEmpty(txt_Ten_DV.Text.Trim())
                || String.IsNullOrEmpty(txt_Loai_DV.Text.Trim())
                || String.IsNullOrEmpty(txt_Gia_DV.Text.Trim())
                || String.IsNullOrEmpty(txt_DV.Text.Trim()))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int a;
            if (!int.TryParse(txt_Gia_DV.Text, out a))
            {
                MessageBox.Show("Hãy nhập giá tiền bằng kiểu số nguyên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ma_dv = txt_Ma_DV.Text.Trim();
            string sqlCheckSDT = "SELECT MA_DV FROM DICH_VU WHERE MA_DV = @MA_DV";
            SqlCommand cmd = new SqlCommand(sqlCheckSDT, con);
            cmd.Parameters.AddWithValue("@MA_DV", ma_dv);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã dịch vụ " + ma_dv + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            dr.Close();

            string ten_dv = txt_Ten_DV.Text.Trim();
            string sqlCheckCMND = "SELECT * FROM DICH_VU WHERE TEN_DV = @TEN_DV";
            cmd = new SqlCommand(sqlCheckCMND, con);
            cmd.Parameters.AddWithValue("@TEN_DV", ten_dv);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tên dịch vụ " + ten_dv + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            else
            {
                MessageBox.Show("Đã thêm phòng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into DICH_VU values ('" + txt_Ma_DV.Text + "', N'" + txt_Ten_DV.Text + "', N'" + txt_Loai_DV.Text + "', '" + txt_Gia_DV.Text + "', N'" + txt_DV.Text + "')";
                command.ExecuteNonQuery();
                txt_Ma_DV.Text = txt_Ten_DV.Text = txt_Loai_DV.Text = txt_Gia_DV.Text = txt_DV.Text = "";
            }
        }

        public static void Xoa_KH(TextBox txt_Ma_DV, TextBox txt_Ten_DV, TextBox txt_Loai_DV, TextBox txt_Gia_DV, TextBox txt_DV)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            con.Open();

            if (String.IsNullOrEmpty(txt_Ma_DV.Text.Trim())
            || String.IsNullOrEmpty(txt_Ten_DV.Text.Trim())
            || String.IsNullOrEmpty(txt_Loai_DV.Text.Trim())
            || String.IsNullOrEmpty(txt_Gia_DV.Text.Trim())
            || String.IsNullOrEmpty(txt_DV.Text.Trim()))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ma_phong = txt_Ma_DV.Text;
            string sql = "SELECT MA_DV FROM DICH_VU WHERE MA_DV = '" + ma_phong + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == false)
            {
                MessageBox.Show("Mã dịch vụ " + ma_phong + " không có !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            dr.Close();
            string sql2 = "SELECT MA_DV FROM DAT_DICH_VU WHERE MA_DV = '" + ma_phong + "'";
            cmd = new SqlCommand(sql2, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã dịch vụ " + ma_phong + " đã được sử dụng không thể xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            else
            {
                MessageBox.Show("Đã xóa dịch vụ thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "delete from DICH_VU where MA_DV= '" + txt_Ma_DV.Text + "'";
                command.ExecuteNonQuery();
                txt_Ma_DV.Text = txt_Ten_DV.Text = txt_Loai_DV.Text = txt_Gia_DV.Text = txt_DV.Text = "";
            }
            
        }


        public static void Sua_KH(TextBox txt_Ma_DV, TextBox txt_Ten_DV, TextBox txt_Loai_DV, TextBox txt_Gia_DV, TextBox txt_DV)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            if (String.IsNullOrEmpty(txt_Ma_DV.Text.Trim())
                || String.IsNullOrEmpty(txt_Ten_DV.Text.Trim())
                || String.IsNullOrEmpty(txt_Loai_DV.Text.Trim())
                || String.IsNullOrEmpty(txt_Gia_DV.Text.Trim())
                || String.IsNullOrEmpty(txt_DV.Text.Trim()))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int a;
            if (!int.TryParse(txt_Gia_DV.Text, out a))
            {
                MessageBox.Show("Hãy nhập giá tiền bằng kiểu số nguyên !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ma_dv = txt_Ma_DV.Text.Trim();
            string sqlCheckSDT = "SELECT MA_DV FROM DICH_VU WHERE MA_DV = @MA_DV";
            SqlCommand cmd = new SqlCommand(sqlCheckSDT, con);
            cmd.Parameters.AddWithValue("@MA_DV", ma_dv);
            SqlDataReader dr = null; 

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read() == false)
                {
                    MessageBox.Show("Mã dịch vụ " + ma_dv + " không có !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã sửa dịch vụ thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "update DICH_VU set LOAI_DV=N'" + txt_Loai_DV.Text + "', TEN_DV=N'" + txt_Ten_DV.Text + "', GIA_DV='" + txt_Gia_DV.Text + "', DON_VI=N'" + txt_DV.Text + "' where MA_DV='" + txt_Ma_DV.Text + "'";
                    command.ExecuteNonQuery();
                    txt_Ma_DV.Text = txt_Ten_DV.Text = txt_Loai_DV.Text = txt_Gia_DV.Text = txt_DV.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close(); 
                }
                con.Close(); 
            }
        }

    }
}

