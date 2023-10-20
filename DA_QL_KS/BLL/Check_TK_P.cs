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
    class Check_TK_P
    {
        public static void ClickCbo(ComboBox txtTK_TH, ComboBox txt_Seach)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            connection = new SqlConnection(str);
            connection.Open();

            if (txtTK_TH.Text == "Tên phòng")
            {
                string sqlQuery = "SELECT TEN_PHONG FROM PHONG";
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
            }
            else if (txtTK_TH.Text == "Loại phòng")
            {
                string sqlQuery = "SELECT LOAI_PHONG FROM PHONG GROUP BY LOAI_PHONG";
                command = new SqlCommand(sqlQuery, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                txt_Seach.Items.Clear();
                txt_Seach.Text = "";

                foreach (DataRow row in table.Rows)
                {
                    string tenDV = row["LOAI_PHONG"].ToString();
                    txt_Seach.Items.Add(tenDV);
                }
            }
            else if (txtTK_TH.Text == "Kiểu phòng")
            {
                string sqlQuery = "SELECT KIEU_PHONG FROM PHONG GROUP BY KIEU_PHONG";
                command = new SqlCommand(sqlQuery, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                txt_Seach.Items.Clear();
                txt_Seach.Text = "";

                foreach (DataRow row in table.Rows)
                {
                    string tenDV = row["KIEU_PHONG"].ToString();
                    txt_Seach.Items.Add(tenDV);
                }
            }
            else if (txtTK_TH.Text == "Tình trạng")
            {
                string sqlQuery = "SELECT TINH_TRANG FROM PHONG GROUP BY TINH_TRANG";
                command = new SqlCommand(sqlQuery, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                txt_Seach.Items.Clear();
                txt_Seach.Text = "";

                foreach (DataRow row in table.Rows)
                {
                    string tenDV = row["TINH_TRANG"].ToString();
                    txt_Seach.Items.Add(tenDV);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn phương thức tìm kiếm theo loại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txt_Seach.Items.Clear();
            }

            connection.Close();
        }


        public static void Tim_Kiem(ComboBox txtTK_TH, ComboBox txt_Seach, DataGridView dgvNhanVien)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            connection = new SqlConnection(str);
            connection.Open();
            if (txtTK_TH.Text == "Tên phòng")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM PHONG WHERE TEN_PHONG=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "Loại phòng")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM PHONG WHERE LOAI_PHONG=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "Kiểu phòng")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM PHONG WHERE KIEU_PHONG=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "Tình trạng")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM PHONG WHERE TINH_TRANG=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
        }
    }
}
