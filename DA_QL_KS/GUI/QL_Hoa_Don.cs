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
    public partial class QL_Hoa_Don : Form
    {
        public QL_Hoa_Don()
        {
            InitializeComponent();
        }

        private void txtXem_CT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ma_HD_Tong.Text)
                || string.IsNullOrEmpty(txt_Ma_Tr_P.Text)
                || string.IsNullOrEmpty(txt_Ma_HD_DV.Text))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Save_Variable.ma_hd_tong = txt_Ma_HD_Tong.Text;
                Save_Variable.ma_tra_p_1 = txt_Ma_Tr_P.Text;
                Save_Variable.ma_hd_dv_1 = txt_Ma_HD_DV.Text;

                Save_Variable.ma_hd_tong_in_hd_xem = txt_Ma_HD_Tong.Text;
                Save_Variable.ma_tr_p_in_hd_xem = txt_Ma_Tr_P.Text;
                Save_Variable.ma_hd_dv_in_hd_xem = txt_Ma_HD_DV.Text;

                Chi_Tiet_HD_Tong m = new Chi_Tiet_HD_Tong();
                this.Hide();
                m.Show();
            }
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

        private void QL_Hoa_Don_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            Connect_Thong_Ke_DT.Load_KH(dgvNhanVien);
        }
    }
}
