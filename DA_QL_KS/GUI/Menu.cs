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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                Dang_Nhap DN = new Dang_Nhap();
                this.Hide();
                DN.ShowDialog();
            }
        }

        private void mnu_QL_KH_Click(object sender, EventArgs e)
        {
            QL_KH QL_KH = new QL_KH();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_QL_P_Click(object sender, EventArgs e)
        {
            QL_P QL_KH = new QL_P();
            this.Hide();
            QL_KH.ShowDialog();

        }

        private void mnu_QL_DV_Click(object sender, EventArgs e)
        {
            QL_DV QL_KH = new QL_DV();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_TK_KH_Click(object sender, EventArgs e)
        {
            Tim_Kiem_KH QL_KH = new Tim_Kiem_KH();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_TK_P_Click(object sender, EventArgs e)
        {
            Tim_Kiem_P QL_KH = new Tim_Kiem_P();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_TK_DV_Click(object sender, EventArgs e)
        {
            Tim_Kiem_DV QL_KH = new Tim_Kiem_DV();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_TG_TT_NV_Click(object sender, EventArgs e)
        {
            Thong_Tin_NV QL_KH = new Thong_Tin_NV();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_TG_DMK_Click(object sender, EventArgs e)
        {
            Doi_MK_NV QL_KH = new Doi_MK_NV();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_CN_THP_Click(object sender, EventArgs e)
        {
            CN_Thue_P QL_KH = new CN_Thue_P();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_CN_TRP_Click(object sender, EventArgs e)
        {
            CN_Tra_P QL_KH = new CN_Tra_P();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void mnu_CN_SDDV_Click(object sender, EventArgs e)
        {
            CN_Su_Dung_DV QL_KH = new CN_Su_Dung_DV();
            this.Hide();
            QL_KH.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Hoa_Don m = new QL_Hoa_Don();
            this.Hide();
            m.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thong_Ke_Doanh_Thu m = new Thong_Ke_Doanh_Thu();
            this.Hide();
            m.ShowDialog();
        }

        private void doanhThuTiềnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thong_Ke_TieN_Phong m = new Thong_Ke_TieN_Phong();
            this.Hide();
            m.ShowDialog();
        }

        private void doanhThuTiềnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thong_Ke_Tien_DV m = new Thong_Ke_Tien_DV();
            this.Hide();
            m.ShowDialog();
        }

        private void doanhThuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thong_Ke_TieN_Phong m = new Thong_Ke_TieN_Phong();
            this.Hide();
            m.ShowDialog();
        }

        private void doanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thong_Ke_Tien_DV m = new Thong_Ke_Tien_DV();
            this.Hide();
            m.ShowDialog();
        }
    }
}
