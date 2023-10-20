using CrystalDecisions.CrystalReports.Engine;
using DA_QL_KS.DAL;
using DA_QL_KS.Report_HD;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=DESKTOP-R6CHIHR;Initial Catalog=QL_KHACH_SAN;Integrated Security=True";

            String ma_hd_tong = Save_Variable.ma_hd_tong_in_hd_xem;
            String ma_tr_phong = Save_Variable.ma_tr_p_in_hd_xem;
            String ma_hd_dich_vu = Save_Variable.ma_hd_dv_in_hd_xem;

            In_Hoa_Don rpt = new In_Hoa_Don();

            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter dap1 = new SqlDataAdapter("SELECT DICH_VU.TEN_DV, SO_LUONG, DICH_VU.DON_VI, DICH_VU.GIA_DV, DICH_VU.GIA_DV*SO_LUONG AS THANH_TIEN " +
                "FROM DAT_DICH_VU INNER JOIN DICH_VU ON DAT_DICH_VU.MA_DV = DICH_VU.MA_DV INNER JOIN " +
                "HD_DICH_VU ON DAT_DICH_VU.MA_HD_DV = HD_DICH_VU.MA_HD_DV " +
                "WHERE HD_DICH_VU.MA_HD_DV = '" + ma_hd_dich_vu + "';", conn);
            DataSet ds1 = new DataSet();
            dap1.Fill(ds1);


            SqlDataAdapter dap2 = new SqlDataAdapter("SELECT PHONG.TEN_PHONG, FORMAT(THUE_PHONG.NGAY_DEN, 'dd/MM/yyyy') AS NGAY_DEN, FORMAT(TRA_PHONG.NGAY_DI, 'dd/MM/yyyy') AS NGAY_DI, DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) AS SO_NGAY_O, PHONG.GIA_PHONG, DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG AS THANH_TIEN FROM TRA_PHONG INNER JOIN THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN " +
                "KHACH_HANG ON KHACH_HANG.MA_KH = THUE_PHONG.MA_KH INNER JOIN PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG INNER JOIN HD_THANH_TOAN ON TRA_PHONG.MA_TRA_P = HD_THANH_TOAN.MA_TRA_P " +
                "WHERE HD_THANH_TOAN.MA_HD_TP = '" + ma_hd_tong + "' AND TRA_PHONG.MA_TRA_P = '" + ma_tr_phong + "';", conn);
            DataSet ds2 = new DataSet();
            dap2.Fill(ds2);

            SqlDataAdapter dap3 = new SqlDataAdapter("SELECT HD_THANH_TOAN.MA_HD_TP, FORMAT(HD_THANH_TOAN.NGAY_THANH_TOAN, 'HH:mm:ss dd/MM/yyyy') AS NGAY_THANH_TOAN, HD_THANH_TOAN.HINH_THUC, KHACH_HANG.TEN_KH, KHACH_HANG.SDT, KHACH_HANG.CNMD, KHACH_HANG.DIA_CHI, PHONG.TEN_PHONG " +
                "FROM HD_THANH_TOAN INNER JOIN TRA_PHONG ON HD_THANH_TOAN.MA_TRA_P = TRA_PHONG.MA_TRA_P INNER JOIN " +
                "THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN NHAN_VIEN ON THUE_PHONG.MA_NV = NHAN_VIEN.MA_NV INNER JOIN " +
                "KHACH_HANG ON THUE_PHONG.MA_KH = KHACH_HANG.MA_KH INNER JOIN PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG " +
                "WHERE HD_THANH_TOAN.MA_HD_TP = '" + ma_hd_tong + "' AND TRA_PHONG.MA_TRA_P = '" + ma_tr_phong + "';", conn);
            DataSet ds3 = new DataSet();
            dap3.Fill(ds3);

            SqlDataAdapter dap4 = new SqlDataAdapter("SELECT DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG AS THANH_TIEN " +
                "FROM TRA_PHONG INNER JOIN THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN " +
                "PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG INNER JOIN HD_THANH_TOAN ON TRA_PHONG.MA_TRA_P = HD_THANH_TOAN.MA_TRA_P " +
                "WHERE HD_THANH_TOAN.MA_HD_TP = '" + ma_hd_tong + "' AND TRA_PHONG.MA_TRA_P = '" + ma_tr_phong + "'; ", conn);
            DataSet ds4 = new DataSet();
            dap4.Fill(ds4);

            SqlDataAdapter dap5 = new SqlDataAdapter("SELECT CAST(COALESCE(CASE WHEN SUM(DV.GIA_DV * DDV.SO_LUONG) = 0 THEN '' ELSE CAST(SUM(DV.GIA_DV * DDV.SO_LUONG) AS VARCHAR(10)) END, '') AS VARCHAR(10)) AS TONG_TIEN_DV " +
                "FROM HD_DICH_VU HD JOIN KHACH_HANG KH ON HD.MA_KH = KH.MA_KH JOIN NHAN_VIEN NV ON HD.MA_NV = NV.MA_NV LEFT JOIN DAT_DICH_VU DDV ON HD.MA_HD_DV = DDV.MA_HD_DV LEFT JOIN " +
                "DICH_VU DV ON DDV.MA_DV = DV.MA_DV " +
                "WHERE  HD.MA_HD_DV = '" + ma_hd_dich_vu + "' GROUP BY HD.MA_HD_DV, HD.MA_KH, KH.TEN_KH, HD.MA_PHONG, HD.MA_NV, HD.NGAY_LAP, TRANG_THAI ORDER BY HD.MA_HD_DV;", conn);
            DataSet ds5 = new DataSet();
            dap5.Fill(ds5);

            SqlDataAdapter dap6 = new SqlDataAdapter("WITH RoomInvoices AS ( SELECT HD_THANH_TOAN.MA_HD_TP, HD_THANH_TOAN.MA_TRA_P, HD_THANH_TOAN.MA_HD_DV, FORMAT( HD_THANH_TOAN.NGAY_THANH_TOAN, 'HH:mm:ss dd/MM/yyyy') As NGAY_THANH_TOAN, HD_THANH_TOAN.HINH_THUC, " +
                " KHACH_HANG.MA_KH, PHONG.TEN_PHONG, SUM(DATEDIFF(DAY, THUE_PHONG.NGAY_DEN, TRA_PHONG.NGAY_DI) * PHONG.GIA_PHONG) AS TONG_TIEN_PHONG FROM KHACH_HANG INNER JOIN THUE_PHONG ON KHACH_HANG.MA_KH = THUE_PHONG.MA_KH INNER JOIN " +
                " PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG INNER JOIN TRA_PHONG ON THUE_PHONG.MA_THUE_P = TRA_PHONG.MA_THUE_P INNER JOIN HD_THANH_TOAN ON TRA_PHONG.MA_TRA_P = HD_THANH_TOAN.MA_TRA_P GROUP BY " +
                " KHACH_HANG.MA_KH, PHONG.TEN_PHONG, HD_THANH_TOAN.MA_HD_TP, HD_THANH_TOAN.MA_TRA_P, HD_THANH_TOAN.NGAY_THANH_TOAN, HD_THANH_TOAN.HINH_THUC, HD_THANH_TOAN.MA_HD_DV), ServiceInvoices AS ( " +
                " SELECT KHACH_HANG.MA_KH, SUM(DV.GIA_DV * DDV.SO_LUONG) AS TONG_TIEN_DV FROM KHACH_HANG INNER JOIN HD_DICH_VU HD ON KHACH_HANG.MA_KH = HD.MA_KH INNER JOIN DAT_DICH_VU DDV ON HD.MA_HD_DV = DDV.MA_HD_DV INNER JOIN " +
                " DICH_VU DV ON DDV.MA_DV = DV.MA_DV GROUP BY KHACH_HANG.MA_KH) SELECT ISNULL(RoomInvoices.TONG_TIEN_PHONG, 0) + ISNULL(ServiceInvoices.TONG_TIEN_DV, 0) AS [Tong_Tien_HD] FROM KHACH_HANG LEFT JOIN RoomInvoices ON KHACH_HANG.MA_KH = RoomInvoices.MA_KH " +
                " LEFT JOIN ServiceInvoices ON KHACH_HANG.MA_KH = ServiceInvoices.MA_KH " +
                " WHERE RoomInvoices.TEN_PHONG IS NOT NULL and RoomInvoices.MA_HD_TP = '" + ma_hd_tong + "' and RoomInvoices.MA_TRA_P = '" + ma_tr_phong + "'; ", conn);
            DataSet ds6 = new DataSet();
            dap6.Fill(ds6);

            SqlDataAdapter dap7 = new SqlDataAdapter("SELECT FORMAT(HD_THANH_TOAN.NGAY_THANH_TOAN, 'dd') AS Ngay, KHACH_HANG.TEN_KH, NHAN_VIEN.HO_TEN_NV AS TEN_NV " +
                "FROM HD_THANH_TOAN INNER JOIN TRA_PHONG ON HD_THANH_TOAN.MA_TRA_P = TRA_PHONG.MA_TRA_P INNER JOIN " +
                "THUE_PHONG ON TRA_PHONG.MA_THUE_P = THUE_PHONG.MA_THUE_P INNER JOIN NHAN_VIEN ON THUE_PHONG.MA_NV = NHAN_VIEN.MA_NV INNER JOIN " +
                "KHACH_HANG ON THUE_PHONG.MA_KH = KHACH_HANG.MA_KH INNER JOIN PHONG ON THUE_PHONG.MA_PHONG = PHONG.MA_PHONG " +
                "WHERE HD_THANH_TOAN.MA_HD_TP = '" + ma_hd_tong + "' AND TRA_PHONG.MA_TRA_P = '" + ma_tr_phong + "';", conn);
            DataSet ds7 = new DataSet();
            dap7.Fill(ds7);


            rpt.Subreports["TT_HOA_DON.rpt"].SetDataSource(ds3.Tables[0]);
            rpt.Subreports["Bang_Thue_P.rpt"].SetDataSource(ds2.Tables[0]);
            rpt.Subreports["Bang_Dich_Vu.rpt"].SetDataSource(ds1.Tables[0]);

            rpt.Subreports["Tong_Tien_Phong.rpt"].SetDataSource(ds4.Tables[0]);

            rpt.Subreports["Tong_Tien_HD.rpt"].SetDataSource(ds6.Tables[0]);

            rpt.Subreports["Tong_Tien_DV.rpt"].SetDataSource(ds5.Tables[0]);

            rpt.Subreports["Chu_Ky.rpt"].SetDataSource(ds7.Tables[0]);

            crystalReportViewer1.ReportSource = rpt;

            conn.Close();
        }
    }
}
