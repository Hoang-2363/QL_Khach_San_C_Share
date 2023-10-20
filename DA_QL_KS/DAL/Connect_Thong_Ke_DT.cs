using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DA_QL_KS.DAL
{
    class Connect_Thong_Ke_DT
    {
        public static void Load_KH(DataGridView a)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "WITH RoomInvoices AS ( SELECT HD_THANH_TOAN.MA_HD_TP, HD_THANH_TOAN.MA_TRA_P, HD_THANH_TOAN.MA_HD_DV, FORMAT( HD_THANH_TOAN.NGAY_THANH_TOAN, 'HH:mm:ss dd/MM/yyyy') As NGAY_THANH_TOAN, HD_THANH_TOAN.HINH_THUC," +
                    " KHACH_HANG.MA_KH, PHONG.TEN_PHONG, SUM(DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG) AS TONG_TIEN_PHONG FROM KHACH_HANG INNER JOIN THUE_PHONG ON KHACH_HANG.MA_KH = THUE_PHONG.MA_KH INNER JOIN" +
                    " PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG INNER JOIN TRA_PHONG ON THUE_PHONG.MA_THUE_P = TRA_PHONG.MA_THUE_P INNER JOIN HD_THANH_TOAN ON TRA_PHONG.MA_TRA_P = HD_THANH_TOAN.MA_TRA_P GROUP BY" +
                    " KHACH_HANG.MA_KH, PHONG.TEN_PHONG, HD_THANH_TOAN.MA_HD_TP, HD_THANH_TOAN.MA_TRA_P, HD_THANH_TOAN.NGAY_THANH_TOAN, HD_THANH_TOAN.HINH_THUC, HD_THANH_TOAN.MA_HD_DV), ServiceInvoices AS (" +
                    " SELECT KHACH_HANG.MA_KH, SUM(DV.GIA_DV * DDV.SO_LUONG) AS TONG_TIEN_DV FROM KHACH_HANG INNER JOIN HD_DICH_VU HD ON KHACH_HANG.MA_KH = HD.MA_KH INNER JOIN DAT_DICH_VU DDV ON HD.MA_HD_DV = DDV.MA_HD_DV INNER JOIN " +
                    " DICH_VU DV ON DDV.MA_DV = DV.MA_DV GROUP BY KHACH_HANG.MA_KH) SELECT RoomInvoices.MA_HD_TP AS [Ma_HD_Tong], RoomInvoices.MA_TRA_P AS [Ma_Tr_P], RoomInvoices.MA_HD_DV AS [Ma_HD_DV], RoomInvoices.NGAY_THANH_TOAN AS [Ngay_Thanh_Toan]," +
                    " RoomInvoices.HINH_THUC AS [Hinh_Thuc], ISNULL(RoomInvoices.TONG_TIEN_PHONG, 0) + ISNULL(ServiceInvoices.TONG_TIEN_DV, 0) AS [TT_HD] FROM KHACH_HANG LEFT JOIN RoomInvoices ON KHACH_HANG.MA_KH = RoomInvoices.MA_KH" +
                    " LEFT JOIN ServiceInvoices ON KHACH_HANG.MA_KH = ServiceInvoices.MA_KH WHERE RoomInvoices.TEN_PHONG IS NOT NULL;";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                a.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public static void Load_Tim_Kiem(DataGridView a, TextBox tungay, TextBox denngay)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                DateTime tungay1;
                DateTime denngay1;
                if (DateTime.TryParseExact(tungay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tungay1) && DateTime.TryParseExact(denngay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out denngay1))
                {
                    if (denngay1 <= tungay1)
                    {
                        MessageBox.Show("Ngày đến phải lớn hơn ngày bắt đầu.");
                    }
                    else
                    {
                        connection = new SqlConnection(str);
                        connection.Open();
                        command = connection.CreateCommand();
                        command.CommandText = "DECLARE @NgayBatDau DATE = CONVERT(DATE, '" + tungay.Text + "' + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103); DECLARE @NgayKetThuc DATE = CONVERT(DATE, '" + denngay.Text + "' + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103); WITH RoomInvoices AS ( SELECT HD_THANH_TOAN.MA_HD_TP, HD_THANH_TOAN.MA_TRA_P, HD_THANH_TOAN.MA_HD_DV, FORMAT( HD_THANH_TOAN.NGAY_THANH_TOAN, 'HH:mm:ss dd/MM/yyyy')" +
                            " As NGAY_THANH_TOAN, HD_THANH_TOAN.HINH_THUC, KHACH_HANG.MA_KH, PHONG.TEN_PHONG, SUM(DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG) AS TONG_TIEN_PHONG FROM KHACH_HANG INNER JOIN THUE_PHONG ON KHACH_HANG.MA_KH = THUE_PHONG.MA_KH INNER JOIN" +
                            " PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG INNER JOIN TRA_PHONG ON THUE_PHONG.MA_THUE_P = TRA_PHONG.MA_THUE_P INNER JOIN HD_THANH_TOAN ON TRA_PHONG.MA_TRA_P = HD_THANH_TOAN.MA_TRA_P WHERE HD_THANH_TOAN.NGAY_THANH_TOAN BETWEEN @NgayBatDau AND @NgayKetThuc" +
                            " GROUP BY KHACH_HANG.MA_KH, PHONG.TEN_PHONG, HD_THANH_TOAN.MA_HD_TP, HD_THANH_TOAN.MA_TRA_P, HD_THANH_TOAN.NGAY_THANH_TOAN, HD_THANH_TOAN.HINH_THUC, HD_THANH_TOAN.MA_HD_DV), ServiceInvoices AS ( SELECT KHACH_HANG.MA_KH, SUM(DV.GIA_DV * DDV.SO_LUONG) AS TONG_TIEN_DV" +
                            " FROM KHACH_HANG INNER JOIN HD_DICH_VU HD ON KHACH_HANG.MA_KH = HD.MA_KH INNER JOIN DAT_DICH_VU DDV ON HD.MA_HD_DV = DDV.MA_HD_DV INNER JOIN DICH_VU DV ON DDV.MA_DV = DV.MA_DV GROUP BY KHACH_HANG.MA_KH) SELECT RoomInvoices.MA_HD_TP AS [Ma_HD_Tong]," +
                            " RoomInvoices.MA_TRA_P AS [Ma_Tr_P], RoomInvoices.MA_HD_DV AS [Ma_HD_DV], RoomInvoices.NGAY_THANH_TOAN AS [Ngay_Thanh_Toan], RoomInvoices.HINH_THUC AS [Hinh_Thuc], ISNULL(RoomInvoices.TONG_TIEN_PHONG, 0) + ISNULL(ServiceInvoices.TONG_TIEN_DV, 0) AS [TT_HD]" +
                            " FROM KHACH_HANG LEFT JOIN RoomInvoices ON KHACH_HANG.MA_KH = RoomInvoices.MA_KH LEFT JOIN ServiceInvoices ON KHACH_HANG.MA_KH = ServiceInvoices.MA_KH WHERE RoomInvoices.TEN_PHONG IS NOT NULL;";
                        adapter.SelectCommand = command;
                        table.Clear();
                        adapter.Fill(table);
                        a.DataSource = table;
                    }
                }
                else
                {
                    MessageBox.Show("Định dạng ngày không hợp lệ dd/MM/yyyy.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        public static void Load_P(DataGridView a)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT TRA_PHONG.MA_TRA_P, PHONG.TEN_PHONG, FORMAT(THUE_PHONG.NGAY_DEN, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DEN, FORMAT(TRA_PHONG.NGAY_DI, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DI, " +
                    "DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) AS SO_NGAY_O, PHONG.GIA_PHONG, DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG AS THANH_TIEN " +
                    "FROM TRA_PHONG INNER JOIN THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN KHACH_HANG ON KHACH_HANG.MA_KH = THUE_PHONG.MA_KH INNER JOIN PHONG ON " +
                    "THUE_PHONG.MA_PHONG = PHONG.MA_PHONG;";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                a.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public static void Load_Tim_Kiem_P(DataGridView a, TextBox tungay, TextBox denngay)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                DateTime tungay1;
                DateTime denngay1;
                if (DateTime.TryParseExact(tungay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tungay1) && DateTime.TryParseExact(denngay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out denngay1))
                {
                    if (denngay1 <= tungay1)
                    {
                        MessageBox.Show("Ngày đến phải lớn hơn ngày bắt đầu.");
                    }
                    else
                    {
                        connection = new SqlConnection(str);
                        connection.Open();
                        command = connection.CreateCommand();
                        command.CommandText = "DECLARE @NgayBatDau DATE = CONVERT(DATE, '" + tungay.Text + "' + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103); " +
                            "DECLARE @NgayKetThuc DATE = CONVERT(DATE, '" + denngay.Text + "' + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103); " +
                            " SELECT TRA_PHONG.MA_TRA_P, PHONG.TEN_PHONG, FORMAT(THUE_PHONG.NGAY_DEN, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DEN, FORMAT(TRA_PHONG.NGAY_DI, 'HH:mm:ss dd/MM/yyyy') AS NGAY_DI, DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) AS SO_NGAY_O, PHONG.GIA_PHONG, DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG AS THANH_TIEN FROM TRA_PHONG INNER JOIN THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN " +
                            " KHACH_HANG ON KHACH_HANG.MA_KH = THUE_PHONG.MA_KH INNER JOIN PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG INNER JOIN HD_THANH_TOAN ON TRA_PHONG.MA_TRA_P = HD_THANH_TOAN.MA_TRA_P WHERE HD_THANH_TOAN.NGAY_THANH_TOAN BETWEEN @NgayBatDau AND @NgayKetThuc;";
                        adapter.SelectCommand = command;
                        table.Clear();
                        adapter.Fill(table);
                        a.DataSource = table;
                    }
                }
                else
                {
                    MessageBox.Show("Định dạng ngày không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public static void Load_DV(DataGridView a)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT HD.MA_HD_DV, KH.TEN_KH, PHONG.TEN_PHONG, FORMAT(HD.NGAY_LAP, 'HH:mm:ss dd/MM/yyyy') AS NGAY_LAP, TRANG_THAI, " +
                    " CAST(COALESCE(CASE WHEN SUM(DV.GIA_DV * DDV.SO_LUONG) = 0 THEN '' ELSE CAST(SUM(DV.GIA_DV * DDV.SO_LUONG) AS VARCHAR(10)) END, '') AS VARCHAR(10)) AS TONG_TIEN_DV " +
                    " FROM HD_DICH_VU HD JOIN " +
                    " KHACH_HANG KH ON HD.MA_KH = KH.MA_KH JOIN " +
                    " PHONG ON HD.MA_PHONG = PHONG.MA_PHONG JOIN " +
                    " NHAN_VIEN NV ON HD.MA_NV = NV.MA_NV JOIN " +
                    " DAT_DICH_VU DDV ON HD.MA_HD_DV = DDV.MA_HD_DV JOIN " +
                    " DICH_VU DV ON DDV.MA_DV = DV.MA_DV " +
                    " GROUP BY HD.MA_HD_DV, HD.MA_KH, KH.TEN_KH, PHONG.TEN_PHONG, HD.MA_NV, HD.NGAY_LAP, TRANG_THAI " +
                    " ORDER BY HD.MA_HD_DV; ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                a.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public static void Load_Tim_Kiem_DV(DataGridView a, TextBox tungay, TextBox denngay)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            try
            {
                DateTime tungay1;
                DateTime denngay1;
                if (DateTime.TryParseExact(tungay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tungay1) && DateTime.TryParseExact(denngay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out denngay1))
                {
                    if (denngay1 <= tungay1)
                    {
                        MessageBox.Show("Ngày đến phải lớn hơn ngày bắt đầu.");
                    }
                    else
                    {
                        connection = new SqlConnection(str);
                        connection.Open();
                        command = connection.CreateCommand();
                        command.CommandText = "DECLARE @NgayBatDau DATE = CONVERT(DATE, '" + tungay.Text + "' + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103); " +
                            "DECLARE @NgayKetThuc DATE = CONVERT(DATE, '" + denngay.Text + "' + ' ' + CONVERT(varchar(8), GETDATE(), 108), 103); " +
                            "SELECT HD.MA_HD_DV, KH.TEN_KH, PHONG.TEN_PHONG, FORMAT(HD.NGAY_LAP, 'HH:mm:ss dd/MM/yyyy') AS NGAY_LAP, TRANG_THAI, " +
                            " CAST(COALESCE(CASE WHEN SUM(DV.GIA_DV * DDV.SO_LUONG) = 0 THEN '' ELSE CAST(SUM(DV.GIA_DV * DDV.SO_LUONG) AS VARCHAR(10)) END, '') AS VARCHAR(10)) AS TONG_TIEN_DV " +
                            " FROM HD_DICH_VU HD JOIN " +
                            " KHACH_HANG KH ON HD.MA_KH = KH.MA_KH JOIN " +
                            " PHONG ON HD.MA_PHONG = PHONG.MA_PHONG JOIN " +
                            " NHAN_VIEN NV ON HD.MA_NV = NV.MA_NV JOIN " +
                            " DAT_DICH_VU DDV ON HD.MA_HD_DV = DDV.MA_HD_DV JOIN " +
                            " DICH_VU DV ON DDV.MA_DV = DV.MA_DV " +
                            " WHERE NGAY_LAP BETWEEN @NgayBatDau AND @NgayKetThuc " +
                            " GROUP BY HD.MA_HD_DV, HD.MA_KH, KH.TEN_KH, PHONG.TEN_PHONG, HD.MA_NV, HD.NGAY_LAP, TRANG_THAI " +
                            " ORDER BY HD.MA_HD_DV; "; 
                        adapter.SelectCommand = command;
                        table.Clear();
                        adapter.Fill(table);
                        a.DataSource = table;
                    }
                }
                else
                {
                    MessageBox.Show("Định dạng ngày không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
