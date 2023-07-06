namespace QL_BanSach
{
    partial class F_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_errorQueQuan = new System.Windows.Forms.Label();
            this.lb_errorSDT = new System.Windows.Forms.Label();
            this.lb_errorTenNV = new System.Windows.Forms.Label();
            this.lb_errorMaNV = new System.Windows.Forms.Label();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.lb_qlnv = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dt_namsinh = new System.Windows.Forms.DateTimePicker();
            this.txt_quequan = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.lb_quequan = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_namsinh = new System.Windows.Forms.Label();
            this.lb_gtinh = new System.Windows.Forms.Label();
            this.lb_tennv = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dt_ListNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ListNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_errorQueQuan);
            this.panel1.Controls.Add(this.lb_errorSDT);
            this.panel1.Controls.Add(this.lb_errorTenNV);
            this.panel1.Controls.Add(this.lb_errorMaNV);
            this.panel1.Controls.Add(this.cb_gioitinh);
            this.panel1.Controls.Add(this.lb_qlnv);
            this.panel1.Controls.Add(this.bt_thoat);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.dt_namsinh);
            this.panel1.Controls.Add(this.txt_quequan);
            this.panel1.Controls.Add(this.txt_sdt);
            this.panel1.Controls.Add(this.txt_tennv);
            this.panel1.Controls.Add(this.txt_manv);
            this.panel1.Controls.Add(this.lb_quequan);
            this.panel1.Controls.Add(this.lb_sdt);
            this.panel1.Controls.Add(this.lb_namsinh);
            this.panel1.Controls.Add(this.lb_gtinh);
            this.panel1.Controls.Add(this.lb_tennv);
            this.panel1.Controls.Add(this.lb_manv);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 285);
            this.panel1.TabIndex = 0;
            // 
            // lb_errorQueQuan
            // 
            this.lb_errorQueQuan.AutoSize = true;
            this.lb_errorQueQuan.ForeColor = System.Drawing.Color.Red;
            this.lb_errorQueQuan.Location = new System.Drawing.Point(545, 211);
            this.lb_errorQueQuan.Name = "lb_errorQueQuan";
            this.lb_errorQueQuan.Size = new System.Drawing.Size(0, 16);
            this.lb_errorQueQuan.TabIndex = 18;
            // 
            // lb_errorSDT
            // 
            this.lb_errorSDT.AutoSize = true;
            this.lb_errorSDT.ForeColor = System.Drawing.Color.Red;
            this.lb_errorSDT.Location = new System.Drawing.Point(545, 160);
            this.lb_errorSDT.Name = "lb_errorSDT";
            this.lb_errorSDT.Size = new System.Drawing.Size(0, 16);
            this.lb_errorSDT.TabIndex = 18;
            // 
            // lb_errorTenNV
            // 
            this.lb_errorTenNV.AutoSize = true;
            this.lb_errorTenNV.ForeColor = System.Drawing.Color.Red;
            this.lb_errorTenNV.Location = new System.Drawing.Point(196, 160);
            this.lb_errorTenNV.Name = "lb_errorTenNV";
            this.lb_errorTenNV.Size = new System.Drawing.Size(0, 16);
            this.lb_errorTenNV.TabIndex = 18;
            // 
            // lb_errorMaNV
            // 
            this.lb_errorMaNV.AutoSize = true;
            this.lb_errorMaNV.ForeColor = System.Drawing.Color.Red;
            this.lb_errorMaNV.Location = new System.Drawing.Point(196, 107);
            this.lb_errorMaNV.Name = "lb_errorMaNV";
            this.lb_errorMaNV.Size = new System.Drawing.Size(0, 16);
            this.lb_errorMaNV.TabIndex = 18;
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(194, 181);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(181, 33);
            this.cb_gioitinh.TabIndex = 17;
            this.cb_gioitinh.Text = "Nam";
            this.cb_gioitinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_gioitinh_KeyPress);
            // 
            // lb_qlnv
            // 
            this.lb_qlnv.AutoSize = true;
            this.lb_qlnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qlnv.ForeColor = System.Drawing.Color.Black;
            this.lb_qlnv.Location = new System.Drawing.Point(253, 19);
            this.lb_qlnv.Name = "lb_qlnv";
            this.lb_qlnv.Size = new System.Drawing.Size(249, 31);
            this.lb_qlnv.TabIndex = 16;
            this.lb_qlnv.Text = "Quản Lý Nhân Viên";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.White;
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(562, 230);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(87, 36);
            this.bt_thoat.TabIndex = 15;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Red;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(415, 230);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(87, 36);
            this.bt_xoa.TabIndex = 14;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(268, 230);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(87, 36);
            this.bt_sua.TabIndex = 13;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Lime;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(121, 230);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(87, 36);
            this.bt_them.TabIndex = 12;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dt_namsinh
            // 
            this.dt_namsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_namsinh.Location = new System.Drawing.Point(548, 74);
            this.dt_namsinh.Name = "dt_namsinh";
            this.dt_namsinh.Size = new System.Drawing.Size(181, 30);
            this.dt_namsinh.TabIndex = 11;
            // 
            // txt_quequan
            // 
            this.txt_quequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quequan.Location = new System.Drawing.Point(548, 178);
            this.txt_quequan.Name = "txt_quequan";
            this.txt_quequan.Size = new System.Drawing.Size(181, 30);
            this.txt_quequan.TabIndex = 10;
            this.txt_quequan.TextChanged += new System.EventHandler(this.txt_quequan_TextChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(548, 127);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(181, 30);
            this.txt_sdt.TabIndex = 9;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            // 
            // txt_tennv
            // 
            this.txt_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennv.Location = new System.Drawing.Point(194, 127);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(181, 30);
            this.txt_tennv.TabIndex = 7;
            this.txt_tennv.TextChanged += new System.EventHandler(this.txt_tennv_TextChanged);
            // 
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(194, 74);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(181, 30);
            this.txt_manv.TabIndex = 6;
            this.txt_manv.TextChanged += new System.EventHandler(this.txt_manv_TextChanged);
            // 
            // lb_quequan
            // 
            this.lb_quequan.AutoSize = true;
            this.lb_quequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quequan.Location = new System.Drawing.Point(416, 181);
            this.lb_quequan.Name = "lb_quequan";
            this.lb_quequan.Size = new System.Drawing.Size(99, 25);
            this.lb_quequan.TabIndex = 5;
            this.lb_quequan.Text = "Quê quán";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(416, 130);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(126, 25);
            this.lb_sdt.TabIndex = 4;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // lb_namsinh
            // 
            this.lb_namsinh.AutoSize = true;
            this.lb_namsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namsinh.Location = new System.Drawing.Point(416, 77);
            this.lb_namsinh.Name = "lb_namsinh";
            this.lb_namsinh.Size = new System.Drawing.Size(94, 25);
            this.lb_namsinh.TabIndex = 3;
            this.lb_namsinh.Text = "Năm sinh";
            // 
            // lb_gtinh
            // 
            this.lb_gtinh.AutoSize = true;
            this.lb_gtinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gtinh.Location = new System.Drawing.Point(41, 181);
            this.lb_gtinh.Name = "lb_gtinh";
            this.lb_gtinh.Size = new System.Drawing.Size(82, 25);
            this.lb_gtinh.TabIndex = 2;
            this.lb_gtinh.Text = "Giới tính";
            // 
            // lb_tennv
            // 
            this.lb_tennv.AutoSize = true;
            this.lb_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tennv.Location = new System.Drawing.Point(41, 130);
            this.lb_tennv.Name = "lb_tennv";
            this.lb_tennv.Size = new System.Drawing.Size(137, 25);
            this.lb_tennv.TabIndex = 1;
            this.lb_tennv.Text = "Tên nhân viên";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manv.Location = new System.Drawing.Point(41, 77);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(130, 25);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dt_ListNhanVien);
            this.panel2.Location = new System.Drawing.Point(12, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 231);
            this.panel2.TabIndex = 1;
            // 
            // dt_ListNhanVien
            // 
            this.dt_ListNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_ListNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.GioiTinh,
            this.NamSinh,
            this.SDT,
            this.QueQuan});
            this.dt_ListNhanVien.Location = new System.Drawing.Point(14, 17);
            this.dt_ListNhanVien.Name = "dt_ListNhanVien";
            this.dt_ListNhanVien.RowHeadersWidth = 51;
            this.dt_ListNhanVien.RowTemplate.Height = 24;
            this.dt_ListNhanVien.Size = new System.Drawing.Size(743, 194);
            this.dt_ListNhanVien.TabIndex = 0;
            this.dt_ListNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_ListNhanVien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.MinimumWidth = 6;
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Width = 125;
            // 
            // F_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên (Quân Trần, Mạnh Cường, Ngọc Ánh)";
            this.Load += new System.EventHandler(this.F_NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_ListNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dt_ListNhanVien;
        private System.Windows.Forms.Label lb_qlnv;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DateTimePicker dt_namsinh;
        private System.Windows.Forms.TextBox txt_quequan;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label lb_quequan;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_namsinh;
        private System.Windows.Forms.Label lb_gtinh;
        private System.Windows.Forms.Label lb_tennv;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.Label lb_errorQueQuan;
        private System.Windows.Forms.Label lb_errorSDT;
        private System.Windows.Forms.Label lb_errorTenNV;
        private System.Windows.Forms.Label lb_errorMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
    }
}