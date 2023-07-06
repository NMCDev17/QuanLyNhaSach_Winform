using QL_BanSach.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QL_BanSach
{
    public partial class F_BanSach : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private const string url = "Data Source=NMC-DEVELOPER\\SQLEXPRESS;Initial Catalog=QL_NhaSach;User Id=sa;Password=Nmc170603;";
        private List<HoaDon> listSachInHD = new List<HoaDon>();
        private List<string> listMaSachInHD = new List<string>();
        public F_BanSach()
        {
            InitializeComponent();
        }
        void ClearForm()
        {
            txt_mahd.Text = "";
            txt_MKH.Text = "";
            txt_TKH.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_soluong.Text = "0";
            txt_tongtien.Text = "0";
            txt_mahd.Focus();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                string select_sql = "select MaSach from Sach where TenSach = '" + cb_tensach.Text.Trim() + "'";
                cmd.CommandText = select_sql;
                string masach = (string)cmd.ExecuteScalar();
                listMaSachInHD.Add(masach);

                //Thêm sản phẩm vào hóa đơn;
                HoaDon hd = new HoaDon();
                hd.TenSach = cb_tensach.Text.Trim();
                hd.GiaBan = int.Parse(txt_gia.Text);
                hd.SoLuong = int.Parse(txt_soluong.Text);
                hd.ThanhTien = int.Parse(txt_thanhtien.Text);
                listSachInHD.Add(hd);
                txt_tongtien.Text = (int.Parse(txt_tongtien.Text) + hd.ThanhTien).ToString();

                //add vào  List sách trong HD;
                dt_listHD.Rows.Add(hd.TenSach, hd.GiaBan, hd.SoLuong, hd.ThanhTien);
                dt_listHD.Refresh();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CreateMaHD()
        {
            string mahd = "HD";
            for (int i = 1; i <= 3; i++)
            {
                Random random = new Random();
                int numRandom = random.Next(0, 10);
                mahd += numRandom;
            }
            txt_mahd.Text = mahd;
        }
        void ReloadTenSach()
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string select_sql = "select TenSach from Sach";
                cmd = new SqlCommand(select_sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                cb_tensach.DataSource = list;
                cb_tensach.Text = "";
                txt_theloai.Text = "";
                txt_gia.Text = "";
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void F_BanSach_Load(object sender, EventArgs e)
        {
            //CreateMaHD();
            ReloadTenSach();
        }
        private void cb_tensach_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string select_sql = "select TheLoai, GiaBan from Sach where TenSach = @tensach";
                cmd = new SqlCommand(select_sql, con);
                cmd.Parameters.AddWithValue("@tensach", cb_tensach.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_theloai.Text = reader.GetString(0);
                    txt_gia.Text = reader.GetInt32(1).ToString();
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int gia = Convert.ToInt32(txt_gia.Text);
                int soluong = Convert.ToInt32(txt_soluong.Text);
                txt_thanhtien.Text = (gia * soluong).ToString();
            }
            catch (Exception ex)
            {

            }
        }
        private void bt_in_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                //kiểm tra xem khách hàng cũ hay mới;
                string check_sql = "select count(MaKH) from KhachHang where MaKH = @makh";
                cmd.CommandText = check_sql;
                cmd.Parameters.AddWithValue("@makh", txt_MKH.Text.Trim());
                int count = (int)cmd.ExecuteScalar();

                DateTime ngaylap = DateTime.Now; //ngay lap hoa đơn;
                //Nếu là khách hàng cũ ta sẽ chỉ lưu hóa đơn mà k lưu lại thông tin;
                if (count > 0)
                {
                    for (int i = 0; i < listSachInHD.Count; ++i)
                    {
                        string insert1_sql = "insert into HoaDon values('" + txt_HDmahd.Text.Trim() +
                           "','" + listMaSachInHD[i] + "','" + txt_MKH.Text.Trim() + "','" + listSachInHD[i].ThanhTien + "','" +
                          listSachInHD[i].SoLuong + "' , '" + ngaylap + "')";
                        cmd.CommandText = insert1_sql;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("In thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listSachInHD.Clear();
                    listMaSachInHD.Clear();
                    //CreateMaHD();
                    Constraint.PrintPanel(panel2);
                    ClearForm();
                    dt_listHD.Rows.Clear();
                }
                //Nếu là khách hàng mới ta lưu thông tin khách hàng và lưu thông tin hóa đơn;
                else
                {
                    //Tien hanh luu thong tin khach hang;
                    bool gioitinh = true;
                    if (cb_gioitinh.Text.Trim() != "Nam")
                    {
                        gioitinh = false;
                    }
                    string insert2_sql = $"insert into KhachHang values('{txt_MKH.Text.Trim()}'," +
                        $"'{txt_TKH.Text.Trim()}','{gioitinh}','{txt_sdt.Text}'," +
                        $"'{txt_diachi.Text.Trim()}')";
                    cmd.CommandText = insert2_sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã Lưu thông tin KH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //tiến hành lưu thông tin hóa đơn;
                    for (int i = 0; i < listSachInHD.Count; ++i)
                    {
                        string insert3_sql = "insert into HoaDon values('" + txt_HDmahd.Text.Trim() +
                          "','" + listMaSachInHD[i] + "','" + txt_MKH.Text.Trim() + "','" + listSachInHD[i].ThanhTien + "','" +
                         listSachInHD[i].SoLuong + "' , '" + ngaylap + "')";
                        cmd.CommandText = insert3_sql;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("In thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //CreateMaHD();
                    listMaSachInHD.Clear();
                    listSachInHD.Clear();
                    Constraint.PrintPanel(panel2);
                    ClearForm();
                    dt_listHD.Rows.Clear();
                }
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
            listSachInHD.Clear();
            listMaSachInHD.Clear();
            dt_listHD.Rows.Clear();
            ClearForm();
            //CreateMaHD();
        }
        private void txt_mahd_TextChanged(object sender, EventArgs e)
        {
            txt_HDmahd.Text = txt_mahd.Text.Trim();
        }
        private void txt_TKH_TextChanged(object sender, EventArgs e)
        {
            txt_HDtkh.Text = txt_TKH.Text.Trim();
        }
        private void cb_gioitinh_TextChanged(object sender, EventArgs e)
        {
            txt_hdGioiTinh.Text = cb_gioitinh.Text.Trim();
        }
        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {
            txt_HDdiachi.Text = txt_diachi.Text.Trim();
        }
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            txt_HDSdt.Text = txt_sdt.Text.Trim();
        }
        private void txt_MKH_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string select_sql = "select TenKH, GioiTinh, DiaChi, SDT from KhachHang where MaKH = '" + txt_MKH.Text.Trim() + "'";
                cmd = new SqlCommand(select_sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        txt_TKH.Text = reader.GetString(0);
                        bool gioitinh = reader.GetBoolean(1);
                        if (gioitinh)
                            cb_gioitinh.Text = "Nam";
                        else
                            cb_gioitinh.Text = "Nữ";
                        txt_diachi.Text = reader.GetString(2);
                        txt_sdt.Text = reader.GetString(3);
                    }
                }
                else
                {
                    txt_TKH.Text = "";
                    cb_gioitinh.Text = "Nam";
                    txt_diachi.Text = "";
                    txt_sdt.Text = "";
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem có dòng được chọn hay không
            try
            {
                if (dt_listHD.SelectedRows.Count > 0)
                {
                    // Lấy chỉ mục của dòng được chọn
                    int selectedRowIndex = dt_listHD.SelectedRows[0].Index;
                    txt_tongtien.Text = (Convert.ToInt32(txt_tongtien.Text) - listSachInHD[selectedRowIndex].ThanhTien).ToString();
                    //xóa sản phẩm;
                    listMaSachInHD.RemoveAt(selectedRowIndex);
                    listSachInHD.RemoveAt(selectedRowIndex);
                    // Xóa dòng tương ứng trên datagridview
                    dt_listHD.Rows.RemoveAt(selectedRowIndex);
                    cb_tensach.Text = "";
                    txt_thanhtien.Text = "0";
                    txt_soluong.Text = "0";
                    txt_theloai.Text = "";
                    txt_gia.Text = "0";
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void dt_listHD_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                DataGridViewRow row = dt_listHD.Rows[e.RowIndex];
                cb_tensach.Text = row.Cells[0].Value.ToString();
                txt_soluong.Text = row.Cells[1].Value.ToString();
                txt_gia.Text = row.Cells[2].Value.ToString();
                txt_thanhtien.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
