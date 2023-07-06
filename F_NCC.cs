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
    public partial class F_NCC : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public static bool logined = false;
        const string url = "Data Source=NMC-DEVELOPER\\SQLEXPRESS;Initial Catalog=QL_NhaSach;User Id=sa;Password=Nmc170603;";
        private bool checkVali = false;
        private string mancc;
        public F_NCC()
        {
            InitializeComponent();
        }

        void ClearForm()
        {
            txt_mancc.Clear();
            txt_diachi.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            txt_tenncc.Clear();
            txt_mancc.Focus();
        }
        void CheckVali()
        {
            if (string.IsNullOrWhiteSpace(txt_mancc.Text))
            {
                lb_errorMNCC.Text = "Không được để trống!";
                checkVali = true;
            }

            if (string.IsNullOrWhiteSpace(txt_tenncc.Text))
            {
                lb_errorTNCC.Text = "Không được để trống!";
                checkVali = true;
            }
            if (string.IsNullOrWhiteSpace(txt_diachi.Text))
            {
                lb_errorDC.Text = "Không được để trống!";
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

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                lb_errorE.Text = "Không được để trông!";
                checkVali = true;
            }
            else
            {
                string regEmail = "^[a-zA-Z0-9]+@gmail\\.com$";
                bool checkEmail = Regex.IsMatch(txt_email.Text, regEmail);
                if (!checkEmail)
                {
                    lb_errorE.Text = "Email không hợp lệ!";
                    checkVali = true;
                }
            }
        }
        private void bt_them_Click(object sender, EventArgs e)
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
                    string sql_check = "select count(MaNCC) from NhaCungCap where MaNCC = @mancc";
                    cmd.CommandText = sql_check;
                    cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text.Trim());
                    int countMaNCC = (int)cmd.ExecuteScalar();
                    if (countMaNCC > 0)
                    {
                        MessageBox.Show("Mã Nhà cung cấp đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insert_sql = $"insert into NhaCungCap values('{txt_mancc.Text.Trim()}','{txt_tenncc.Text.Trim()}','{txt_diachi.Text.Trim()}','{txt_sdt.Text.Trim()}','{txt_email.Text.Trim()}')";
                        cmd.CommandText = insert_sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadData();
                        ClearForm();
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
        void ReloadData()
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string select_sql = "select * from NhaCungCap";
                cmd = new SqlCommand(select_sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<NhaCungCap> list = new List<NhaCungCap>();
                while (reader.Read())
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.MaNCC = reader.GetString(0);
                    ncc.TenNCC = reader.GetString(1);
                    ncc.DiaChi = reader.GetString(2);
                    ncc.SDT = reader.GetString(3);
                    ncc.Email = reader.GetString(4);
                    list.Add(ncc);
                }

                dt_ListNCC.DataSource = list;
                cmd.Dispose();
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorE.Text = "";
        }
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorSDT.Text = "";
        }
        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorDC.Text = "";
        }
        private void txt_tenncc_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorTNCC.Text = "";
        }
        private void txt_mancc_TextChanged(object sender, EventArgs e)
        {
            checkVali = false;
            lb_errorMNCC.Text = "";
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void F_NCC_Load(object sender, EventArgs e)
        {
            ReloadData();
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
                    string update_sql = "update NhaCungCap set MaNCC = @mancc," +
                        "TenNCC = @tenncc,DiaChi = @diachi, SDT = @sdt,Email = @email where MaNCC = @condition";
                    cmd.CommandText = update_sql;
                    cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenncc", txt_tenncc.Text.Trim());
                    cmd.Parameters.AddWithValue("@diachi",txt_diachi.Text.Trim());
                    cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim());
                    cmd.Parameters.AddWithValue("@condition", mancc);

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
        private void dt_ListNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi mà click vào 1 ô trên dòng ta sẽ lấy index của dòng đó.
            DataGridViewRow row = dt_ListNCC.Rows[e.RowIndex];
            mancc = row.Cells[0].Value.ToString();
            txt_mancc.Text = row.Cells[0].Value.ToString();
            txt_tenncc.Text = row.Cells[1].Value.ToString();
            txt_diachi.Text = row.Cells[2].Value.ToString();
            txt_sdt.Text = row.Cells[3].Value.ToString();
            txt_email.Text = row.Cells[4].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(url);
            try
            {
                con.Open();
                string delete_sql = "delete from NhaCungCap where MaNCC = @mancc";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = delete_sql;
                cmd.Parameters.AddWithValue("@mancc", txt_mancc.Text.Trim());
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
    }
}
