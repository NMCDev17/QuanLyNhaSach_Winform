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

namespace QL_BanSach
{
    public partial class F_Sach : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        const string url = "Data Source=NMC-DEVELOPER\\SQLEXPRESS;Initial Catalog=QL_NhaSach;User Id=sa;Password=Nmc170603;";
        private bool checkVali = false;
        public F_Sach()
        {
            InitializeComponent();
        }

        void CheckVali()
        {
            if (string.IsNullOrWhiteSpace(txt_masach.Text))
            {
                lb_errorMaSach.Text = "Không được để trống!";
                checkVali = true;
            }
            if (string.IsNullOrWhiteSpace(txt_makho.Text))
            {
                lb_errorMaKho.Text = "Không được để trống!";
                checkVali = true;
            }
            if (string.IsNullOrWhiteSpace(txt_tensach.Text))
            {
                lb_errorTenSach.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_theloai.Text))
            {
                lb_errorTheLoai.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_soluong.Text))
            {
                lb_errorSL.Text = "Không được để trống!";
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
        void ClearForm()
        {
            txt_masach.Clear();
            txt_makho.Clear();
            txt_tensach.Clear();
            txt_tentg.Clear();
            txt_theloai.Clear();
            txt_giaban.Clear();
            txt_giamua.Clear();
            txt_masach.Focus();
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();

                CheckVali();
                if (!checkVali)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = con;

                    string check_sql = "select count(MaSach) from Sach where MaSach = @masach";// kiem tra xem có mã sách đó chưa;
                    cmd.CommandText = check_sql;
                    cmd.Parameters.AddWithValue("@masach", txt_masach.Text.Trim());
                    int count1 = (int)cmd.ExecuteScalar();
                    string check_sql2 = "select count(MaKho) from KhoSach where MaKho = @makho and MaSach = @masach3";//Kiem tra xem có sách kho đó chưa;
                    cmd.CommandText = check_sql2;
                    cmd.Parameters.AddWithValue("@makho", txt_makho.Text.Trim());
                    cmd.Parameters.AddWithValue("@masach3", txt_masach.Text.Trim());
                    int count2 = (int)cmd.ExecuteScalar();

                    //Nếu mã sách đã có trong kho ta tiến hành update số lượng sách trong kho;
                    if (count1 > 0 && count2 > 0)
                    {
                        //Lấy ra số lượng hiện có trong kho;
                        string select_sql = "select SoLuong from KhoSach where MaSach = '" + txt_masach.Text.Trim() +
                            "' and MaKho = '" + txt_makho.Text + "'";
                        cmd.CommandText = select_sql;
                        int soluong = (int)cmd.ExecuteScalar();
                        //update số lượng
                        soluong += Convert.ToInt32(txt_soluong.Text);
                        string update_sql = "update KhoSach set SoLuong = @soluong where MaSach = @masach22 and MaKho = @makho22";
                        cmd.CommandText = update_sql;
                        cmd.Parameters.AddWithValue("@soluong", soluong);
                        cmd.Parameters.AddWithValue("@masach22", txt_masach.Text.Trim());
                        cmd.Parameters.AddWithValue("@makho22", txt_makho.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã update số lượng sách trong kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        ReloadData();
                    }
                    // nếu mã sách đã có mà thêm vào kho sách khác
                    // thì ta sẽ thêm sách vào kho đó mà không thêm mới thông tin về sách
                    else if (count1 > 0)
                    {
                        string insert_Sql1 = $"insert into KhoSach values('{txt_makho.Text.Trim()}','{txt_masach.Text.Trim()}','{txt_soluong.Text.Trim()}','{dt_ngaynhap.Value}')";
                        cmd.CommandText = insert_Sql1;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        ReloadData();
                        ReloadMaKho();
                    }
                    //Nếu mã sách chưa có ta tiến hành thêm thông tin sách
                    //và thêm sách vào kho tương ứng;
                    else
                    {
                        string insert_Sql2 = $"insert into Sach values('{txt_masach.Text.Trim()}'," +
                                                $"'{txt_tensach.Text.Trim()}','{txt_tentg.Text.Trim()}'," +
                                                $"'{txt_theloai.Text.Trim()}','{txt_giaban.Text.Trim()}'," +
                                                $"'{txt_giamua.Text.Trim()}','{cb_mancc.Text.Trim()}')";
                        cmd.CommandText = insert_Sql2;
                        cmd.ExecuteNonQuery();
                        string insert_Sql1 = $"insert into KhoSach values('{txt_makho.Text.Trim()}','{txt_masach.Text.Trim()}','{txt_soluong.Text.Trim()}','{dt_ngaynhap.Value}')";
                        cmd.CommandText = insert_Sql1;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        ReloadData();
                    }
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ReloadMaNCC()
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                //đổ dữ liệu vào combox;
                string select_sql1 = "select MaNCC from NhaCungCap";
                List<string> listMaNCC = new List<string>();
                cmd.CommandText = select_sql1;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listMaNCC.Add(reader.GetString(0));
                }
                reader.Close();
                cb_mancc.DataSource = listMaNCC;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ReloadMaKho()
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string select_sql = "Select distinct MaKho from KhoSach";
                cmd = new SqlCommand(select_sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> listMaKho = new List<string>();

                while (reader.Read())
                {
                    listMaKho.Add(reader.GetString(0));
                }
                cb_makho.DataSource = listMaKho;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ReloadData()
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;

                //đổ dữ liệu vào datagridview;
                string select_sql2 = "select KhoSach.MaSach,TenSach, TenTG, TheLoai, SoLuong, GiaBan, GiaMua, NgayNhap, MaNCC " +
                    "From KhoSach inner join Sach on Sach.MaSach = KhoSach.MaSach " +
                    "where MaKho = '" + cb_makho.Text.Trim() + "'";
                cmd.CommandText = select_sql2;
                SqlDataReader reader2 = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader2);
                dt_listSach.DataSource = table;
                cmd.Dispose();
                reader2.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void F_Sach_Load(object sender, EventArgs e)
        {
            ReloadMaKho();
            ReloadMaNCC();
            ReloadData();
        }
        private void cb_mancc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Constraint.blockInput(sender, e);
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            try
            {
                con.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_masach_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorMaSach.Text = "";
            con = new SqlConnection(url);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                string check_sql = "select count(MaSach) from Sach where MaSach = @masach";
                cmd.CommandText = check_sql;
                cmd.Parameters.AddWithValue("@masach", txt_masach.Text.Trim());
                int count1 = (int)cmd.ExecuteScalar();
                //string check_sql2 = "select count(MaKho) from KhoSach where MaKho = @makho";
                //cmd.CommandText = check_sql2;
                //cmd.Parameters.AddWithValue("@makho", txt_makho.Text.Trim());
                //int count2 = (int)cmd.ExecuteScalar();

                if (count1 > 0)
                {
                    string select_sql = "select TenSach, TenTG, TheLoai, GiaBan, GiaMua from Sach where MaSach = @masach2";
                    cmd.CommandText = select_sql;
                    cmd.Parameters.AddWithValue("@masach2", txt_masach.Text.Trim());
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txt_tensach.Text = reader.GetString(0);
                        txt_tentg.Text = reader.GetString(1);
                        txt_theloai.Text = reader.GetString(2);
                        txt_giaban.Text = reader.GetInt32(3).ToString();
                        txt_giamua.Text = reader.GetInt32(4).ToString();
                    }
                    //txt_makho.Text = reader.GetString(2);
                }
                else
                {
                    txt_tensach.Clear();
                    txt_theloai.Clear();
                    txt_giamua.Clear();
                    txt_giaban.Clear();
                    txt_tentg.Clear();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void txt_makho_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorMaKho.Text = "";
        }
        private void txt_tensach_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorTenSach.Text = "";

        }
        private void txt_theloai_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorTheLoai.Text = "";
        }
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorSL.Text = "";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cb_makho_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void dt_listSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dt_listSach.Rows[e.RowIndex];
                if (row != null)
                {
                    txt_masach.Text = row.Cells[0].Value.ToString();
                    txt_makho.Text = cb_makho.Text;
                    txt_tensach.Text = row.Cells[1].Value.ToString();
                    txt_tentg.Text = row.Cells[2].Value.ToString();
                    txt_theloai.Text = row.Cells[3].Value.ToString();
                    txt_soluong.Text = row.Cells[4].Value.ToString();
                    txt_giaban.Text = row.Cells[5].Value.ToString();
                    txt_giamua.Text = row.Cells[6].Value.ToString();
                    dt_ngaynhap.Value = (DateTime)row.Cells[7].Value;
                    cb_mancc.Text = row.Cells[8].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;

                string delete_sql = "delete from KhoSach where MaKho = @makho and MaSach = @masach";
                cmd.CommandText = delete_sql;
                cmd.Parameters.AddWithValue("@makho", txt_makho.Text.Trim());
                cmd.Parameters.AddWithValue("@masach", txt_masach.Text.Trim());
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khỏi kho không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công khỏi kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadData();
                    ClearForm();
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (string.IsNullOrWhiteSpace(txt_masach.Text))
                {
                    lb_errorMaSach.Text = "Không được để trống";
                }

                if (string.IsNullOrWhiteSpace(txt_makho.Text))
                {
                    lb_errorMaSach.Text = "Không được để trống";
                }
            }
        }
    }
}
