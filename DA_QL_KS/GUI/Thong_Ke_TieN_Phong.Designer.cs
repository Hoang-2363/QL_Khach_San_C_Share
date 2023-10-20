
namespace DA_QL_KS.GUI
{
    partial class Thong_Ke_TieN_Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thong_Ke_TieN_Phong));
            this.Thoat = new System.Windows.Forms.Button();
            this.txt_Tong_DT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MA_TRA_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_DEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_DI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_NGAY_O = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANH_TIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Tim_Kiem = new System.Windows.Forms.Button();
            this.txt_Den_Ngay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tu_Ngay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(454, 489);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(122, 35);
            this.Thoat.TabIndex = 185;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // txt_Tong_DT
            // 
            this.txt_Tong_DT.Enabled = false;
            this.txt_Tong_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong_DT.Location = new System.Drawing.Point(349, 139);
            this.txt_Tong_DT.Name = "txt_Tong_DT";
            this.txt_Tong_DT.Size = new System.Drawing.Size(421, 38);
            this.txt_Tong_DT.TabIndex = 182;
            this.txt_Tong_DT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 31);
            this.label4.TabIndex = 183;
            this.label4.Text = "Tổng doanh thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Location = new System.Drawing.Point(2, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 260);
            this.panel1.TabIndex = 181;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_TRA_P,
            this.TEN_PHONG,
            this.NGAY_DEN,
            this.NGAY_DI,
            this.SO_NGAY_O,
            this.GIA_PHONG,
            this.THANH_TIEN});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1051, 260);
            this.dgvNhanVien.TabIndex = 18;
            // 
            // MA_TRA_P
            // 
            this.MA_TRA_P.DataPropertyName = "MA_TRA_P";
            this.MA_TRA_P.HeaderText = "Mã trả phòng";
            this.MA_TRA_P.Name = "MA_TRA_P";
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
            // THANH_TIEN
            // 
            this.THANH_TIEN.DataPropertyName = "THANH_TIEN";
            this.THANH_TIEN.FillWeight = 80F;
            this.THANH_TIEN.HeaderText = "Thành tiền";
            this.THANH_TIEN.Name = "THANH_TIEN";
            // 
            // btn_Tim_Kiem
            // 
            this.btn_Tim_Kiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Tim_Kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim_Kiem.Location = new System.Drawing.Point(789, 76);
            this.btn_Tim_Kiem.Name = "btn_Tim_Kiem";
            this.btn_Tim_Kiem.Size = new System.Drawing.Size(122, 35);
            this.btn_Tim_Kiem.TabIndex = 180;
            this.btn_Tim_Kiem.Text = "Tìm kiếm";
            this.btn_Tim_Kiem.UseVisualStyleBackColor = false;
            this.btn_Tim_Kiem.Click += new System.EventHandler(this.btn_Tim_Kiem_Click);
            // 
            // txt_Den_Ngay
            // 
            this.txt_Den_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Den_Ngay.Location = new System.Drawing.Point(511, 79);
            this.txt_Den_Ngay.Name = "txt_Den_Ngay";
            this.txt_Den_Ngay.Size = new System.Drawing.Size(236, 26);
            this.txt_Den_Ngay.TabIndex = 178;
            this.txt_Den_Ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 179;
            this.label3.Text = "Đến ngày";
            // 
            // txt_Tu_Ngay
            // 
            this.txt_Tu_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tu_Ngay.Location = new System.Drawing.Point(152, 79);
            this.txt_Tu_Ngay.Name = "txt_Tu_Ngay";
            this.txt_Tu_Ngay.Size = new System.Drawing.Size(224, 26);
            this.txt_Tu_Ngay.TabIndex = 176;
            this.txt_Tu_Ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 177;
            this.label2.Text = "Từ ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(444, 42);
            this.label8.TabIndex = 169;
            this.label8.Text = "Thống kê doanh thu tiền phòng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 26);
            this.dateTimePicker1.TabIndex = 186;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(749, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(16, 26);
            this.dateTimePicker2.TabIndex = 187;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Thong_Ke_TieN_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 545);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.txt_Tong_DT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Tim_Kiem);
            this.Controls.Add(this.txt_Den_Ngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tu_Ngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "Thong_Ke_TieN_Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu tiền phòng";
            this.Load += new System.EventHandler(this.Thong_Ke_TieN_Phong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.TextBox txt_Tong_DT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Tim_Kiem;
        private System.Windows.Forms.TextBox txt_Den_Ngay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tu_Ngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_TRA_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_DEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_DI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_NGAY_O;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_PHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANH_TIEN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}