using QL_BanSach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanSach
{
    public partial class F_BaoCao : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public static bool logined = false;
        const string url = "Data Source=NMC-DEVELOPER\\SQLEXPRESS;Initial Catalog=QL_NhaSach;User Id=sa;Password=Nmc170603;";
        public F_BaoCao()
        {
            InitializeComponent();
        }

        string CreateMaTK()
        {
            DateTime dt = dtime_ngaybd.Value;
            MessageBox.Show(dt.ToString());
            int ngaybd = dt.Day;
            int thangbd = dt.Month;
            int nambd = dt.Year;

            DateTime dt2 = dtime_ngkt.Value;
            MessageBox.Show(dt2.ToString());
            int ngaykt = dt2.Day;
            int thangkt = dt2.Month;
            int namkt = dt2.Year;

            string matk = "MK" + ngaybd + thangbd + nambd + "-" + ngaykt + thangkt + namkt;

            return matk;
        }
        private void F_BaoCao_Load(object sender, EventArgs e)
        {
            //thống kê tháng hiên tại;
            con = new SqlConnection(url);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                string sql = "SELECT Sach.MaSach,Sach.TenSach, Sach.GiaBan, iif(Sum(HoaDon.SoLuong) is null, 0, Sum(HoaDon.SoLuong)), " +
                    "iif(Sum(HoaDon.ThanhTien) is null, 0, Sum(HoaDon.ThanhTien))" +
                    "FROM Sach " +
                    "left join HoaDon on Sach.MaSach = HoaDon.MaSach " +
                    "group by Sach.MaSach, Sach.TenSach, Sach.GiaBan;";
                //// Tạo tham số và gán giá trị
                //cmd.Parameters.AddWithValue("@StartDate", new DateTime(year, month, 1));// ngày 1 của tháng;
                //cmd.Parameters.AddWithValue("@EndDate", new DateTime(year, month, DateTime.DaysInMonth(year, month))); // ngày cuối cùng của tháng;

                // Thực thi câu lệnh SQL và xử lý kết quả
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                int tongdoanhthu = 0;
                while (reader.Read())
                {
                    dt_baocao.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                    tongdoanhthu += reader.GetInt32(4);
                }
                lb_price.Text = tongdoanhthu.ToString() + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmd.Dispose();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Constraint.Print(bangtk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            //Xóa dữ liệu trên datagridview;
            dt_baocao.Rows.Clear();
            con = new SqlConnection(url);
            DateTime ngaybd = dtime_ngaybd.Value;
            DateTime ngaykt = dtime_ngkt.Value;
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                string sql = "SELECT Sach.MaSach,Sach.TenSach, Sach.GiaBan, iif(Sum(HoaDon.SoLuong) is null, 0, Sum(HoaDon.SoLuong)), " +
                    "iif(Sum(HoaDon.ThanhTien) is null, 0, Sum(HoaDon.ThanhTien))" +
                    "FROM Sach " +
                    "left join HoaDon on Sach.MaSach = HoaDon.MaSach " +
                    "where HoaDon.Ngaylap >= @ngaybd and HoaDon.Ngaylap <= @ngaykt " +
                    "group by Sach.MaSach, Sach.TenSach, Sach.GiaBan;";
                // Tạo tham số và gán giá trị
                //cmd.Parameters.AddWithValue("@StartDate", new DateTime(year, month, 1));// ngày 1 của tháng;
                //cmd.Parameters.AddWithValue("@EndDate", new DateTime(year, month, DateTime.DaysInMonth(year, month))); // ngày cuối cùng của tháng;
                cmd.Parameters.AddWithValue("@ngaybd", ngaybd);
                cmd.Parameters.AddWithValue("@ngaykt", ngaykt);

                // Thực thi câu lệnh SQL và xử lý kết quả
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                int tongdoanhthu = 0;
                while (reader.Read())
                {
                    dt_baocao.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));
                    tongdoanhthu += reader.GetInt32(4);
                }
               lb_price.Text = tongdoanhthu.ToString() + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmd.Dispose();
            con.Close();
        }

        private void lb_tongdoanhthu_Click(object sender, EventArgs e)
        {

        }
    }
}
