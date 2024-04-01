namespace testLogin
{
    partial class Form_dangnhap
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
            this.label_taikhoan = new System.Windows.Forms.Label();
            this.textBox_taikhoan = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel_taotaikhoan = new System.Windows.Forms.LinkLabel();
            this.label_taikhoanmoi = new System.Windows.Forms.Label();
            this.checkBox_ghinhodangnhap = new System.Windows.Forms.CheckBox();
            this.linkLabel_quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_dangnhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_taikhoan
            // 
            this.label_taikhoan.AutoSize = true;
            this.label_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taikhoan.ForeColor = System.Drawing.Color.White;
            this.label_taikhoan.Location = new System.Drawing.Point(15, 9);
            this.label_taikhoan.Name = "label_taikhoan";
            this.label_taikhoan.Size = new System.Drawing.Size(67, 16);
            this.label_taikhoan.TabIndex = 0;
            this.label_taikhoan.Text = "Tài khoản";
            // 
            // textBox_taikhoan
            // 
            this.textBox_taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.textBox_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_taikhoan.ForeColor = System.Drawing.Color.White;
            this.textBox_taikhoan.Location = new System.Drawing.Point(18, 28);
            this.textBox_taikhoan.Multiline = true;
            this.textBox_taikhoan.Name = "textBox_taikhoan";
            this.textBox_taikhoan.Size = new System.Drawing.Size(215, 22);
            this.textBox_taikhoan.TabIndex = 1;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.textBox_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_matkhau.ForeColor = System.Drawing.Color.White;
            this.textBox_matkhau.Location = new System.Drawing.Point(15, 30);
            this.textBox_matkhau.Multiline = true;
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(215, 22);
            this.textBox_matkhau.TabIndex = 2;
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.ForeColor = System.Drawing.Color.White;
            this.label_matkhau.Location = new System.Drawing.Point(12, 11);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(64, 16);
            this.label_matkhau.TabIndex = 0;
            this.label_matkhau.Text = "Mật  khẩu";
            this.label_matkhau.Click += new System.EventHandler(this.label_matkhau_Click);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.button_dangnhap.ForeColor = System.Drawing.Color.White;
            this.button_dangnhap.Location = new System.Drawing.Point(79, 280);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(274, 49);
            this.button_dangnhap.TabIndex = 3;
            this.button_dangnhap.Text = "Đăng khập";
            this.button_dangnhap.UseVisualStyleBackColor = false;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(170)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.linkLabel_taotaikhoan);
            this.panel1.Controls.Add(this.label_taikhoanmoi);
            this.panel1.Controls.Add(this.checkBox_ghinhodangnhap);
            this.panel1.Controls.Add(this.linkLabel_quenmatkhau);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label_dangnhap);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_dangnhap);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 519);
            this.panel1.TabIndex = 5;
            // 
            // linkLabel_taotaikhoan
            // 
            this.linkLabel_taotaikhoan.AutoSize = true;
            this.linkLabel_taotaikhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_taotaikhoan.Location = new System.Drawing.Point(243, 436);
            this.linkLabel_taotaikhoan.Name = "linkLabel_taotaikhoan";
            this.linkLabel_taotaikhoan.Size = new System.Drawing.Size(56, 16);
            this.linkLabel_taotaikhoan.TabIndex = 6;
            this.linkLabel_taotaikhoan.TabStop = true;
            this.linkLabel_taotaikhoan.Text = "Đăng ký";
            this.linkLabel_taotaikhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_taotaikhoan_LinkClicked);
            // 
            // label_taikhoanmoi
            // 
            this.label_taikhoanmoi.AutoSize = true;
            this.label_taikhoanmoi.Location = new System.Drawing.Point(76, 436);
            this.label_taikhoanmoi.Name = "label_taikhoanmoi";
            this.label_taikhoanmoi.Size = new System.Drawing.Size(161, 16);
            this.label_taikhoanmoi.TabIndex = 0;
            this.label_taikhoanmoi.Text = "Tạo tài khỏan Vchat mới ?";
            // 
            // checkBox_ghinhodangnhap
            // 
            this.checkBox_ghinhodangnhap.AutoSize = true;
            this.checkBox_ghinhodangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_ghinhodangnhap.Location = new System.Drawing.Point(79, 387);
            this.checkBox_ghinhodangnhap.Name = "checkBox_ghinhodangnhap";
            this.checkBox_ghinhodangnhap.Size = new System.Drawing.Size(141, 20);
            this.checkBox_ghinhodangnhap.TabIndex = 5;
            this.checkBox_ghinhodangnhap.Text = "Ghi nhớ đăng nhập";
            this.checkBox_ghinhodangnhap.UseVisualStyleBackColor = true;
            // 
            // linkLabel_quenmatkhau
            // 
            this.linkLabel_quenmatkhau.AutoSize = true;
            this.linkLabel_quenmatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_quenmatkhau.Location = new System.Drawing.Point(162, 345);
            this.linkLabel_quenmatkhau.Name = "linkLabel_quenmatkhau";
            this.linkLabel_quenmatkhau.Size = new System.Drawing.Size(103, 16);
            this.linkLabel_quenmatkhau.TabIndex = 4;
            this.linkLabel_quenmatkhau.TabStop = true;
            this.linkLabel_quenmatkhau.Text = "Quên mật khẩu?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.textBox_matkhau);
            this.panel3.Controls.Add(this.label_matkhau);
            this.panel3.Location = new System.Drawing.Point(82, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 73);
            this.panel3.TabIndex = 0;
            // 
            // label_dangnhap
            // 
            this.label_dangnhap.AutoSize = true;
            this.label_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dangnhap.Location = new System.Drawing.Point(74, 28);
            this.label_dangnhap.Name = "label_dangnhap";
            this.label_dangnhap.Size = new System.Drawing.Size(108, 25);
            this.label_dangnhap.TabIndex = 0;
            this.label_dangnhap.Text = "Đăng nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.textBox_taikhoan);
            this.panel2.Controls.Add(this.label_taikhoan);
            this.panel2.Location = new System.Drawing.Point(79, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 73);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testLogin.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(476, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(947, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_dangnhap";
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_taikhoan;
        private System.Windows.Forms.TextBox textBox_taikhoan;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_dangnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_ghinhodangnhap;
        private System.Windows.Forms.LinkLabel linkLabel_quenmatkhau;
        private System.Windows.Forms.LinkLabel linkLabel_taotaikhoan;
        private System.Windows.Forms.Label label_taikhoanmoi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

