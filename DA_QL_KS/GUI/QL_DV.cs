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
    public partial class QL_DV : Form
    {
        public QL_DV()
        {
            InitializeComponent();
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txt_Ma_DV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txt_Ten_DV.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txt_Loai_DV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txt_Gia_DV.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txt_DV.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Check_QL_DV.Them_KH(txt_Ma_DV, txt_Ten_DV, txt_Loai_DV, txt_Gia_DV, txt_DV);
            Connect_QL_DV.Load_KH(dgvNhanVien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Check_QL_DV.Xoa_KH(txt_Ma_DV, txt_Ten_DV, txt_Loai_DV, txt_Gia_DV, txt_DV);
            Connect_QL_DV.Load_KH(dgvNhanVien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Check_QL_DV.Sua_KH(txt_Ma_DV, txt_Ten_DV, txt_Loai_DV, txt_Gia_DV, txt_DV);
            Connect_QL_DV.Load_KH(dgvNhanVien);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void QL_DV_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            Connect_QL_DV.Load_KH(dgvNhanVien);
        }
    }
}
