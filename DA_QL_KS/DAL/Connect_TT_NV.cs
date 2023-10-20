using System;
using System.Collections.Generic;
using System.Linq;
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
    class Connect_TT_NV
    {
        public static void Load_KH(DataGridView a)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            string tk = Save_Variable.tk;
            string mk = Save_Variable.mk;
            string sql = "SELECT NHAN_VIEN.* FROM NHAN_VIEN INNER JOIN NGUOI_DUNG ON NHAN_VIEN.MA_NV = NGUOI_DUNG. MA_NV WHERE TAI_KHOAN = '" + tk + "' AND MAT_KHAU = '" + mk + "';";

            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = sql;
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                a.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
