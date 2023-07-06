using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanSach
{
    public partial class F_main : Form
    {
        public F_main()
        {
            InitializeComponent();
        }
        private void tàiKhaonrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_login = new F_login();
            f_login.MdiParent = this;
            f_login.Show();
        }
        private void F_main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login.logined = false;
            F_main.tàiKhaonrToolStripMenuItem.Visible = true;
            F_main.đăngXuấtToolStripMenuItem.Visible = false;
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (F_login.logined)
            {
                F_NhanVien f_NhanVien = new F_NhanVien();
                f_NhanVien.MdiParent = this;
                f_NhanVien.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (F_login.logined)
            {
                F_Sach f_Sach = new F_Sach();
                f_Sach.MdiParent = this;
                f_Sach.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nhậpNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (F_login.logined)
            {
                F_NCC f_ncc = new F_NCC();
                f_ncc.MdiParent = this;
                f_ncc.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hóaĐơnBánSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (F_login.logined)
            {
                F_BanSach f_bansach = new F_BanSach();
                f_bansach.MdiParent = this;
                f_bansach.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TimKiem f_TimKiem = new F_TimKiem();
            f_TimKiem.MdiParent = this;
            f_TimKiem.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (F_login.logined)
            {
               F_BaoCao f_baocao = new F_BaoCao();
                f_baocao.MdiParent = this;
                f_baocao.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
