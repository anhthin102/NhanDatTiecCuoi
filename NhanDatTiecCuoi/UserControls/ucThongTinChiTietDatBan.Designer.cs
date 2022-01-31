
namespace NhanDatTiecCuoi.UserControls
{
    partial class ucThongTinChiTietDatBan
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
            this.cboMaMonAn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nupSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatBan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.epMaTiecCuoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMaMonAn = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSoLuong = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaTiecCuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(147, 365);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 38);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.txtMaTiecCuoi);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.cboMaMonAn);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.txtDonGia);
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.nupSoLuong);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.txtGhiChu);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(7, 40);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(432, 392);
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
            this.txtMaTiecCuoi.Size = new System.Drawing.Size(350, 26);
            this.txtMaTiecCuoi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã món ăn";
            // 
            // cboMaMonAn
            // 
            this.cboMaMonAn.FormattingEnabled = true;
            this.cboMaMonAn.Location = new System.Drawing.Point(10, 91);
            this.cboMaMonAn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.cboMaMonAn.Name = "cboMaMonAn";
            this.cboMaMonAn.Size = new System.Drawing.Size(125, 28);
            this.cboMaMonAn.TabIndex = 2;
            this.cboMaMonAn.SelectedIndexChanged += new System.EventHandler(this.cboMaMonAn_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(10, 154);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(350, 26);
            this.txtDonGia.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng";
            // 
            // nupSoLuong
            // 
            this.nupSoLuong.Location = new System.Drawing.Point(10, 215);
            this.nupSoLuong.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.nupSoLuong.Name = "nupSoLuong";
            this.nupSoLuong.Size = new System.Drawing.Size(120, 26);
            this.nupSoLuong.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(10, 276);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(350, 26);
            this.txtGhiChu.TabIndex = 1;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.dgvMonAn);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(445, 40);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(633, 414);
            this.flowLayoutPanel4.TabIndex = 9;
            this.flowLayoutPanel4.Click += new System.EventHandler(this.flowLayoutPanel4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách món ăn";
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(10, 40);
            this.dgvMonAn.Margin = new System.Windows.Forms.Padding(10);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.RowHeadersWidth = 62;
            this.dgvMonAn.RowTemplate.Height = 28;
            this.dgvMonAn.Size = new System.Drawing.Size(606, 293);
            this.dgvMonAn.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dgvDatBan);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 522);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1074, 418);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách chi tiết đặt bàn";
            // 
            // dgvDatBan
            // 
            this.dgvDatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatBan.Location = new System.Drawing.Point(10, 40);
            this.dgvDatBan.Margin = new System.Windows.Forms.Padding(10);
            this.dgvDatBan.Name = "dgvDatBan";
            this.dgvDatBan.RowHeadersWidth = 62;
            this.dgvDatBan.RowTemplate.Height = 28;
            this.dgvDatBan.Size = new System.Drawing.Size(1054, 281);
            this.dgvDatBan.TabIndex = 1;
            this.dgvDatBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatBan_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÔNG TIN CHI TIẾT ĐẶT BÀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(943, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tiệc cưới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // epMaTiecCuoi
            // 
            this.epMaTiecCuoi.ContainerControl = this;
            // 
            // epMaMonAn
            // 
            this.epMaMonAn.ContainerControl = this;
            // 
            // epSoLuong
            // 
            this.epSoLuong.ContainerControl = this;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(20, 365);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(121, 38);
            this.btnThemMoi.TabIndex = 12;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(274, 365);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 38);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ucThongTinChiTietDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ucThongTinChiTietDatBan";
            this.Size = new System.Drawing.Size(1074, 940);
            this.Load += new System.EventHandler(this.ucThongTinChiTietDatBan_Load);
            this.Click += new System.EventHandler(this.ucThongTinChiTietDatBan_Click);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaTiecCuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTiecCuoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMaMonAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider epMaTiecCuoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.ErrorProvider epMaMonAn;
        private System.Windows.Forms.ErrorProvider epSoLuong;
    }
}
