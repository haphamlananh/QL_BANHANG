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
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        FunctionTest fn = new FunctionTest();
        String query;
        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            LAYBANG_KHACHHANG();
            Hienthi_Dulieu();
        }
        public void LAYBANG_KHACHHANG()
        {


            query = "Select * From KHACHHANG";
            DataSet ds = fn.getData(query);
            DataGrid.DataSource = ds.Tables[0];

        }
        private void Hienthi_Dulieu()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", DataGrid.DataSource, "ma_kh");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", DataGrid.DataSource, "ho_ten");

            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", DataGrid.DataSource, "SDT");

            txtCCCD.DataBindings.Clear();
            txtCCCD.DataBindings.Add("Text", DataGrid.DataSource, "cccd");

            txtGioitinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Add("Text", DataGrid.DataSource, "gioi_tinh");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", DataGrid.DataSource, "dia_chi");
        }

        private void CreateNewbutton_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtCCCD.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            txtGioitinh.Text = "";
            txtMaKH.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string sql1 = "Insert into KHACHHANG Values('" + txtTenKH.Text + "', '" + txtDienthoai.Text + "', '" + txtCCCD.Text + "', '" + txtDiachi.Text + "', '" + txtGioitinh.Text + "' )";
            ketnoi.Execute(sql1);
            LAYBANG_KHACHHANG();
        }

        private void EdditButton_Click(object sender, EventArgs e)
        {
            string sql2;
            sql2 = "Update KHACHHANG Set ho_ten = '" + txtTenKH.Text + "', SDT = '" + txtDienthoai.Text + "', cccd = '" + txtCCCD.Text + "', gioi_tinh = '" + txtGioitinh.Text + "', dia_chi = '" + txtDiachi.Text + "'  WHERE ma_kh = '" + txtMaKH.Text + "'";
            ketnoi.Execute(sql2);
            LAYBANG_KHACHHANG();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string sql3 = "Delete FROM KHACHHANG WHERE ma_kh = '" + txtMaKH.Text + "'";
            ketnoi.Execute(sql3);
            LAYBANG_KHACHHANG();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
