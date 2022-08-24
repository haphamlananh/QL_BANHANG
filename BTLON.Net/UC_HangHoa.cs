using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTLON.Net
{
    public partial class UC_HangHoa : UserControl
    {

        FunctionTest fn = new FunctionTest();
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        String query,query2;

        public UC_HangHoa()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UC_HangHoa_Load(object sender, EventArgs e)
        {
            query = "Select * From HANGHOA";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
            LoadTK();
            LoadNhapHang();
            Hienthidulieu();
        }
        private void LoadNhapHang()
        {
            LAYBANG_HANGHOA();
            LAYBANG_NHAPHANGHOA();
            Hienthi_Dulieu();
        }

        public void LAYBANG_NHAPHANGHOA()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.LayDulieu("Select * FROM NHAPHANGHOA");
            DataGrid_HH.DataSource = dta;
            Hienthi_Dulieu();
        }

        public void LAYBANG_HANGHOA()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.LayDulieu("Select * FROM HANGHOA");
            cboMaHH.DataSource = dta;
            cboMaHH.DisplayMember = "ma_hang_hoa";
            cboMaHH.ValueMember = "ma_hang_hoa";
        }

        private void Hienthi_Dulieu()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", DataGrid_HH.DataSource, "id");

            txtNgaynhap.DataBindings.Clear();
            txtNgaynhap.DataBindings.Add("Text", DataGrid_HH.DataSource, "ngay_nhap");

            txtSoluong.DataBindings.Clear();
            txtSoluong.DataBindings.Add("Text", DataGrid_HH.DataSource, "so_luong_nhap");

            cboMaHH.DataBindings.Clear();
            cboMaHH.DataBindings.Add("Text", DataGrid_HH.DataSource, "ma_hang_hoa");
        }
        private void LoadTK()
        {
            query = "Select * From HANGHOA";
            DataSet ds = fn.getData(query);
            DatagridView2.DataSource = ds.Tables[0];
            LayNhomhang();
        }
        private void LayNhomhang()
        {
            DataTable dta = new DataTable();

            dta = ketnoi.LayDulieu("Select ten_nhom_hang FROM HANGHOA Group by ten_nhom_hang");
            TKNhomHang.DataSource = dta;
            TKNhomHang.DisplayMember = "ten_nhom_hang";
            TKNhomHang.ValueMember = "ten_nhom_hang";
        }
        private void Hienthidulieu()
        {
            Mahanghoa.DataBindings.Clear();
            Mahanghoa.DataBindings.Add("Text", DataGridView1.DataSource, "ma_hang_hoa");



            Tennhomhang.DataBindings.Clear();
            Tennhomhang.DataBindings.Add("Text", DataGridView1.DataSource, "ten_nhom_hang");

            TenHanghoa.DataBindings.Clear();
            TenHanghoa.DataBindings.Add("Text", DataGridView1.DataSource, "ten_hang_hoa");

            SoluongHang.DataBindings.Clear();
            SoluongHang.DataBindings.Add("Text", DataGridView1.DataSource, "so_luong_ton_kho");

            Dongia.DataBindings.Clear();
            Dongia.DataBindings.Add("Text", DataGridView1.DataSource, "don_gia");

            Donvitinh.DataBindings.Clear();
            Donvitinh.DataBindings.Add("Text", DataGridView1.DataSource, "don_vi_tinh");

            ThueVAT.DataBindings.Clear();
            ThueVAT.DataBindings.Add("Text", DataGridView1.DataSource, "VAT");

        }

 

        private void AddnewButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            Tennhomhang.Clear();
            TenHanghoa.Clear();
            SoluongHang.Clear();
            Dongia.Clear();

            Donvitinh.Clear();
            ThueVAT.Clear();
            Mahanghoa.Clear();

          
        }

        private void UC_HangHoa_Enter(object sender, EventArgs e)
        {
            UC_HangHoa_Load(this, null);
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            UC_HangHoa_Load(this, null);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (Tennhomhang.Text != "" && TenHanghoa.Text != "" && SoluongHang.Text != "" && Dongia.Text != "" && Donvitinh.Text != "" && ThueVAT.Text != "")
            {
                String ma_hang_hoa = Mahanghoa.Text;
              
                String ten_nhom_hang = Tennhomhang.Text;
                string ten_hang_hoa = TenHanghoa.Text;
                Int64 so_luong_ton_kho = Int64.Parse(SoluongHang.Text);
                Int64 don_gia = Int64.Parse(Dongia.Text);

                String don_vi_tinh = Donvitinh.Text;

                float VAT = float.Parse(ThueVAT.Text);

                query = "Update HANGHOA Set ten_hang_hoa=N'" + TenHanghoa.Text + "',ten_nhom_hang=N'" + Tennhomhang.Text + "',don_gia='" + Dongia.Text + "',so_luong_ton_kho='" + SoluongHang.Text + "',don_vi_tinh=N'" + Donvitinh.Text + "',VAT='" + ThueVAT.Text + "' where ma_hang_hoa='" + Mahanghoa.Text + "'";

                fn.setData(query, "Cập nhật thành công.");
                UC_HangHoa_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String ma_hang_hoa = Mahanghoa.Text;
            query2 = "Delete From HANGHOA where ma_hang_hoa='" + Mahanghoa.Text + "'";

            fn.setData(query2, "Thực hiện xóa thành công.");


            UC_HangHoa_Load(this, null);
            ClearAll();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            UC_HangHoa_Load(sender, e);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (OptionTimTenSP.Checked == true)
            {
                TKNhomHang.SelectedIndex = -1;
                sqltk = "Select * From HANGHOA where ten_hang_hoa like N'%" + TKTenSP.Text + "%' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else if (OptTKLoaiHang.Checked == true)
            {
                TKTenSP.Text = "";
                sqltk = "Select * From HANGHOA where ten_nhom_hang like N'%" + TKNhomHang.Text + "%' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else
            {
                MessageBox.Show("Chưa lựa chọn tìm kiếm.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DatagridView2.DataSource = dta;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNgaynhap.Text = "";
            txtSoluong.Text = "";
            txtID.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into NHAPHANGHOA Values('" + cboMaHH.Text + "', '" + txtNgaynhap.Text + "', '" + txtSoluong.Text + "')";
            ketnoi.Execute(sql1);
            LAYBANG_NHAPHANGHOA();
        }

        private void EDditButton_Click(object sender, EventArgs e)
        {
            string sql2;
            sql2 = "Update NHAPHANGHOA Set ngay_nhap = '" + txtNgaynhap.Text + "',so_luong_nhap = '" + txtSoluong.Text + "',ma_hang_hoa = '" + cboMaHH.Text + "'  WHERE id = '" + txtID.Text + "'";
            ketnoi.Execute(sql2);
            LAYBANG_NHAPHANGHOA();
        }

        private void DeleeteButton_Click(object sender, EventArgs e)
        {
            string sql3 = "Delete FROM NHAPHANGHOA WHERE id = '" + txtID.Text + "'";
            ketnoi.Execute(sql3);
            LAYBANG_NHAPHANGHOA();
        }

        private void ExitBUtton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Tennhomhang.Text != "" && TenHanghoa.Text != "" && SoluongHang.Text != "" && Dongia.Text != "" && Donvitinh.Text != "" && ThueVAT.Text != "")
            {
                
                String ten_nhom_hang = Tennhomhang.Text;
                string ten_hang_hoa = TenHanghoa.Text;
                Int64 so_luong_ton_kho = Int64.Parse(SoluongHang.Text);
                Int64 don_gia = Int64.Parse(Dongia.Text);
                
                String don_vi_tinh = Donvitinh.Text;
             
                float VAT = float.Parse(ThueVAT.Text);
                


                query = "Insert into HANGHOA ( ten_nhom_hang,ten_hang_hoa, don_gia,so_luong_ton_kho, don_vi_tinh, VAT) values (N'" + ten_nhom_hang + "',N'" + ten_hang_hoa + "','" + so_luong_ton_kho + "','" + don_gia + "',N'" + don_vi_tinh + "','" + VAT + "')";

                fn.setData(query, "Thêm thành công.");
                UC_HangHoa_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
