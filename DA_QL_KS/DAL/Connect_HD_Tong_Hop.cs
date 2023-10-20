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
    class Connect_HD_Tong_Hop
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
                command.CommandText = "SELECT DICH_VU.TEN_DV, SO_LUONG, DICH_VU.DON_VI, DICH_VU.GIA_DV, DICH_VU.GIA_DV*SO_LUONG AS THANH_TIEN FROM DAT_DICH_VU INNER JOIN DICH_VU ON DAT_DICH_VU.MA_DV = DICH_VU.MA_DV WHERE DAT_DICH_VU.MA_HD_DV = '" + Save_Variable.ma_hd_dv + "';";
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
                command.CommandText = "SELECT PHONG.TEN_PHONG, FORMAT(THUE_PHONG.NGAY_DEN, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DEN, FORMAT(TRA_PHONG.NGAY_DI, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DI, " +
                    "DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) AS SO_NGAY_O, PHONG.GIA_PHONG, DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG AS THANH_TIEN " +
                    "FROM TRA_PHONG INNER JOIN THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN KHACH_HANG ON KHACH_HANG.MA_KH = THUE_PHONG.MA_KH INNER JOIN PHONG ON " +
                    "THUE_PHONG.MA_PHONG = PHONG.MA_PHONG WHERE KHACH_HANG.TEN_KH = N'" + b + "' AND TRA_PHONG.MA_TRA_P = '" + c + "';";
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

        public static void Load_Ma_HD_TT(TextBox txt_Seach, String ma_Tr_p)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            connection = new SqlConnection(str);
            connection.Open();
            string sqlQuery = "SELECT MA_HD_TP FROM HD_THANH_TOAN where MA_TRA_P = '" + ma_Tr_p + "'; ";
            command = new SqlCommand(sqlQuery, connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            txt_Seach.Text = "";

            foreach (DataRow row in table.Rows)
            {
                string maDV = row["MA_HD_TP"].ToString();
                txt_Seach.Text = maDV;
            }
            connection.Close();
        }

        public static void Tong_Tien_DV(DataGridView dgvTien_Dich_Vu, TextBox txtTT_DV)
        {
            int sc = dgvTien_Dich_Vu.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvTien_Dich_Vu.Rows[i].Cells["THANH_TIEN"].Value.ToString());

            txtTT_DV.Text = thanhtien.ToString();
        }

        public static void Tong_Tien_P(DataGridView dgvTien_Dich_Vu, TextBox txtTT_DV)
        {
            int i;
            i = dgvTien_Dich_Vu.CurrentRow.Index;
            txtTT_DV.Text = dgvTien_Dich_Vu.Rows[i].Cells[5].Value.ToString();
        }
    }
}
