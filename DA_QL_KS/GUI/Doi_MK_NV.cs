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
    public partial class Doi_MK_NV : Form
    {
        public Doi_MK_NV()
        {
            InitializeComponent();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            Check_Doi_MK.Doi_MK(txtTen_TK, txtMK_Cu, txtMK_Moi, txtMK_Moi_NL);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void chk_Hien_MK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Hien_MK.Checked)
            {
                txtMK_Cu.PasswordChar = (char)0;
                txtMK_Moi.PasswordChar = (char)0;
                txtMK_Moi_NL.PasswordChar = (char)0;
            }
            else
            {
                txtMK_Cu.PasswordChar = '*';
                txtMK_Moi.PasswordChar = '*';
                txtMK_Moi_NL.PasswordChar = '*';
            }
        }

        private void Doi_MK_NV_Load(object sender, EventArgs e)
        {
            string loggedInUser = Save_Variable.tk;
            txtTen_TK.Text = loggedInUser;
            string PassInUser = Save_Variable.mk;
        }
    }
}
