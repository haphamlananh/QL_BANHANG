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
    public partial class UC_Nhanvien : UserControl
    {
        public UC_Nhanvien()
        {
            InitializeComponent();
        }
        FunctionTest fn = new FunctionTest();
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        String query, queryy, query2;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void LoadTK()
        {
            query = "Select * From NHANVIEN";
            DataSet ds = fn.getData(query);
            DatagridView2.DataSource = ds.Tables[0];
            LayLuong();
        }
        private void LayLuong()
        {
            DataTable dta = new DataTable();

            dta = ketnoi.LayDulieu("Select ma_nv FROM NHANVIEN Group by ma_nv");
            TKManhanvien.DataSource = dta;
            TKManhanvien.DisplayMember = "ma_nv";
            TKManhanvien.ValueMember = "ma_nv";

            dta = ketnoi.LayDulieu("Select * from NHANVIEN");
            TKTenNhanvien.DataSource = dta;
            TKTenNhanvien.DisplayMember = "ho_ten";
            TKTenNhanvien.ValueMember = "ho_ten";
        }

        private void Laymanv()
        {
            DataTable dta = new DataTable();

            dta = ketnoi.LayDulieu("Select ma_nv FROM NHANVIEN Group by ma_nv");
            manv.DataSource = dta;
            manv.DisplayMember = "ma_nv";
            manv.ValueMember = "ma_nv";
        }

        private void UC_Nhanvien_Load(object sender, EventArgs e)
        {
            query = "Select * From NHANVIEN";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
            LoadTK();
            Hienthidulieu();
            queryy = "Select * From v_tonghopluong";
            DataSet dss = fn.getData(queryy);
            dataGridView3.DataSource = dss.Tables[0];
            Hienthidulieu3();
            Laymanv();
        }

        private void AddnewButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            Manhanvien.Clear();
            Tennhanvien.Clear();
            Gioitinh.Clear();
            Ngaysinh.Clear();
            sdt.Clear();
            Diachi.Clear();
        }

        private void AddnewButton_Enter(object sender, EventArgs e)
        {
            UC_Nhanvien_Load(this, null);
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Tennhanvien.Text != "" && Gioitinh.Text != "" && Ngaysinh.Text != "" && sdt.Text != "" && Diachi.Text != "")
            {

                String ten_nhanvien = Tennhanvien.Text;
                String gioitinh = Gioitinh.Text;
                String ngaysinh = Ngaysinh.Text;
                String SDT = sdt.Text;


                String dia_chi = Diachi.Text;



                query = "Insert into NHANVIEN ( ho_ten, gioi_tinh, ngay_sinh, SDT, dia_chi) values (N'" + ten_nhanvien + "',N'" + gioitinh + "','" + ngaysinh + "','" + SDT + "',N'" + dia_chi + "')";

                fn.setData(query, "Thêm thành công.");
                UC_Nhanvien_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (Tennhanvien.Text != "" && Gioitinh.Text != "" && Ngaysinh.Text != "" && sdt.Text != "" && Diachi.Text != "")
            {
                String ma_nv = Manhanvien.Text;

                String ho_ten = Tennhanvien.Text;
                String gioi_tinh = Gioitinh.Text;
                String ngaysinh = Ngaysinh.Text;
                Int64 SDT = Int64.Parse(sdt.Text);


                String dia_chi = Diachi.Text;


                query = "Update NHANVIEN Set ho_ten=N'" + Tennhanvien.Text + "',gioi_tinh=N'" + Gioitinh.Text + "',ngay_sinh='" + Ngaysinh.Text + "',SDT='" + sdt.Text + "',dia_chi=N'" + Diachi.Text + "' where ma_nv='" + Manhanvien.Text + "'";



                fn.setData(query, "Cập nhật thành công.");
                UC_Nhanvien_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String ma_nhanvien = Manhanvien.Text;
            query2 = "Delete From NHANVIEN where ma_nv='" + Manhanvien.Text + "'";

            fn.setData(query2, "Thực hiện xóa thành công.");


            UC_Nhanvien_Load(this, null);
            ClearAll();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            UC_Nhanvien_Load(sender, e);
        }

        private void taomoi_Click(object sender, EventArgs e)
        {
            ClearAlll();
        }
        public void ClearAlll()
        {
            // manv.clear();
            macc.Clear();
            hsluong.Clear();
            sogio.Clear();
            thang.Clear();
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (manv.Text != "" && hsluong.Text != "" && sogio.Text != "" && thang.Text != "")
            {

                String ma_nhanvien = manv.Text;

                Int64 sogioo = Int64.Parse(sogio.Text);

                float hesol = float.Parse(hsluong.Text);
                Int64 thangg = Int64.Parse(thang.Text);


                queryy = "Insert into CHAMCONG (ma_nv, thang, tong_so_gio, hs_luong) values (N'" + manv.Text + "',N'" + thang.Text + "','" + sogio.Text + "','" + hsluong.Text + "')";

                fn.setData(queryy, "Thêm thành công.");
                UC_Nhanvien_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (manv.Text != "" && thang.Text != "" && sogio.Text != "" && hsluong.Text != "")
            {
                String ma_cc = macc.Text;

                String manhanv = manv.Text;
                Int64 sogioo = Int64.Parse(sogio.Text);
                Int64 hesol = Int64.Parse(hsluong.Text);
                Int64 thangg = Int64.Parse(thang.Text);


                String dia_chi = Diachi.Text;


                queryy = "Update CHAMCONG Set ma_nv=N'" + manv.Text + "',thang=N'" + thang.Text + "',tong_so_gio=N'" + sogio.Text + "',hs_luong='" + hsluong.Text + "' where ma_cc='" + macc.Text + "'";



                fn.setData(queryy, "Cập nhật thành công.");
                UC_Nhanvien_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            String ma_chamcong = macc.Text;
            query2 = "Delete From CHAMCONG where ma_cc='" + macc.Text + "'";

            fn.setData(query2, "Thực hiện xóa thành công.");


            UC_Nhanvien_Load(this, null);
            ClearAlll();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (OptionTimmTenNV.Checked == true)
            {

                sqltk = "Select * From NHANVIEN where ho_ten like N'%" + TKTenNhanvien.Text + "%' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else if (OptManhanvien.Checked == true)
            {

                sqltk = "Select * From NHANVIEN where ma_nv like N'%" + TKManhanvien.Text + "%' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else
            {
                MessageBox.Show("Chưa lựa chọn tìm kiếm.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DatagridView2.DataSource = dta;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            UC_Nhanvien_Load(this, null);
        }

        private void Diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hienthidulieu()
        {

            Manhanvien.DataBindings.Clear();
            Manhanvien.DataBindings.Add("Text", DataGridView1.DataSource, "ma_nv");

            Tennhanvien.DataBindings.Clear();
            Tennhanvien.DataBindings.Add("Text", DataGridView1.DataSource, "ho_ten");

            Gioitinh.DataBindings.Clear();
            Gioitinh.DataBindings.Add("Text", DataGridView1.DataSource, "gioi_tinh");

            Ngaysinh.DataBindings.Clear();
            Ngaysinh.DataBindings.Add("Text", DataGridView1.DataSource, "ngay_sinh");

            sdt.DataBindings.Clear();
            sdt.DataBindings.Add("Text", DataGridView1.DataSource, "SDT");

            Diachi.DataBindings.Clear();
            Diachi.DataBindings.Add("Text", DataGridView1.DataSource, "dia_chi");

        }

        private void Hienthidulieu3()
        {

            manv.DataBindings.Clear();
            manv.DataBindings.Add("Text", dataGridView3.DataSource, "ma_nv");

            macc.DataBindings.Clear();
            macc.DataBindings.Add("Text", dataGridView3.DataSource, "ma_cc");

            hsluong.DataBindings.Clear();
            hsluong.DataBindings.Add("Text", dataGridView3.DataSource, "hs_luong");

            sogio.DataBindings.Clear();
            sogio.DataBindings.Add("Text", dataGridView3.DataSource, "tong_so_gio");

            thang.DataBindings.Clear();
            thang.DataBindings.Add("Text", dataGridView3.DataSource, "thang");

        }
    }
}
