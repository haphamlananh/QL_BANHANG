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
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        ketnoiCSDL ketnoi = new ketnoiCSDL();
        FunctionTest fn = new FunctionTest();
        String query;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = ketnoi.LayDulieu("Select * FROM QUAY");
            comboBoxQuay.DataSource = dta;
            comboBoxQuay.DisplayMember = "ma_quay";
            comboBoxQuay.ValueMember = "ma_quay";

            dta = ketnoi.LayDulieu("Select * FROM NHANVIEN");
            comboBoxMaNV.DataSource = dta;
            comboBoxMaNV.DisplayMember = "ma_nv";
            comboBoxMaNV.ValueMember = "ma_nv";

            dta = ketnoi.LayDulieu("Select * FROM KHACHHANG");
            comboBoxMaKH.DataSource = dta;
            comboBoxMaKH.DisplayMember = "ma_kh";
            comboBoxMaKH.ValueMember = "ma_kh";

            dta = ketnoi.LayDulieu("Select * FROM HANGHOA");
            comboBoxMaHH.DataSource = dta;
            comboBoxMaHH.DisplayMember = "ma_hang_hoa";
            comboBoxMaHH.ValueMember = "ma_hang_hoa";

        }

        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            if (comboBoxQuay.Text != "" && comboBoxMaNV.Text != "" && comboBoxMaKH.Text != "")
            {
                query = $"insert into HANGHOA (ma_nv, ma_quay, ma_kh, ngay_lap_hd) values ('{comboBoxMaNV.Text.ToString()}', '{comboBoxQuay.Text.ToString()}', '{comboBoxMaKH.Text.ToString()}', '{dateTimePickerNgayBan.Value.ToString()}')";
                ketnoi.Execute(query);
            }
        }


        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTenNV.Items.Clear();
            query = "Select ho_ten from NHANVIEN where ma_nv= '" + comboBoxMaNV.Text + "';";

            setCombobox(query, comboBoxTenNV);
        }


        private void comboBoxTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxCCCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void setCombobox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetValue(i).ToString());
                }

            }
            sdr.Close();
        }

        private void comboBoxMaHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTenHH.Items.Clear();
            query = "Select ten_hang_hoa  from HANGHOA where ma_hang_hoa = '" + comboBoxMaHH.Text + "';";
            setCombobox(query, comboBoxTenHH);

            comboBoxDonGia.Items.Clear();
            query = "Select don_gia from HANGHOA where ma_hang_hoa = '" + comboBoxMaHH.Text + "';";
            setCombobox(query, comboBoxDonGia);
        }

        private void comboBoxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTenKH.Items.Clear();
            query = "Select ho_ten from KHACHHANG where ma_kh= '" + comboBoxMaKH.Text + "';";
            setCombobox(query, comboBoxTenKH);

            comboBoxCCCD.Items.Clear();
            query = "Select cccd from KHACHHANG where ma_kh= '" + comboBoxMaKH.Text + "';";
            setCombobox(query, comboBoxCCCD);

            comboBoxDiaChi.Items.Clear();
            query = "Select dia_chi from KHACHHANG where ma_kh= '" + comboBoxMaKH.Text + "';";
            setCombobox(query, comboBoxDiaChi);
        }

        private void buttonHuyHD_Click(object sender, EventArgs e)
        {
            
        }
    }
}
