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
    public partial class HD_TT_Tong_Hop : Form
    {
        public HD_TT_Tong_Hop()
        {
            InitializeComponent();
        }

        private void HD_TT_Tong_Hop_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            dgvThue_Phong.Font = new Font("Arial", 10);
            Font boldFont1 = new Font(dgvThue_Phong.Font, FontStyle.Bold);
            dgvThue_Phong.Font = boldFont1;

            String b = Save_Variable.ten_KH;
            String c = Save_Variable.ma_tra_p;
            txt_Ten_KH.Text = Save_Variable.ten_KH;

            Connect_HD_Tong_Hop.Load_Ma_HD_TT(txt_Ma_HD_TT, c);
            Connect_HD_Tong_Hop.Load_DV(dgvThue_Phong);
            Connect_HD_Tong_Hop.Load_P(dgvNhanVien, b, c);
            Connect_HD_Tong_Hop.Tong_Tien_DV(dgvThue_Phong, txt_Tong_Tien_DV);
            Connect_HD_Tong_Hop.Tong_Tien_P(dgvNhanVien, txt_Tong_Tien_P);
            int tongTienDV, tongTienP;
            if (int.TryParse(txt_Tong_Tien_DV.Text, out tongTienDV) && int.TryParse(txt_Tong_Tien_P.Text, out tongTienP))
            {
                int tongTien = tongTienDV + tongTienP;
                txt_Tong_Tien.Text = tongTien.ToString();
            }

            Save_Variable.ma_hd_dv_in_hd_xem = Save_Variable.ma_hd_dv;
            Save_Variable.ma_hd_tong_in_hd_xem = txt_Ma_HD_TT.Text;
            Save_Variable.ma_tr_p_in_hd_xem = Save_Variable.ma_tra_p;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_Dang_Nhap_Click(object sender, EventArgs e)
        {
            String b = Save_Variable.ma_tra_p;
            String a = Save_Variable.ma_hd_dv;
            Check_HD_Tong_Hop.Tra_P(txt_Hinh_Thuc_TT, a, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String b = Save_Variable.ma_tra_p;
            String a = Save_Variable.ma_hd_dv;
            Check_HD_Tong_Hop.Tra_P(txt_Hinh_Thuc_TT, a, b);
            Form1 bc = new Form1();
            bc.Show();
        }
    }
}
