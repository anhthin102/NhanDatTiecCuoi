
namespace NhanDatTiecCuoi.UserControls
{
    partial class ucDanhSachDichVu
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
            this.sds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sds
            // 
            this.sds.AutoSize = true;
            this.sds.Location = new System.Drawing.Point(447, 218);
            this.sds.Name = "sds";
            this.sds.Size = new System.Drawing.Size(139, 20);
            this.sds.TabIndex = 0;
            this.sds.Text = "Danh sách dịch vụ";
            // 
            // ucDanhSachDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sds);
            this.Name = "ucDanhSachDichVu";
            this.Size = new System.Drawing.Size(1074, 729);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sds;
    }
}
