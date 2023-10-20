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
    public partial class QL_P : Form
    {
        public QL_P()
        {
            InitializeComponent();
        }

        private void QL_P_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;
            Connect_QL_P.Load_KH(dgvNhanVien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Check_QL_P.Them_KH(txt_Ma_phong, txt_Ten_P, txt_Loai_phong, txt_Kieu_phong, txt_Tinh_trang, txt_Gia_phong, txt_Don_VT);
            Connect_QL_P.Load_KH(dgvNhanVien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Check_QL_P.Xoa_KH(txt_Ma_phong, txt_Ten_P, txt_Loai_phong, txt_Kieu_phong, txt_Tinh_trang, txt_Gia_phong, txt_Don_VT);
            Connect_QL_P.Load_KH(dgvNhanVien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Check_QL_P.Sua_KH(txt_Ma_phong, txt_Ten_P, txt_Loai_phong, txt_Kieu_phong, txt_Tinh_trang, txt_Gia_phong, txt_Don_VT);
            Connect_QL_P.Load_KH(dgvNhanVien);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txt_Ma_phong.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txt_Ten_P.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txt_Loai_phong.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txt_Kieu_phong.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txt_Tinh_trang.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txt_Gia_phong.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txt_Don_VT.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
        }
    }
}
