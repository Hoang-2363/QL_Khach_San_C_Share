using DA_QL_KS.BLL;
using DA_QL_KS.DAL;
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
    public partial class CN_Su_Dung_DV : Form
    {
        public CN_Su_Dung_DV()
        {
            InitializeComponent();
        }

        private void CN_Su_Dung_DV_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            dgvThue_Phong.Font = new Font("Arial", 10);
            Font boldFont1 = new Font(dgvThue_Phong.Font, FontStyle.Bold);
            dgvThue_Phong.Font = boldFont1;

            Connect_QL_DV.Load_KH(dgvNhanVien);
            Connect_CN_Thue_P.LoadMaNV(txtMa_NV);
            Connect_Su_Dung_DV.Load_DV_SD(dgvThue_Phong);
            Connect_Su_Dung_DV.Load_Ten_Phong_Da_Th(txt_Ten_P);
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txt_Ma_DV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTen_DV.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txt_Ten_P.Text = "";
        }

        private void dgvThue_Phong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvThue_Phong.CurrentRow.Index;
            txt_Ma_DV.Text = dgvThue_Phong.Rows[i].Cells[0].Value.ToString();
            txtTen_DV.Text = dgvThue_Phong.Rows[i].Cells[1].Value.ToString();
            txt_So_Luong.Text = dgvThue_Phong.Rows[i].Cells[2].Value.ToString();
            txt_Ten_P.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (Check_Su_Dung_DV.KT_Thoat())
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
        }

        private void txt_Ten_P_TextChanged(object sender, EventArgs e)
        {
            Connect_Su_Dung_DV.Tim_Kiem_TT_KH(txt_Ten_P, txt_Ma_P, txt_Ma_KH, txt_Ten_KH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Check_Su_Dung_DV.Them_DV(txt_So_Luong, txt_Ma_DV);
            Connect_Su_Dung_DV.Load_DV_SD(dgvThue_Phong);
            txtTen_DV.Text = txt_Ma_DV.Text = txt_So_Luong.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_Su_Dung_DV.Sua_DV(txt_So_Luong, txt_Ma_DV);
            Connect_Su_Dung_DV.Load_DV_SD(dgvThue_Phong);
            txtTen_DV.Text = txt_Ma_DV.Text = txt_So_Luong.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check_Su_Dung_DV.Xoa_DV(txt_So_Luong, txt_Ma_DV);
            Connect_Su_Dung_DV.Load_DV_SD(dgvThue_Phong);
            txtTen_DV.Text = txt_Ma_DV.Text = txt_So_Luong.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check_Su_Dung_DV.Them_HD_DV(txt_Ma_KH, txt_Ma_P, txtMa_NV, txtNgay_Lap);
            Connect_Su_Dung_DV.Load_DV_SD(dgvThue_Phong);
            txt_Ten_P.SelectedItem = txt_Ma_KH.Text = txt_Ma_P.Text = txtNgay_Lap.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string formattedDate = selectedDate.ToString("dd/MM/yyyy");
            txtNgay_Lap.Text = formattedDate;
        }
    }
}
