
namespace GUI
{
    partial class frmQuanLySinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySinhVien));
            this.pnSearchSinhVien = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbSearchStudent = new System.Windows.Forms.ComboBox();
            this.btnDefaultDataStudent = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.pnContainerDgv = new System.Windows.Forms.Panel();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.pnStudentDetails = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbbTinhTrangSV = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbbMaLop_SV = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtQueQuanSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbGioiTinhSV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpNgaySinhSV = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnDeleteSinhVien = new System.Windows.Forms.Button();
            this.btnModiFySinhVien = new System.Windows.Forms.Button();
            this.btnAddSinhVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSortDes = new System.Windows.Forms.Button();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.cbbSortStudent = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pnSearchSinhVien.SuspendLayout();
            this.pnContainerDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.pnStudentDetails.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearchSinhVien
            // 
            this.pnSearchSinhVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnSearchSinhVien.Controls.Add(this.label17);
            this.pnSearchSinhVien.Controls.Add(this.cbbSearchStudent);
            this.pnSearchSinhVien.Controls.Add(this.btnDefaultDataStudent);
            this.pnSearchSinhVien.Controls.Add(this.btnSearchStudent);
            this.pnSearchSinhVien.Location = new System.Drawing.Point(13, 12);
            this.pnSearchSinhVien.Name = "pnSearchSinhVien";
            this.pnSearchSinhVien.Size = new System.Drawing.Size(623, 67);
            this.pnSearchSinhVien.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Tìm sinh viên theo:";
            // 
            // cbbSearchStudent
            // 
            this.cbbSearchStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearchStudent.FormattingEnabled = true;
            this.cbbSearchStudent.Location = new System.Drawing.Point(4, 30);
            this.cbbSearchStudent.Name = "cbbSearchStudent";
            this.cbbSearchStudent.Size = new System.Drawing.Size(150, 28);
            this.cbbSearchStudent.TabIndex = 0;
            this.cbbSearchStudent.SelectedIndexChanged += new System.EventHandler(this.cbbSearchStudent_SelectedIndexChanged);
            // 
            // btnDefaultDataStudent
            // 
            this.btnDefaultDataStudent.BackgroundImage = global::GUI.Properties.Resources.icon_Default;
            this.btnDefaultDataStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultDataStudent.Location = new System.Drawing.Point(534, 25);
            this.btnDefaultDataStudent.Name = "btnDefaultDataStudent";
            this.btnDefaultDataStudent.Size = new System.Drawing.Size(86, 33);
            this.btnDefaultDataStudent.TabIndex = 3;
            this.btnDefaultDataStudent.UseVisualStyleBackColor = true;
            this.btnDefaultDataStudent.Click += new System.EventHandler(this.btnDefaultDataStudent_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackgroundImage = global::GUI.Properties.Resources.icon_Find;
            this.btnSearchStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchStudent.Location = new System.Drawing.Point(442, 25);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(86, 33);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // pnContainerDgv
            // 
            this.pnContainerDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContainerDgv.Controls.Add(this.dgvSinhVien);
            this.pnContainerDgv.Location = new System.Drawing.Point(13, 129);
            this.pnContainerDgv.Name = "pnContainerDgv";
            this.pnContainerDgv.Size = new System.Drawing.Size(623, 363);
            this.pnContainerDgv.TabIndex = 1;
            this.pnContainerDgv.SizeChanged += new System.EventHandler(this.pnContainerDgv_SizeChanged);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(623, 363);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // pnStudentDetails
            // 
            this.pnStudentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStudentDetails.Controls.Add(this.panel11);
            this.pnStudentDetails.Controls.Add(this.panel10);
            this.pnStudentDetails.Controls.Add(this.panel9);
            this.pnStudentDetails.Controls.Add(this.panel8);
            this.pnStudentDetails.Controls.Add(this.panel7);
            this.pnStudentDetails.Controls.Add(this.panel6);
            this.pnStudentDetails.Controls.Add(this.panel5);
            this.pnStudentDetails.Controls.Add(this.panel4);
            this.pnStudentDetails.Location = new System.Drawing.Point(642, 13);
            this.pnStudentDetails.Name = "pnStudentDetails";
            this.pnStudentDetails.Size = new System.Drawing.Size(312, 411);
            this.pnStudentDetails.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.cbbTinhTrangSV);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Location = new System.Drawing.Point(3, 360);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(309, 38);
            this.panel11.TabIndex = 7;
            // 
            // cbbTinhTrangSV
            // 
            this.cbbTinhTrangSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTinhTrangSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrangSV.FormattingEnabled = true;
            this.cbbTinhTrangSV.Location = new System.Drawing.Point(134, 3);
            this.cbbTinhTrangSV.Name = "cbbTinhTrangSV";
            this.cbbTinhTrangSV.Size = new System.Drawing.Size(172, 28);
            this.cbbTinhTrangSV.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(105, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tình trạng";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbbMaLop_SV);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Location = new System.Drawing.Point(3, 310);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(309, 38);
            this.panel10.TabIndex = 6;
            // 
            // cbbMaLop_SV
            // 
            this.cbbMaLop_SV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaLop_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLop_SV.FormattingEnabled = true;
            this.cbbMaLop_SV.Location = new System.Drawing.Point(62, 3);
            this.cbbMaLop_SV.Name = "cbbMaLop_SV";
            this.cbbMaLop_SV.Size = new System.Drawing.Size(244, 26);
            this.cbbMaLop_SV.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(41, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lớp";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtDanToc);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(3, 259);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(309, 38);
            this.panel9.TabIndex = 5;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanToc.Location = new System.Drawing.Point(131, 3);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(172, 27);
            this.txtDanToc.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(105, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Dân tộc";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtQueQuanSV);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(3, 209);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(309, 38);
            this.panel8.TabIndex = 4;
            // 
            // txtQueQuanSV
            // 
            this.txtQueQuanSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuanSV.Location = new System.Drawing.Point(131, 3);
            this.txtQueQuanSV.Name = "txtQueQuanSV";
            this.txtQueQuanSV.Size = new System.Drawing.Size(172, 27);
            this.txtQueQuanSV.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(105, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quê quán";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbbGioiTinhSV);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(3, 158);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(309, 38);
            this.panel7.TabIndex = 3;
            // 
            // cbbGioiTinhSV
            // 
            this.cbbGioiTinhSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinhSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioiTinhSV.FormattingEnabled = true;
            this.cbbGioiTinhSV.Location = new System.Drawing.Point(131, 6);
            this.cbbGioiTinhSV.Name = "cbbGioiTinhSV";
            this.cbbGioiTinhSV.Size = new System.Drawing.Size(172, 28);
            this.cbbGioiTinhSV.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(105, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giới tính";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpNgaySinhSV);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(309, 38);
            this.panel6.TabIndex = 2;
            // 
            // dtpNgaySinhSV
            // 
            this.dtpNgaySinhSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhSV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhSV.Location = new System.Drawing.Point(131, 6);
            this.dtpNgaySinhSV.Name = "dtpNgaySinhSV";
            this.dtpNgaySinhSV.Size = new System.Drawing.Size(172, 27);
            this.dtpNgaySinhSV.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(105, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtHoTenSV);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 38);
            this.panel5.TabIndex = 1;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenSV.Location = new System.Drawing.Point(131, 6);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(172, 27);
            this.txtHoTenSV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(105, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMaSinhVien);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 38);
            this.panel4.TabIndex = 0;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSinhVien.Location = new System.Drawing.Point(134, 3);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(169, 27);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(112, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.btnDeleteSinhVien);
            this.panel12.Controls.Add(this.btnModiFySinhVien);
            this.panel12.Controls.Add(this.btnAddSinhVien);
            this.panel12.Location = new System.Drawing.Point(642, 430);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(312, 62);
            this.panel12.TabIndex = 1;
            // 
            // btnDeleteSinhVien
            // 
            this.btnDeleteSinhVien.BackgroundImage = global::GUI.Properties.Resources.icon_Delete;
            this.btnDeleteSinhVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteSinhVien.Location = new System.Drawing.Point(229, 11);
            this.btnDeleteSinhVien.Name = "btnDeleteSinhVien";
            this.btnDeleteSinhVien.Size = new System.Drawing.Size(77, 40);
            this.btnDeleteSinhVien.TabIndex = 2;
            this.btnDeleteSinhVien.UseVisualStyleBackColor = true;
            this.btnDeleteSinhVien.Click += new System.EventHandler(this.btnDeleteSinhVien_Click);
            // 
            // btnModiFySinhVien
            // 
            this.btnModiFySinhVien.BackgroundImage = global::GUI.Properties.Resources.icon_modify;
            this.btnModiFySinhVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModiFySinhVien.Location = new System.Drawing.Point(129, 11);
            this.btnModiFySinhVien.Name = "btnModiFySinhVien";
            this.btnModiFySinhVien.Size = new System.Drawing.Size(77, 40);
            this.btnModiFySinhVien.TabIndex = 1;
            this.btnModiFySinhVien.UseVisualStyleBackColor = true;
            this.btnModiFySinhVien.Click += new System.EventHandler(this.btnModiFySinhVien_Click);
            // 
            // btnAddSinhVien
            // 
            this.btnAddSinhVien.BackgroundImage = global::GUI.Properties.Resources.icon_Add;
            this.btnAddSinhVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSinhVien.Location = new System.Drawing.Point(29, 11);
            this.btnAddSinhVien.Name = "btnAddSinhVien";
            this.btnAddSinhVien.Size = new System.Drawing.Size(77, 40);
            this.btnAddSinhVien.TabIndex = 0;
            this.btnAddSinhVien.UseVisualStyleBackColor = true;
            this.btnAddSinhVien.Click += new System.EventHandler(this.btnAddSinhVien_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnSortDes);
            this.panel1.Controls.Add(this.btnSortAsc);
            this.panel1.Controls.Add(this.cbbSortStudent);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 38);
            this.panel1.TabIndex = 3;
            // 
            // btnSortDes
            // 
            this.btnSortDes.BackgroundImage = global::GUI.Properties.Resources.Sort_icon_Alpha_Desc;
            this.btnSortDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSortDes.Location = new System.Drawing.Point(535, 3);
            this.btnSortDes.Name = "btnSortDes";
            this.btnSortDes.Size = new System.Drawing.Size(86, 33);
            this.btnSortDes.TabIndex = 9;
            this.btnSortDes.UseVisualStyleBackColor = true;
            this.btnSortDes.Click += new System.EventHandler(this.btnSortDes_Click);
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.BackgroundImage = global::GUI.Properties.Resources.Sort_icon_Alpha;
            this.btnSortAsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSortAsc.Location = new System.Drawing.Point(443, 3);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(86, 33);
            this.btnSortAsc.TabIndex = 8;
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // cbbSortStudent
            // 
            this.cbbSortStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSortStudent.FormattingEnabled = true;
            this.cbbSortStudent.Location = new System.Drawing.Point(217, 7);
            this.cbbSortStudent.Name = "cbbSortStudent";
            this.cbbSortStudent.Size = new System.Drawing.Size(204, 26);
            this.cbbSortStudent.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 20);
            this.label18.TabIndex = 8;
            this.label18.Text = "Sắp xếp sinh viên theo:";
            // 
            // frmQuanLySinhVien
            // 
            this.AcceptButton = this.btnAddSinhVien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.pnStudentDetails);
            this.Controls.Add(this.pnContainerDgv);
            this.Controls.Add(this.pnSearchSinhVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(984, 544);
            this.Name = "frmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            this.pnSearchSinhVien.ResumeLayout(false);
            this.pnSearchSinhVien.PerformLayout();
            this.pnContainerDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.pnStudentDetails.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSearchSinhVien;
        private System.Windows.Forms.Button btnDefaultDataStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Panel pnContainerDgv;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Panel pnStudentDetails;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cbbTinhTrangSV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbbMaLop_SV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtQueQuanSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbbGioiTinhSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnDeleteSinhVien;
        private System.Windows.Forms.Button btnModiFySinhVien;
        private System.Windows.Forms.Button btnAddSinhVien;
        private System.Windows.Forms.ComboBox cbbSearchStudent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSortDes;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.ComboBox cbbSortStudent;
        private System.Windows.Forms.Label label18;
    }
}