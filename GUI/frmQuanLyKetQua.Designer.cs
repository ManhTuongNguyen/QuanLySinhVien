
namespace GUI
{
    partial class frmQuanLyKetQua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKetQua));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDefaultDataKetQua = new System.Windows.Forms.Button();
            this.btnSearchKetQua = new System.Windows.Forms.Button();
            this.txtSearchKetQua = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteKetQua = new System.Windows.Forms.Button();
            this.btnModifyKetQua = new System.Windows.Forms.Button();
            this.btnAddKetQua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemThiLan2 = new System.Windows.Forms.TextBox();
            this.cbbMaSinhVien_MH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.txtDiemThiLan1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContainerDgv = new System.Windows.Forms.Panel();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnContainerDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.btnDefaultDataKetQua);
            this.panel4.Controls.Add(this.btnSearchKetQua);
            this.panel4.Controls.Add(this.txtSearchKetQua);
            this.panel4.Location = new System.Drawing.Point(13, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 56);
            this.panel4.TabIndex = 2;
            // 
            // btnDefaultDataKetQua
            // 
            this.btnDefaultDataKetQua.BackgroundImage = global::GUI.Properties.Resources.icon_Default;
            this.btnDefaultDataKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultDataKetQua.Location = new System.Drawing.Point(321, 11);
            this.btnDefaultDataKetQua.Name = "btnDefaultDataKetQua";
            this.btnDefaultDataKetQua.Size = new System.Drawing.Size(86, 33);
            this.btnDefaultDataKetQua.TabIndex = 2;
            this.btnDefaultDataKetQua.UseVisualStyleBackColor = true;
            this.btnDefaultDataKetQua.Click += new System.EventHandler(this.btnDefaultDataKetQua_Click);
            // 
            // btnSearchKetQua
            // 
            this.btnSearchKetQua.BackgroundImage = global::GUI.Properties.Resources.icon_Find;
            this.btnSearchKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchKetQua.Location = new System.Drawing.Point(221, 11);
            this.btnSearchKetQua.Name = "btnSearchKetQua";
            this.btnSearchKetQua.Size = new System.Drawing.Size(86, 33);
            this.btnSearchKetQua.TabIndex = 1;
            this.btnSearchKetQua.UseVisualStyleBackColor = true;
            this.btnSearchKetQua.Click += new System.EventHandler(this.btnSearchKetQua_Click);
            // 
            // txtSearchKetQua
            // 
            this.txtSearchKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKetQua.Location = new System.Drawing.Point(3, 13);
            this.txtSearchKetQua.Name = "txtSearchKetQua";
            this.txtSearchKetQua.Size = new System.Drawing.Size(208, 27);
            this.txtSearchKetQua.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnDeleteKetQua);
            this.panel3.Controls.Add(this.btnModifyKetQua);
            this.panel3.Controls.Add(this.btnAddKetQua);
            this.panel3.Location = new System.Drawing.Point(429, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnDeleteKetQua
            // 
            this.btnDeleteKetQua.BackgroundImage = global::GUI.Properties.Resources.icon_Delete;
            this.btnDeleteKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteKetQua.Location = new System.Drawing.Point(243, 31);
            this.btnDeleteKetQua.Name = "btnDeleteKetQua";
            this.btnDeleteKetQua.Size = new System.Drawing.Size(103, 40);
            this.btnDeleteKetQua.TabIndex = 2;
            this.btnDeleteKetQua.UseVisualStyleBackColor = true;
            this.btnDeleteKetQua.Click += new System.EventHandler(this.btnDeleteKetQua_Click);
            // 
            // btnModifyKetQua
            // 
            this.btnModifyKetQua.BackgroundImage = global::GUI.Properties.Resources.icon_modify;
            this.btnModifyKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifyKetQua.Location = new System.Drawing.Point(122, 31);
            this.btnModifyKetQua.Name = "btnModifyKetQua";
            this.btnModifyKetQua.Size = new System.Drawing.Size(103, 40);
            this.btnModifyKetQua.TabIndex = 1;
            this.btnModifyKetQua.UseVisualStyleBackColor = true;
            this.btnModifyKetQua.Click += new System.EventHandler(this.btnModifyKetQua_Click);
            // 
            // btnAddKetQua
            // 
            this.btnAddKetQua.BackgroundImage = global::GUI.Properties.Resources.icon_Add;
            this.btnAddKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddKetQua.Location = new System.Drawing.Point(3, 31);
            this.btnAddKetQua.Name = "btnAddKetQua";
            this.btnAddKetQua.Size = new System.Drawing.Size(103, 40);
            this.btnAddKetQua.TabIndex = 0;
            this.btnAddKetQua.UseVisualStyleBackColor = true;
            this.btnAddKetQua.Click += new System.EventHandler(this.btnAddKetQua_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDiemThiLan2);
            this.panel2.Controls.Add(this.cbbMaSinhVien_MH);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbbMaMonHoc);
            this.panel2.Controls.Add(this.txtDiemThiLan1);
            this.panel2.Controls.Add(this.label5);
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
            this.label7.Location = new System.Drawing.Point(130, 124);
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
            this.label6.Location = new System.Drawing.Point(97, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "*";
            // 
            // txtDiemThiLan2
            // 
            this.txtDiemThiLan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThiLan2.Location = new System.Drawing.Point(153, 189);
            this.txtDiemThiLan2.Name = "txtDiemThiLan2";
            this.txtDiemThiLan2.Size = new System.Drawing.Size(203, 27);
            this.txtDiemThiLan2.TabIndex = 3;
            // 
            // cbbMaSinhVien_MH
            // 
            this.cbbMaSinhVien_MH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSinhVien_MH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaSinhVien_MH.FormattingEnabled = true;
            this.cbbMaSinhVien_MH.Location = new System.Drawing.Point(122, 10);
            this.cbbMaSinhVien_MH.Name = "cbbMaSinhVien_MH";
            this.cbbMaSinhVien_MH.Size = new System.Drawing.Size(234, 28);
            this.cbbMaSinhVien_MH.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm thi lần 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm thi lần 2";
            // 
            // cbbMaMonHoc
            // 
            this.cbbMaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaMonHoc.FormattingEnabled = true;
            this.cbbMaMonHoc.Location = new System.Drawing.Point(122, 73);
            this.cbbMaMonHoc.Name = "cbbMaMonHoc";
            this.cbbMaMonHoc.Size = new System.Drawing.Size(234, 28);
            this.cbbMaMonHoc.TabIndex = 1;
            // 
            // txtDiemThiLan1
            // 
            this.txtDiemThiLan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThiLan1.Location = new System.Drawing.Point(153, 121);
            this.txtDiemThiLan1.Name = "txtDiemThiLan1";
            this.txtDiemThiLan1.Size = new System.Drawing.Size(203, 27);
            this.txtDiemThiLan1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(97, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh viên";
            // 
            // pnContainerDgv
            // 
            this.pnContainerDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContainerDgv.Controls.Add(this.dgvKetQua);
            this.pnContainerDgv.Location = new System.Drawing.Point(13, 74);
            this.pnContainerDgv.Name = "pnContainerDgv";
            this.pnContainerDgv.Size = new System.Drawing.Size(410, 364);
            this.pnContainerDgv.TabIndex = 3;
            this.pnContainerDgv.SizeChanged += new System.EventHandler(this.pnContainerDgv_SizeChanged);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(0, 0);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersVisible = false;
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.Size = new System.Drawing.Size(410, 364);
            this.dgvKetQua.TabIndex = 0;
            this.dgvKetQua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellClick);
            // 
            // frmQuanLyKetQua
            // 
            this.AcceptButton = this.btnAddKetQua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnContainerDgv);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmQuanLyKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý kết quả";
            this.Load += new System.EventHandler(this.frmQuanLyKetQua_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnContainerDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDefaultDataKetQua;
        private System.Windows.Forms.Button btnSearchKetQua;
        private System.Windows.Forms.TextBox txtSearchKetQua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteKetQua;
        private System.Windows.Forms.Button btnModifyKetQua;
        private System.Windows.Forms.Button btnAddKetQua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemThiLan2;
        private System.Windows.Forms.TextBox txtDiemThiLan1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaSinhVien_MH;
        private System.Windows.Forms.ComboBox cbbMaMonHoc;
        private System.Windows.Forms.Panel pnContainerDgv;
        private System.Windows.Forms.DataGridView dgvKetQua;
    }
}