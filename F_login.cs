using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanSach
{
    public partial class F_login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public static bool logined = false;
        const string url = "Data Source=NMC-DEVELOPER\\SQLEXPRESS;Initial Catalog=QL_NhaSach;User Id=sa;Password=Nmc170603;";


        public F_login()
        {
            InitializeComponent();
        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_user.Text))
            {
                lb_errorUser.Text = "Bạn chưa nhập vào tài khoản!";
            }
            if (string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                lb_errorPass.Text = "Bạn chưa nhập vào mật khẩu!";
                return;
            }
            //tạo 1 đối tượng connection;
            con = new SqlConnection(url);
            try
            {
                //mở kết nối sql;
                con.Open();
                string select_sql = "select MatKhau from TaiKhoan where TenTK = @taikhoan";
                cmd = new SqlCommand(select_sql, con);
                cmd.Parameters.AddWithValue("@taikhoan",txt_user.Text.Trim());
                string check = (string)cmd.ExecuteScalar();
                if (string.IsNullOrEmpty(check))
                {
                    lb_errorPass.Text = "User không tồn tại!";
                }
                else if (string.Equals(check.Trim(), txt_pass.Text.Trim()))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logined = true;
                    F_main.đăngXuấtToolStripMenuItem.Visible = true;
                    F_main.tàiKhaonrToolStripMenuItem.Visible = false;
                    this.Close();
                }
                else
                {
                    lb_errorPass.Text = "Mật khẩu không chính xác!";
                }
                con.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            lb_errorPass.Text = "";
            lb_errorUser.Text = "";
        }
        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            lb_errorUser.Text = "";
            lb_errorPass.Text = "";
        }
    }
}
