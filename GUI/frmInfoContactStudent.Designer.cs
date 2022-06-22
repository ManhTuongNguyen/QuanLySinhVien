
namespace GUI
{
    partial class frmInfoContactStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoContactStudent));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbSearchStudentContact = new System.Windows.Forms.ComboBox();
            this.btnDefaultDataContactStudent = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPhoneNumberRelativeOfStudent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaSV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameRelativeOfStudent = new System.Windows.Forms.TextBox();
            this.txtSDTSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteContactStudent = new System.Windows.Forms.Button();
            this.btnModifyContactStudent = new System.Windows.Forms.Button();
            this.btnAddContactStudent = new System.Windows.Forms.Button();
            this.pnContainDgv = new System.Windows.Forms.Panel();
            this.dgvInfoContactStudent = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnContainDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoContactStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.cbbSearchStudentContact);
            this.panel4.Controls.Add(this.btnDefaultDataContactStudent);
            this.panel4.Controls.Add(this.btnSearchStudent);
            this.panel4.Location = new System.Drawing.Point(13, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 67);
            this.panel4.TabIndex = 2;
            // 
            // cbbSearchStudentContact
            // 
            this.cbbSearchStudentContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSearchStudentContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSearchStudentContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearchStudentContact.FormattingEnabled = true;
            this.cbbSearchStudentContact.Location = new System.Drawing.Point(8, 17);
            this.cbbSearchStudentContact.Name = "cbbSearchStudentContact";
            this.cbbSearchStudentContact.Size = new System.Drawing.Size(264, 26);
            this.cbbSearchStudentContact.TabIndex = 0;
            // 
            // btnDefaultDataContactStudent
            // 
            this.btnDefaultDataContactStudent.BackgroundImage = global::GUI.Properties.Resources.icon_Default;
            this.btnDefaultDataContactStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultDataContactStudent.Location = new System.Drawing.Point(350, 11);
            this.btnDefaultDataContactStudent.Name = "btnDefaultDataContactStudent";
            this.btnDefaultDataContactStudent.Size = new System.Drawing.Size(57, 33);
            this.btnDefaultDataContactStudent.TabIndex = 2;
            this.btnDefaultDataContactStudent.UseVisualStyleBackColor = true;
            this.btnDefaultDataContactStudent.Click += new System.EventHandler(this.btnDefaultDataContactStudent_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackgroundImage = global::GUI.Properties.Resources.icon_Find;
            this.btnSearchStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchStudent.Location = new System.Drawing.Point(289, 10);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(55, 33);
            this.btnSearchStudent.TabIndex = 1;
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtPhoneNumberRelativeOfStudent);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEmailSV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbbMaSV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNameRelativeOfStudent);
            this.panel2.Controls.Add(this.txtSDTSV);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(429, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 320);
            this.panel2.TabIndex = 0;
            // 
            // txtPhoneNumberRelativeOfStudent
            // 
            this.txtPhoneNumberRelativeOfStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumberRelativeOfStudent.Location = new System.Drawing.Point(148, 268);
            this.txtPhoneNumberRelativeOfStudent.Name = "txtPhoneNumberRelativeOfStudent";
            this.txtPhoneNumberRelativeOfStudent.Size = new System.Drawing.Size(208, 27);
            this.txtPhoneNumberRelativeOfStudent.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "SĐT người thân";
            // 
            // txtEmailSV
            // 
            this.txtEmailSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSV.Location = new System.Drawing.Point(148, 133);
            this.txtEmailSV.Name = "txtEmailSV";
            this.txtEmailSV.Size = new System.Drawing.Size(208, 27);
            this.txtEmailSV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(125, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "*";
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaSV.FormattingEnabled = true;
            this.cbbMaSV.Location = new System.Drawing.Point(148, 6);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(208, 28);
            this.cbbMaSV.TabIndex = 9;
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
            // txtNameRelativeOfStudent
            // 
            this.txtNameRelativeOfStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRelativeOfStudent.Location = new System.Drawing.Point(148, 200);
            this.txtNameRelativeOfStudent.Name = "txtNameRelativeOfStudent";
            this.txtNameRelativeOfStudent.Size = new System.Drawing.Size(208, 27);
            this.txtNameRelativeOfStudent.TabIndex = 2;
            // 
            // txtSDTSV
            // 
            this.txtSDTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTSV.Location = new System.Drawing.Point(148, 68);
            this.txtSDTSV.Name = "txtSDTSV";
            this.txtSDTSV.Size = new System.Drawing.Size(208, 27);
            this.txtSDTSV.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên người thân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "SĐT SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnDeleteContactStudent);
            this.panel3.Controls.Add(this.btnModifyContactStudent);
            this.panel3.Controls.Add(this.btnAddContactStudent);
            this.panel3.Location = new System.Drawing.Point(429, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 100);
            this.panel3.TabIndex = 1;
            // 
            // btnDeleteContactStudent
            // 
            this.btnDeleteContactStudent.BackgroundImage = global::GUI.Properties.Resources.icon_Delete;
            this.btnDeleteContactStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteContactStudent.Location = new System.Drawing.Point(243, 31);
            this.btnDeleteContactStudent.Name = "btnDeleteContactStudent";
            this.btnDeleteContactStudent.Size = new System.Drawing.Size(103, 40);
            this.btnDeleteContactStudent.TabIndex = 2;
            this.btnDeleteContactStudent.UseVisualStyleBackColor = true;
            this.btnDeleteContactStudent.Click += new System.EventHandler(this.btnDeleteContactStudent_Click);
            // 
            // btnModifyContactStudent
            // 
            this.btnModifyContactStudent.BackgroundImage = global::GUI.Properties.Resources.icon_modify;
            this.btnModifyContactStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModifyContactStudent.Location = new System.Drawing.Point(122, 31);
            this.btnModifyContactStudent.Name = "btnModifyContactStudent";
            this.btnModifyContactStudent.Size = new System.Drawing.Size(103, 40);
            this.btnModifyContactStudent.TabIndex = 1;
            this.btnModifyContactStudent.UseVisualStyleBackColor = true;
            this.btnModifyContactStudent.Click += new System.EventHandler(this.btnModifyContactStudent_Click);
            // 
            // btnAddContactStudent
            // 
            this.btnAddContactStudent.BackgroundImage = global::GUI.Properties.Resources.icon_Add;
            this.btnAddContactStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddContactStudent.Location = new System.Drawing.Point(3, 31);
            this.btnAddContactStudent.Name = "btnAddContactStudent";
            this.btnAddContactStudent.Size = new System.Drawing.Size(103, 40);
            this.btnAddContactStudent.TabIndex = 0;
            this.btnAddContactStudent.UseVisualStyleBackColor = true;
            this.btnAddContactStudent.Click += new System.EventHandler(this.btnAddContactStudent_Click);
            // 
            // pnContainDgv
            // 
            this.pnContainDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContainDgv.Controls.Add(this.dgvInfoContactStudent);
            this.pnContainDgv.Location = new System.Drawing.Point(13, 94);
            this.pnContainDgv.Name = "pnContainDgv";
            this.pnContainDgv.Size = new System.Drawing.Size(410, 344);
            this.pnContainDgv.TabIndex = 6;
            this.pnContainDgv.SizeChanged += new System.EventHandler(this.pnContainDgv_SizeChanged);
            // 
            // dgvInfoContactStudent
            // 
            this.dgvInfoContactStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoContactStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoContactStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvInfoContactStudent.Name = "dgvInfoContactStudent";
            this.dgvInfoContactStudent.ReadOnly = true;
            this.dgvInfoContactStudent.RowHeadersVisible = false;
            this.dgvInfoContactStudent.RowHeadersWidth = 51;
            this.dgvInfoContactStudent.RowTemplate.Height = 24;
            this.dgvInfoContactStudent.Size = new System.Drawing.Size(410, 344);
            this.dgvInfoContactStudent.TabIndex = 0;
            this.dgvInfoContactStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoContactStudent_CellClick);
            // 
            // frmInfoContactStudent
            // 
            this.AcceptButton = this.btnAddContactStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnContainDgv);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmInfoContactStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin liên lạc sinh viên";
            this.Load += new System.EventHandler(this.frmInfoContactStudent_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnContainDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoContactStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDefaultDataContactStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameRelativeOfStudent;
        private System.Windows.Forms.TextBox txtSDTSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteContactStudent;
        private System.Windows.Forms.Button btnModifyContactStudent;
        private System.Windows.Forms.Button btnAddContactStudent;
        private System.Windows.Forms.Panel pnContainDgv;
        private System.Windows.Forms.DataGridView dgvInfoContactStudent;
        private System.Windows.Forms.TextBox txtPhoneNumberRelativeOfStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailSV;
        private System.Windows.Forms.ComboBox cbbSearchStudentContact;
    }
}