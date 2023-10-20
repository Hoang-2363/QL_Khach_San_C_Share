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
    class Check_Doi_MK
    {
        public static void Doi_MK(TextBox txtTen_TK, TextBox txtMK_Cu, TextBox txtMK_Moi, TextBox txtMK_Moi_NL)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
                con.Open();
                string loggedInUser = Save_Variable.tk;
                txtTen_TK.Text = loggedInUser;
                string username = txtTen_TK.Text;
                string mk = txtMK_Cu.Text;
                string newPassword = txtMK_Moi.Text;
                string sql = "SELECT * FROM NGUOI_DUNG WHERE TAI_KHOAN = '" + txtTen_TK.Text + "' AND MAT_KHAU = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    if (String.IsNullOrEmpty(txtMK_Moi.Text.Trim()))
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMK_Moi.Focus();
                        return;
                    }
                    if (String.IsNullOrEmpty(txtMK_Moi_NL.Text.Trim()))
                    {
                        MessageBox.Show("Bạn chưa nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMK_Moi_NL.Focus();
                        return;
                    }
                    if (txtMK_Cu.Text == txtMK_Moi.Text)
                    {
                        MessageBox.Show("Mật khẩu mới giống mật khẩu cũ. Vui lòng nhập lại mật khẩu khác mật khẩu cũ !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMK_Moi.Focus();
                        return;
                    }
                    if (txtMK_Moi.Text == txtMK_Moi_NL.Text)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string checkUserQuery = "SELECT COUNT(*) FROM NGUOI_DUNG WHERE TAI_KHOAN = @Username";
                            SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, connection);
                            checkUserCmd.Parameters.AddWithValue("@Username", username);

                            int userCount = (int)checkUserCmd.ExecuteScalar();

                            if (userCount > 0)
                            {
                                string updatePasswordQuery = "UPDATE NGUOI_DUNG SET MAT_KHAU = @Password WHERE TAI_KHOAN = @Username";
                                SqlCommand updatePasswordCmd = new SqlCommand(updatePasswordQuery, connection);
                                updatePasswordCmd.Parameters.AddWithValue("@Password", newPassword);
                                updatePasswordCmd.Parameters.AddWithValue("@Username", username);

                                int rowsAffected = updatePasswordCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Bạn đã đổi thành công mật khẩu !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtMK_Cu.Text = "";
                                    txtMK_Moi.Text = "";
                                    txtMK_Moi_NL.Text = "";

                                }
                                else
                                {
                                    MessageBox.Show("Không thể cập nhật mật khẩu.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không tồn tại.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp nhập lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMK_Moi_NL.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMK_Cu.Text = "";
                    txtMK_Moi.Text = "";
                    txtMK_Moi_NL.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
