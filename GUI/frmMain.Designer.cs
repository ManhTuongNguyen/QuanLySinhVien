
namespace GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnQuanLy = new System.Windows.Forms.Panel();
            this.btnInfoContactStudent = new System.Windows.Forms.Button();
            this.btnDiemDetails = new System.Windows.Forms.Button();
            this.btnQuanLyDiem = new System.Windows.Forms.Button();
            this.btnQuanLySinhVien = new System.Windows.Forms.Button();
            this.btnQuanLyMonHoc = new System.Windows.Forms.Button();
            this.pnThongTinSinhVien = new System.Windows.Forms.Panel();
            this.btnDiemSinhVien = new System.Windows.Forms.Button();
            this.btnThongTinSinhVien = new System.Windows.Forms.Button();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnQuanLy.SuspendLayout();
            this.pnThongTinSinhVien.SuspendLayout();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thoongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thoongToolStripMenuItem
            // 
            this.thoongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiThôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thoongToolStripMenuItem.Name = "thoongToolStripMenuItem";
            this.thoongToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thoongToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thayĐổiThôngTinToolStripMenuItem
            // 
            this.thayĐổiThôngTinToolStripMenuItem.Name = "thayĐổiThôngTinToolStripMenuItem";
            this.thayĐổiThôngTinToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.thayĐổiThôngTinToolStripMenuItem.Text = "Thay đổi thông tin";
            this.thayĐổiThôngTinToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiThôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pnQuanLy
            // 
            this.pnQuanLy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnQuanLy.Controls.Add(this.btnInfoContactStudent);
            this.pnQuanLy.Controls.Add(this.btnDiemDetails);
            this.pnQuanLy.Controls.Add(this.btnQuanLyDiem);
            this.pnQuanLy.Controls.Add(this.btnQuanLySinhVien);
            this.pnQuanLy.Controls.Add(this.btnQuanLyMonHoc);
            this.pnQuanLy.Location = new System.Drawing.Point(167, 127);
            this.pnQuanLy.Name = "pnQuanLy";
            this.pnQuanLy.Size = new System.Drawing.Size(888, 100);
            this.pnQuanLy.TabIndex = 1;
            // 
            // btnInfoContactStudent
            // 
            this.btnInfoContactStudent.Location = new System.Drawing.Point(738, 23);
            this.btnInfoContactStudent.Name = "btnInfoContactStudent";
            this.btnInfoContactStudent.Size = new System.Drawing.Size(147, 46);
            this.btnInfoContactStudent.TabIndex = 4;
            this.btnInfoContactStudent.Text = "Thông tin liên hệ sinh viên";
            this.btnInfoContactStudent.UseVisualStyleBackColor = true;
            this.btnInfoContactStudent.Click += new System.EventHandler(this.btnInfoContactStudent_Click);
            // 
            // btnDiemDetails
            // 
            this.btnDiemDetails.Location = new System.Drawing.Point(572, 23);
            this.btnDiemDetails.Name = "btnDiemDetails";
            this.btnDiemDetails.Size = new System.Drawing.Size(147, 46);
            this.btnDiemDetails.TabIndex = 3;
            this.btnDiemDetails.Text = "Chi tiết Điểm";
            this.btnDiemDetails.UseVisualStyleBackColor = true;
            this.btnDiemDetails.Click += new System.EventHandler(this.btnDiemDetails_Click);
            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.Location = new System.Drawing.Point(400, 23);
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.Size = new System.Drawing.Size(147, 46);
            this.btnQuanLyDiem.TabIndex = 2;
            this.btnQuanLyDiem.Text = "Quản lý điểm";
            this.btnQuanLyDiem.UseVisualStyleBackColor = true;
            this.btnQuanLyDiem.Click += new System.EventHandler(this.btnQuanLyDiem_Click);
            // 
            // btnQuanLySinhVien
            // 
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(212, 23);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(147, 46);
            this.btnQuanLySinhVien.TabIndex = 1;
            this.btnQuanLySinhVien.Text = "Quản lý sinh viên";
            this.btnQuanLySinhVien.UseVisualStyleBackColor = true;
            this.btnQuanLySinhVien.Click += new System.EventHandler(this.btnQuanLySinhVien_Click);
            // 
            // btnQuanLyMonHoc
            // 
            this.btnQuanLyMonHoc.Location = new System.Drawing.Point(16, 23);
            this.btnQuanLyMonHoc.Name = "btnQuanLyMonHoc";
            this.btnQuanLyMonHoc.Size = new System.Drawing.Size(147, 46);
            this.btnQuanLyMonHoc.TabIndex = 0;
            this.btnQuanLyMonHoc.Text = "Quản lý Môn học";
            this.btnQuanLyMonHoc.UseVisualStyleBackColor = true;
            this.btnQuanLyMonHoc.Click += new System.EventHandler(this.btnQuanLyMonHoc_Click);
            // 
            // pnThongTinSinhVien
            // 
            this.pnThongTinSinhVien.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnThongTinSinhVien.Controls.Add(this.btnDiemSinhVien);
            this.pnThongTinSinhVien.Controls.Add(this.btnThongTinSinhVien);
            this.pnThongTinSinhVien.Location = new System.Drawing.Point(581, 233);
            this.pnThongTinSinhVien.Name = "pnThongTinSinhVien";
            this.pnThongTinSinhVien.Size = new System.Drawing.Size(474, 100);
            this.pnThongTinSinhVien.TabIndex = 2;
            // 
            // btnDiemSinhVien
            // 
            this.btnDiemSinhVien.Location = new System.Drawing.Point(284, 28);
            this.btnDiemSinhVien.Name = "btnDiemSinhVien";
            this.btnDiemSinhVien.Size = new System.Drawing.Size(147, 46);
            this.btnDiemSinhVien.TabIndex = 2;
            this.btnDiemSinhVien.Text = "Điểm cá nhân";
            this.btnDiemSinhVien.UseVisualStyleBackColor = true;
            this.btnDiemSinhVien.Click += new System.EventHandler(this.btnDiemSinhVien_Click);
            // 
            // btnThongTinSinhVien
            // 
            this.btnThongTinSinhVien.Location = new System.Drawing.Point(53, 28);
            this.btnThongTinSinhVien.Name = "btnThongTinSinhVien";
            this.btnThongTinSinhVien.Size = new System.Drawing.Size(147, 46);
            this.btnThongTinSinhVien.TabIndex = 0;
            this.btnThongTinSinhVien.Text = "Hồ sơ sinh viên";
            this.btnThongTinSinhVien.UseVisualStyleBackColor = true;
            this.btnThongTinSinhVien.Click += new System.EventHandler(this.btnThongTinSinhVien_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnTitle.Controls.Add(this.pbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.ForeColor = System.Drawing.Color.Transparent;
            this.pnTitle.Location = new System.Drawing.Point(0, 28);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1067, 91);
            this.pnTitle.TabIndex = 3;
            // 
            // pbTitle
            // 
            this.pbTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTitle.Image = global::GUI.Properties.Resources.QLSV_RemoveBackGround;
            this.pbTitle.Location = new System.Drawing.Point(0, 0);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(1067, 91);
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTitle.TabIndex = 0;
            this.pbTitle.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 514);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnThongTinSinhVien);
            this.Controls.Add(this.pnQuanLy);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1085, 561);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnQuanLy.ResumeLayout(false);
            this.pnThongTinSinhVien.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel pnQuanLy;
        private System.Windows.Forms.Button btnQuanLyDiem;
        private System.Windows.Forms.Button btnQuanLySinhVien;
        private System.Windows.Forms.Button btnQuanLyMonHoc;
        private System.Windows.Forms.Button btnDiemDetails;
        private System.Windows.Forms.Button btnInfoContactStudent;
        private System.Windows.Forms.Panel pnThongTinSinhVien;
        private System.Windows.Forms.Button btnDiemSinhVien;
        private System.Windows.Forms.Button btnThongTinSinhVien;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.PictureBox pbTitle;
    }
}