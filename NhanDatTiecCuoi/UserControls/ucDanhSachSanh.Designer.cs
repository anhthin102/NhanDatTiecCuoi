
namespace NhanDatTiecCuoi.UserControls
{
    partial class ucDanhSachSanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSanh = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLoaiSanh = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSanh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSanh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaLoaiSanh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nupSoLuongBanMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.epMaSanh = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTenSanh = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMaLoaiSanh = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSoLuongBanToiDa = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanh)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanh)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuongBanMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaLoaiSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSoLuongBanToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SẢNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dgvSanh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 522);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1074, 418);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách sảnh";
            // 
            // dgvSanh
            // 
            this.dgvSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanh.Location = new System.Drawing.Point(10, 40);
            this.dgvSanh.Margin = new System.Windows.Forms.Padding(10);
            this.dgvSanh.Name = "dgvSanh";
            this.dgvSanh.RowHeadersWidth = 62;
            this.dgvSanh.RowTemplate.Height = 28;
            this.dgvSanh.Size = new System.Drawing.Size(1054, 281);
            this.dgvSanh.TabIndex = 1;
            this.dgvSanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanh_CellClick);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.dgvLoaiSanh);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(468, 50);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(613, 414);
            this.flowLayoutPanel4.TabIndex = 4;
            this.flowLayoutPanel4.Click += new System.EventHandler(this.flowLayoutPanel4_Click);
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách các loại sảnh";
            // 
            // dgvLoaiSanh
            // 
            this.dgvLoaiSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSanh.Location = new System.Drawing.Point(10, 40);
            this.dgvLoaiSanh.Margin = new System.Windows.Forms.Padding(10);
            this.dgvLoaiSanh.Name = "dgvLoaiSanh";
            this.dgvLoaiSanh.RowHeadersWidth = 62;
            this.dgvLoaiSanh.RowTemplate.Height = 28;
            this.dgvLoaiSanh.Size = new System.Drawing.Size(606, 293);
            this.dgvLoaiSanh.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.txtMaSanh);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.txtTenSanh);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.cbMaLoaiSanh);
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.nupSoLuongBanMax);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.txtGhiChu);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 50);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(455, 387);
            this.flowLayoutPanel3.TabIndex = 0;
            this.flowLayoutPanel3.Click += new System.EventHandler(this.flowLayoutPanel3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã sảnh";
            // 
            // txtMaSanh
            // 
            this.txtMaSanh.Location = new System.Drawing.Point(10, 30);
            this.txtMaSanh.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtMaSanh.Name = "txtMaSanh";
            this.txtMaSanh.ReadOnly = true;
            this.txtMaSanh.Size = new System.Drawing.Size(404, 26);
            this.txtMaSanh.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên sảnh";
            // 
            // txtTenSanh
            // 
            this.txtTenSanh.Location = new System.Drawing.Point(10, 91);
            this.txtTenSanh.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTenSanh.Name = "txtTenSanh";
            this.txtTenSanh.Size = new System.Drawing.Size(404, 26);
            this.txtTenSanh.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã loại sảnh";
            // 
            // cbMaLoaiSanh
            // 
            this.cbMaLoaiSanh.FormattingEnabled = true;
            this.cbMaLoaiSanh.Location = new System.Drawing.Point(10, 152);
            this.cbMaLoaiSanh.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.cbMaLoaiSanh.Name = "cbMaLoaiSanh";
            this.cbMaLoaiSanh.Size = new System.Drawing.Size(125, 28);
            this.cbMaLoaiSanh.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng bàn tối đa";
            // 
            // nupSoLuongBanMax
            // 
            this.nupSoLuongBanMax.Location = new System.Drawing.Point(10, 215);
            this.nupSoLuongBanMax.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.nupSoLuongBanMax.Name = "nupSoLuongBanMax";
            this.nupSoLuongBanMax.Size = new System.Drawing.Size(120, 26);
            this.nupSoLuongBanMax.TabIndex = 4;
            this.nupSoLuongBanMax.ValueChanged += new System.EventHandler(this.label4_Click);
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
            this.txtGhiChu.Size = new System.Drawing.Size(404, 26);
            this.txtGhiChu.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(145, 375);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 38);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Location = new System.Drawing.Point(20, 377);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(108, 34);
            this.btnThemMoi.TabIndex = 18;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(278, 377);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // epMaSanh
            // 
            this.epMaSanh.ContainerControl = this;
            // 
            // epTenSanh
            // 
            this.epTenSanh.ContainerControl = this;
            // 
            // epMaLoaiSanh
            // 
            this.epMaLoaiSanh.ContainerControl = this;
            // 
            // epSoLuongBanToiDa
            // 
            this.epSoLuongBanToiDa.ContainerControl = this;
            // 
            // ucDanhSachSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ucDanhSachSanh";
            this.Size = new System.Drawing.Size(1074, 940);
            this.Load += new System.EventHandler(this.ucDanhSachSanh_Load);
            this.Click += new System.EventHandler(this.ucDanhSachSanh_Click);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanh)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanh)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuongBanMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaLoaiSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSoLuongBanToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSanh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLoaiSanh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaLoaiSanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupSoLuongBanMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider epMaSanh;
        private System.Windows.Forms.ErrorProvider epTenSanh;
        private System.Windows.Forms.ErrorProvider epMaLoaiSanh;
        private System.Windows.Forms.ErrorProvider epSoLuongBanToiDa;
    }
}
