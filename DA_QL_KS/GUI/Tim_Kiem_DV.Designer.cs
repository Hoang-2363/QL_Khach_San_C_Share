
namespace DA_QL_KS.GUI
{
    partial class Tim_Kiem_DV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tim_Kiem_DV));
            this.txtTK_TH = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MA_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_VI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Seach = new System.Windows.Forms.ComboBox();
            this.btn_Seach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTK_TH
            // 
            this.txtTK_TH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK_TH.FormattingEnabled = true;
            this.txtTK_TH.Items.AddRange(new object[] {
            "Mã dịch vụ",
            "Tên dịch vụ",
            "Loại dịch vụ"});
            this.txtTK_TH.Location = new System.Drawing.Point(366, 72);
            this.txtTK_TH.Name = "txtTK_TH";
            this.txtTK_TH.Size = new System.Drawing.Size(226, 28);
            this.txtTK_TH.TabIndex = 152;
            this.txtTK_TH.TextChanged += new System.EventHandler(this.txtTK_TH_TextChanged);
            this.txtTK_TH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTK_TH_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Location = new System.Drawing.Point(13, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 238);
            this.panel1.TabIndex = 150;
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
            this.dgvNhanVien.Size = new System.Drawing.Size(856, 238);
            this.dgvNhanVien.TabIndex = 13;
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
            // txt_Seach
            // 
            this.txt_Seach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Seach.FormattingEnabled = true;
            this.txt_Seach.Location = new System.Drawing.Point(204, 119);
            this.txt_Seach.Name = "txt_Seach";
            this.txt_Seach.Size = new System.Drawing.Size(334, 28);
            this.txt_Seach.TabIndex = 149;
            this.txt_Seach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Seach_MouseClick);
            // 
            // btn_Seach
            // 
            this.btn_Seach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Seach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Seach.Location = new System.Drawing.Point(542, 115);
            this.btn_Seach.Name = "btn_Seach";
            this.btn_Seach.Size = new System.Drawing.Size(92, 35);
            this.btn_Seach.TabIndex = 148;
            this.btn_Seach.Text = "Tìm kiếm";
            this.btn_Seach.UseVisualStyleBackColor = false;
            this.btn_Seach.Click += new System.EventHandler(this.btn_Seach_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(495, 444);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(83, 35);
            this.btnDong.TabIndex = 147;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(315, 444);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 35);
            this.btnSua.TabIndex = 146;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 47);
            this.label1.TabIndex = 145;
            this.label1.Text = "Tìm kiếm dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // Tim_Kiem_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 505);
            this.Controls.Add(this.txtTK_TH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Seach);
            this.Controls.Add(this.btn_Seach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Tim_Kiem_DV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm dịch vụ";
            this.Load += new System.EventHandler(this.Tim_Kiem_DV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtTK_TH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_VI;
        private System.Windows.Forms.ComboBox txt_Seach;
        private System.Windows.Forms.Button btn_Seach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}