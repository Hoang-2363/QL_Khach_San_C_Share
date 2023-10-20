
namespace DA_QL_KS.GUI
{
    partial class CN_Su_Dung_DV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CN_Su_Dung_DV));
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThue_Phong = new System.Windows.Forms.DataGridView();
            this.MA_DV_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_THUE_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANH_TIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Ten_KH = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Ten_P = new System.Windows.Forms.ComboBox();
            this.txt_Ma_KH = new System.Windows.Forms.ComboBox();
            this.txt_Ma_P = new System.Windows.Forms.ComboBox();
            this.txtMa_NV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgay_Lap = new System.Windows.Forms.TextBox();
            this.txtTen_DV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MA_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_VI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_So_Luong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ma_DV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThue_Phong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 166;
            this.label9.Text = "Tên phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvThue_Phong);
            this.panel2.Location = new System.Drawing.Point(1, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 187);
            this.panel2.TabIndex = 149;
            // 
            // dgvThue_Phong
            // 
            this.dgvThue_Phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThue_Phong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvThue_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThue_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_DV_1,
            this.MA_THUE_P,
            this.SO_LUONG,
            this.MA_KH,
            this.MA_NV,
            this.THANH_TIEN});
            this.dgvThue_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThue_Phong.Location = new System.Drawing.Point(0, 0);
            this.dgvThue_Phong.Name = "dgvThue_Phong";
            this.dgvThue_Phong.Size = new System.Drawing.Size(947, 187);
            this.dgvThue_Phong.TabIndex = 22;
            this.dgvThue_Phong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvThue_Phong_CellMouseClick);
            // 
            // MA_DV_1
            // 
            this.MA_DV_1.DataPropertyName = "MA_DV";
            this.MA_DV_1.FillWeight = 80F;
            this.MA_DV_1.HeaderText = "Mã dịch vụ";
            this.MA_DV_1.Name = "MA_DV_1";
            // 
            // MA_THUE_P
            // 
            this.MA_THUE_P.DataPropertyName = "TEN_DV";
            this.MA_THUE_P.HeaderText = "Tên dịch vụ";
            this.MA_THUE_P.Name = "MA_THUE_P";
            // 
            // SO_LUONG
            // 
            this.SO_LUONG.DataPropertyName = "SO_LUONG";
            this.SO_LUONG.FillWeight = 80F;
            this.SO_LUONG.HeaderText = "Số lượng";
            this.SO_LUONG.Name = "SO_LUONG";
            // 
            // MA_KH
            // 
            this.MA_KH.DataPropertyName = "DON_VI";
            this.MA_KH.FillWeight = 90F;
            this.MA_KH.HeaderText = "Đơn vị tính";
            this.MA_KH.Name = "MA_KH";
            // 
            // MA_NV
            // 
            this.MA_NV.DataPropertyName = "GIA_DV";
            this.MA_NV.FillWeight = 90F;
            this.MA_NV.HeaderText = "Giá dịch vụ";
            this.MA_NV.Name = "MA_NV";
            // 
            // THANH_TIEN
            // 
            this.THANH_TIEN.DataPropertyName = "THANH_TIEN";
            this.THANH_TIEN.FillWeight = 90F;
            this.THANH_TIEN.HeaderText = "Thành tiền";
            this.THANH_TIEN.Name = "THANH_TIEN";
            // 
            // txt_Ten_KH
            // 
            this.txt_Ten_KH.Enabled = false;
            this.txt_Ten_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_KH.FormattingEnabled = true;
            this.txt_Ten_KH.Location = new System.Drawing.Point(641, 234);
            this.txt_Ten_KH.Name = "txt_Ten_KH";
            this.txt_Ten_KH.Size = new System.Drawing.Size(211, 28);
            this.txt_Ten_KH.TabIndex = 169;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 168;
            this.label10.Text = "Tên khách hàng";
            // 
            // txt_Ten_P
            // 
            this.txt_Ten_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_P.FormattingEnabled = true;
            this.txt_Ten_P.Location = new System.Drawing.Point(182, 315);
            this.txt_Ten_P.Name = "txt_Ten_P";
            this.txt_Ten_P.Size = new System.Drawing.Size(211, 28);
            this.txt_Ten_P.TabIndex = 167;
            this.txt_Ten_P.TextChanged += new System.EventHandler(this.txt_Ten_P_TextChanged);
            // 
            // txt_Ma_KH
            // 
            this.txt_Ma_KH.Enabled = false;
            this.txt_Ma_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_KH.FormattingEnabled = true;
            this.txt_Ma_KH.Location = new System.Drawing.Point(641, 275);
            this.txt_Ma_KH.Name = "txt_Ma_KH";
            this.txt_Ma_KH.Size = new System.Drawing.Size(211, 28);
            this.txt_Ma_KH.TabIndex = 160;
            // 
            // txt_Ma_P
            // 
            this.txt_Ma_P.Enabled = false;
            this.txt_Ma_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_P.FormattingEnabled = true;
            this.txt_Ma_P.Location = new System.Drawing.Point(182, 272);
            this.txt_Ma_P.Name = "txt_Ma_P";
            this.txt_Ma_P.Size = new System.Drawing.Size(211, 28);
            this.txt_Ma_P.TabIndex = 163;
            // 
            // txtMa_NV
            // 
            this.txtMa_NV.Enabled = false;
            this.txtMa_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa_NV.Location = new System.Drawing.Point(182, 234);
            this.txtMa_NV.Name = "txtMa_NV";
            this.txtMa_NV.Size = new System.Drawing.Size(211, 26);
            this.txtMa_NV.TabIndex = 162;
            this.txtMa_NV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 161;
            this.label6.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 159;
            this.label7.Text = "Mã phòng";
            // 
            // txtNgay_Lap
            // 
            this.txtNgay_Lap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay_Lap.Location = new System.Drawing.Point(641, 315);
            this.txtNgay_Lap.Name = "txtNgay_Lap";
            this.txtNgay_Lap.Size = new System.Drawing.Size(211, 26);
            this.txtNgay_Lap.TabIndex = 158;
            this.txtNgay_Lap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen_DV
            // 
            this.txtTen_DV.Enabled = false;
            this.txtTen_DV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen_DV.Location = new System.Drawing.Point(400, 364);
            this.txtTen_DV.Name = "txtTen_DV";
            this.txtTen_DV.Size = new System.Drawing.Size(255, 26);
            this.txtTen_DV.TabIndex = 157;
            this.txtTen_DV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 156;
            this.label5.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(559, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 155;
            this.label3.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 154;
            this.label2.Text = "Tên dịch vụ";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(714, 651);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(109, 35);
            this.btnDong.TabIndex = 153;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(118, 651);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 35);
            this.btnThem.TabIndex = 152;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 35);
            this.label1.TabIndex = 151;
            this.label1.Text = "Danh sách dịch vụ đã dùng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, -3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 42);
            this.label8.TabIndex = 150;
            this.label8.Text = "Thông tin dịch vụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Location = new System.Drawing.Point(1, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 180);
            this.panel1.TabIndex = 148;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_DV,
            this.TEN_DV,
            this.LOAI_DV,
            this.GIA_DV,
            this.DON_VI});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(947, 180);
            this.dgvNhanVien.TabIndex = 19;
            this.dgvNhanVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhanVien_CellMouseClick);
            // 
            // MA_DV
            // 
            this.MA_DV.DataPropertyName = "MA_DV";
            this.MA_DV.HeaderText = "Mã dịch vụ";
            this.MA_DV.Name = "MA_DV";
            // 
            // TEN_DV
            // 
            this.TEN_DV.DataPropertyName = "TEN_DV";
            this.TEN_DV.HeaderText = "Tên dịch vụ";
            this.TEN_DV.Name = "TEN_DV";
            // 
            // LOAI_DV
            // 
            this.LOAI_DV.DataPropertyName = "LOAI_DV";
            this.LOAI_DV.HeaderText = "Loại dịch vụ";
            this.LOAI_DV.Name = "LOAI_DV";
            // 
            // GIA_DV
            // 
            this.GIA_DV.DataPropertyName = "GIA_DV";
            this.GIA_DV.HeaderText = "Giá dịch vụ";
            this.GIA_DV.Name = "GIA_DV";
            // 
            // DON_VI
            // 
            this.DON_VI.DataPropertyName = "DON_VI";
            this.DON_VI.HeaderText = "Đơn vị";
            this.DON_VI.Name = "DON_VI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 170;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(400, 651);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 171;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_So_Luong
            // 
            this.txt_So_Luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_So_Luong.Location = new System.Drawing.Point(781, 365);
            this.txt_So_Luong.Name = "txt_So_Luong";
            this.txt_So_Luong.Size = new System.Drawing.Size(140, 26);
            this.txt_So_Luong.TabIndex = 173;
            this.txt_So_Luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 172;
            this.label4.Text = "Số lượng";
            // 
            // txt_Ma_DV
            // 
            this.txt_Ma_DV.Enabled = false;
            this.txt_Ma_DV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_DV.Location = new System.Drawing.Point(118, 364);
            this.txt_Ma_DV.Name = "txt_Ma_DV";
            this.txt_Ma_DV.Size = new System.Drawing.Size(134, 26);
            this.txt_Ma_DV.TabIndex = 175;
            this.txt_Ma_DV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 174;
            this.label11.Text = "Mã dịch vụ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(547, 651);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 35);
            this.button3.TabIndex = 176;
            this.button3.Text = "Lưu hóa đơn";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(858, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(19, 26);
            this.dateTimePicker1.TabIndex = 177;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CN_Su_Dung_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 695);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_Ma_DV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_So_Luong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Ten_KH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Ten_P);
            this.Controls.Add(this.txt_Ma_KH);
            this.Controls.Add(this.txt_Ma_P);
            this.Controls.Add(this.txtMa_NV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgay_Lap);
            this.Controls.Add(this.txtTen_DV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "CN_Su_Dung_DV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức năng sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.CN_Su_Dung_DV_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThue_Phong)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txt_Ten_KH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txt_Ten_P;
        private System.Windows.Forms.ComboBox txt_Ma_KH;
        private System.Windows.Forms.ComboBox txt_Ma_P;
        private System.Windows.Forms.TextBox txtMa_NV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgay_Lap;
        private System.Windows.Forms.TextBox txtTen_DV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_So_Luong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ma_DV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvThue_Phong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_VI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_DV_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_THUE_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANH_TIEN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}