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
    class Check_HD_Tong_Hop
    {
        public static void Tra_P(ComboBox txt_Hinh_Thuc_TT, String a, String b)
        {
            SqlConnection connection;
            SqlCommand command;
            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True");
            con.Open();
            if (string.IsNullOrEmpty(txt_Hinh_Thuc_TT.Text) || string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Đã thanh toán thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "UPDATE HD_THANH_TOAN SET MA_HD_DV = '" + a + "', HINH_THUC = N'" + txt_Hinh_Thuc_TT.Text + "' WHERE MA_TRA_P = '" + b + "';";
                command.ExecuteNonQuery();
                txt_Hinh_Thuc_TT.Text = "";
                
            }
        }
    }
}
