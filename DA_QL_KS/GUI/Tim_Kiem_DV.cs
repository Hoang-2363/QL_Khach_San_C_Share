using DA_QL_KS.BLL;
using DA_QL_KS.DAL.DA_QL_KS.DAL;
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
    public partial class Tim_Kiem_DV : Form
    {
        public Tim_Kiem_DV()
        {
            InitializeComponent();
        }

        private void btn_Seach_Click(object sender, EventArgs e)
        {
            Check_TK_DV.Tim_Kiem(txtTK_TH, txt_Seach, dgvNhanVien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QL_DV sua_dv = new QL_DV();
            this.Hide();
            sua_dv.Show();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void Tim_Kiem_DV_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            Connect_QL_DV.Load_KH(dgvNhanVien);
        }

        private void txtTK_TH_TextChanged(object sender, EventArgs e)
        {
            Check_TK_DV.ClickCbo(txtTK_TH, txt_Seach);
            Connect_QL_DV.Load_KH(dgvNhanVien);
        }

        private void txtTK_TH_MouseClick(object sender, MouseEventArgs e)
        {
            Connect_QL_DV.Load_KH(dgvNhanVien);
        }

        private void txt_Seach_MouseClick(object sender, MouseEventArgs e)
        {
            Connect_QL_DV.Load_KH(dgvNhanVien);
        }
    }
}
