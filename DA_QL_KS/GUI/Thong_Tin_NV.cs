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
    public partial class Thong_Tin_NV : Form
    {
        public Thong_Tin_NV()
        {
            InitializeComponent();
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtMa_NV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTen_NV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtDia_Chi.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtGmail.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            Check_TT_NV.Sua_KH(txtMa_NV, txtTen_NV, txtLuong, txtDia_Chi, txtSDT, txtGmail);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void Thong_Tin_NV_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            Connect_TT_NV.Load_KH(dgvNhanVien);
        }
    }
}
