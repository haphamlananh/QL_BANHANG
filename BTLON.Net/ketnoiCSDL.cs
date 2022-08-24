using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BTLON.Net
{
    class ketnoiCSDL
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable Dta;
        public SqlDataAdapter ada;

        public void KetNoi_Dulieu()
        {
            string StrgKetNoi = "Data Source=HPLA\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True"; //Change name and database
            cnn = new SqlConnection(StrgKetNoi);
            cnn.Open();

        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable LayDulieu(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            Dta = new DataTable();
            ada.Fill(Dta);
            return Dta;
        }


        public void Execute(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
