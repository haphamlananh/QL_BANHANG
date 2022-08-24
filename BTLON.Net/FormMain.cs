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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            uC_HangHoa1.Visible = false;
            uC_KhachHang1.Visible = false;
            uC_CrystalReport1.Visible = false;
            uC_Nhanvien1.Visible = false;
            uC_HoaDon1.Visible = false;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void MaximizeButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(MaximizeButton, "Maximize");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            System.Windows.Forms.Application.ExitThread();
        }

        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CloseButton, "Exit");
        }

        private void MinimizeButton_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(MinimizeButton, "Minimize");
        
        }
       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void QLHangHoaButton_Click(object sender, EventArgs e)
        {
            uC_HangHoa1.Visible = true;
            uC_HangHoa1.BringToFront();

            uC_KhachHang1.Visible = false;
            uC_CrystalReport1.Visible = false;
            uC_Nhanvien1.Visible = false;
            uC_HoaDon1.Visible = false;
        }

        private void CustomerManagementButton_Click(object sender, EventArgs e)
        {
            uC_KhachHang1.Visible = true;
            uC_KhachHang1.BringToFront();

            uC_HangHoa1.Visible = false;
            uC_CrystalReport1.Visible = false;
            uC_Nhanvien1.Visible = false;
            uC_HoaDon1.Visible = false;
        }

        private void CReportButton_Click(object sender, EventArgs e)
        {
            uC_CrystalReport1.Visible = true;
            uC_CrystalReport1.BringToFront();

            uC_HangHoa1.Visible = false;
            uC_KhachHang1.Visible = false;
            uC_Nhanvien1.Visible = false;
            uC_HoaDon1.Visible = false;
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            uC_Nhanvien1.Visible = true;
            uC_Nhanvien1.BringToFront();

            uC_HangHoa1.Visible = false;
            uC_KhachHang1.Visible = false;
            uC_CrystalReport1.Visible = false;
            uC_HoaDon1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_Nhanvien1_Load(object sender, EventArgs e)
        {

        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            uC_HoaDon1.Visible = true;
            uC_HoaDon1.BringToFront();

            uC_HangHoa1.Visible = false;
            uC_KhachHang1.Visible = false;
            uC_CrystalReport1.Visible = false;
            uC_Nhanvien1.Visible = false;
        }
    }
}
