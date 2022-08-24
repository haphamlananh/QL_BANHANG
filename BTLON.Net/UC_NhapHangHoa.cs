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
    public partial class UC_NhapHangHoa : UserControl
    {
        public UC_NhapHangHoa()
        {
            InitializeComponent();
        }
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        private void UC_NhapHangHoa_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            string sql2;
            sql2 = "Update NHAPHANGHOA Set ngay_nhap = '" + txtNgaynhap.Text + "',so_luong_nhap = '" + txtSoluong.Text + "',ma_hang_hoa = '" + cboMaHH.Text + "'  WHERE id = '" + txtID.Text + "'";
            ketnoi.Execute(sql2);
            LAYBANG_NHAPHANGHOA();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql3 = "Delete FROM NHAPHANGHOA WHERE id = '" + txtID.Text + "'";
            ketnoi.Execute(sql3);
            LAYBANG_NHAPHANGHOA();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
