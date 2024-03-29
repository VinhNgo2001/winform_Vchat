namespace testLogin
{
    partial class Form_main
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
            this.button_dangki = new System.Windows.Forms.Button();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_thongtin = new System.Windows.Forms.Label();
            this.button_home = new System.Windows.Forms.Button();
            this.button_chat = new System.Windows.Forms.Button();
            this.button_dangxuat = new System.Windows.Forms.Button();
            this.label_ten = new System.Windows.Forms.Label();
            this.siticoneCirclePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dangki
            // 
            this.button_dangki.Location = new System.Drawing.Point(560, 49);
            this.button_dangki.Name = "button_dangki";
            this.button_dangki.Size = new System.Drawing.Size(186, 49);
            this.button_dangki.TabIndex = 0;
            this.button_dangki.Text = "Dang ki";
            this.button_dangki.UseVisualStyleBackColor = true;
            this.button_dangki.Click += new System.EventHandler(this.button_dangki_Click);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Location = new System.Drawing.Point(560, 122);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(186, 52);
            this.button_dangnhap.TabIndex = 1;
            this.button_dangnhap.Text = "dang nhap";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_ten);
            this.panel1.Controls.Add(this.button_dangxuat);
            this.panel1.Controls.Add(this.button_chat);
            this.panel1.Controls.Add(this.button_home);
            this.panel1.Controls.Add(this.label_thongtin);
            this.panel1.Controls.Add(this.siticoneCirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 478);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_thongtin
            // 
            this.label_thongtin.AutoSize = true;
            this.label_thongtin.Location = new System.Drawing.Point(98, 17);
            this.label_thongtin.Name = "label_thongtin";
            this.label_thongtin.Size = new System.Drawing.Size(62, 16);
            this.label_thongtin.TabIndex = 1;
            this.label_thongtin.Text = "Thong tin";
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(3, 242);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(253, 50);
            this.button_home.TabIndex = 2;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = true;
            // 
            // button_chat
            // 
            this.button_chat.Location = new System.Drawing.Point(0, 310);
            this.button_chat.Name = "button_chat";
            this.button_chat.Size = new System.Drawing.Size(253, 50);
            this.button_chat.TabIndex = 3;
            this.button_chat.Text = "Chat";
            this.button_chat.UseVisualStyleBackColor = true;
            // 
            // button_dangxuat
            // 
            this.button_dangxuat.Location = new System.Drawing.Point(3, 378);
            this.button_dangxuat.Name = "button_dangxuat";
            this.button_dangxuat.Size = new System.Drawing.Size(253, 50);
            this.button_dangxuat.TabIndex = 4;
            this.button_dangxuat.Text = "Log out";
            this.button_dangxuat.UseVisualStyleBackColor = true;
            // 
            // label_ten
            // 
            this.label_ten.AutoSize = true;
            this.label_ten.Location = new System.Drawing.Point(98, 182);
            this.label_ten.Name = "label_ten";
            this.label_ten.Size = new System.Drawing.Size(76, 16);
            this.label_ten.TabIndex = 5;
            this.label_ten.Text = "Quang Vinh";
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Image = global::testLogin.Properties.Resources.NgoQuanfVinh;
            this.siticoneCirclePictureBox1.ImageRotate = 0F;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(67, 50);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(121, 112);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox1.TabIndex = 0;
            this.siticoneCirclePictureBox1.TabStop = false;
            this.siticoneCirclePictureBox1.Click += new System.EventHandler(this.siticoneCirclePictureBox1_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.button_dangki);
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dangki;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_dangxuat;
        private System.Windows.Forms.Button button_chat;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label_thongtin;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private System.Windows.Forms.Label label_ten;
    }
}