
namespace NhanDatTiecCuoi.UserControls
{
    partial class ucDanhSachCacLoaiSanh
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLoaiSanh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenLoaiSanh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGiaBanToiThieu = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSanh = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.epTenLoaiSanh = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDonGiaBanToiThieu = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMaLoaiSanh = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenLoaiSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDonGiaBanToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaLoaiSanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN LOẠI SẢNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.txtMaLoaiSanh);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.txtTenLoaiSanh);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.txtDonGiaBanToiThieu);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 66);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(471, 279);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã loại sảnh";
            // 
            // txtMaLoaiSanh
            // 
            this.txtMaLoaiSanh.Location = new System.Drawing.Point(10, 30);
            this.txtMaLoaiSanh.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtMaLoaiSanh.Name = "txtMaLoaiSanh";
            this.txtMaLoaiSanh.ReadOnly = true;
            this.txtMaLoaiSanh.Size = new System.Drawing.Size(404, 26);
            this.txtMaLoaiSanh.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên loại sảnh";
            // 
            // txtTenLoaiSanh
            // 
            this.txtTenLoaiSanh.Location = new System.Drawing.Point(10, 91);
            this.txtTenLoaiSanh.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtTenLoaiSanh.Name = "txtTenLoaiSanh";
            this.txtTenLoaiSanh.Size = new System.Drawing.Size(404, 26);
            this.txtTenLoaiSanh.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá bàn tối thiểu";
            // 
            // txtDonGiaBanToiThieu
            // 
            this.txtDonGiaBanToiThieu.Location = new System.Drawing.Point(10, 152);
            this.txtDonGiaBanToiThieu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtDonGiaBanToiThieu.Name = "txtDonGiaBanToiThieu";
            this.txtDonGiaBanToiThieu.Size = new System.Drawing.Size(404, 26);
            this.txtDonGiaBanToiThieu.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dgvSanh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 467);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1074, 473);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách loại sảnh";
            // 
            // dgvSanh
            // 
            this.dgvSanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanh.Location = new System.Drawing.Point(10, 40);
            this.dgvSanh.Margin = new System.Windows.Forms.Padding(10);
            this.dgvSanh.Name = "dgvSanh";
            this.dgvSanh.RowHeadersWidth = 62;
            this.dgvSanh.RowTemplate.Height = 28;
            this.dgvSanh.Size = new System.Drawing.Size(1054, 335);
            this.dgvSanh.TabIndex = 1;
            this.dgvSanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanh_CellClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(145, 285);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 34);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(275, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Location = new System.Drawing.Point(17, 285);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(108, 34);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // epTenLoaiSanh
            // 
            this.epTenLoaiSanh.ContainerControl = this;
            // 
            // epDonGiaBanToiThieu
            // 
            this.epDonGiaBanToiThieu.ContainerControl = this;
            // 
            // epMaLoaiSanh
            // 
            this.epMaLoaiSanh.ContainerControl = this;
            // 
            // ucDanhSachCacLoaiSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ucDanhSachCacLoaiSanh";
            this.Size = new System.Drawing.Size(1074, 940);
            this.Load += new System.EventHandler(this.ucDanhSachCacLoaiSanh_Load);
            this.Click += new System.EventHandler(this.ucDanhSachCacLoaiSanh_Click);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenLoaiSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDonGiaBanToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaLoaiSanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox txtMaLoaiSanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenLoaiSanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGiaBanToiThieu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider epTenLoaiSanh;
        private System.Windows.Forms.ErrorProvider epDonGiaBanToiThieu;
        private System.Windows.Forms.ErrorProvider epMaLoaiSanh;
    }
}
