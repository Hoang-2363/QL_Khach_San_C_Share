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
    public partial class Dang_Nhap : Form
    {
        public Dang_Nhap()
        {
            InitializeComponent();
        }

        private void btn_Dang_Nhap_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Connect_Dang_Nhap.Dang_Nhap(this, menu, txtTai_Khoan, txt_Mat_khau);
        }

        private void chk_Hien_MK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Hien_MK.Checked)
            {
                txt_Mat_khau.PasswordChar = (char)0;
            }
            else
            {
                txt_Mat_khau.PasswordChar = '*';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Dang_Nhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Dang_Nhap_Click(sender, e);
            }
        }

        private void Dang_Nhap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
