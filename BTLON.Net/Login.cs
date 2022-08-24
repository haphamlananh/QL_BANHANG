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
using System.Data.Sql;

namespace BTLON.Net
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketnoi.KetNoi_Dulieu();
            string TK = Username.Text;
            string MK = Password.Text;

            string sql_login = "Select ten_dang_nhap,mat_khau From DANGNHAP where ten_dang_nhap='" + TK + "' and mat_khau='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sql_login, ketnoi.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read() == true)
            {
                MessageBox.Show("Dang Nhap thanh cong", "Thong bao", MessageBoxButtons.OK);
                Form FMain = new FormMain();
                FMain.Show();
                Visible = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
