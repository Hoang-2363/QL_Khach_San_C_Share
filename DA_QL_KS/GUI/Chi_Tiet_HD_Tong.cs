using DA_QL_KS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_QL_KS.GUI
{
    public partial class Chi_Tiet_HD_Tong : Form
    {
        public Chi_Tiet_HD_Tong()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            QL_Hoa_Don m = new QL_Hoa_Don();
            this.Hide();
            m.Show();
        }
        
        private void Chi_Tiet_HD_Tong_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Font = new Font("Arial", 10);
            Font boldFont = new Font(dgvNhanVien.Font, FontStyle.Bold);
            dgvNhanVien.Font = boldFont;

            dgvThue_Phong.Font = new Font("Arial", 10);
            Font boldFont1 = new Font(dgvThue_Phong.Font, FontStyle.Bold);
            dgvThue_Phong.Font = boldFont1;

            String b = Save_Variable.ma_tra_p_1;
            String c = Save_Variable.ma_hd_dv_1;
            String a = Save_Variable.ma_hd_tong;

            Connect_QL_HD.Load_DV(dgvThue_Phong);
            Connect_QL_HD.Load_P(dgvNhanVien, a, b);
            Connect_QL_HD.Load_Ten_KH(txt_Ten_KH, txt_ten_NV, c);
            int tong = 0;
            foreach (DataGridViewRow row in dgvThue_Phong.Rows)
            {
                if (!row.IsNewRow && row.Cells["THANH_TIEN"].Value != null)
                {
                    int giaTriCot = Convert.ToInt32(row.Cells["THANH_TIEN"].Value);
                    tong += giaTriCot;
                }
            }
            txt_Tong_Tien_DV.Text = tong.ToString();

            int tong1 = 0;
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (!row.IsNewRow && row.Cells["THANH_TIEN_1"].Value != null)
                {
                    int giaTriCot = Convert.ToInt32(row.Cells["THANH_TIEN_1"].Value);
                    tong1 += giaTriCot;
                }
            }
            txt_Tong_Tien_P.Text = tong1.ToString();

            int tongTienDV, tongTienP;
            if (int.TryParse(txt_Tong_Tien_DV.Text, out tongTienDV) && int.TryParse(txt_Tong_Tien_P.Text, out tongTienP))
            {
                int tongTien = tongTienDV + tongTienP;
                txt_Tong_Tien.Text = tongTien.ToString();
            }
        }

        private void btn_Dang_Nhap_Click(object sender, EventArgs e)
        {
            String b = Save_Variable.ma_tra_p_1;
            String c = Save_Variable.ma_hd_dv_1;
            String a = Save_Variable.ma_hd_tong;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            connection = new SqlConnection(str);
            connection.Open();
            string sqlQuery = "SELECT HD_THANH_TOAN.MA_HD_TP, FORMAT(HD_THANH_TOAN.NGAY_THANH_TOAN, 'HH:mm:ss dd/MM/yyyy') AS NGAY_THANH_TOAN, HD_THANH_TOAN.HINH_THUC, KHACH_HANG.TEN_KH, KHACH_HANG.SDT, KHACH_HANG.CNMD, KHACH_HANG.DIA_CHI, PHONG.TEN_PHONG " +
                "FROM HD_THANH_TOAN INNER JOIN TRA_PHONG ON HD_THANH_TOAN.MA_TRA_P = TRA_PHONG.MA_TRA_P INNER JOIN " +
                "THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN NHAN_VIEN ON THUE_PHONG.MA_NV = NHAN_VIEN.MA_NV INNER JOIN " +
                "KHACH_HANG ON THUE_PHONG.MA_KH = KHACH_HANG.MA_KH INNER JOIN PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG " +
                "WHERE HD_THANH_TOAN.MA_HD_TP = '" + a + "' AND TRA_PHONG.MA_TRA_P = '" + b + "'";
            command = new SqlCommand(sqlQuery, connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            string ma_hd_tong, thoi_gan_TT, ten_phong, ht_TT, sdt, cmnd, dia_chi;
            if (table.Rows.Count > 0)
            {
                ma_hd_tong = table.Rows[0]["MA_HD_TP"].ToString();
                thoi_gan_TT = table.Rows[0]["NGAY_THANH_TOAN"].ToString();
                ten_phong = table.Rows[0]["TEN_PHONG"].ToString();
                ht_TT = table.Rows[0]["HINH_THUC"].ToString();
                sdt = table.Rows[0]["SDT"].ToString();
                cmnd = table.Rows[0]["CNMD"].ToString();
                dia_chi = table.Rows[0]["DIA_CHI"].ToString();

                DataTable dt = (DataTable)dgvThue_Phong.DataSource;
                DataTable dt1 = (DataTable)dgvNhanVien.DataSource;
                Export(dt1, dt, "Tong_TL", "HÓA ĐƠN THANH TOÁN TỔNG HỢP", ma_hd_tong, thoi_gan_TT, ten_phong, ht_TT, sdt, cmnd, dia_chi);

            }
            connection.Close();
        }
        public void Export(DataTable dt, DataTable dt1, string sheetName, string title, string ma_hd_tong, string thoi_gan_TT, string ten_phong, string ht_TT, string sdt, string cmnd, string dia_chi)
        {
            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            //Tạo logo
            Microsoft.Office.Interop.Excel.Range lg = oSheet.get_Range("A1", "B1");
            lg.Value2 = "Khách sạn Marriott Hà Nội";
            lg.MergeCells = true;
            Microsoft.Office.Interop.Excel.Range logo = oSheet.get_Range("A1", "B1");
            logo.Font.Bold = true;
            logo.Font.Size = 16;
            logo.Font.Color = Color.Blue;
            logo.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range lg1 = oSheet.get_Range("A2", "B2");
            lg1.Value2 = "Địa chỉ: 8 Đỗ Đức Dục, Mễ Trì, Từ Liêm, Hà Nội";
            lg1.MergeCells = true;
            Microsoft.Office.Interop.Excel.Range lg2 = oSheet.get_Range("D2", "E2");
            lg2.Value2 = "Mẫu số 01a - LDTL";
            lg2.MergeCells = true;
            Microsoft.Office.Interop.Excel.Range lg3 = oSheet.get_Range("A3", "B3");
            lg3.Value2 = "Số điện thoại: 0349135499";
            lg3.MergeCells = true;
            Microsoft.Office.Interop.Excel.Range lg4 = oSheet.get_Range("D3", "E3");
            lg4.Value2 = "Thông tư số 198/2023/TLD";
            lg4.MergeCells = true;
            Microsoft.Office.Interop.Excel.Range logo1 = oSheet.get_Range("A2", "E3");
            logo1.Font.Bold = true;
            logo1.Font.Italic = true;
            logo1.Font.Color = Color.Blue;
            logo1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A5", "E5");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Color = Color.Red;
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Tạo ngày tháng trả lương
            Microsoft.Office.Interop.Excel.Range ngay = oSheet.get_Range("A6", "E6");
            ngay.MergeCells = true;
            ngay.Value2 = "Tháng 10 Năm 2023";
            ngay.Font.Bold = true;
            ngay.Font.Italic = true;
            ngay.Font.Color = Color.Violet;
            ngay.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            //Tạo thông tin hóa đơn
            
            Microsoft.Office.Interop.Excel.Range tt1 = oSheet.get_Range("A8", "B8");
            tt1.Value2 = "                Mã hóa đơn: " + ma_hd_tong;
            tt1.MergeCells = true;

            Microsoft.Office.Interop.Excel.Range tt2 = oSheet.get_Range("A9", "B9");
            tt2.Value2 = "                Thời gian thanh toán: " + thoi_gan_TT;
            tt2.MergeCells = true;

            Microsoft.Office.Interop.Excel.Range tt3 = oSheet.get_Range("A10", "B10");
            tt3.Value2 = "                Tên phòng thuê: " + ten_phong;
            tt3.MergeCells = true;

            Microsoft.Office.Interop.Excel.Range tt4 = oSheet.get_Range("A11", "B11");
            tt4.Value2 = "                Hình thức thanh toán: " + ht_TT;
            tt4.MergeCells = true;

            Microsoft.Office.Interop.Excel.Range tt5 = oSheet.get_Range("D8", "E8");
            tt5.Value2 = "        Tên khách hàng: " + txt_Ten_KH.Text;
            tt5.MergeCells = true;

            Microsoft.Office.Interop.Excel.Range tt6 = oSheet.get_Range("D9", "E9");
            tt6.Value2 = "        Số điện thoại: " + sdt;
            tt6.MergeCells = true;

            Microsoft.Office.Interop.Excel.Range tt7 = oSheet.get_Range("D10", "E10");
            tt7.Value2 = "        CMND: " + cmnd;
            tt7.MergeCells = true;

            Microsoft.Office.Interop.Excel.Range tt8 = oSheet.get_Range("D11", "E11");
            tt8.Value2 = "        Địa chỉ: " + dia_chi;
            tt8.MergeCells = true;

            Microsoft.Office.Interop.Excel.Range thongtin1 = oSheet.get_Range("A8", "E11");
            thongtin1.Font.Bold = true;



            //Tiêu đề bảng 
            Microsoft.Office.Interop.Excel.Range bang1 = oSheet.get_Range("A13", "E13");
            bang1.Value2 = "Bảng thông tin thuê phòng";
            bang1.MergeCells = true;
            bang1.Font.Bold = true;
            bang1.Font.Color = Color.Red;
            bang1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Đơn vị
            Microsoft.Office.Interop.Excel.Range donvi = oSheet.get_Range("E14", "E14");
            donvi.Value2 = "Đơn vị: Đồng";
            donvi.Font.Bold = true;
            donvi.Font.Italic = true;
            donvi.Font.Color = Color.Black;
            donvi.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

            //Bảng 1:
            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A15", "A15");
            cl1.Value2 = "Ngày đến";
            cl1.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B15", "B15");
            cl2.Value2 = "Ngày đi";
            cl2.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C15", "C15");
            cl3.Value2 = "Số ngày ở";
            cl3.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D15", "D15");
            cl4.Value2 = "Giá phòng";
            cl4.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E15", "E15");
            cl5.Value2 = "Thành tiền";
            cl5.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A15", "E15");
            rowHead.Font.Bold = true;
            rowHead.Font.Color = Color.Red;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 4;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, 5];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 3; c < 8; c++)
                {
                    arr[r, c - 3] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 16;
            int columnStart1 = 1;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count - 3;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart1];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart1];
            Microsoft.Office.Interop.Excel.Range c5 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            Microsoft.Office.Interop.Excel.Range c7 = oSheet.get_Range(c1, c5);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.get_Range(c5, c7).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //In số thành dấu ','
            Microsoft.Office.Interop.Excel.Range phay1 = oSheet.get_Range(c5, c7);
            phay1.NumberFormat = "#,##0";

            //Tổng tiền phòng 
            // Lấy phân tách thập phân được sử dụng trong hệ thống
            Microsoft.Office.Interop.Excel.Range phong = oSheet.get_Range("C17", "E17");
            phong.Value2 = "Tổng tiền phòng:   " + txt_Tong_Tien_P.Text + " Đồng";
            phong.MergeCells = true;
            phong.Font.Bold = true;
            phong.Font.Size = 13; 
            phong.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;



            //Tiêu đề bảng 2
            Microsoft.Office.Interop.Excel.Range bang2 = oSheet.get_Range("A19", "E19");
            bang2.Value2 = "Bảng sử dụng dịch vụ";
            bang2.MergeCells = true;
            bang2.Font.Bold = true;
            bang2.Font.Color = Color.Red;
            bang2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Đơn vị
            Microsoft.Office.Interop.Excel.Range donvi1 = oSheet.get_Range("E20", "E20");
            donvi1.Value2 = "Đơn vị: Đồng";
            donvi1.Font.Bold = true;
            donvi1.Font.Italic = true;
            donvi1.Font.Color = Color.Black;
            donvi1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

            // Tạo tiêu đề cột 
            Microsoft.Office.Interop.Excel.Range cl31 = oSheet.get_Range("A21", "A21");
            cl31.Value2 = "Tên dịch vụ";
            cl31.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl41 = oSheet.get_Range("B21", "B21");
            cl41.Value2 = "Số lượng";
            cl41.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl51 = oSheet.get_Range("C21", "C21");
            cl51.Value2 = "Đơn vị tính";
            cl51.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl61 = oSheet.get_Range("D21", "D21");
            cl61.Value2 = "Giá dịch vụ";
            cl61.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl71 = oSheet.get_Range("E21", "E21");
            cl71.Value2 = "Thành tiền";
            cl71.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range rowHead1 = oSheet.get_Range("A21", "E21");
            rowHead1.Font.Bold = true;
            rowHead1.Font.Color = Color.Red;

            // Kẻ viền
            rowHead1.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead1.Interior.ColorIndex = 4;
            rowHead1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr1 = new object[dt1.Rows.Count, dt1.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt1.Rows.Count; r++)
            {
                DataRow dr1 = dt1.Rows[r];
                for (int c = 0; c < dt1.Columns.Count; c++)
                {
                    arr1[r, c] = dr1[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart1 = 22;
            int columnStart11 = 1;
            int columnStart21 = 5;
            int rowEnd1 = rowStart1 + dt1.Rows.Count - 1;
            int columtEnd1 = dt.Columns.Count - 3;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c11 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart1, columnStart11];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c22 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1, columtEnd1];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range1 = oSheet.get_Range(c11, c22);
            //Điền dữ liệu vào vùng đã thiết lập
            range1.Value2 = arr1;
            // Kẻ viền
            range1.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT

            Microsoft.Office.Interop.Excel.Range c31 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1, columnStart11];
            Microsoft.Office.Interop.Excel.Range c51 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1, columnStart21];

            Microsoft.Office.Interop.Excel.Range c41 = oSheet.get_Range(c11, c31);
            Microsoft.Office.Interop.Excel.Range c71 = oSheet.get_Range(c11, c51);

            oSheet.get_Range(c31, c41).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.get_Range(c51, c71).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //In số thành dấu ','
            Microsoft.Office.Interop.Excel.Range phay11 = oSheet.get_Range(c51, c71);
            phay11.NumberFormat = "#,##0";

            //Tổng tiền dịch vụ
            // Lấy phân tách thập phân được sử dụng trong hệ thống
            Microsoft.Office.Interop.Excel.Range dich_vu = oSheet.get_Range((Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 1, columtEnd1 - 2], (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 1, columtEnd1]);
            dich_vu.Value2 = "Tổng tiền dịch vụ:   " + txt_Tong_Tien_DV.Text + " Đồng";
            dich_vu.MergeCells = true;
            dich_vu.Font.Bold = true;
            dich_vu.Font.Size = 13;
            dich_vu.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            //Tổng tiền hóa đơn
            // Lấy phân tách thập phân được sử dụng trong hệ thống
            Microsoft.Office.Interop.Excel.Range tong_hd = oSheet.get_Range((Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 3, columtEnd1 - 4], (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 3, columtEnd1]);
            tong_hd.Value2 = "Tổng tiền thanh toán:   " + txt_Tong_Tien.Text + " Đồng";
            tong_hd.MergeCells = true;
            tong_hd.Font.Bold = true;
            tong_hd.Font.Size = 16;
            tong_hd.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            //Border
            Microsoft.Office.Interop.Excel.Range border = oSheet.get_Range((Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 5, columtEnd1 - 1], (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 5, columtEnd1]);
            border.Value2 = "Hà Nội, tháng 10 năm 2023";
            border.Font.Bold = true;
            border.Font.Italic = true;
            border.MergeCells = true;
            border.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Ký tên
            Microsoft.Office.Interop.Excel.Range border2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 7, columtEnd1 - 3];
            border2.Value2 = "Nhân viên";
            border2.Font.Bold = true;
            border2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border3 = oSheet.get_Range((Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 7, columtEnd1 - 1], (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 7, columtEnd1]);
            border3.Value2 = "Khách hàng";
            border3.Font.Bold = true;
            border3.MergeCells = true;
            border3.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border22 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 8, columtEnd1 - 3];
            border22.Value2 = "(Ký, họ tên)";
            border22.Font.Italic = true;
            border22.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border33 = oSheet.get_Range((Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 8, columtEnd1 - 1], (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 8, columtEnd1]);
            border33.Value2 = "(Ký, họ tên)";
            border33.Font.Italic = true;
            border33.MergeCells = true;
            border33.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Chữ ký
           /* Microsoft.Office.Interop.Excel.Range border222 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 6, columtEnd1 - 3];
            border222.Value2 = "Huy";
            border222.Font.Bold = true;
            border222.Font.Name = "Script MT Bold";
            border222.Font.Italic = true;
            border222.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border333 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 6, columtEnd1];
            border333.Value2 = "Hoàng";
            border333.Font.Bold = true;
            border333.Font.Name = "Script MT Bold";
            border333.Font.Italic = true;
            border333.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;*/

            Microsoft.Office.Interop.Excel.Range border555 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 10, columtEnd1 - 3];
            border555.Value2 = txt_ten_NV.Text;
            border555.Font.Bold = true;
            border555.Font.Name = "Script MT Bold";
            border555.Font.Italic = true;
            border555.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range border666 = oSheet.get_Range((Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 10, columtEnd1-1], (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd1 + 10, columtEnd1]);
            border666.Value2 = txt_Ten_KH.Text;
            border666.Font.Bold = true;
            border666.Font.Name = "Script MT Bold";
            border666.Font.Italic = true;
            border666.MergeCells = true;
            border666.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 bc = new Form1();
            bc.Show();
        }
    }
}

