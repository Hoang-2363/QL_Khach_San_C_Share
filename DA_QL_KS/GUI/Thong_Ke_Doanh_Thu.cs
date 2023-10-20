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
    public partial class Thong_Ke_Doanh_Thu : Form
    {
        public Thong_Ke_Doanh_Thu()
        {
            InitializeComponent();
        }

        private void Thong_Ke_Doanh_Thu_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            Connect_Thong_Ke_DT.Load_KH(dgvNhanVien);

            int tong = 0;
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (!row.IsNewRow && row.Cells["TT_HD"].Value != null)
                {
                    int giaTriCot = Convert.ToInt32(row.Cells["TT_HD"].Value);
                    tong += giaTriCot;
                }
            }
            txt_Tong_DT.Text = tong.ToString();
        }

        private void btn_Tim_Kiem_Click(object sender, EventArgs e)
        {
            Connect_Thong_Ke_DT.Load_Tim_Kiem(dgvNhanVien, txt_Tu_Ngay, txt_Den_Ngay);
            int tong = 0;
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (!row.IsNewRow && row.Cells["TT_HD"].Value != null)
                {
                    int giaTriCot = Convert.ToInt32(row.Cells["TT_HD"].Value);
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

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txt_Ma_HD_Tong.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txt_Ma_HD_DV.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txt_Ma_Tr_P.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
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
