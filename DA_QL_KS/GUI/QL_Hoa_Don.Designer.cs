
namespace DA_QL_KS.GUI
{
    partial class QL_Hoa_Don
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_Hoa_Don));
            this.Thoat = new System.Windows.Forms.Button();
            this.txtXem_CT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Ma_HD_Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Tr_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_HD_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Thanh_Toan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh_Thuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT_HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Ma_HD_DV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma_Tr_P = new System.Windows.Forms.TextBox();
            this.txt_Ma_HD_Tong = new System.Windows.Forms.TextBox();
            this.lbl_Mat_Khau = new System.Windows.Forms.Label();
            this.lblTen_Dang_Nhap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(642, 506);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(122, 35);
            this.Thoat.TabIndex = 185;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // txtXem_CT
            // 
            this.txtXem_CT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtXem_CT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXem_CT.Location = new System.Drawing.Point(308, 506);
            this.txtXem_CT.Name = "txtXem_CT";
            this.txtXem_CT.Size = new System.Drawing.Size(122, 35);
            this.txtXem_CT.TabIndex = 184;
            this.txtXem_CT.Text = "Xem chi tiết";
            this.txtXem_CT.UseVisualStyleBackColor = false;
            this.txtXem_CT.Click += new System.EventHandler(this.txtXem_CT_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Location = new System.Drawing.Point(7, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 342);
            this.panel1.TabIndex = 181;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HD_Tong,
            this.Ma_Tr_P,
            this.Ma_HD_DV,
            this.Ngay_Thanh_Toan,
            this.Hinh_Thuc,
            this.TT_HD});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1066, 342);
            this.dgvNhanVien.TabIndex = 15;
            this.dgvNhanVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhanVien_CellMouseClick);
            // 
            // Ma_HD_Tong
            // 
            this.Ma_HD_Tong.DataPropertyName = "Ma_HD_Tong";
            this.Ma_HD_Tong.HeaderText = "Mã HĐ Tổng";
            this.Ma_HD_Tong.Name = "Ma_HD_Tong";
            // 
            // Ma_Tr_P
            // 
            this.Ma_Tr_P.DataPropertyName = "Ma_Tr_P";
            this.Ma_Tr_P.HeaderText = "Mã trả phòng";
            this.Ma_Tr_P.Name = "Ma_Tr_P";
            // 
            // Ma_HD_DV
            // 
            this.Ma_HD_DV.DataPropertyName = "Ma_HD_DV";
            this.Ma_HD_DV.HeaderText = "Mã HĐ DV";
            this.Ma_HD_DV.Name = "Ma_HD_DV";
            // 
            // Ngay_Thanh_Toan
            // 
            this.Ngay_Thanh_Toan.DataPropertyName = "Ngay_Thanh_Toan";
            this.Ngay_Thanh_Toan.HeaderText = "Ngày thanh toán";
            this.Ngay_Thanh_Toan.Name = "Ngay_Thanh_Toan";
            // 
            // Hinh_Thuc
            // 
            this.Hinh_Thuc.DataPropertyName = "Hinh_Thuc";
            this.Hinh_Thuc.HeaderText = "Hình thức";
            this.Hinh_Thuc.Name = "Hinh_Thuc";
            // 
            // TT_HD
            // 
            this.TT_HD.DataPropertyName = "TT_HD";
            this.TT_HD.HeaderText = "Tổng tiền HĐ";
            this.TT_HD.Name = "TT_HD";
            // 
            // txt_Ma_HD_DV
            // 
            this.txt_Ma_HD_DV.Enabled = false;
            this.txt_Ma_HD_DV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_HD_DV.Location = new System.Drawing.Point(843, 74);
            this.txt_Ma_HD_DV.Name = "txt_Ma_HD_DV";
            this.txt_Ma_HD_DV.Size = new System.Drawing.Size(190, 26);
            this.txt_Ma_HD_DV.TabIndex = 174;
            this.txt_Ma_HD_DV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 175;
            this.label1.Text = "Mã HD dịch vụ";
            // 
            // txt_Ma_Tr_P
            // 
            this.txt_Ma_Tr_P.Enabled = false;
            this.txt_Ma_Tr_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_Tr_P.Location = new System.Drawing.Point(493, 74);
            this.txt_Ma_Tr_P.Name = "txt_Ma_Tr_P";
            this.txt_Ma_Tr_P.Size = new System.Drawing.Size(190, 26);
            this.txt_Ma_Tr_P.TabIndex = 171;
            this.txt_Ma_Tr_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Ma_HD_Tong
            // 
            this.txt_Ma_HD_Tong.Enabled = false;
            this.txt_Ma_HD_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_HD_Tong.Location = new System.Drawing.Point(172, 74);
            this.txt_Ma_HD_Tong.Name = "txt_Ma_HD_Tong";
            this.txt_Ma_HD_Tong.Size = new System.Drawing.Size(163, 26);
            this.txt_Ma_HD_Tong.TabIndex = 170;
            this.txt_Ma_HD_Tong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Mat_Khau
            // 
            this.lbl_Mat_Khau.AutoSize = true;
            this.lbl_Mat_Khau.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mat_Khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Khau.Location = new System.Drawing.Point(377, 77);
            this.lbl_Mat_Khau.Name = "lbl_Mat_Khau";
            this.lbl_Mat_Khau.Size = new System.Drawing.Size(115, 20);
            this.lbl_Mat_Khau.TabIndex = 173;
            this.lbl_Mat_Khau.Text = "Mã trả phòng";
            // 
            // lblTen_Dang_Nhap
            // 
            this.lblTen_Dang_Nhap.AutoSize = true;
            this.lblTen_Dang_Nhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_Dang_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_Dang_Nhap.Location = new System.Drawing.Point(60, 77);
            this.lblTen_Dang_Nhap.Name = "lblTen_Dang_Nhap";
            this.lblTen_Dang_Nhap.Size = new System.Drawing.Size(109, 20);
            this.lblTen_Dang_Nhap.TabIndex = 172;
            this.lblTen_Dang_Nhap.Text = "Mã HD Tổng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 42);
            this.label8.TabIndex = 169;
            this.label8.Text = "Quản lý hóa đơn";
            // 
            // QL_Hoa_Don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 549);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.txtXem_CT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Ma_HD_DV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ma_Tr_P);
            this.Controls.Add(this.txt_Ma_HD_Tong);
            this.Controls.Add(this.lbl_Mat_Khau);
            this.Controls.Add(this.lblTen_Dang_Nhap);
            this.Controls.Add(this.label8);
            this.Name = "QL_Hoa_Don";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.QL_Hoa_Don_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button txtXem_CT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Ma_HD_DV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma_Tr_P;
        private System.Windows.Forms.TextBox txt_Ma_HD_Tong;
        private System.Windows.Forms.Label lbl_Mat_Khau;
        private System.Windows.Forms.Label lblTen_Dang_Nhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HD_Tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Tr_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HD_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Thanh_Toan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh_Thuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT_HD;
    }
}