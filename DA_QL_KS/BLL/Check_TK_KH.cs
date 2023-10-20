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
    class Check_TK_KH
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

            if (txtTK_TH.Text == "Tên khách hàng")
            {
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
            }
            else if (txtTK_TH.Text == "Số điện thoại")
            {
                string sqlQuery = "SELECT SDT FROM KHACH_HANG";
                command = new SqlCommand(sqlQuery, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                txt_Seach.Items.Clear();
                txt_Seach.Text = "";

                foreach (DataRow row in table.Rows)
                {
                    string tenDV = row["SDT"].ToString();
                    txt_Seach.Items.Add(tenDV);
                }
            }
            else if (txtTK_TH.Text == "CMND")
            {
                string sqlQuery = "SELECT CNMD FROM KHACH_HANG";
                command = new SqlCommand(sqlQuery, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                txt_Seach.Items.Clear();
                txt_Seach.Text = "";

                foreach (DataRow row in table.Rows)
                {
                    string tenDV = row["CNMD"].ToString();
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
            if (txtTK_TH.Text == "Tên khách hàng")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM KHACH_HANG WHERE TEN_KH=N'" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "Số điện thoại")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM KHACH_HANG WHERE SDT='" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
            else if (txtTK_TH.Text == "CMND")
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM KHACH_HANG WHERE CNMD='" + txt_Seach.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvNhanVien.DataSource = table;
            }
        }
    }
}
