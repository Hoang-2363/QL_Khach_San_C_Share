
namespace DA_QL_KS.GUI
{
    partial class Dang_Nhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dang_Nhap));
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Dang_Nhap = new System.Windows.Forms.Button();
            this.chk_Hien_MK = new System.Windows.Forms.CheckBox();
            this.txt_Mat_khau = new System.Windows.Forms.TextBox();
            this.txtTai_Khoan = new System.Windows.Forms.TextBox();
            this.lbl_Mat_Khau = new System.Windows.Forms.Label();
            this.lblTen_Dang_Nhap = new System.Windows.Forms.Label();
            this.lblTieu_De = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.Location = new System.Drawing.Point(325, 325);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(144, 40);
            this.btn_Thoat.TabIndex = 24;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Dang_Nhap
            // 
            this.btn_Dang_Nhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Dang_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dang_Nhap.ForeColor = System.Drawing.Color.Black;
            this.btn_Dang_Nhap.Location = new System.Drawing.Point(110, 325);
            this.btn_Dang_Nhap.Name = "btn_Dang_Nhap";
            this.btn_Dang_Nhap.Size = new System.Drawing.Size(157, 40);
            this.btn_Dang_Nhap.TabIndex = 23;
            this.btn_Dang_Nhap.Text = "Đăng nhập";
            this.btn_Dang_Nhap.UseVisualStyleBackColor = false;
            this.btn_Dang_Nhap.Click += new System.EventHandler(this.btn_Dang_Nhap_Click);
            this.btn_Dang_Nhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Dang_Nhap_KeyDown);
            // 
            // chk_Hien_MK
            // 
            this.chk_Hien_MK.AutoSize = true;
            this.chk_Hien_MK.BackColor = System.Drawing.Color.Transparent;
            this.chk_Hien_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Hien_MK.Location = new System.Drawing.Point(224, 240);
            this.chk_Hien_MK.Name = "chk_Hien_MK";
            this.chk_Hien_MK.Size = new System.Drawing.Size(145, 20);
            this.chk_Hien_MK.TabIndex = 28;
            this.chk_Hien_MK.Text = "Hiển thị mật khẩu";
            this.chk_Hien_MK.UseVisualStyleBackColor = false;
            this.chk_Hien_MK.CheckedChanged += new System.EventHandler(this.chk_Hien_MK_CheckedChanged);
            // 
            // txt_Mat_khau
            // 
            this.txt_Mat_khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_khau.Location = new System.Drawing.Point(214, 191);
            this.txt_Mat_khau.Name = "txt_Mat_khau";
            this.txt_Mat_khau.PasswordChar = '*';
            this.txt_Mat_khau.Size = new System.Drawing.Size(266, 26);
            this.txt_Mat_khau.TabIndex = 22;
            this.txt_Mat_khau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTai_Khoan
            // 
            this.txtTai_Khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTai_Khoan.Location = new System.Drawing.Point(214, 145);
            this.txtTai_Khoan.Name = "txtTai_Khoan";
            this.txtTai_Khoan.Size = new System.Drawing.Size(266, 26);
            this.txtTai_Khoan.TabIndex = 21;
            this.txtTai_Khoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Mat_Khau
            // 
            this.lbl_Mat_Khau.AutoSize = true;
            this.lbl_Mat_Khau.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mat_Khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Khau.Location = new System.Drawing.Point(123, 194);
            this.lbl_Mat_Khau.Name = "lbl_Mat_Khau";
            this.lbl_Mat_Khau.Size = new System.Drawing.Size(83, 20);
            this.lbl_Mat_Khau.TabIndex = 27;
            this.lbl_Mat_Khau.Text = "Mật khẩu";
            // 
            // lblTen_Dang_Nhap
            // 
            this.lblTen_Dang_Nhap.AutoSize = true;
            this.lblTen_Dang_Nhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTen_Dang_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_Dang_Nhap.Location = new System.Drawing.Point(79, 148);
            this.lblTen_Dang_Nhap.Name = "lblTen_Dang_Nhap";
            this.lblTen_Dang_Nhap.Size = new System.Drawing.Size(129, 20);
            this.lblTen_Dang_Nhap.TabIndex = 26;
            this.lblTen_Dang_Nhap.Text = "Tên đăng nhập";
            // 
            // lblTieu_De
            // 
            this.lblTieu_De.AutoSize = true;
            this.lblTieu_De.BackColor = System.Drawing.Color.Transparent;
            this.lblTieu_De.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieu_De.ForeColor = System.Drawing.Color.Black;
            this.lblTieu_De.Location = new System.Drawing.Point(184, 19);
            this.lblTieu_De.Name = "lblTieu_De";
            this.lblTieu_De.Size = new System.Drawing.Size(205, 49);
            this.lblTieu_De.TabIndex = 25;
            this.lblTieu_De.Text = "Đăng nhập";
            // 
            // Dang_Nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 396);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Dang_Nhap);
            this.Controls.Add(this.chk_Hien_MK);
            this.Controls.Add(this.txt_Mat_khau);
            this.Controls.Add(this.txtTai_Khoan);
            this.Controls.Add(this.lbl_Mat_Khau);
            this.Controls.Add(this.lblTen_Dang_Nhap);
            this.Controls.Add(this.lblTieu_De);
            this.Name = "Dang_Nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Dang_Nhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Dang_Nhap;
        private System.Windows.Forms.CheckBox chk_Hien_MK;
        private System.Windows.Forms.TextBox txt_Mat_khau;
        private System.Windows.Forms.TextBox txtTai_Khoan;
        private System.Windows.Forms.Label lbl_Mat_Khau;
        private System.Windows.Forms.Label lblTen_Dang_Nhap;
        private System.Windows.Forms.Label lblTieu_De;
    }
}