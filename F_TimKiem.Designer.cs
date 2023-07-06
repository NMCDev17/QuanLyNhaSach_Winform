namespace QL_BanSach
{
    partial class F_TimKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.dt_listSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.gb_chitiet = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_mancc = new System.Windows.Forms.Label();
            this.txt_giamua = new System.Windows.Forms.TextBox();
            this.lb_giamua = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.lb_giaban = new System.Windows.Forms.Label();
            this.txt_theloai = new System.Windows.Forms.TextBox();
            this.lb_theloai = new System.Windows.Forms.Label();
            this.txt_tentg = new System.Windows.Forms.TextBox();
            this.lb_tentg = new System.Windows.Forms.Label();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.lb_tensach = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.lb_masach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_errorMaS = new System.Windows.Forms.Label();
            this.lb_errorGiaBan = new System.Windows.Forms.Label();
            this.lb_errorGiaMua = new System.Windows.Forms.Label();
            this.lb_errorTL = new System.Windows.Forms.Label();
            this.lb_errorTenS = new System.Windows.Forms.Label();
            this.lb_errorTG = new System.Windows.Forms.Label();
            this.lb_nhacc = new System.Windows.Forms.Label();
            this.cb_nhacc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_listSach)).BeginInit();
            this.gb_chitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(208, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Sách";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bt_thoat);
            this.panel2.Controls.Add(this.dt_listSach);
            this.panel2.Controls.Add(this.bt_timkiem);
            this.panel2.Controls.Add(this.txt_timkiem);
            this.panel2.Location = new System.Drawing.Point(12, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 341);
            this.panel2.TabIndex = 1;
            // 
            // bt_thoat
            // 
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(975, 22);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(125, 40);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // dt_listSach
            // 
            this.dt_listSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_listSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TenTG,
            this.GiaBan,
            this.GiaMua,
            this.SoLuong});
            this.dt_listSach.Location = new System.Drawing.Point(44, 105);
            this.dt_listSach.Name = "dt_listSach";
            this.dt_listSach.RowHeadersWidth = 51;
            this.dt_listSach.RowTemplate.Height = 24;
            this.dt_listSach.Size = new System.Drawing.Size(1056, 215);
            this.dt_listSach.TabIndex = 2;
            this.dt_listSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_listSach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TheLoai
            // 
            this.TheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenTG
            // 
            this.TenTG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTG.DataPropertyName = "TenTG";
            this.TenTG.HeaderText = "Tên tác giả";
            this.TenTG.MinimumWidth = 6;
            this.TenTG.Name = "TenTG";
            this.TenTG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GiaMua
            // 
            this.GiaMua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaMua.DataPropertyName = "GiaMua";
            this.GiaMua.HeaderText = "Giá mua";
            this.GiaMua.MinimumWidth = 6;
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.Color.White;
            this.bt_timkiem.Location = new System.Drawing.Point(775, 22);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(171, 40);
            this.bt_timkiem.TabIndex = 1;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(44, 28);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(680, 30);
            this.txt_timkiem.TabIndex = 0;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // gb_chitiet
            // 
            this.gb_chitiet.BackColor = System.Drawing.Color.White;
            this.gb_chitiet.Controls.Add(this.cb_nhacc);
            this.gb_chitiet.Controls.Add(this.lb_errorTG);
            this.gb_chitiet.Controls.Add(this.lb_errorTenS);
            this.gb_chitiet.Controls.Add(this.lb_errorTL);
            this.gb_chitiet.Controls.Add(this.lb_errorGiaMua);
            this.gb_chitiet.Controls.Add(this.lb_errorGiaBan);
            this.gb_chitiet.Controls.Add(this.lb_errorMaS);
            this.gb_chitiet.Controls.Add(this.btn_sua);
            this.gb_chitiet.Controls.Add(this.txt_soluong);
            this.gb_chitiet.Controls.Add(this.lb_nhacc);
            this.gb_chitiet.Controls.Add(this.label8);
            this.gb_chitiet.Controls.Add(this.lb_mancc);
            this.gb_chitiet.Controls.Add(this.txt_giamua);
            this.gb_chitiet.Controls.Add(this.lb_giamua);
            this.gb_chitiet.Controls.Add(this.txt_giaban);
            this.gb_chitiet.Controls.Add(this.lb_giaban);
            this.gb_chitiet.Controls.Add(this.txt_theloai);
            this.gb_chitiet.Controls.Add(this.lb_theloai);
            this.gb_chitiet.Controls.Add(this.txt_tentg);
            this.gb_chitiet.Controls.Add(this.lb_tentg);
            this.gb_chitiet.Controls.Add(this.txt_tensach);
            this.gb_chitiet.Controls.Add(this.lb_tensach);
            this.gb_chitiet.Controls.Add(this.txt_masach);
            this.gb_chitiet.Controls.Add(this.lb_masach);
            this.gb_chitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_chitiet.Location = new System.Drawing.Point(12, 104);
            this.gb_chitiet.Name = "gb_chitiet";
            this.gb_chitiet.Size = new System.Drawing.Size(1150, 267);
            this.gb_chitiet.TabIndex = 2;
            this.gb_chitiet.TabStop = false;
            this.gb_chitiet.Text = "Thông tin chi tiết";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_sua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(956, 180);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(171, 47);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa thông tin";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Enabled = false;
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(703, 115);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(155, 30);
            this.txt_soluong.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng:";
            // 
            // lb_mancc
            // 
            this.lb_mancc.AutoSize = true;
            this.lb_mancc.Location = new System.Drawing.Point(655, 44);
            this.lb_mancc.Name = "lb_mancc";
            this.lb_mancc.Size = new System.Drawing.Size(0, 20);
            this.lb_mancc.TabIndex = 0;
            // 
            // txt_giamua
            // 
            this.txt_giamua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giamua.Location = new System.Drawing.Point(415, 118);
            this.txt_giamua.Name = "txt_giamua";
            this.txt_giamua.Size = new System.Drawing.Size(155, 30);
            this.txt_giamua.TabIndex = 1;
            this.txt_giamua.TextChanged += new System.EventHandler(this.txt_giamua_TextChanged);
            // 
            // lb_giamua
            // 
            this.lb_giamua.AutoSize = true;
            this.lb_giamua.Location = new System.Drawing.Point(309, 121);
            this.lb_giamua.Name = "lb_giamua";
            this.lb_giamua.Size = new System.Drawing.Size(77, 20);
            this.lb_giamua.TabIndex = 0;
            this.lb_giamua.Text = "Giá mua:";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaban.Location = new System.Drawing.Point(118, 114);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(155, 30);
            this.txt_giaban.TabIndex = 1;
            this.txt_giaban.TextChanged += new System.EventHandler(this.txt_giaban_TextChanged);
            // 
            // lb_giaban
            // 
            this.lb_giaban.AutoSize = true;
            this.lb_giaban.BackColor = System.Drawing.Color.White;
            this.lb_giaban.Location = new System.Drawing.Point(12, 117);
            this.lb_giaban.Name = "lb_giaban";
            this.lb_giaban.Size = new System.Drawing.Size(72, 20);
            this.lb_giaban.TabIndex = 0;
            this.lb_giaban.Text = "Giá bán:";
            // 
            // txt_theloai
            // 
            this.txt_theloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_theloai.Location = new System.Drawing.Point(415, 47);
            this.txt_theloai.Name = "txt_theloai";
            this.txt_theloai.Size = new System.Drawing.Size(155, 30);
            this.txt_theloai.TabIndex = 1;
            this.txt_theloai.TextChanged += new System.EventHandler(this.txt_theloai_TextChanged);
            // 
            // lb_theloai
            // 
            this.lb_theloai.AutoSize = true;
            this.lb_theloai.Location = new System.Drawing.Point(309, 50);
            this.lb_theloai.Name = "lb_theloai";
            this.lb_theloai.Size = new System.Drawing.Size(73, 20);
            this.lb_theloai.TabIndex = 0;
            this.lb_theloai.Text = "Thể loại:";
            // 
            // txt_tentg
            // 
            this.txt_tentg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tentg.Location = new System.Drawing.Point(989, 47);
            this.txt_tentg.Name = "txt_tentg";
            this.txt_tentg.Size = new System.Drawing.Size(155, 30);
            this.txt_tentg.TabIndex = 1;
            this.txt_tentg.TextChanged += new System.EventHandler(this.txt_tentg_TextChanged);
            // 
            // lb_tentg
            // 
            this.lb_tentg.AutoSize = true;
            this.lb_tentg.Location = new System.Drawing.Point(870, 50);
            this.lb_tentg.Name = "lb_tentg";
            this.lb_tentg.Size = new System.Drawing.Size(97, 20);
            this.lb_tentg.TabIndex = 0;
            this.lb_tentg.Text = "Tên tác giả:";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensach.Location = new System.Drawing.Point(703, 47);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(155, 30);
            this.txt_tensach.TabIndex = 1;
            this.txt_tensach.TextChanged += new System.EventHandler(this.txt_tensach_TextChanged);
            // 
            // lb_tensach
            // 
            this.lb_tensach.AutoSize = true;
            this.lb_tensach.Location = new System.Drawing.Point(594, 50);
            this.lb_tensach.Name = "lb_tensach";
            this.lb_tensach.Size = new System.Drawing.Size(83, 20);
            this.lb_tensach.TabIndex = 0;
            this.lb_tensach.Text = "Tên sách:";
            // 
            // txt_masach
            // 
            this.txt_masach.Enabled = false;
            this.txt_masach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masach.Location = new System.Drawing.Point(118, 47);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(155, 30);
            this.txt_masach.TabIndex = 1;
            this.txt_masach.TextChanged += new System.EventHandler(this.txt_masach_TextChanged);
            // 
            // lb_masach
            // 
            this.lb_masach.AutoSize = true;
            this.lb_masach.Location = new System.Drawing.Point(12, 50);
            this.lb_masach.Name = "lb_masach";
            this.lb_masach.Size = new System.Drawing.Size(78, 20);
            this.lb_masach.TabIndex = 0;
            this.lb_masach.Text = "Mã sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách";
            // 
            // lb_errorMaS
            // 
            this.lb_errorMaS.AutoSize = true;
            this.lb_errorMaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errorMaS.ForeColor = System.Drawing.Color.Red;
            this.lb_errorMaS.Location = new System.Drawing.Point(119, 80);
            this.lb_errorMaS.Name = "lb_errorMaS";
            this.lb_errorMaS.Size = new System.Drawing.Size(0, 16);
            this.lb_errorMaS.TabIndex = 4;
            // 
            // lb_errorGiaBan
            // 
            this.lb_errorGiaBan.AutoSize = true;
            this.lb_errorGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errorGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lb_errorGiaBan.Location = new System.Drawing.Point(119, 147);
            this.lb_errorGiaBan.Name = "lb_errorGiaBan";
            this.lb_errorGiaBan.Size = new System.Drawing.Size(0, 16);
            this.lb_errorGiaBan.TabIndex = 4;
            // 
            // lb_errorGiaMua
            // 
            this.lb_errorGiaMua.AutoSize = true;
            this.lb_errorGiaMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errorGiaMua.ForeColor = System.Drawing.Color.Red;
            this.lb_errorGiaMua.Location = new System.Drawing.Point(411, 151);
            this.lb_errorGiaMua.Name = "lb_errorGiaMua";
            this.lb_errorGiaMua.Size = new System.Drawing.Size(0, 16);
            this.lb_errorGiaMua.TabIndex = 4;
            // 
            // lb_errorTL
            // 
            this.lb_errorTL.AutoSize = true;
            this.lb_errorTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errorTL.ForeColor = System.Drawing.Color.Red;
            this.lb_errorTL.Location = new System.Drawing.Point(411, 80);
            this.lb_errorTL.Name = "lb_errorTL";
            this.lb_errorTL.Size = new System.Drawing.Size(0, 16);
            this.lb_errorTL.TabIndex = 4;
            // 
            // lb_errorTenS
            // 
            this.lb_errorTenS.AutoSize = true;
            this.lb_errorTenS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errorTenS.ForeColor = System.Drawing.Color.Red;
            this.lb_errorTenS.Location = new System.Drawing.Point(700, 80);
            this.lb_errorTenS.Name = "lb_errorTenS";
            this.lb_errorTenS.Size = new System.Drawing.Size(0, 16);
            this.lb_errorTenS.TabIndex = 4;
            // 
            // lb_errorTG
            // 
            this.lb_errorTG.AutoSize = true;
            this.lb_errorTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errorTG.ForeColor = System.Drawing.Color.Red;
            this.lb_errorTG.Location = new System.Drawing.Point(985, 80);
            this.lb_errorTG.Name = "lb_errorTG";
            this.lb_errorTG.Size = new System.Drawing.Size(0, 16);
            this.lb_errorTG.TabIndex = 4;
            // 
            // lb_nhacc
            // 
            this.lb_nhacc.AutoSize = true;
            this.lb_nhacc.Location = new System.Drawing.Point(12, 195);
            this.lb_nhacc.Name = "lb_nhacc";
            this.lb_nhacc.Size = new System.Drawing.Size(112, 20);
            this.lb_nhacc.TabIndex = 0;
            this.lb_nhacc.Text = "Nhà cung cấp";
            // 
            // cb_nhacc
            // 
            this.cb_nhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nhacc.FormattingEnabled = true;
            this.cb_nhacc.Location = new System.Drawing.Point(151, 188);
            this.cb_nhacc.Name = "cb_nhacc";
            this.cb_nhacc.Size = new System.Drawing.Size(189, 33);
            this.cb_nhacc.TabIndex = 5;
            // 
            // F_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 740);
            this.Controls.Add(this.gb_chitiet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm (Quân Trần, Mạnh Cường, Ngọc Ánh)";
            this.Load += new System.EventHandler(this.F_TimKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_listSach)).EndInit();
            this.gb_chitiet.ResumeLayout(false);
            this.gb_chitiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dt_listSach;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox gb_chitiet;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_mancc;
        private System.Windows.Forms.TextBox txt_giamua;
        private System.Windows.Forms.Label lb_giamua;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label lb_giaban;
        private System.Windows.Forms.TextBox txt_theloai;
        private System.Windows.Forms.Label lb_theloai;
        private System.Windows.Forms.TextBox txt_tentg;
        private System.Windows.Forms.Label lb_tentg;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label lb_tensach;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.Label lb_masach;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_errorTG;
        private System.Windows.Forms.Label lb_errorTenS;
        private System.Windows.Forms.Label lb_errorTL;
        private System.Windows.Forms.Label lb_errorGiaMua;
        private System.Windows.Forms.Label lb_errorGiaBan;
        private System.Windows.Forms.Label lb_errorMaS;
        private System.Windows.Forms.ComboBox cb_nhacc;
        private System.Windows.Forms.Label lb_nhacc;
    }
}