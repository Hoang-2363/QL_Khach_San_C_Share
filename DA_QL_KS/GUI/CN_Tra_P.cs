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
    public partial class CN_Tra_P : Form
    {
        public CN_Tra_P()
        {
            InitializeComponent();
        }

        private void CN_Tra_P_Load(object sender, EventArgs e)
        {
            dgvTra_phong.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvTra_phong.Font, FontStyle.Bold);
            dgvTra_phong.Font = boldFont;

            Connect_CN_Tra_P.Load_TP(dgvTra_phong);
            Connect_CN_Tra_P.Load_Ten_Phong(txt_Ten_P);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void dgvTra_phong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvTra_phong.CurrentRow.Index;
            txt_Ma_TRP.Text = dgvTra_phong.Rows[i].Cells[0].Value.ToString();
            txtNgay_Di.Text = dgvTra_phong.Rows[i].Cells[1].Value.ToString();
            txt_Ma_TH_P.Text = dgvTra_phong.Rows[i].Cells[2].Value.ToString();
            txt_Trang_Thai.Text = dgvTra_phong.Rows[i].Cells[3].Value.ToString();
            txt_Ten_P.Text = "";
        }

        private void txt_Ten_P_TextChanged(object sender, EventArgs e)
        {
            Connect_CN_Tra_P.TimTenKH(txt_Ten_P, txt_Ma_TH_P);
        }

        private void btnTra_P_Click(object sender, EventArgs e)
        {
            Check_CN_Tra_P.Tra_P(txt_Ma_TRP, txtNgay_Di, txt_Ma_TH_P);
            Connect_CN_Tra_P.Load_TP(dgvTra_phong);
            Connect_CN_Tra_P.Load_Ten_Phong(txt_Ten_P);
        }

        private void btn_HD_Thanh_Toan_Click(object sender, EventArgs e)
        {
            Check_CN_Tra_P.Tao_HD_Tong_Hop(txt_Ma_TRP, txt_Ma_TH_P);
            Connect_CN_Tra_P.luu_ten_KH(txt_Ma_TH_P);
            Connect_CN_Tra_P.luu_ma_hd_dv(txt_Ma_TH_P);
            Connect_CN_Tra_P.luu_ma_tr_p(txt_Ma_TRP);
            HD_TT_Tong_Hop h = new HD_TT_Tong_Hop();
            this.Hide();
            h.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string formattedDate = selectedDate.ToString("dd/MM/yyyy");
            txtNgay_Di.Text = formattedDate;
        }
    }
}
