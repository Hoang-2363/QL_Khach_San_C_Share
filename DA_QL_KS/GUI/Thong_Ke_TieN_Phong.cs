using DA_QL_KS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QL_KS.GUI
{
    public partial class Thong_Ke_TieN_Phong : Form
    {
        public Thong_Ke_TieN_Phong()
        {
            InitializeComponent();
        }

        private void Thong_Ke_TieN_Phong_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;
            Connect_Thong_Ke_DT.Load_P(dgvNhanVien);

            int tong = 0;
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (!row.IsNewRow && row.Cells["THANH_TIEN"].Value != null)
                {
                    int giaTriCot = Convert.ToInt32(row.Cells["THANH_TIEN"].Value);
                    tong += giaTriCot;
                }
            }
            txt_Tong_DT.Text = tong.ToString();
        }

        private void btn_Tim_Kiem_Click(object sender, EventArgs e)
        {
            Connect_Thong_Ke_DT.Load_Tim_Kiem_P(dgvNhanVien, txt_Tu_Ngay, txt_Den_Ngay);
            int tong = 0;
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (!row.IsNewRow && row.Cells["THANH_TIEN"].Value != null)
                {
                    int giaTriCot = Convert.ToInt32(row.Cells["THANH_TIEN"].Value);
                    tong += giaTriCot;
                }
            }
            txt_Tong_DT.Text = tong.ToString();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string formattedDate = selectedDate.ToString("dd/MM/yyyy");
            txt_Tu_Ngay.Text = formattedDate;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker2.Value;
            string formattedDate = selectedDate.ToString("dd/MM/yyyy");
            txt_Den_Ngay.Text = formattedDate;
        }
    }
}
