
namespace NhanDatTiecCuoi.UserControls
{
    partial class ucHoaDon
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
            this.btnTiecCuoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTiecCuoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenChuRe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenCoDau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nupSoLuongBan = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTiecCuoi = new System.Windows.Forms.DataGridView();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongTienBan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTongTienDichVu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongTienHoaDon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.epThanhToan = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMaTiecCuoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuongBan)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiecCuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaTiecCuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTiecCuoi
            // 
            this.btnTiecCuoi.Location = new System.Drawing.Point(931, 48);
            this.btnTiecCuoi.Name = "btnTiecCuoi";
            this.btnTiecCuoi.Size = new System.Drawing.Size(117, 39);
            this.btnTiecCuoi.TabIndex = 18;
            this.btnTiecCuoi.Text = "Tiệc cưới";
            this.btnTiecCuoi.UseVisualStyleBackColor = true;
            this.btnTiecCuoi.Click += new System.EventHandler(this.btnTiecCuoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(142, 595);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(116, 38);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.flowLayoutPanel3.Controls.Add(this.dtpNgayThanhToan);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.nupSoLuongBan);
            this.flowLayoutPanel3.Controls.Add(this.label9);
            this.flowLayoutPanel3.Controls.Add(this.txtDonGiaBan);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 77);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(209, 424);
            this.flowLayoutPanel3.TabIndex = 13;
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
            this.txtMaTiecCuoi.Size = new System.Drawing.Size(175, 26);
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
            // 
            // txtTenChuRe
            // 
            this.txtTenChuRe.Location = new System.Drawing.Point(10, 91);
            this.txtTenChuRe.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTenChuRe.Name = "txtTenChuRe";
            this.txtTenChuRe.ReadOnly = true;
            this.txtTenChuRe.Size = new System.Drawing.Size(175, 26);
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
            this.txtTenCoDau.ReadOnly = true;
            this.txtTenCoDau.Size = new System.Drawing.Size(175, 26);
            this.txtTenCoDau.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày thanh toán";
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(10, 213);
            this.dtpNgayThanhToan.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(175, 26);
            this.dtpNgayThanhToan.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng bàn";
            // 
            // nupSoLuongBan
            // 
            this.nupSoLuongBan.Location = new System.Drawing.Point(10, 274);
            this.nupSoLuongBan.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.nupSoLuongBan.Name = "nupSoLuongBan";
            this.nupSoLuongBan.ReadOnly = true;
            this.nupSoLuongBan.Size = new System.Drawing.Size(175, 26);
            this.nupSoLuongBan.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 310);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đơn giá bàn";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(10, 335);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Size = new System.Drawing.Size(175, 26);
            this.txtDonGiaBan.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.dgvTiecCuoi);
            this.flowLayoutPanel4.Controls.Add(this.btnChinhSua);
            this.flowLayoutPanel4.Controls.Add(this.label16);
            this.flowLayoutPanel4.Controls.Add(this.dgvDichVu);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(432, 77);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(641, 679);
            this.flowLayoutPanel4.TabIndex = 15;
            this.flowLayoutPanel4.Click += new System.EventHandler(this.flowLayoutPanel4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách tiệc cưới";
            // 
            // dgvTiecCuoi
            // 
            this.dgvTiecCuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiecCuoi.Location = new System.Drawing.Point(10, 40);
            this.dgvTiecCuoi.Margin = new System.Windows.Forms.Padding(10);
            this.dgvTiecCuoi.Name = "dgvTiecCuoi";
            this.dgvTiecCuoi.RowHeadersWidth = 62;
            this.dgvTiecCuoi.RowTemplate.Height = 28;
            this.dgvTiecCuoi.Size = new System.Drawing.Size(606, 262);
            this.dgvTiecCuoi.TabIndex = 1;
            this.dgvTiecCuoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiecCuoi_CellClick);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(10, 332);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(112, 36);
            this.btnChinhSua.TabIndex = 2;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 381);
            this.label16.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(216, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Danh sách chi tiết đặt dịch vụ";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(10, 411);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(10);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 62;
            this.dgvDichVu.RowTemplate.Height = 28;
            this.dgvDichVu.Size = new System.Drawing.Size(606, 223);
            this.dgvDichVu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.txtTongTienBan);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.txtTongTienDichVu);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.txtTongTienHoaDon);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.txtTienDatCoc);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtConLai);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(217, 77);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(209, 424);
            this.flowLayoutPanel2.TabIndex = 17;
            this.flowLayoutPanel2.Click += new System.EventHandler(this.flowLayoutPanel2_Click);
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tổng tiền bàn";
            // 
            // txtTongTienBan
            // 
            this.txtTongTienBan.Location = new System.Drawing.Point(10, 30);
            this.txtTongTienBan.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTongTienBan.Name = "txtTongTienBan";
            this.txtTongTienBan.ReadOnly = true;
            this.txtTongTienBan.Size = new System.Drawing.Size(175, 26);
            this.txtTongTienBan.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tổng tiền dịch vụ";
            // 
            // txtTongTienDichVu
            // 
            this.txtTongTienDichVu.Location = new System.Drawing.Point(10, 91);
            this.txtTongTienDichVu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTongTienDichVu.Name = "txtTongTienDichVu";
            this.txtTongTienDichVu.ReadOnly = true;
            this.txtTongTienDichVu.Size = new System.Drawing.Size(175, 26);
            this.txtTongTienDichVu.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tổng tiền hóa đơn";
            // 
            // txtTongTienHoaDon
            // 
            this.txtTongTienHoaDon.Location = new System.Drawing.Point(10, 152);
            this.txtTongTienHoaDon.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTongTienHoaDon.Name = "txtTongTienHoaDon";
            this.txtTongTienHoaDon.ReadOnly = true;
            this.txtTongTienHoaDon.Size = new System.Drawing.Size(175, 26);
            this.txtTongTienHoaDon.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tiền đặt cọc";
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Location = new System.Drawing.Point(10, 213);
            this.txtTienDatCoc.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.ReadOnly = true;
            this.txtTienDatCoc.Size = new System.Drawing.Size(175, 26);
            this.txtTienDatCoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Còn lại";
            // 
            // txtConLai
            // 
            this.txtConLai.Location = new System.Drawing.Point(10, 274);
            this.txtConLai.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.ReadOnly = true;
            this.txtConLai.Size = new System.Drawing.Size(175, 26);
            this.txtConLai.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(164, 536);
            this.label14.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Thanh Toán";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(122, 561);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(175, 26);
            this.txtThanhToan.TabIndex = 1;
            // 
            // epThanhToan
            // 
            this.epThanhToan.ContainerControl = this;
            // 
            // epMaTiecCuoi
            // 
            this.epMaTiecCuoi.ContainerControl = this;
            // 
            // ucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnTiecCuoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtThanhToan);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(1074, 940);
            this.Load += new System.EventHandler(this.ucHoaDon_Load);
            this.Click += new System.EventHandler(this.ucHoaDon_Click);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuongBan)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiecCuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaTiecCuoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTiecCuoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTiecCuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenChuRe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenCoDau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupSoLuongBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTiecCuoi;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongTienBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongTienDichVu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTongTienHoaDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.ErrorProvider epThanhToan;
        private System.Windows.Forms.ErrorProvider epMaTiecCuoi;
    }
}
