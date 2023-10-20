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
    class Check_TK_DV
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

            if (txtTK_TH.Text == "Mã dịch vụ")
            {
                string sqlQuery = "SELECT MA_DV FROM DICH_VU";
                command = new SqlCommand(sqlQuery, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                txt_Seach.Items.Clear();
                txt_Seach.Text = "";

                foreach (DataRow row in table.Rows)
                {
                    string maDV = row["MA_DV"].ToString();
                    txt_Seach.Items.Add(maDV);
                }
            }
            else if (txtTK_TH.Text == "Tên dịch vụ")
            {
                string sqlQuery = "SELECT TEN_DV FROM DICH_VU";
                command = new SqlCommand(sqlQuery, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                txt_Seach.Items.Clear();
                txt_Seach.Text = "";

                foreach (DataRow row in table.Rows)
                {
                    string tenDV = row["TEN_DV"].ToString();
                    txt_Seach.Items.Add(tenDV);
                }
            }
            else if (txtTK_TH.Text == "Loại dịch vụ")
            {
                txt_Seach.Items.Clear();
                txt_Seach.Text = "";

                txt_Seach.Items.Add("Rượu");
                txt_Seach.Items.Add("Hoa quả");
                txt_Seach.Items.Add("Bia");
                txt_Seach.Items.Add("Nước giải khát");
                txt_Seach.Items.Add("Đồ ăn liền");
                txt_Seach.Items.Add("Sữa");
                txt_Seach.Items.Add("Đồ ăn vặt");
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
            if (txtTK_TH.Text == "Mã dịch vụ")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM DICH_VU WHERE MA_DV='" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "Tên dịch vụ")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM DICH_VU WHERE TEN_DV=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "Loại dịch vụ")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM DICH_VU WHERE LOAI_DV=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            if (txtTK_TH.Text == "Mã dịch vụ")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM DICH_VU WHERE MA_DV='" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "Tên dịch vụ")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM DICH_VU WHERE TEN_DV=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "Loại dịch vụ")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM DICH_VU WHERE LOAI_DV=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
        }
    }
}
