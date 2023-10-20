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
    class Connect_CN_Thue_P
    {
        public static void Load_KH(DataGridView a)
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
                command.CommandText = "SELECT * FROM PHONG WHERE TINH_TRANG = N'Trống'";
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
                command.CommandText = "SELECT MA_THUE_P, FORMAT(NGAY_DEN, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DEN, MA_KH, MA_NV, MA_PHONG, TRANG_THAI FROM THUE_PHONG WHERE TRANG_THAI = N'Đang thuê phòng';";
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

        public static void LoadMaNV(TextBox a)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT MA_NV FROM NGUOI_DUNG WHERE TAI_KHOAN = @TaiKhoan AND MAT_KHAU = @MatKhau;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaiKhoan", Save_Variable.tk);
                        command.Parameters.AddWithValue("@MatKhau", Save_Variable.mk);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            a.Text = result.ToString(); 
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã nhân viên.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public static void Load_Ten_KH(ComboBox txt_Seach)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            connection = new SqlConnection(str);
            connection.Open();
            string sqlQuery = "SELECT TEN_KH FROM KHACH_HANG";
            command = new SqlCommand(sqlQuery, connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            txt_Seach.Items.Clear();
            txt_Seach.Text = "";

            foreach (DataRow row in table.Rows)
            {
                string maDV = row["TEN_KH"].ToString();
                txt_Seach.Items.Add(maDV);
            }
            connection.Close();
        }
        public static void TimTenKH(ComboBox a, ComboBox b)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT MA_KH FROM KHACH_HANG WHERE TEN_KH = @TenKH";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenKH", a.SelectedItem.ToString());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                b.Text = reader["MA_KH"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tên khách hàng.");
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
