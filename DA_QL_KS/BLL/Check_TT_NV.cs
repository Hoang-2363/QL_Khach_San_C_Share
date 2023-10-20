using DA_QL_KS.DAL;
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
    class Check_TT_NV
    {
        public static void Sua_KH(TextBox txtMa_NV, TextBox txtTen_NV, TextBox txtLuong, TextBox txtDia_Chi, TextBox txtSDT, TextBox txtGmail)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            if (!string.IsNullOrEmpty(txtMa_NV.Text))
            {
                MessageBox.Show("Đã sửa thông tin nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update NHAN_VIEN set DIA_CHI=N'" + txtDia_Chi.Text + "', SDT='" + txtSDT.Text + "', EMAIL='" + txtGmail.Text + "' where MA_NV='" + txtMa_NV.Text + "'";
                command.ExecuteNonQuery();
                txtMa_NV.Text = txtTen_NV.Text = txtLuong.Text = txtDia_Chi.Text = txtDia_Chi.Text = txtSDT.Text = txtGmail.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
