
namespace GUI
{
    partial class frmDiemDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemDetails));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbSearchDiemDetails = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDefaultDataKetQua = new System.Windows.Forms.Button();
            this.btnSearchKetQua = new System.Windows.Forms.Button();
            this.txtSearchKetQua = new System.Windows.Forms.TextBox();
            this.pnContainerDgv = new System.Windows.Forms.Panel();
            this.dgvDiemDetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSortDiemDetails_Des = new System.Windows.Forms.Button();
            this.btnSortDiemDetails_Asc = new System.Windows.Forms.Button();
            this.cbbSortDiemDetails = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.pnContainerDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.cbbSearchDiemDetails);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnDefaultDataKetQua);
            this.panel4.Controls.Add(this.btnSearchKetQua);
            this.panel4.Controls.Add(this.txtSearchKetQua);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 67);
            this.panel4.TabIndex = 3;
            // 
            // cbbSearchDiemDetails
            // 
            this.cbbSearchDiemDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchDiemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearchDiemDetails.FormattingEnabled = true;
            this.cbbSearchDiemDetails.Location = new System.Drawing.Point(7, 33);
            this.cbbSearchDiemDetails.Name = "cbbSearchDiemDetails";
            this.cbbSearchDiemDetails.Size = new System.Drawing.Size(149, 26);
            this.cbbSearchDiemDetails.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // btnDefaultDataKetQua
            // 
            this.btnDefaultDataKetQua.BackgroundImage = global::GUI.Properties.Resources.icon_Default;
            this.btnDefaultDataKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultDataKetQua.Location = new System.Drawing.Point(462, 15);
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
            this.btnSearchKetQua.Location = new System.Drawing.Point(370, 15);
            this.btnSearchKetQua.Name = "btnSearchKetQua";
            this.btnSearchKetQua.Size = new System.Drawing.Size(86, 33);
            this.btnSearchKetQua.TabIndex = 1;
            this.btnSearchKetQua.UseVisualStyleBackColor = true;
            this.btnSearchKetQua.Click += new System.EventHandler(this.btnSearchKetQua_Click);
            // 
            // txtSearchKetQua
            // 
            this.txtSearchKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKetQua.Location = new System.Drawing.Point(174, 17);
            this.txtSearchKetQua.Name = "txtSearchKetQua";
            this.txtSearchKetQua.Size = new System.Drawing.Size(171, 27);
            this.txtSearchKetQua.TabIndex = 0;
            // 
            // pnContainerDgv
            // 
            this.pnContainerDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContainerDgv.Controls.Add(this.dgvDiemDetails);
            this.pnContainerDgv.Location = new System.Drawing.Point(12, 150);
            this.pnContainerDgv.Name = "pnContainerDgv";
            this.pnContainerDgv.Size = new System.Drawing.Size(559, 288);
            this.pnContainerDgv.TabIndex = 4;
            this.pnContainerDgv.SizeChanged += new System.EventHandler(this.pnContainerDgv_SizeChanged);
            // 
            // dgvDiemDetails
            // 
            this.dgvDiemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvDiemDetails.MinimumSize = new System.Drawing.Size(559, 288);
            this.dgvDiemDetails.Name = "dgvDiemDetails";
            this.dgvDiemDetails.ReadOnly = true;
            this.dgvDiemDetails.RowHeadersVisible = false;
            this.dgvDiemDetails.RowHeadersWidth = 51;
            this.dgvDiemDetails.RowTemplate.Height = 24;
            this.dgvDiemDetails.Size = new System.Drawing.Size(559, 288);
            this.dgvDiemDetails.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnSortDiemDetails_Des);
            this.panel2.Controls.Add(this.btnSortDiemDetails_Asc);
            this.panel2.Controls.Add(this.cbbSortDiemDetails);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 58);
            this.panel2.TabIndex = 5;
            // 
            // btnSortDiemDetails_Des
            // 
            this.btnSortDiemDetails_Des.BackgroundImage = global::GUI.Properties.Resources.Sort_icon_Alpha_Desc;
            this.btnSortDiemDetails_Des.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSortDiemDetails_Des.Location = new System.Drawing.Point(462, 11);
            this.btnSortDiemDetails_Des.Name = "btnSortDiemDetails_Des";
            this.btnSortDiemDetails_Des.Size = new System.Drawing.Size(86, 33);
            this.btnSortDiemDetails_Des.TabIndex = 11;
            this.btnSortDiemDetails_Des.UseVisualStyleBackColor = true;
            this.btnSortDiemDetails_Des.Click += new System.EventHandler(this.btnSortDiemDetails_Des_Click);
            // 
            // btnSortDiemDetails_Asc
            // 
            this.btnSortDiemDetails_Asc.BackgroundImage = global::GUI.Properties.Resources.Sort_icon_Alpha;
            this.btnSortDiemDetails_Asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSortDiemDetails_Asc.Location = new System.Drawing.Point(370, 11);
            this.btnSortDiemDetails_Asc.Name = "btnSortDiemDetails_Asc";
            this.btnSortDiemDetails_Asc.Size = new System.Drawing.Size(86, 33);
            this.btnSortDiemDetails_Asc.TabIndex = 10;
            this.btnSortDiemDetails_Asc.UseVisualStyleBackColor = true;
            this.btnSortDiemDetails_Asc.Click += new System.EventHandler(this.btnSortDiemDetails_Asc_Click);
            // 
            // cbbSortDiemDetails
            // 
            this.cbbSortDiemDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortDiemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortDiemDetails.FormattingEnabled = true;
            this.cbbSortDiemDetails.Location = new System.Drawing.Point(142, 18);
            this.cbbSortDiemDetails.Name = "cbbSortDiemDetails";
            this.cbbSortDiemDetails.Size = new System.Drawing.Size(217, 26);
            this.cbbSortDiemDetails.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sắp xếp theo";
            // 
            // frmDiemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnContainerDgv);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(597, 497);
            this.Name = "frmDiemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin chi tiết điểm sinh viên";
            this.Load += new System.EventHandler(this.frmDiemDetails_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnContainerDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDefaultDataKetQua;
        private System.Windows.Forms.Button btnSearchKetQua;
        private System.Windows.Forms.TextBox txtSearchKetQua;
        private System.Windows.Forms.ComboBox cbbSearchDiemDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnContainerDgv;
        private System.Windows.Forms.DataGridView dgvDiemDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbSortDiemDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSortDiemDetails_Des;
        private System.Windows.Forms.Button btnSortDiemDetails_Asc;
    }
}