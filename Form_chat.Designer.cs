namespace testLogin
{
    partial class Form_chat
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
            this.textBox_inputmess = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel_mess = new System.Windows.Forms.FlowLayoutPanel();
            this.button_searchtext = new System.Windows.Forms.Button();
            this.button_checkvideo = new System.Windows.Forms.Button();
            this.button_checkfile = new System.Windows.Forms.Button();
            this.button_icons = new System.Windows.Forms.Button();
            this.button_video = new System.Windows.Forms.Button();
            this.button_hinh = new System.Windows.Forms.Button();
            this.button_gui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_inputmess
            // 
            this.textBox_inputmess.Location = new System.Drawing.Point(213, 497);
            this.textBox_inputmess.Multiline = true;
            this.textBox_inputmess.Name = "textBox_inputmess";
            this.textBox_inputmess.Size = new System.Drawing.Size(400, 66);
            this.textBox_inputmess.TabIndex = 1;
            this.textBox_inputmess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel_mess
            // 
            this.flowLayoutPanel_mess.AutoScroll = true;
            this.flowLayoutPanel_mess.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_mess.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel_mess.Name = "flowLayoutPanel_mess";
            this.flowLayoutPanel_mess.Size = new System.Drawing.Size(670, 479);
            this.flowLayoutPanel_mess.TabIndex = 5;
            this.flowLayoutPanel_mess.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_mess_Paint);
            // 
            // button_searchtext
            // 
            this.button_searchtext.Image = global::testLogin.Properties.Resources.icons8_magnifying_glass_50;
            this.button_searchtext.Location = new System.Drawing.Point(688, 154);
            this.button_searchtext.Name = "button_searchtext";
            this.button_searchtext.Size = new System.Drawing.Size(70, 64);
            this.button_searchtext.TabIndex = 10;
            this.button_searchtext.UseVisualStyleBackColor = true;
            this.button_searchtext.Click += new System.EventHandler(this.button_searchtext_Click);
            // 
            // button_checkvideo
            // 
            this.button_checkvideo.Image = global::testLogin.Properties.Resources.icons8_video_file_501;
            this.button_checkvideo.Location = new System.Drawing.Point(688, 85);
            this.button_checkvideo.Name = "button_checkvideo";
            this.button_checkvideo.Size = new System.Drawing.Size(70, 63);
            this.button_checkvideo.TabIndex = 9;
            this.button_checkvideo.UseVisualStyleBackColor = true;
            this.button_checkvideo.Click += new System.EventHandler(this.button_checkvideo_Click);
            // 
            // button_checkfile
            // 
            this.button_checkfile.Image = global::testLogin.Properties.Resources.download;
            this.button_checkfile.Location = new System.Drawing.Point(688, 12);
            this.button_checkfile.Name = "button_checkfile";
            this.button_checkfile.Size = new System.Drawing.Size(70, 67);
            this.button_checkfile.TabIndex = 8;
            this.button_checkfile.UseVisualStyleBackColor = true;
            this.button_checkfile.Click += new System.EventHandler(this.button_checkfile_Click);
            // 
            // button_icons
            // 
            this.button_icons.Image = global::testLogin.Properties.Resources.icons8_emotion_48;
            this.button_icons.Location = new System.Drawing.Point(141, 509);
            this.button_icons.Name = "button_icons";
            this.button_icons.Size = new System.Drawing.Size(66, 54);
            this.button_icons.TabIndex = 7;
            this.button_icons.UseVisualStyleBackColor = true;
            this.button_icons.Click += new System.EventHandler(this.button_icons_Click);
            // 
            // button_video
            // 
            this.button_video.Image = global::testLogin.Properties.Resources.icons8_video_50;
            this.button_video.Location = new System.Drawing.Point(76, 512);
            this.button_video.Name = "button_video";
            this.button_video.Size = new System.Drawing.Size(59, 51);
            this.button_video.TabIndex = 6;
            this.button_video.UseVisualStyleBackColor = true;
            this.button_video.Click += new System.EventHandler(this.button_video_Click);
            // 
            // button_hinh
            // 
            this.button_hinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_hinh.Image = global::testLogin.Properties.Resources.icons8_image_50;
            this.button_hinh.Location = new System.Drawing.Point(12, 509);
            this.button_hinh.Name = "button_hinh";
            this.button_hinh.Size = new System.Drawing.Size(58, 54);
            this.button_hinh.TabIndex = 4;
            this.button_hinh.UseVisualStyleBackColor = true;
            this.button_hinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_gui
            // 
            this.button_gui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gui.Image = global::testLogin.Properties.Resources.icons8_send_50;
            this.button_gui.Location = new System.Drawing.Point(619, 497);
            this.button_gui.Name = "button_gui";
            this.button_gui.Size = new System.Drawing.Size(74, 66);
            this.button_gui.TabIndex = 0;
            this.button_gui.UseVisualStyleBackColor = true;
            this.button_gui.Click += new System.EventHandler(this.button_gui_Click);
            // 
            // Form_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 572);
            this.Controls.Add(this.button_searchtext);
            this.Controls.Add(this.button_checkvideo);
            this.Controls.Add(this.button_checkfile);
            this.Controls.Add(this.button_icons);
            this.Controls.Add(this.button_video);
            this.Controls.Add(this.flowLayoutPanel_mess);
            this.Controls.Add(this.button_hinh);
            this.Controls.Add(this.textBox_inputmess);
            this.Controls.Add(this.button_gui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form_chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gui;
        private System.Windows.Forms.TextBox textBox_inputmess;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_hinh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_mess;
        private System.Windows.Forms.Button button_video;
        private System.Windows.Forms.Button button_icons;
        private System.Windows.Forms.Button button_checkfile;
        private System.Windows.Forms.Button button_checkvideo;
        private System.Windows.Forms.Button button_searchtext;
    }
}