
namespace DA_QL_KS.GUI
{
    partial class Thong_Ke_Tien_DV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thong_Ke_Tien_DV));
            this.btn_Tim_Kiem = new System.Windows.Forms.Button();
            this.txt_Den_Ngay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tu_Ngay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Tong_DT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MA_HD_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_LAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANG_THAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONG_TIEN_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tim_Kiem
            // 
            this.btn_Tim_Kiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Tim_Kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim_Kiem.Location = new System.Drawing.Point(777, 74);
            this.btn_Tim_Kiem.Name = "btn_Tim_Kiem";
            this.btn_Tim_Kiem.Size = new System.Drawing.Size(122, 35);
            this.btn_Tim_Kiem.TabIndex = 191;
            this.btn_Tim_Kiem.Text = "Tìm kiếm";
            this.btn_Tim_Kiem.UseVisualStyleBackColor = false;
            this.btn_Tim_Kiem.Click += new System.EventHandler(this.btn_Tim_Kiem_Click);
            // 
            // txt_Den_Ngay
            // 
            this.txt_Den_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Den_Ngay.Location = new System.Drawing.Point(499, 77);
            this.txt_Den_Ngay.Name = "txt_Den_Ngay";
            this.txt_Den_Ngay.Size = new System.Drawing.Size(236, 26);
            this.txt_Den_Ngay.TabIndex = 189;
            this.txt_Den_Ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 190;
            this.label3.Text = "Đến ngày";
            // 
            // txt_Tu_Ngay
            // 
            this.txt_Tu_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tu_Ngay.Location = new System.Drawing.Point(140, 77);
            this.txt_Tu_Ngay.Name = "txt_Tu_Ngay";
            this.txt_Tu_Ngay.Size = new System.Drawing.Size(224, 26);
            this.txt_Tu_Ngay.TabIndex = 187;
            this.txt_Tu_Ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(461, 42);
            this.label8.TabIndex = 186;
            this.label8.Text = "Thống kê doanh thu tiền dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 188;
            this.label2.Text = "Từ ngày";
            // 
            // txt_Tong_DT
            // 
            this.txt_Tong_DT.Enabled = false;
            this.txt_Tong_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong_DT.Location = new System.Drawing.Point(337, 137);
            this.txt_Tong_DT.Name = "txt_Tong_DT";
            this.txt_Tong_DT.Size = new System.Drawing.Size(421, 38);
            this.txt_Tong_DT.TabIndex = 193;
            this.txt_Tong_DT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 31);
            this.label4.TabIndex = 194;
            this.label4.Text = "Tổng doanh thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Location = new System.Drawing.Point(8, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 260);
            this.panel1.TabIndex = 192;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_HD_DV,
            this.TEN_KH,
            this.TEN_PHONG,
            this.NGAY_LAP,
            this.TRANG_THAI,
            this.TONG_TIEN_DV});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1016, 260);
            this.dgvNhanVien.TabIndex = 19;
            // 
            // MA_HD_DV
            // 
            this.MA_HD_DV.DataPropertyName = "MA_HD_DV";
            this.MA_HD_DV.HeaderText = "Mã HĐ dịch vụ";
            this.MA_HD_DV.Name = "MA_HD_DV";
            // 
            // TEN_KH
            // 
            this.TEN_KH.DataPropertyName = "TEN_KH";
            this.TEN_KH.HeaderText = "Tên khách hàng";
            this.TEN_KH.Name = "TEN_KH";
            // 
            // TEN_PHONG
            // 
            this.TEN_PHONG.DataPropertyName = "TEN_PHONG";
            this.TEN_PHONG.HeaderText = "Tên phòng";
            this.TEN_PHONG.Name = "TEN_PHONG";
            // 
            // NGAY_LAP
            // 
            this.NGAY_LAP.DataPropertyName = "NGAY_LAP";
            this.NGAY_LAP.HeaderText = "Ngày lập";
            this.NGAY_LAP.Name = "NGAY_LAP";
            // 
            // TRANG_THAI
            // 
            this.TRANG_THAI.DataPropertyName = "TRANG_THAI";
            this.TRANG_THAI.HeaderText = "Trạng thái";
            this.TRANG_THAI.Name = "TRANG_THAI";
            // 
            // TONG_TIEN_DV
            // 
            this.TONG_TIEN_DV.DataPropertyName = "TONG_TIEN_DV";
            this.TONG_TIEN_DV.HeaderText = "Tổng tiền HĐ dịch vụ";
            this.TONG_TIEN_DV.Name = "TONG_TIEN_DV";
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(425, 496);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(122, 35);
            this.Thoat.TabIndex = 196;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(367, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(17, 26);
            this.dateTimePicker1.TabIndex = 197;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(738, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(20, 26);
            this.dateTimePicker2.TabIndex = 198;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Thong_Ke_Tien_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 543);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Tim_Kiem);
            this.Controls.Add(this.txt_Den_Ngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tu_Ngay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Tong_DT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Thoat);
            this.Name = "Thong_Ke_Tien_DV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tiền dịch vụ";
            this.Load += new System.EventHandler(this.Thong_Ke_Tien_DV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tim_Kiem;
        private System.Windows.Forms.TextBox txt_Den_Ngay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tu_Ngay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Tong_DT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_HD_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_LAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANG_THAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONG_TIEN_DV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}