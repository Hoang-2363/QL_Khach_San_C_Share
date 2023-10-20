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
    public partial class QL_KH : Form
    {
        public QL_KH()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Check_QL_KH.Them_KH(txtSDT, txtCMND, txtMa_Khach, txtTen_Khach, txtGioi_Tinh, txtDia_Chi);
            Connect_QL_KH.Load_KH(dgvNhanVien);
        }

        private void QL_KH_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            Connect_QL_KH.Load_KH(dgvNhanVien);
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtMa_Khach.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTen_Khach.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtGioi_Tinh.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtDia_Chi.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Check_QL_KH.Xoa_KH(txtSDT, txtCMND, txtMa_Khach, txtTen_Khach, txtGioi_Tinh, txtDia_Chi);
            Connect_QL_KH.Load_KH(dgvNhanVien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Check_QL_KH.Sua_KH(txtSDT, txtCMND, txtMa_Khach, txtTen_Khach, txtGioi_Tinh, txtDia_Chi);
            Connect_QL_KH.Load_KH(dgvNhanVien);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
