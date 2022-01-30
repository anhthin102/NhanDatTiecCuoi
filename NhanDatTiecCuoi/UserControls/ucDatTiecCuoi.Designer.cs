
namespace NhanDatTiecCuoi.UserControls
{
    partial class ucDatTiecCuoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTiecCuoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenChuRe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenCoDau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayDatTiec = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayDaiTiec = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCa = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvSanh = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTiecCuoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoLuongBan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoBanDuTru = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMaCa = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboMaSanh = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChinhSuaDV = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvDatDichVu = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChinhSuaBan = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvDatBan = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.epMaTiecCuoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTenChuRe = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTenCoDau = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTienDatCoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSoLuongBan = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanh)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiecCuoi)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatDichVu)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaTiecCuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenChuRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenCoDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTienDatCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSoLuongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(138, 425);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 38);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.txtMaTiecCuoi);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.txtTenChuRe);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.txtTenCoDau);
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.txtSDT);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.dtpNgayDatTiec);
            this.flowLayoutPanel3.Controls.Add(this.label9);
            this.flowLayoutPanel3.Controls.Add(this.dtpNgayDaiTiec);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(7, 39);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(212, 394);
            this.flowLayoutPanel3.TabIndex = 6;
            this.flowLayoutPanel3.Click += new System.EventHandler(this.flowLayoutPanel3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã tiệc cưới";
            // 
            // txtMaTiecCuoi
            // 
            this.txtMaTiecCuoi.Location = new System.Drawing.Point(10, 30);
            this.txtMaTiecCuoi.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtMaTiecCuoi.Name = "txtMaTiecCuoi";
            this.txtMaTiecCuoi.ReadOnly = true;
            this.txtMaTiecCuoi.Size = new System.Drawing.Size(166, 26);
            this.txtMaTiecCuoi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên chú rể";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTenChuRe
            // 
            this.txtTenChuRe.Location = new System.Drawing.Point(10, 91);
            this.txtTenChuRe.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTenChuRe.Name = "txtTenChuRe";
            this.txtTenChuRe.Size = new System.Drawing.Size(166, 26);
            this.txtTenChuRe.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên cô dâu";
            // 
            // txtTenCoDau
            // 
            this.txtTenCoDau.Location = new System.Drawing.Point(10, 152);
            this.txtTenCoDau.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTenCoDau.Name = "txtTenCoDau";
            this.txtTenCoDau.Size = new System.Drawing.Size(166, 26);
            this.txtTenCoDau.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "SĐT";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(10, 213);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 26);
            this.txtSDT.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày đặt tiệc";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtpNgayDatTiec
            // 
            this.dtpNgayDatTiec.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDatTiec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDatTiec.Location = new System.Drawing.Point(10, 274);
            this.dtpNgayDatTiec.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dtpNgayDatTiec.Name = "dtpNgayDatTiec";
            this.dtpNgayDatTiec.Size = new System.Drawing.Size(166, 26);
            this.dtpNgayDatTiec.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 310);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày đãi tiệc";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtpNgayDaiTiec
            // 
            this.dtpNgayDaiTiec.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDaiTiec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDaiTiec.Location = new System.Drawing.Point(10, 335);
            this.dtpNgayDaiTiec.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dtpNgayDaiTiec.Name = "dtpNgayDaiTiec";
            this.dtpNgayDaiTiec.Size = new System.Drawing.Size(166, 26);
            this.dtpNgayDaiTiec.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.dgvCa);
            this.flowLayoutPanel4.Controls.Add(this.label16);
            this.flowLayoutPanel4.Controls.Add(this.dgvSanh);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(437, 39);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(641, 424);
            this.flowLayoutPanel4.TabIndex = 9;
            this.flowLayoutPanel4.Click += new System.EventHandler(this.flowLayoutPanel4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách ca";
            // 
            // dgvCa
            // 
            this.dgvCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCa.Location = new System.Drawing.Point(10, 40);
            this.dgvCa.Margin = new System.Windows.Forms.Padding(10);
            this.dgvCa.Name = "dgvCa";
            this.dgvCa.RowHeadersWidth = 62;
            this.dgvCa.RowTemplate.Height = 28;
            this.dgvCa.Size = new System.Drawing.Size(606, 140);
            this.dgvCa.TabIndex = 1;
            this.dgvCa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 200);
            this.label16.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Danh sách sảnh";
            // 
            // dgvSanh
            // 
            this.dgvSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanh.Location = new System.Drawing.Point(10, 230);
            this.dgvSanh.Margin = new System.Windows.Forms.Padding(10);
            this.dgvSanh.Name = "dgvSanh";
            this.dgvSanh.RowHeadersWidth = 62;
            this.dgvSanh.RowTemplate.Height = 28;
            this.dgvSanh.Size = new System.Drawing.Size(606, 164);
            this.dgvSanh.TabIndex = 1;
            this.dgvSanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dgvTiecCuoi);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-3, 468);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1074, 253);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách tiệc cưới";
            // 
            // dgvTiecCuoi
            // 
            this.dgvTiecCuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiecCuoi.Location = new System.Drawing.Point(10, 40);
            this.dgvTiecCuoi.Margin = new System.Windows.Forms.Padding(10);
            this.dgvTiecCuoi.Name = "dgvTiecCuoi";
            this.dgvTiecCuoi.RowHeadersWidth = 62;
            this.dgvTiecCuoi.RowTemplate.Height = 28;
            this.dgvTiecCuoi.Size = new System.Drawing.Size(1054, 192);
            this.dgvTiecCuoi.TabIndex = 1;
            this.dgvTiecCuoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiecCuoi_CellClick);
            this.dgvTiecCuoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÔNG TIN ĐẶT TIỆC CƯỚI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.txtTienDatCoc);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.txtSoLuongBan);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.txtSoBanDuTru);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.txtDonGiaBan);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.cboMaCa);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.cboMaSanh);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(222, 39);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(212, 394);
            this.flowLayoutPanel2.TabIndex = 11;
            this.flowLayoutPanel2.Click += new System.EventHandler(this.flowLayoutPanel2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tiền đặt cọc";
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Location = new System.Drawing.Point(10, 30);
            this.txtTienDatCoc.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(167, 26);
            this.txtTienDatCoc.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số lượng bàn";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Location = new System.Drawing.Point(10, 91);
            this.txtSoLuongBan.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(167, 26);
            this.txtSoLuongBan.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số bàn dự trữ";
            // 
            // txtSoBanDuTru
            // 
            this.txtSoBanDuTru.Location = new System.Drawing.Point(10, 152);
            this.txtSoBanDuTru.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtSoBanDuTru.Name = "txtSoBanDuTru";
            this.txtSoBanDuTru.Size = new System.Drawing.Size(167, 26);
            this.txtSoBanDuTru.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Đơn giá bàn";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(10, 213);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Size = new System.Drawing.Size(167, 26);
            this.txtDonGiaBan.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 249);
            this.label14.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã ca";
            // 
            // cboMaCa
            // 
            this.cboMaCa.FormattingEnabled = true;
            this.cboMaCa.Location = new System.Drawing.Point(10, 274);
            this.cboMaCa.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.cboMaCa.Name = "cboMaCa";
            this.cboMaCa.Size = new System.Drawing.Size(167, 28);
            this.cboMaCa.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 312);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã sảnh";
            // 
            // cboMaSanh
            // 
            this.cboMaSanh.FormattingEnabled = true;
            this.cboMaSanh.Location = new System.Drawing.Point(10, 337);
            this.cboMaSanh.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.cboMaSanh.Name = "cboMaSanh";
            this.cboMaSanh.Size = new System.Drawing.Size(167, 28);
            this.cboMaSanh.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(936, 10);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(117, 39);
            this.btnThanhToan.TabIndex = 12;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.btnChinhSuaDV);
            this.flowLayoutPanel7.Controls.Add(this.label19);
            this.flowLayoutPanel7.Controls.Add(this.dgvDatDichVu);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(527, 727);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(534, 213);
            this.flowLayoutPanel7.TabIndex = 15;
            this.flowLayoutPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel7_Paint);
            // 
            // btnChinhSuaDV
            // 
            this.btnChinhSuaDV.Location = new System.Drawing.Point(10, 3);
            this.btnChinhSuaDV.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnChinhSuaDV.Name = "btnChinhSuaDV";
            this.btnChinhSuaDV.Size = new System.Drawing.Size(98, 33);
            this.btnChinhSuaDV.TabIndex = 3;
            this.btnChinhSuaDV.Text = "Chỉnh sửa";
            this.btnChinhSuaDV.UseVisualStyleBackColor = true;
            this.btnChinhSuaDV.Click += new System.EventHandler(this.button3_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 44);
            this.label19.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(216, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Danh sách chi tiết đặt dịch vụ";
            // 
            // dgvDatDichVu
            // 
            this.dgvDatDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatDichVu.Location = new System.Drawing.Point(10, 74);
            this.dgvDatDichVu.Margin = new System.Windows.Forms.Padding(10);
            this.dgvDatDichVu.Name = "dgvDatDichVu";
            this.dgvDatDichVu.RowHeadersWidth = 62;
            this.dgvDatDichVu.RowTemplate.Height = 28;
            this.dgvDatDichVu.Size = new System.Drawing.Size(524, 114);
            this.dgvDatDichVu.TabIndex = 1;
            this.dgvDatDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.btnChinhSuaBan);
            this.flowLayoutPanel5.Controls.Add(this.label17);
            this.flowLayoutPanel5.Controls.Add(this.dgvDatBan);
            this.flowLayoutPanel5.Controls.Add(this.button2);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(7, 727);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(514, 213);
            this.flowLayoutPanel5.TabIndex = 16;
            this.flowLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel5_Paint_1);
            // 
            // btnChinhSuaBan
            // 
            this.btnChinhSuaBan.Location = new System.Drawing.Point(10, 3);
            this.btnChinhSuaBan.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnChinhSuaBan.Name = "btnChinhSuaBan";
            this.btnChinhSuaBan.Size = new System.Drawing.Size(98, 33);
            this.btnChinhSuaBan.TabIndex = 2;
            this.btnChinhSuaBan.Text = "Chỉnh sửa";
            this.btnChinhSuaBan.UseVisualStyleBackColor = true;
            this.btnChinhSuaBan.Click += new System.EventHandler(this.button4_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 44);
            this.label17.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(194, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Danh sách chi tiết đặt bàn";
            // 
            // dgvDatBan
            // 
            this.dgvDatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatBan.Location = new System.Drawing.Point(10, 74);
            this.dgvDatBan.Margin = new System.Windows.Forms.Padding(10);
            this.dgvDatBan.Name = "dgvDatBan";
            this.dgvDatBan.RowHeadersWidth = 62;
            this.dgvDatBan.RowTemplate.Height = 28;
            this.dgvDatBan.Size = new System.Drawing.Size(497, 111);
            this.dgvDatBan.TabIndex = 1;
            this.dgvDatBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(7, 424);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(121, 38);
            this.btnThemMoi.TabIndex = 17;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(266, 425);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 38);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.Location = new System.Drawing.Point(403, 753);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(121, 38);
            this.btnXoaBan.TabIndex = 19;
            this.btnXoaBan.Text = "Xóa";
            this.btnXoaBan.UseVisualStyleBackColor = true;
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.Location = new System.Drawing.Point(939, 750);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(121, 38);
            this.btnXoaDV.TabIndex = 20;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = true;
            // 
            // epMaTiecCuoi
            // 
            this.epMaTiecCuoi.ContainerControl = this;
            // 
            // epTenChuRe
            // 
            this.epTenChuRe.ContainerControl = this;
            // 
            // epTenCoDau
            // 
            this.epTenCoDau.ContainerControl = this;
            // 
            // epSDT
            // 
            this.epSDT.ContainerControl = this;
            // 
            // epTienDatCoc
            // 
            this.epTienDatCoc.ContainerControl = this;
            // 
            // epSoLuongBan
            // 
            this.epSoLuongBan.ContainerControl = this;
            // 
            // ucDatTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "ucDatTiecCuoi";
            this.Size = new System.Drawing.Size(1074, 940);
            this.Load += new System.EventHandler(this.ucDatTiecCuoi_Load);
            this.Click += new System.EventHandler(this.ucDatTiecCuoi_Click);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanh)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiecCuoi)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatDichVu)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaTiecCuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenChuRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenCoDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTienDatCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSoLuongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTiecCuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenChuRe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTiecCuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvSanh;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvDatDichVu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvDatBan;
        private System.Windows.Forms.Button btnChinhSuaBan;
        private System.Windows.Forms.Button btnChinhSuaDV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenCoDau;
        private System.Windows.Forms.DateTimePicker dtpNgayDatTiec;
        private System.Windows.Forms.DateTimePicker dtpNgayDaiTiec;
        private System.Windows.Forms.TextBox txtSoBanDuTru;
        private System.Windows.Forms.ComboBox cboMaCa;
        private System.Windows.Forms.ComboBox cboMaSanh;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.ErrorProvider epMaTiecCuoi;
        private System.Windows.Forms.ErrorProvider epTenChuRe;
        private System.Windows.Forms.ErrorProvider epTenCoDau;
        private System.Windows.Forms.ErrorProvider epSDT;
        private System.Windows.Forms.ErrorProvider epTienDatCoc;
        private System.Windows.Forms.ErrorProvider epSoLuongBan;
    }
}
