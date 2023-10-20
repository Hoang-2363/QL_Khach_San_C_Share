
namespace DA_QL_KS.GUI
{
    partial class HD_TT_Tong_Hop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HD_TT_Tong_Hop));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThue_Phong = new System.Windows.Forms.DataGridView();
            this.TEN_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_VI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANH_TIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.TEN_PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_DEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_DI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_NGAY_O = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANH_TIEN_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTen_Dang_Nhap = new System.Windows.Forms.Label();
            this.txt_Ten_KH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tong_Tien_DV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Tong_Tien_P = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Tong_Tien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_Hinh_Thuc_TT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Ma_HD_TT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThue_Phong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(423, 42);
            this.label8.TabIndex = 151;
            this.label8.Text = "Hóa đơn thanh toán tổng hợp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvThue_Phong);
            this.panel1.Location = new System.Drawing.Point(437, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 241);
            this.panel1.TabIndex = 152;
            // 
            // dgvThue_Phong
            // 
            this.dgvThue_Phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThue_Phong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvThue_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThue_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN_DV,
            this.SO_LUONG,
            this.DON_VI,
            this.GIA_DV,
            this.THANH_TIEN});
            this.dgvThue_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThue_Phong.Location = new System.Drawing.Point(0, 0);
            this.dgvThue_Phong.Name = "dgvThue_Phong";
            this.dgvThue_Phong.Size = new System.Drawing.Size(497, 241);
            this.dgvThue_Phong.TabIndex = 23;
            // 
            // TEN_DV
            // 
            this.TEN_DV.DataPropertyName = "TEN_DV";
            this.TEN_DV.HeaderText = "Tên dịch vụ";
            this.TEN_DV.Name = "TEN_DV";
            // 
            // SO_LUONG
            // 
            this.SO_LUONG.DataPropertyName = "SO_LUONG";
            this.SO_LUONG.FillWeight = 80F;
            this.SO_LUONG.HeaderText = "Số lượng";
            this.SO_LUONG.Name = "SO_LUONG";
            // 
            // DON_VI
            // 
            this.DON_VI.DataPropertyName = "DON_VI";
            this.DON_VI.FillWeight = 90F;
            this.DON_VI.HeaderText = "Đơn vị tính";
            this.DON_VI.Name = "DON_VI";
            // 
            // GIA_DV
            // 
            this.GIA_DV.DataPropertyName = "GIA_DV";
            this.GIA_DV.FillWeight = 90F;
            this.GIA_DV.HeaderText = "Giá dịch vụ";
            this.GIA_DV.Name = "GIA_DV";
            // 
            // THANH_TIEN
            // 
            this.THANH_TIEN.DataPropertyName = "THANH_TIEN";
            this.THANH_TIEN.FillWeight = 90F;
            this.THANH_TIEN.HeaderText = "Thành tiền";
            this.THANH_TIEN.Name = "THANH_TIEN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNhanVien);
            this.panel2.Location = new System.Drawing.Point(1, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 132);
            this.panel2.TabIndex = 153;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN_PHONG,
            this.NGAY_DEN,
            this.NGAY_DI,
            this.SO_NGAY_O,
            this.GIA_PHONG,
            this.THANH_TIEN_1});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(933, 132);
            this.dgvNhanVien.TabIndex = 15;
            // 
            // TEN_PHONG
            // 
            this.TEN_PHONG.DataPropertyName = "TEN_PHONG";
            this.TEN_PHONG.HeaderText = "Tên phòng";
            this.TEN_PHONG.Name = "TEN_PHONG";
            // 
            // NGAY_DEN
            // 
            this.NGAY_DEN.DataPropertyName = "NGAY_DEN";
            this.NGAY_DEN.HeaderText = "Ngày đến";
            this.NGAY_DEN.Name = "NGAY_DEN";
            // 
            // NGAY_DI
            // 
            this.NGAY_DI.DataPropertyName = "NGAY_DI";
            this.NGAY_DI.HeaderText = "Ngày đi";
            this.NGAY_DI.Name = "NGAY_DI";
            // 
            // SO_NGAY_O
            // 
            this.SO_NGAY_O.DataPropertyName = "SO_NGAY_O";
            this.SO_NGAY_O.HeaderText = "Số ngày ở";
            this.SO_NGAY_O.Name = "SO_NGAY_O";
            // 
            // GIA_PHONG
            // 
            this.GIA_PHONG.DataPropertyName = "GIA_PHONG";
            this.GIA_PHONG.HeaderText = "Giá phòng";
            this.GIA_PHONG.Name = "GIA_PHONG";
            // 
            // THANH_TIEN_1
            // 
            this.THANH_TIEN_1.DataPropertyName = "THANH_TIEN";
            this.THANH_TIEN_1.FillWeight = 80F;
            this.THANH_TIEN_1.HeaderText = "Thành tiền";
            this.THANH_TIEN_1.Name = "THANH_TIEN_1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 154;
            this.label1.Text = "Dịch vụ sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 28);
            this.label2.TabIndex = 155;
            this.label2.Text = "Phòng đã thuê";
            // 
            // lblTen_Dang_Nhap
            // 
            this.lblTen_Dang_Nhap.AutoSize = true;
            this.lblTen_Dang_Nhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_Dang_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_Dang_Nhap.Location = new System.Drawing.Point(5, 150);
            this.lblTen_Dang_Nhap.Name = "lblTen_Dang_Nhap";
            this.lblTen_Dang_Nhap.Size = new System.Drawing.Size(178, 20);
            this.lblTen_Dang_Nhap.TabIndex = 157;
            this.lblTen_Dang_Nhap.Text = "Hình thức thanh toán";
            // 
            // txt_Ten_KH
            // 
            this.txt_Ten_KH.Enabled = false;
            this.txt_Ten_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_KH.Location = new System.Drawing.Point(186, 61);
            this.txt_Ten_KH.Name = "txt_Ten_KH";
            this.txt_Ten_KH.Size = new System.Drawing.Size(230, 26);
            this.txt_Ten_KH.TabIndex = 158;
            this.txt_Ten_KH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 159;
            this.label3.Text = "Tên khách hàng";
            // 
            // txt_Tong_Tien_DV
            // 
            this.txt_Tong_Tien_DV.Enabled = false;
            this.txt_Tong_Tien_DV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong_Tien_DV.Location = new System.Drawing.Point(186, 197);
            this.txt_Tong_Tien_DV.Name = "txt_Tong_Tien_DV";
            this.txt_Tong_Tien_DV.Size = new System.Drawing.Size(230, 26);
            this.txt_Tong_Tien_DV.TabIndex = 160;
            this.txt_Tong_Tien_DV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 161;
            this.label4.Text = "Tổng tiền dịch vụ";
            // 
            // txt_Tong_Tien_P
            // 
            this.txt_Tong_Tien_P.Enabled = false;
            this.txt_Tong_Tien_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong_Tien_P.Location = new System.Drawing.Point(186, 247);
            this.txt_Tong_Tien_P.Name = "txt_Tong_Tien_P";
            this.txt_Tong_Tien_P.Size = new System.Drawing.Size(230, 26);
            this.txt_Tong_Tien_P.TabIndex = 162;
            this.txt_Tong_Tien_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 163;
            this.label5.Text = "Tổng tiền phòng";
            // 
            // txt_Tong_Tien
            // 
            this.txt_Tong_Tien.Enabled = false;
            this.txt_Tong_Tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong_Tien.Location = new System.Drawing.Point(186, 292);
            this.txt_Tong_Tien.Name = "txt_Tong_Tien";
            this.txt_Tong_Tien.Size = new System.Drawing.Size(230, 38);
            this.txt_Tong_Tien.TabIndex = 164;
            this.txt_Tong_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 31);
            this.label6.TabIndex = 165;
            this.label6.Text = "Tổng tiền ";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.Location = new System.Drawing.Point(594, 519);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(144, 37);
            this.btn_Thoat.TabIndex = 167;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_Hinh_Thuc_TT
            // 
            this.txt_Hinh_Thuc_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hinh_Thuc_TT.FormattingEnabled = true;
            this.txt_Hinh_Thuc_TT.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ"});
            this.txt_Hinh_Thuc_TT.Location = new System.Drawing.Point(186, 147);
            this.txt_Hinh_Thuc_TT.Name = "txt_Hinh_Thuc_TT";
            this.txt_Hinh_Thuc_TT.Size = new System.Drawing.Size(230, 28);
            this.txt_Hinh_Thuc_TT.TabIndex = 168;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(176, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 37);
            this.button1.TabIndex = 169;
            this.button1.Text = "Thanh toán và in hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Ma_HD_TT
            // 
            this.txt_Ma_HD_TT.Enabled = false;
            this.txt_Ma_HD_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_HD_TT.Location = new System.Drawing.Point(186, 105);
            this.txt_Ma_HD_TT.Name = "txt_Ma_HD_TT";
            this.txt_Ma_HD_TT.Size = new System.Drawing.Size(230, 26);
            this.txt_Ma_HD_TT.TabIndex = 170;
            this.txt_Ma_HD_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 171;
            this.label7.Text = "Mã HD thanh toán";
            // 
            // HD_TT_Tong_Hop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.txt_Ma_HD_TT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Hinh_Thuc_TT);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_Tong_Tien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Tong_Tien_P);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Tong_Tien_DV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ten_KH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTen_Dang_Nhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Name = "HD_TT_Tong_Hop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn tổng hợp";
            this.Load += new System.EventHandler(this.HD_TT_Tong_Hop_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThue_Phong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTen_Dang_Nhap;
        private System.Windows.Forms.TextBox txt_Ten_KH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tong_Tien_DV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Tong_Tien_P;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Tong_Tien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox txt_Hinh_Thuc_TT;
        private System.Windows.Forms.DataGridView dgvThue_Phong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_VI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANH_TIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_DEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_DI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_NGAY_O;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANH_TIEN_1;
        private System.Windows.Forms.TextBox txt_Ma_HD_TT;
        private System.Windows.Forms.Label label7;
    }
}