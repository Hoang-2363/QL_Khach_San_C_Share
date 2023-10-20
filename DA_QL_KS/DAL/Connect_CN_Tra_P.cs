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
    class Connect_CN_Tra_P
    {
        public static void Load_TP(DataGridView a)
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
                command.CommandText = "SELECT MA_TRA_P, FORMAT(NGAY_DI, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DI, MA_THUE_P, TRANG_THAI FROM TRA_PHONG WHERE TRANG_THAI = N'Chưa thanh toán';";
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
        public static void Load_Ten_Phong(ComboBox txt_Seach)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            connection = new SqlConnection(str);
            connection.Open();
            string sqlQuery = "SELECT TEN_PHONG FROM PHONG WHERE TINH_TRANG = N'Đã thuê'";
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
        public static void TimTenKH(ComboBox a, TextBox b)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (a.SelectedItem != null)
                    {
                        string query = "SELECT THUE_PHONG.MA_THUE_P FROM THUE_PHONG INNER JOIN PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG WHERE TEN_PHONG = @TEN_PHONG;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TEN_PHONG", a.SelectedItem.ToString());

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    b.Text = reader["MA_THUE_P"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy tên khách hàng.");
                                }
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

        public static void luu_ten_KH(TextBox a)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "select KHACH_HANG.TEN_KH from THUE_PHONG inner join KHACH_HANG on THUE_PHONG.MA_KH  = KHACH_HANG.MA_KH where MA_THUE_P = '" + a.Text + "' and TRANG_THAI = N'Đã trả phòng';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            Save_Variable.ten_KH = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tên khách hàng.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }
        public static void luu_ma_tr_p(TextBox a)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT MA_TRA_P FROM TRA_PHONG WHERE MA_TRA_P = '" + a.Text + "'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            Save_Variable.ma_tra_p = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã hóa đơn dịch vụ.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public static void luu_ma_hd_dv(TextBox a)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT HD_DICH_VU.MA_HD_DV FROM HD_DICH_VU INNER JOIN PHONG ON HD_DICH_VU.MA_PHONG = PHONG.MA_PHONG INNER JOIN THUE_PHONG ON PHONG.MA_PHONG = THUE_PHONG.MA_PHONG WHERE HD_DICH_VU.MA_PHONG = (SELECT MA_PHONG FROM THUE_PHONG WHERE MA_THUE_P = '" + a.Text + "' and TRANG_THAI = N'Đã trả phòng') AND HD_DICH_VU.TRANG_THAI = N'Đã thanh toán';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            Save_Variable.ma_hd_dv = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã hóa đơn dịch vụ.");
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
