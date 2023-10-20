using DA_QL_KS.BLL;
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
    public partial class CN_Thue_P : Form
    {
        public CN_Thue_P()
        {
            InitializeComponent();
        }

        private void CN_Thue_P_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            dgvThue_Phong.Font = new Font("Arial", 10);
            Font boldFont1 = new Font(dgvThue_Phong.Font, FontStyle.Bold);
            dgvThue_Phong.Font = boldFont1;

            Connect_CN_Thue_P.Load_KH(dgvNhanVien);
            Connect_CN_Thue_P.Load_TP(dgvThue_Phong);
            Connect_CN_Thue_P.LoadMaNV(txtMa_NV);
            Connect_CN_Thue_P.Load_Ten_KH(txt_Ten_KH);
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txt_Ma_P.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txt_Ten_P.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
        }

        private void dgvThue_Phong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvThue_Phong.CurrentRow.Index;
            txtMa_TP.Text = dgvThue_Phong.Rows[i].Cells[0].Value.ToString();
            txtNgay_Den.Text = dgvThue_Phong.Rows[i].Cells[1].Value.ToString();
            txt_Ma_KH.Text = dgvThue_Phong.Rows[i].Cells[2].Value.ToString();
            txt_Ma_P.Text = dgvThue_Phong.Rows[i].Cells[4].Value.ToString();
            txt_Trang_Thai.Text = dgvThue_Phong.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Check_CN_Thue_P.thue_Phong(txtMa_TP, txtNgay_Den, txt_Ma_KH, txtMa_NV, txt_Ma_P);
            Connect_CN_Thue_P.Load_KH(dgvNhanVien);
            Connect_CN_Thue_P.Load_TP(dgvThue_Phong);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void txt_Ten_KH_TextChanged(object sender, EventArgs e)
        {
            Connect_CN_Thue_P.TimTenKH(txt_Ten_KH, txt_Ma_KH);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string formattedDate = selectedDate.ToString("dd/MM/yyyy");
            txtNgay_Den.Text = formattedDate;
        }
    }
}
