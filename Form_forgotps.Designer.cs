namespace testLogin
{
    partial class Form_forgotps
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
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_taikhoan = new System.Windows.Forms.Label();
            this.textBox_taikhoan = new System.Windows.Forms.TextBox();
            this.label_dangnhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.button_dangnhap.ForeColor = System.Drawing.Color.White;
            this.button_dangnhap.Location = new System.Drawing.Point(79, 164);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(274, 49);
            this.button_dangnhap.TabIndex = 3;
            this.button_dangnhap.Text = "Gửi";
            this.button_dangnhap.UseVisualStyleBackColor = false;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
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
            // label_taikhoan
            // 
            this.label_taikhoan.AutoSize = true;
            this.label_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taikhoan.ForeColor = System.Drawing.Color.White;
            this.label_taikhoan.Location = new System.Drawing.Point(15, 9);
            this.label_taikhoan.Name = "label_taikhoan";
            this.label_taikhoan.Size = new System.Drawing.Size(149, 16);
            this.label_taikhoan.TabIndex = 0;
            this.label_taikhoan.Text = "Email đăng ký tài khoản";
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
            // label_dangnhap
            // 
            this.label_dangnhap.AutoSize = true;
            this.label_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dangnhap.Location = new System.Drawing.Point(74, 28);
            this.label_dangnhap.Name = "label_dangnhap";
            this.label_dangnhap.Size = new System.Drawing.Size(153, 25);
            this.label_dangnhap.TabIndex = 0;
            this.label_dangnhap.Text = "Lấy lại mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(170)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.label_dangnhap);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_dangnhap);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 519);
            this.panel1.TabIndex = 6;
            // 
            // Form_forgotps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 548);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form_forgotps";
            this.Text = "Quên Mật Khẩu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_taikhoan;
        private System.Windows.Forms.Label label_taikhoan;
        private System.Windows.Forms.Label label_dangnhap;
        private System.Windows.Forms.Panel panel1;
    }
}