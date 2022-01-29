
namespace NhanDatTiecCuoi.UserControls
{
    partial class ucDanhSachCa
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
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiCa = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.epTenLoaiCa = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMaCa = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenLoaiCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaCa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(144, 213);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(108, 34);
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
            this.flowLayoutPanel3.Controls.Add(this.txtMaCa);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.txtLoaiCa);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(471, 218);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã ca";
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(10, 30);
            this.txtMaCa.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.ReadOnly = true;
            this.txtMaCa.Size = new System.Drawing.Size(404, 26);
            this.txtMaCa.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại ca";
            // 
            // txtLoaiCa
            // 
            this.txtLoaiCa.Location = new System.Drawing.Point(10, 91);
            this.txtLoaiCa.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.txtLoaiCa.Name = "txtLoaiCa";
            this.txtLoaiCa.Size = new System.Drawing.Size(404, 26);
            this.txtLoaiCa.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dgvCa);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 408);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1074, 532);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách ca";
            // 
            // dgvCa
            // 
            this.dgvCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCa.Location = new System.Drawing.Point(10, 40);
            this.dgvCa.Margin = new System.Windows.Forms.Padding(10);
            this.dgvCa.Name = "dgvCa";
            this.dgvCa.RowHeadersWidth = 62;
            this.dgvCa.RowTemplate.Height = 28;
            this.dgvCa.Size = new System.Drawing.Size(1037, 367);
            this.dgvCa.TabIndex = 1;
            this.dgvCa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCa_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÔNG TIN CA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(278, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 34);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // epTenLoaiCa
            // 
            this.epTenLoaiCa.ContainerControl = this;
            // 
            // epMaCa
            // 
            this.epMaCa.ContainerControl = this;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Location = new System.Drawing.Point(17, 213);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(108, 34);
            this.btnThemMoi.TabIndex = 12;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // ucDanhSachCa
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
            this.Name = "ucDanhSachCa";
            this.Size = new System.Drawing.Size(1074, 940);
            this.Load += new System.EventHandler(this.ucDanhSachCa_Load);
            this.Click += new System.EventHandler(this.ucDanhSachCa_Click);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTenLoaiCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaCa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoaiCa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider epTenLoaiCa;
        private System.Windows.Forms.ErrorProvider epMaCa;
        private System.Windows.Forms.Button btnThemMoi;
    }
}
