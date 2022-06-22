
namespace GUI
{
    partial class frmCheckAuthenticCode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAuthenticCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAuthentication = new System.Windows.Forms.Button();
            this.btnResendAuthenticCode = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAuthenticCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 48);
            this.panel1.TabIndex = 0;
            // 
            // txtAuthenticCode
            // 
            this.txtAuthenticCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthenticCode.Location = new System.Drawing.Point(133, 9);
            this.txtAuthenticCode.Name = "txtAuthenticCode";
            this.txtAuthenticCode.Size = new System.Drawing.Size(213, 30);
            this.txtAuthenticCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xác thực:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Hủy bỏ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Location = new System.Drawing.Point(173, 101);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.Size = new System.Drawing.Size(98, 43);
            this.btnAuthentication.TabIndex = 1;
            this.btnAuthentication.Text = "Xác thực";
            this.btnAuthentication.UseVisualStyleBackColor = true;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // btnResendAuthenticCode
            // 
            this.btnResendAuthenticCode.Location = new System.Drawing.Point(173, 69);
            this.btnResendAuthenticCode.Name = "btnResendAuthenticCode";
            this.btnResendAuthenticCode.Size = new System.Drawing.Size(85, 26);
            this.btnResendAuthenticCode.TabIndex = 9;
            this.btnResendAuthenticCode.Text = "Gửi lại mã";
            this.btnResendAuthenticCode.UseVisualStyleBackColor = true;
            this.btnResendAuthenticCode.Visible = false;
            this.btnResendAuthenticCode.Click += new System.EventHandler(this.btnResendAuthenticCode_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(282, 66);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(100, 27);
            this.txtTimer.TabIndex = 10;
            this.txtTimer.Text = "03:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCheckAuthenticCode
            // 
            this.AcceptButton = this.btnAuthentication;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 153);
            this.ControlBox = false;
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.btnResendAuthenticCode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAuthentication);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 153);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(407, 153);
            this.Name = "frmCheckAuthenticCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác thực hai lớp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheckAuthenticCode_FormClosing);
            this.Load += new System.EventHandler(this.frmCheckAuthenticCode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAuthenticCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAuthentication;
        private System.Windows.Forms.Button btnResendAuthenticCode;
        private System.Windows.Forms.TextBox txtTimer;
    }
}