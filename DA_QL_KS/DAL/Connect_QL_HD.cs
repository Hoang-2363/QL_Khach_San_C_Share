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
    class Connect_QL_HD
    {
        public static void Load_DV(DataGridView a)
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
                command.CommandText = "SELECT DICH_VU.TEN_DV, SO_LUONG, DICH_VU.DON_VI, DICH_VU.GIA_DV, DICH_VU.GIA_DV*SO_LUONG AS THANH_TIEN FROM DAT_DICH_VU INNER JOIN DICH_VU ON DAT_DICH_VU.MA_DV = DICH_VU.MA_DV INNER JOIN HD_DICH_VU ON DAT_DICH_VU.MA_HD_DV = HD_DICH_VU.MA_HD_DV INNER JOIN KHACH_HANG ON HD_DICH_VU.MA_KH = KHACH_HANG.MA_KH " +
                    "WHERE DAT_DICH_VU.MA_HD_DV = '" + Save_Variable.ma_hd_dv_1 + "';";
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

        public static void Load_P(DataGridView a, String b, String c)
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
                command.CommandText = "SELECT HD_THANH_TOAN.MA_HD_TP, KHACH_HANG.TEN_KH, PHONG.TEN_PHONG, FORMAT(THUE_PHONG.NGAY_DEN, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DEN, FORMAT(TRA_PHONG.NGAY_DI, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DI, DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) AS SO_NGAY_O, PHONG.GIA_PHONG, DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG AS THANH_TIEN FROM TRA_PHONG INNER JOIN THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN " +
                    " KHACH_HANG ON KHACH_HANG.MA_KH = THUE_PHONG.MA_KH INNER JOIN PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG INNER JOIN HD_THANH_TOAN ON TRA_PHONG.MA_TRA_P = HD_THANH_TOAN.MA_TRA_P " +
                    " WHERE HD_THANH_TOAN.MA_HD_TP = '" + b + "' AND TRA_PHONG.MA_TRA_P = '" + c + "';";
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

        public static void Load_Ten_KH(TextBox a, TextBox b, String c)
        {
            string connectionString = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT KHACH_HANG.TEN_KH, NHAN_VIEN.HO_TEN_NV FROM DAT_DICH_VU INNER JOIN DICH_VU ON DAT_DICH_VU.MA_DV = DICH_VU.MA_DV INNER JOIN " +
                        "HD_DICH_VU ON DAT_DICH_VU.MA_HD_DV = HD_DICH_VU.MA_HD_DV INNER JOIN KHACH_HANG ON HD_DICH_VU.MA_KH = KHACH_HANG.MA_KH INNER JOIN " +
                        "NHAN_VIEN ON HD_DICH_VU.MA_NV = NHAN_VIEN.MA_NV WHERE DAT_DICH_VU.MA_HD_DV = '" + c + "' ;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                a.Text = reader["TEN_KH"].ToString();
                                b.Text = reader["HO_TEN_NV"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tên khách hàng và tên nhân viên.");
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
