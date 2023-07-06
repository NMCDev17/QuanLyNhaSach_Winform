using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanSach
{
    public partial class F_TimKiem : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        public static bool logined = false;
        const string url = "Data Source=NMC-DEVELOPER\\SQLEXPRESS;Initial Catalog=QL_NhaSach;User Id=sa;Password=Nmc170603;";
        private bool checkVali = false;
        public F_TimKiem()
        {
            InitializeComponent();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            dt_listSach.Rows.Clear();
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string select_sql = "select Sach.MaSach, TenSach, TheLoai, TenTG, GiaBan,GiaMua, iif(Sum(SoLuong) is null, 0, Sum(SoLuong)) " +
                    "from Sach " +
                    "left join KhoSach on Sach.MaSach = KhoSach.MaSach " +
                    "where Sach.MaSach like '%" + txt_timkiem.Text + "%'" +
                    "group by Sach.MaSach, TenSach, TheLoai, TenTG, GiaBan, GiaMua";
                cmd = new SqlCommand(select_sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dt_listSach.Rows.Add(reader.GetString(0), reader.GetString(1),
                        reader.GetString(2), reader.GetString(3), reader.GetInt32(4),
                        reader.GetInt32(5), reader.GetInt32(6));
                }
                dt_listSach.Refresh();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        void ReloadData()
        {
            dt_listSach.Rows.Clear();
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string select_Sql = "select Sach.MaSach, TenSach, TheLoai, TenTG, GiaBan,GiaMua, iif(Sum(SoLuong) is null, 0, Sum(SoLuong)) " +
                    "from Sach " +
                    "left join KhoSach on Sach.MaSach = KhoSach.MaSach " +
                    "group by Sach.MaSach, TenSach, TheLoai, TenTG, GiaBan, GiaMua";
                cmd = new SqlCommand(select_Sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dt_listSach.Rows.Add(reader.GetString(0), reader.GetString(1),
                        reader.GetString(2), reader.GetString(3), reader.GetInt32(4),
                        reader.GetInt32(5), reader.GetInt32(6));
                }
                dt_listSach.Refresh();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void F_TimKiem_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dt_listSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                DataGridViewRow row = dt_listSach.Rows[e.RowIndex];
                string masach;
                if (row != null)
                {
                    txt_masach.Text = row.Cells[0].Value.ToString();
                    masach = txt_masach.Text.Trim();
                    txt_tensach.Text = row.Cells[1].Value.ToString();
                    txt_theloai.Text = row.Cells[2].Value.ToString();
                    txt_tentg.Text = row.Cells[3].Value.ToString();
                    txt_giaban.Text = row.Cells[4].Value.ToString();
                    txt_giamua.Text = row.Cells[5].Value.ToString();
                    txt_soluong.Text = row.Cells[6].Value.ToString();

                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;

                    //Đổ dữ liệu vào combox các nhà cung cấp để sửa đổi;
                    string select_sql1 = "Select TenNCC from NhaCungCap ";
                    cmd.CommandText = select_sql1;
                    List<string> listTenNCC = new List<string>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listTenNCC.Add(reader.GetString(0));
                    }
                    cb_nhacc.DataSource = listTenNCC;

                    //hiển thị nhà cung cấp trước đó;
                    string select_sql = "Select TenNCC from Sach " +
                        "inner join NhaCungCap on NhaCungCap.MaNCC = Sach.MaNCC " +
                        "where MaSach = '" + masach + "'";
                    string tenncc = (string)cmd.ExecuteScalar();
                    cb_nhacc.Text = tenncc;
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {

            }
            con.Close();
        }
        void CheckVali()
        {
            if (string.IsNullOrWhiteSpace(txt_masach.Text))
            {
                lb_errorMaS.Text = "Không được để trống";
                checkVali = true;// đánh dấu dữ liêu không hợp lệ;
            }

            if (string.IsNullOrWhiteSpace(txt_tensach.Text))
            {
                lb_errorTenS.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_theloai.Text))
            {
                lb_errorTL.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_tentg.Text))
            {
                lb_errorTG.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_giaban.Text))
            {
                lb_errorGiaBan.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_giamua.Text))
            {
                lb_errorGiaMua.Text = "Không được để trống!";
                checkVali = true;
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            CheckVali();

            if (!checkVali)
            {
                con = new SqlConnection(url);
                try
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;

                    string select_sql = "select MaNCC from NhaCungCap where TenNCC = '" + cb_nhacc.Text + "'";
                    cmd.CommandText = select_sql;
                    string mancc = (string)cmd.ExecuteScalar();

                    string update_sql = "update Sach set MaSach = '" + txt_masach.Text.Trim() +
                        "', TenSach = '" + txt_tensach.Text.Trim() + "', TenTG = '" +
                        txt_tentg.Text.Trim() + "', TheLoai = '" + txt_theloai.Text.Trim() +
                        "', GiaBan = '" + txt_giaban.Text + "', GiaMua = '" +
                        txt_giamua.Text + "', MaNCC = '" + mancc + "' " +
                        "where MaSach = '" + txt_masach.Text.Trim() + "'";
                    cmd.CommandText = update_sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_masach_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorMaS.Text = "";
        }

        private void txt_theloai_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorTL.Text = "";
        }

        private void txt_tensach_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorTenS.Text = "";
        }

        private void txt_tentg_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorTG.Text = "";
        }

        private void txt_giaban_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorGiaBan.Text = "";
        }

        private void txt_giamua_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorGiaMua.Text = "";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if(txt_timkiem.Text == "")
            {
                ReloadData();
            }
        }
    }
}
