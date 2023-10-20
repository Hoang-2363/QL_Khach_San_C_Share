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

namespace DA_QL_KS.DAL
{
    class Connect_Dang_Nhap
    {
        public static void Dang_Nhap(Form i, Form o, TextBox txtTai_Khoan, TextBox txt_Mat_khau)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtTai_Khoan.Text;
                string mk = txt_Mat_khau.Text;
                string sql = "SELECT * FROM NGUOI_DUNG WHERE TAI_KHOAN = '" + tk + "' AND MAT_KHAU = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (String.IsNullOrEmpty(txtTai_Khoan.Text.Trim()))
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTai_Khoan.Focus();
                    return;
                }

                if (String.IsNullOrEmpty(txt_Mat_khau.Text.Trim()))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Mat_khau.Focus();
                    return;
                }
                if (dr.Read() == true)
                {
                    Save_Variable.tk = txtTai_Khoan.Text;
                    Save_Variable.mk = txt_Mat_khau.Text;
                    MessageBox.Show("Chào mừng bạn đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    i.Hide();
                    o.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Mat_khau.Text = "";
                    txtTai_Khoan.Text = "";
                    txtTai_Khoan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
