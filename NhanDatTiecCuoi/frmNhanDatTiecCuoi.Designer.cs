
namespace NhanDatTiecCuoi
{
    partial class frnNhanDatTiecCuoi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnPage = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSanh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhSachSanh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhSachCacLoaiSanh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTiecCuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatTiecCuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhSachDatTiecCuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.tieccuoiToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDanhSachCa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThongTinMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhSachDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTaiChinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoanhThuThang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuyDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThayDoiQuyDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1238, 1005);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ TIỆC CƯỚI";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pnPage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1230, 946);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // pnPage
            // 
            this.pnPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage.Location = new System.Drawing.Point(153, 3);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(1074, 940);
            this.pnPage.TabIndex = 0;
            this.pnPage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPage_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDashboard,
            this.tsmiSanh,
            this.tsmiTiecCuoi,
            this.tsmiTaiChinh,
            this.tsmiQuyDinh});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(122, 946);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmiDashboard
            // 
            this.tsmiDashboard.Name = "tsmiDashboard";
            this.tsmiDashboard.Size = new System.Drawing.Size(109, 29);
            this.tsmiDashboard.Text = "Dashboard";
            this.tsmiDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiDashboard.Click += new System.EventHandler(this.tsmiDashboard_Click);
            // 
            // tsmiSanh
            // 
            this.tsmiSanh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDanhSachSanh,
            this.tsmiDanhSachCacLoaiSanh});
            this.tsmiSanh.Name = "tsmiSanh";
            this.tsmiSanh.Size = new System.Drawing.Size(109, 29);
            this.tsmiSanh.Text = "Sảnh";
            this.tsmiSanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiDanhSachSanh
            // 
            this.tsmiDanhSachSanh.Name = "tsmiDanhSachSanh";
            this.tsmiDanhSachSanh.Size = new System.Drawing.Size(301, 34);
            this.tsmiDanhSachSanh.Text = "Danh sách sảnh";
            this.tsmiDanhSachSanh.Click += new System.EventHandler(this.tsmiDanhSachSanh_Click);
            // 
            // tsmiDanhSachCacLoaiSanh
            // 
            this.tsmiDanhSachCacLoaiSanh.Name = "tsmiDanhSachCacLoaiSanh";
            this.tsmiDanhSachCacLoaiSanh.Size = new System.Drawing.Size(301, 34);
            this.tsmiDanhSachCacLoaiSanh.Text = "Danh sách các loại sảnh";
            this.tsmiDanhSachCacLoaiSanh.Click += new System.EventHandler(this.tsmiDanhSachCacLoaiSanh_Click);
            // 
            // tsmiTiecCuoi
            // 
            this.tsmiTiecCuoi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDatTiecCuoi,
            this.tsmiDanhSachDatTiecCuoi,
            this.tieccuoiToolStripMenuItem,
            this.tsmiDanhSachCa,
            this.tsmiThongTinMonAn,
            this.tsmiDanhSachDichVu});
            this.tsmiTiecCuoi.Name = "tsmiTiecCuoi";
            this.tsmiTiecCuoi.Size = new System.Drawing.Size(109, 29);
            this.tsmiTiecCuoi.Text = "Tiệc cưới";
            this.tsmiTiecCuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiDatTiecCuoi
            // 
            this.tsmiDatTiecCuoi.Name = "tsmiDatTiecCuoi";
            this.tsmiDatTiecCuoi.Size = new System.Drawing.Size(298, 34);
            this.tsmiDatTiecCuoi.Text = "Đặt tiệc cưới";
            this.tsmiDatTiecCuoi.Click += new System.EventHandler(this.tsmiDatTiecCuoi_Click);
            // 
            // tsmiDanhSachDatTiecCuoi
            // 
            this.tsmiDanhSachDatTiecCuoi.Name = "tsmiDanhSachDatTiecCuoi";
            this.tsmiDanhSachDatTiecCuoi.Size = new System.Drawing.Size(298, 34);
            this.tsmiDanhSachDatTiecCuoi.Text = "Danh sách đặt tiệc cưới";
            this.tsmiDanhSachDatTiecCuoi.Click += new System.EventHandler(this.tsmiDanhSachDatTiecCuoi_Click);
            // 
            // tieccuoiToolStripMenuItem
            // 
            this.tieccuoiToolStripMenuItem.Name = "tieccuoiToolStripMenuItem";
            this.tieccuoiToolStripMenuItem.Size = new System.Drawing.Size(295, 6);
            // 
            // tsmiDanhSachCa
            // 
            this.tsmiDanhSachCa.Name = "tsmiDanhSachCa";
            this.tsmiDanhSachCa.Size = new System.Drawing.Size(298, 34);
            this.tsmiDanhSachCa.Text = "Danh sách ca";
            this.tsmiDanhSachCa.Click += new System.EventHandler(this.tsmiDanhSachCa_Click);
            // 
            // tsmiThongTinMonAn
            // 
            this.tsmiThongTinMonAn.Name = "tsmiThongTinMonAn";
            this.tsmiThongTinMonAn.Size = new System.Drawing.Size(298, 34);
            this.tsmiThongTinMonAn.Text = "Thông tin món ăn";
            this.tsmiThongTinMonAn.Click += new System.EventHandler(this.tsmiThongTinMonAn_Click);
            // 
            // tsmiDanhSachDichVu
            // 
            this.tsmiDanhSachDichVu.Name = "tsmiDanhSachDichVu";
            this.tsmiDanhSachDichVu.Size = new System.Drawing.Size(298, 34);
            this.tsmiDanhSachDichVu.Text = "Danh sách dịch vụ";
            this.tsmiDanhSachDichVu.Click += new System.EventHandler(this.tsmiDanhSachDichVu_Click);
            // 
            // tsmiTaiChinh
            // 
            this.tsmiTaiChinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHoaDon,
            this.tsmiDoanhThuThang});
            this.tsmiTaiChinh.Name = "tsmiTaiChinh";
            this.tsmiTaiChinh.Size = new System.Drawing.Size(109, 29);
            this.tsmiTaiChinh.Text = "Tài chính";
            this.tsmiTaiChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiHoaDon
            // 
            this.tsmiHoaDon.Name = "tsmiHoaDon";
            this.tsmiHoaDon.Size = new System.Drawing.Size(249, 34);
            this.tsmiHoaDon.Text = "Hóa đơn";
            this.tsmiHoaDon.Click += new System.EventHandler(this.tsmiHoaDon_Click);
            // 
            // tsmiDoanhThuThang
            // 
            this.tsmiDoanhThuThang.Name = "tsmiDoanhThuThang";
            this.tsmiDoanhThuThang.Size = new System.Drawing.Size(249, 34);
            this.tsmiDoanhThuThang.Text = "Doanh thu tháng";
            this.tsmiDoanhThuThang.Click += new System.EventHandler(this.tsmiDoanhThuThang_Click);
            // 
            // tsmiQuyDinh
            // 
            this.tsmiQuyDinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThayDoiQuyDinh});
            this.tsmiQuyDinh.Name = "tsmiQuyDinh";
            this.tsmiQuyDinh.Size = new System.Drawing.Size(109, 29);
            this.tsmiQuyDinh.Text = "Quy định";
            this.tsmiQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsmiThayDoiQuyDinh
            // 
            this.tsmiThayDoiQuyDinh.Name = "tsmiThayDoiQuyDinh";
            this.tsmiThayDoiQuyDinh.Size = new System.Drawing.Size(257, 34);
            this.tsmiThayDoiQuyDinh.Text = "Thay đổi quy định";
            this.tsmiThayDoiQuyDinh.Click += new System.EventHandler(this.tsmiThayDoiQuyDinh_Click);
            // 
            // frnNhanDatTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 1005);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frnNhanDatTiecCuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận đặt tiệc cưới";
            this.Load += new System.EventHandler(this.frnNhanDatTiecCuoi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDashboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanh;
        private System.Windows.Forms.ToolStripMenuItem tsmiTiecCuoi;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhSachCa;
        private System.Windows.Forms.ToolStripMenuItem tsmiTaiChinh;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuyDinh;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhSachSanh;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatTiecCuoi;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhSachDatTiecCuoi;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhSachCacLoaiSanh;
        private System.Windows.Forms.ToolStripSeparator tieccuoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongTinMonAn;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhSachDichVu;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoanhThuThang;
        private System.Windows.Forms.ToolStripMenuItem tsmiThayDoiQuyDinh;
    }
}

