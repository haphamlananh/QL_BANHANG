using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLON.Net
{
    public partial class UC_CrystalReport : UserControl
    {
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        public UC_CrystalReport()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UC_CrystalReport_Load(object sender, EventArgs e)
        {
            LoadTKHoadon();
            LoadCRHoadon();
            LoadTKNV();
            LoadCRNV();

        }
        private void LoadTKHoadon()
        {
            DataTable dta = ketnoi.LayDulieu("Select * from HOADON");
            cboNhapma.DataSource = dta;
            cboNhapma.DisplayMember = "ma_hd";
            cboNhapma.ValueMember = "ma_hd";


        }
        private void LoadCRHoadon()
        {
            DataTable dta = new DataTable();
            string sqltk = "Select * from v_chi_tiet_hoa_don ";
            dta = ketnoi.LayDulieu(sqltk);
            CRHoadon baocao_hd = new CRHoadon(); // khởi tạo báo cáo
            baocao_hd.SetDataSource(dta);
            crystalReportViewer1.ReportSource = baocao_hd;
        }

        private void LoadTKNV()
        {
            DataTable dta = ketnoi.LayDulieu("Select * from NHANVIEN");
            cboMaNV.DataSource = dta;
            cboMaNV.DisplayMember = "ma_nv";
            cboMaNV.ValueMember = "ma_nv";

            cboMaNV.SelectedIndex = -1;
        }

        private void LoadCRNV()
        {
            DataTable dta = new DataTable();
            string sqltk = "Select * from v_tonghopluong ";
            dta = ketnoi.LayDulieu(sqltk);
            CRLuong baocao_luong = new CRLuong(); // khởi tạo báo cáo
            baocao_luong.SetDataSource(dta);
            crystalReportViewer2.ReportSource = baocao_luong;
        }


        private void btnTimkiemHoadon_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk = "Select * from v_chi_tiet_hoa_don where ma_hd like'" + cboNhapma.Text + "' ";
            dta = ketnoi.LayDulieu(sqltk);
            CRHoadon baocao_hd = new CRHoadon(); // khởi tạo báo cáo
            baocao_hd.SetDataSource(dta);
            crystalReportViewer1.ReportSource = baocao_hd;
        }

        private void btnTimkiemNV_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk = "Select * from v_tonghopluong where ma_nv like'" + cboMaNV.Text + "' ";
            dta = ketnoi.LayDulieu(sqltk);
            CRLuong baocao_luong = new CRLuong(); // khởi tạo báo cáo
            baocao_luong.SetDataSource(dta);
            crystalReportViewer2.ReportSource = baocao_luong;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            UC_CrystalReport_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UC_CrystalReport_Load(sender, e);
        }
    }
}
