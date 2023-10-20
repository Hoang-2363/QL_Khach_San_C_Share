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
    class Check_QL_KH
    {
        public static void Them_KH(TextBox txtSDT, TextBox txtCMND, TextBox txtMa_Khach, TextBox txtTen_Khach, TextBox txtGioi_Tinh, TextBox txtDia_Chi)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            con.Open();
            string sdt = txtSDT.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            if (string.IsNullOrEmpty(txtMa_Khach.Text)
                || string.IsNullOrEmpty(txtTen_Khach.Text)
                || string.IsNullOrEmpty(txtGioi_Tinh.Text)
                || string.IsNullOrEmpty(sdt)
                || string.IsNullOrEmpty(txtDia_Chi.Text)
                || string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlCheckSDT = "SELECT * FROM KHACH_HANG WHERE SDT = @SDT";
            SqlCommand cmd = new SqlCommand(sqlCheckSDT, con);
            cmd.Parameters.AddWithValue("@SDT", sdt);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Số điện thoại " + sdt + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            dr.Close();

            string sqlCheckCMND = "SELECT * FROM KHACH_HANG WHERE CNMD = @CNMD";
            cmd = new SqlCommand(sqlCheckCMND, con);
            cmd.Parameters.AddWithValue("@CNMD", cmnd);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Chứng minh nhân dân " + cmnd + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                return;
            }
            else
            {
                MessageBox.Show("Đã thêm khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO KHACH_HANG VALUES ('KH' + RIGHT('00' + CAST(NEXT VALUE FOR KhachHang_Seq AS NVARCHAR(3)), 2), N'" + txtTen_Khach.Text + "', N'" + txtGioi_Tinh.Text + "', '" + txtSDT.Text + "', '" + txtCMND.Text + "', N'" + txtDia_Chi.Text + "');";
                command.ExecuteNonQuery();
                txtMa_Khach.Text = txtTen_Khach.Text = txtGioi_Tinh.Text = txtCMND.Text = txtDia_Chi.Text = txtSDT.Text = "";
            }
        }

        public static void Xoa_KH(TextBox txtSDT, TextBox txtCMND, TextBox txtMa_Khach, TextBox txtTen_Khach, TextBox txtGioi_Tinh, TextBox txtDia_Chi)
        {
            if (!string.IsNullOrEmpty(txtMa_Khach.Text))
            {
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
                String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
                con.Open();

                string ma_kh = txtMa_Khach.Text.Trim();
                string sqlCheckSDT = "SELECT MA_KH FROM THUE_PHONG WHERE MA_KH = @MA_KH";
                SqlCommand cmd = new SqlCommand(sqlCheckSDT, con);
                cmd.Parameters.AddWithValue("@MA_KH", ma_kh);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Mã nhân viên " + ma_kh + " đã thuê phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Đã xóa khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM KHACH_HANG WHERE MA_KH = @MA_KH";
                    command.Parameters.AddWithValue("@MA_KH", ma_kh);
                    command.ExecuteNonQuery();
                    txtMa_Khach.Text = txtTen_Khach.Text = txtGioi_Tinh.Text = txtCMND.Text = txtDia_Chi.Text = txtSDT.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Sua_KH(TextBox txtSDT, TextBox txtCMND, TextBox txtMa_Khach, TextBox txtTen_Khach, TextBox txtGioi_Tinh, TextBox txtDia_Chi)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            if (!string.IsNullOrEmpty(txtMa_Khach.Text))
            {
                MessageBox.Show("Đã sửa khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update KHACH_HANG set TEN_KH=N'" + txtTen_Khach.Text + "', GIOI_TINH=N'" + txtGioi_Tinh.Text + "', SDT='" + txtSDT.Text + "', CNMD='" + txtCMND.Text + "', DIA_CHI=N'" + txtDia_Chi.Text + "' where MA_KH='" + txtMa_Khach.Text + "'";
                command.ExecuteNonQuery();
                txtMa_Khach.Text = txtTen_Khach.Text = txtGioi_Tinh.Text = txtCMND.Text = txtDia_Chi.Text = txtSDT.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
