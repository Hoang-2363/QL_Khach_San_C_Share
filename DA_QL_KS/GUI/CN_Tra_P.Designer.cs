
namespace DA_QL_KS.GUI
{
    partial class CN_Tra_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CN_Tra_P));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma_TRP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TRANG_THAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_THUE_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_DI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_TRA_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTra_phong = new System.Windows.Forms.DataGridView();
            this.txt_Trang_Thai = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_HD_Thanh_Toan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTra_P = new System.Windows.Forms.Button();
            this.txtNgay_Di = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ma_TH_P = new System.Windows.Forms.TextBox();
            this.txt_Ten_P = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTra_phong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Trạng thái";
            // 
            // txt_Ma_TRP
            // 
            this.txt_Ma_TRP.Enabled = false;
            this.txt_Ma_TRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_TRP.Location = new System.Drawing.Point(146, 86);
            this.txt_Ma_TRP.Name = "txt_Ma_TRP";
            this.txt_Ma_TRP.Size = new System.Drawing.Size(246, 26);
            this.txt_Ma_TRP.TabIndex = 42;
            this.txt_Ma_TRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã trả phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 42);
            this.label8.TabIndex = 37;
            this.label8.Text = "Thông tin trả phòng";
            // 
            // TRANG_THAI
            // 
            this.TRANG_THAI.DataPropertyName = "TRANG_THAI";
            this.TRANG_THAI.HeaderText = "Trạng thái";
            this.TRANG_THAI.Name = "TRANG_THAI";
            // 
            // MA_THUE_P
            // 
            this.MA_THUE_P.DataPropertyName = "MA_THUE_P";
            this.MA_THUE_P.HeaderText = "Mã thuê phòng";
            this.MA_THUE_P.Name = "MA_THUE_P";
            // 
            // NGAY_DI
            // 
            this.NGAY_DI.DataPropertyName = "NGAY_DI";
            this.NGAY_DI.HeaderText = "Ngày đi";
            this.NGAY_DI.Name = "NGAY_DI";
            // 
            // MA_TRA_P
            // 
            this.MA_TRA_P.DataPropertyName = "MA_TRA_P";
            this.MA_TRA_P.HeaderText = "Mã trả phòng";
            this.MA_TRA_P.Name = "MA_TRA_P";
            // 
            // dgvTra_phong
            // 
            this.dgvTra_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTra_phong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvTra_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTra_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_TRA_P,
            this.NGAY_DI,
            this.MA_THUE_P,
            this.TRANG_THAI});
            this.dgvTra_phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTra_phong.Location = new System.Drawing.Point(0, 0);
            this.dgvTra_phong.Name = "dgvTra_phong";
            this.dgvTra_phong.Size = new System.Drawing.Size(888, 234);
            this.dgvTra_phong.TabIndex = 21;
            this.dgvTra_phong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTra_phong_CellMouseClick);
            // 
            // txt_Trang_Thai
            // 
            this.txt_Trang_Thai.Enabled = false;
            this.txt_Trang_Thai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Trang_Thai.Location = new System.Drawing.Point(146, 180);
            this.txt_Trang_Thai.Name = "txt_Trang_Thai";
            this.txt_Trang_Thai.Size = new System.Drawing.Size(246, 26);
            this.txt_Trang_Thai.TabIndex = 44;
            this.txt_Trang_Thai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTra_phong);
            this.panel1.Location = new System.Drawing.Point(-6, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 234);
            this.panel1.TabIndex = 40;
            // 
            // btn_HD_Thanh_Toan
            // 
            this.btn_HD_Thanh_Toan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_HD_Thanh_Toan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HD_Thanh_Toan.Location = new System.Drawing.Point(321, 498);
            this.btn_HD_Thanh_Toan.Name = "btn_HD_Thanh_Toan";
            this.btn_HD_Thanh_Toan.Size = new System.Drawing.Size(238, 35);
            this.btn_HD_Thanh_Toan.TabIndex = 39;
            this.btn_HD_Thanh_Toan.Text = "Hóa đơn thanh toán";
            this.btn_HD_Thanh_Toan.UseVisualStyleBackColor = false;
            this.btn_HD_Thanh_Toan.Click += new System.EventHandler(this.btn_HD_Thanh_Toan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(625, 498);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 35);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTra_P
            // 
            this.btnTra_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTra_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra_P.Location = new System.Drawing.Point(128, 498);
            this.btnTra_P.Name = "btnTra_P";
            this.btnTra_P.Size = new System.Drawing.Size(119, 35);
            this.btnTra_P.TabIndex = 36;
            this.btnTra_P.Text = "Trả phòng";
            this.btnTra_P.UseVisualStyleBackColor = false;
            this.btnTra_P.Click += new System.EventHandler(this.btnTra_P_Click);
            // 
            // txtNgay_Di
            // 
            this.txtNgay_Di.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay_Di.Location = new System.Drawing.Point(146, 131);
            this.txtNgay_Di.Name = "txtNgay_Di";
            this.txtNgay_Di.Size = new System.Drawing.Size(246, 26);
            this.txtNgay_Di.TabIndex = 34;
            this.txtNgay_Di.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã thuê phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày đi";
            // 
            // txt_Ma_TH_P
            // 
            this.txt_Ma_TH_P.Enabled = false;
            this.txt_Ma_TH_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_TH_P.Location = new System.Drawing.Point(598, 131);
            this.txt_Ma_TH_P.Name = "txt_Ma_TH_P";
            this.txt_Ma_TH_P.Size = new System.Drawing.Size(231, 26);
            this.txt_Ma_TH_P.TabIndex = 45;
            this.txt_Ma_TH_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Ten_P
            // 
            this.txt_Ten_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_P.FormattingEnabled = true;
            this.txt_Ten_P.Location = new System.Drawing.Point(598, 82);
            this.txt_Ten_P.Name = "txt_Ten_P";
            this.txt_Ten_P.Size = new System.Drawing.Size(231, 28);
            this.txt_Ten_P.TabIndex = 147;
            this.txt_Ten_P.TextChanged += new System.EventHandler(this.txt_Ten_P_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(498, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 146;
            this.label9.Text = "Tên phòng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(18, 26);
            this.dateTimePicker1.TabIndex = 148;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CN_Tra_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 552);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_Ten_P);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Ma_TH_P);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ma_TRP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Trang_Thai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HD_Thanh_Toan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTra_P);
            this.Controls.Add(this.txtNgay_Di);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "CN_Tra_P";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức năng trả phòng";
            this.Load += new System.EventHandler(this.CN_Tra_P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTra_phong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma_TRP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANG_THAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_THUE_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_DI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_TRA_P;
        private System.Windows.Forms.DataGridView dgvTra_phong;
        private System.Windows.Forms.TextBox txt_Trang_Thai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_HD_Thanh_Toan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTra_P;
        private System.Windows.Forms.TextBox txtNgay_Di;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ma_TH_P;
        private System.Windows.Forms.ComboBox txt_Ten_P;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}