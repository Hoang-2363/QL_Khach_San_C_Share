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
    class Connect_Su_Dung_DV
    {
        public static void Load_DV_SD(DataGridView a)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT DAT_DICH_VU.MA_DV, DICH_VU.TEN_DV, SO_LUONG, DICH_VU.DON_VI, DICH_VU.GIA_DV, DICH_VU.GIA_DV*SO_LUONG AS THANH_TIEN FROM DAT_DICH_VU INNER JOIN DICH_VU ON DAT_DICH_VU.MA_DV = DICH_VU.MA_DV WHERE DAT_DICH_VU.MA_HD_DV IS NULL;";
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

        public static void Load_Ten_Phong_Da_Th(ComboBox txt_Seach)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            connection = new SqlConnection(str);
            connection.Open();
            string sqlQuery = "select PHONG.TEN_PHONG from THUE_PHONG inner join PHONG on THUE_PHONG.MA_PHONG = PHONG.MA_PHONG where TRANG_THAI = N'Đang thuê phòng';";
            command = new SqlCommand(sqlQuery, connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            txt_Seach.Items.Clear();
            txt_Seach.Text = "";

            foreach (DataRow row in table.Rows)
            {
                string maDV = row["TEN_PHONG"].ToString();
                txt_Seach.Items.Add(maDV);
            }
            connection.Close();
        }
        public static void Tim_Kiem_TT_KH(ComboBox a, ComboBox b, ComboBox c, ComboBox d)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "select PHONG.MA_PHONG, KHACH_HANG.MA_KH, KHACH_HANG.TEN_KH from THUE_PHONG inner join PHONG on THUE_PHONG.MA_PHONG = PHONG.MA_PHONG inner join KHACH_HANG on THUE_PHONG.MA_KH  = KHACH_HANG.MA_KH where PHONG.TEN_PHONG = @TEN_PHONG AND TRANG_THAI = N'Đang thuê phòng';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TEN_PHONG", a.SelectedItem.ToString());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                b.Text = reader["MA_PHONG"].ToString();
                                c.Text = reader["MA_KH"].ToString();
                                d.Text = reader["TEN_KH"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
