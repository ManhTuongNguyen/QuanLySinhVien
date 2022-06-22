
namespace GUI
{
    partial class frmQuanLyMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyMonHoc));
            this.pnContainDgv = new System.Windows.Forms.Panel();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.btnSuaMonHoc = new System.Windows.Forms.Button();
            this.btnAddMonHoc = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDefaultDataMonHoc = new System.Windows.Forms.Button();
            this.btnSearchMonHoc = new System.Windows.Forms.Button();
            this.txtSearchMonHoc = new System.Windows.Forms.TextBox();
            this.pnContainDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainDgv
            // 
            this.pnContainDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContainDgv.Controls.Add(this.dgvMonHoc);
            this.pnContainDgv.Location = new System.Drawing.Point(13, 85);
            this.pnContainDgv.Name = "pnContainDgv";
            this.pnContainDgv.Size = new System.Drawing.Size(410, 353);
            this.pnContainDgv.TabIndex = 3;
            this.pnContainDgv.SizeChanged += new System.EventHandler(this.pnContainDgv_SizeChanged);
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 0);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(410, 353);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbbMaKhoa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSoTinChi);
            this.panel2.Controls.Add(this.txtTenMonHoc);
            this.panel2.Controls.Add(this.txtMaMonHoc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(429, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 320);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(125, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(63, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "*";
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(86, 73);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(270, 28);
            this.cbbMaKhoa.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(125, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "*";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTinChi.Location = new System.Drawing.Point(148, 208);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(208, 27);
            this.txtSoTinChi.TabIndex = 3;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.Location = new System.Drawing.Point(148, 140);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(208, 27);
            this.txtTenMonHoc.TabIndex = 2;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(148, 10);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(208, 27);
            this.txtMaMonHoc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tín chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnXoaMonHoc);
            this.panel3.Controls.Add(this.btnSuaMonHoc);
            this.panel3.Controls.Add(this.btnAddMonHoc);
            this.panel3.Location = new System.Drawing.Point(429, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.BackgroundImage = global::GUI.Properties.Resources.icon_Delete;
            this.btnXoaMonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaMonHoc.Location = new System.Drawing.Point(243, 31);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(103, 40);
            this.btnXoaMonHoc.TabIndex = 2;
            this.btnXoaMonHoc.UseVisualStyleBackColor = true;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaMonHoc_Click);
            // 
            // btnSuaMonHoc
            // 
            this.btnSuaMonHoc.BackgroundImage = global::GUI.Properties.Resources.icon_modify;
            this.btnSuaMonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaMonHoc.Location = new System.Drawing.Point(122, 31);
            this.btnSuaMonHoc.Name = "btnSuaMonHoc";
            this.btnSuaMonHoc.Size = new System.Drawing.Size(103, 40);
            this.btnSuaMonHoc.TabIndex = 1;
            this.btnSuaMonHoc.UseVisualStyleBackColor = true;
            this.btnSuaMonHoc.Click += new System.EventHandler(this.btnSuaMonHoc_Click);
            // 
            // btnAddMonHoc
            // 
            this.btnAddMonHoc.BackgroundImage = global::GUI.Properties.Resources.icon_Add;
            this.btnAddMonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMonHoc.Location = new System.Drawing.Point(3, 31);
            this.btnAddMonHoc.Name = "btnAddMonHoc";
            this.btnAddMonHoc.Size = new System.Drawing.Size(103, 40);
            this.btnAddMonHoc.TabIndex = 0;
            this.btnAddMonHoc.UseVisualStyleBackColor = true;
            this.btnAddMonHoc.Click += new System.EventHandler(this.btnAddMonHoc_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.btnDefaultDataMonHoc);
            this.panel4.Controls.Add(this.btnSearchMonHoc);
            this.panel4.Controls.Add(this.txtSearchMonHoc);
            this.panel4.Location = new System.Drawing.Point(13, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 67);
            this.panel4.TabIndex = 2;
            // 
            // btnDefaultDataMonHoc
            // 
            this.btnDefaultDataMonHoc.BackgroundImage = global::GUI.Properties.Resources.icon_Default;
            this.btnDefaultDataMonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultDataMonHoc.Location = new System.Drawing.Point(321, 11);
            this.btnDefaultDataMonHoc.Name = "btnDefaultDataMonHoc";
            this.btnDefaultDataMonHoc.Size = new System.Drawing.Size(86, 33);
            this.btnDefaultDataMonHoc.TabIndex = 2;
            this.btnDefaultDataMonHoc.UseVisualStyleBackColor = true;
            this.btnDefaultDataMonHoc.Click += new System.EventHandler(this.btnDefaultDataMonHoc_Click);
            // 
            // btnSearchMonHoc
            // 
            this.btnSearchMonHoc.BackgroundImage = global::GUI.Properties.Resources.icon_Find;
            this.btnSearchMonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchMonHoc.Location = new System.Drawing.Point(217, 11);
            this.btnSearchMonHoc.Name = "btnSearchMonHoc";
            this.btnSearchMonHoc.Size = new System.Drawing.Size(86, 33);
            this.btnSearchMonHoc.TabIndex = 1;
            this.btnSearchMonHoc.UseVisualStyleBackColor = true;
            this.btnSearchMonHoc.Click += new System.EventHandler(this.btnSearchMonHoc_Click);
            // 
            // txtSearchMonHoc
            // 
            this.txtSearchMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMonHoc.Location = new System.Drawing.Point(3, 13);
            this.txtSearchMonHoc.Name = "txtSearchMonHoc";
            this.txtSearchMonHoc.Size = new System.Drawing.Size(208, 27);
            this.txtSearchMonHoc.TabIndex = 0;
            // 
            // frmQuanLyMonHoc
            // 
            this.AcceptButton = this.btnAddMonHoc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnContainDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmQuanLyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.frmQuanLyMonHoc_Load);
            this.pnContainDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainDgv;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.Button btnSuaMonHoc;
        private System.Windows.Forms.Button btnAddMonHoc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchMonHoc;
        private System.Windows.Forms.Button btnDefaultDataMonHoc;
        private System.Windows.Forms.Button btnSearchMonHoc;
    }
}