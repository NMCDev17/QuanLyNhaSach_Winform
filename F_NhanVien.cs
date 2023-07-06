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
    public partial class F_NhanVien : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public static bool logined = false;
        const string url = "Data Source=NMC-DEVELOPER\\SQLEXPRESS;Initial Catalog=QL_NhaSach;User Id=sa;Password=Nmc170603;";
        private bool checkVali = false;
        private string manv;
        public F_NhanVien()
        {
            InitializeComponent();
        }

        void ClearForm()
        {
            txt_manv.Clear();
            txt_tennv.Clear();
            txt_quequan.Clear();
            txt_sdt.Clear();
            dt_namsinh.Value = DateTime.Now;
            txt_manv.Focus();
        }
        void CheckVali()
        {
            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                lb_errorMaNV.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_tennv.Text))
            {
                lb_errorTenNV.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                lb_errorSDT.Text = "Không được để trống!";
                checkVali = true;
            }
            else
            {
                string regSDT = "^\\d{10}$";
                bool checkSDT = Regex.IsMatch(txt_sdt.Text, regSDT);
                if (!checkSDT)
                {
                    lb_errorSDT.Text = "Số điện thoại không hợp lệ!";
                    checkVali = true;
                }
            }

            if (string.IsNullOrWhiteSpace(txt_quequan.Text))
            {
                lb_errorQueQuan.Text = "Không được để trống!";
                checkVali = true;
            }
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                //mở kết nối csdl;
                con.Open();

                CheckVali();// kiểm tra xem dữ liệu có hợp lệ không;

                //tạo object truy vấn dữ liệu;
                cmd = new SqlCommand();
                cmd.Connection = con;
                string sql_check = "select count(MaNV) from NhanVien where MaNV = @manv";
                cmd.CommandText = sql_check;
                cmd.Parameters.AddWithValue("@manv", txt_manv.Text.Trim());
                int countMaNV = (int)cmd.ExecuteScalar();
                if (countMaNV > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmd.Dispose();
                    con.Close();
                    return;
                }

                //Nếu dữ liêu đã hợp lệ rồi ta tiến hành thêm vào csdl;
                if (!checkVali)
                {
                    bool gioitinh = (cb_gioitinh.Text == "Nam") ? true : false;
                    string insert_sql = $"insert into NhanVien values ('{txt_manv.Text.Trim()}','{txt_tennv.Text.Trim()}','{gioitinh}','{dt_namsinh.Value}','{txt_sdt.Text.Trim()}','{txt_quequan.Text.Trim()}')";
                    cmd.CommandText = insert_sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadData();
                    ClearForm();
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_manv_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorMaNV.Text = "";
        }
        private void txt_tennv_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorTenNV.Text = "";
        }
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorSDT.Text = "";
        }
        private void txt_quequan_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorQueQuan.Text = "";
        }
        public void ReloadData()
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string select_sql = "select * from NhanVien";
                cmd = new SqlCommand(select_sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<NhanVien> list = new List<NhanVien>();
                while (reader.Read())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = reader.GetString(0);
                    nv.TenNV = reader.GetString(1);
                    if (reader.GetBoolean(2))
                        nv.GioiTinh = "Nam";
                    else
                        nv.GioiTinh = "Nữ";
                    nv.NamSinh = reader.GetDateTime(3);
                    nv.SDT = reader.GetString(4);
                    nv.QueQuan = reader.GetString(5);
                    list.Add(nv);
                }

                dt_ListNhanVien.DataSource = list;
                cmd.Dispose();
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void F_NhanVien_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                CheckVali();
                if (!checkVali)
                {
                    string update_sql = "update NhanVien set MaNV = @manv," +
                        "TenNV = @tennv, GioiTinh = @gioitinh, NamSinh = @namsinh, SDT = @sdt, QuenQuan = @quequan where MaNV = @condition";
                    cmd.CommandText = update_sql;
                    cmd.Parameters.AddWithValue("@manv", txt_manv.Text.Trim());
                    cmd.Parameters.AddWithValue("@tennv", txt_tennv.Text.Trim());
                    bool gioitinh = true;
                    if (cb_gioitinh.Text.Trim() != "Nam")
                    {
                        gioitinh = false;
                    }
                    cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@namsinh", dt_namsinh.Value);
                    cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text.Trim());
                    cmd.Parameters.AddWithValue("@quequan", txt_quequan.Text.Trim());
                    cmd.Parameters.AddWithValue("@condition", manv);

                    DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa không!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        ReloadData();
                    }
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dt_ListNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi mà click vào 1 ô trên dòng ta sẽ lấy index của dòng đó.
            DataGridViewRow row = dt_ListNhanVien.Rows[e.RowIndex];
            manv = row.Cells[0].Value.ToString();
            txt_manv.Text = row.Cells[0].Value.ToString();
            txt_tennv.Text = row.Cells[1].Value.ToString();
            cb_gioitinh.Text = row.Cells[2].Value.ToString();
            dt_namsinh.Value = (DateTime)row.Cells[3].Value;
            txt_sdt.Text = row.Cells[4].Value.ToString();
            txt_quequan.Text = row.Cells[5].Value.ToString();
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string delete_sql = "delete from NhanVien where MaNV = @manv";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = delete_sql;
                cmd.Parameters.AddWithValue("@manv", txt_manv.Text.Trim());
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadData();
                    ClearForm();
                }
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cb_gioitinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            Constraint.blockInput(sender,e);
        }
    }
}
