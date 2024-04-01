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
            this.button_gui = new System.Windows.Forms.Button();
            this.textBox_inputmess = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_hinh = new System.Windows.Forms.Button();
            this.flowLayoutPanel_mess = new System.Windows.Forms.FlowLayoutPanel();
            this.button_video = new System.Windows.Forms.Button();
            this.button_icons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_gui
            // 
            this.button_gui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gui.Location = new System.Drawing.Point(615, 509);
            this.button_gui.Name = "button_gui";
            this.button_gui.Size = new System.Drawing.Size(94, 39);
            this.button_gui.TabIndex = 0;
            this.button_gui.Text = "Gui";
            this.button_gui.UseVisualStyleBackColor = true;
            this.button_gui.Click += new System.EventHandler(this.button_gui_Click);
            // 
            // textBox_inputmess
            // 
            this.textBox_inputmess.Location = new System.Drawing.Point(283, 509);
            this.textBox_inputmess.Multiline = true;
            this.textBox_inputmess.Name = "textBox_inputmess";
            this.textBox_inputmess.Size = new System.Drawing.Size(304, 39);
            this.textBox_inputmess.TabIndex = 1;
            this.textBox_inputmess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_hinh
            // 
            this.button_hinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_hinh.Location = new System.Drawing.Point(12, 506);
            this.button_hinh.Name = "button_hinh";
            this.button_hinh.Size = new System.Drawing.Size(69, 42);
            this.button_hinh.TabIndex = 4;
            this.button_hinh.Text = "hinh";
            this.button_hinh.UseVisualStyleBackColor = true;
            this.button_hinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel_mess
            // 
            this.flowLayoutPanel_mess.AutoScroll = true;
            this.flowLayoutPanel_mess.Location = new System.Drawing.Point(45, 12);
            this.flowLayoutPanel_mess.Name = "flowLayoutPanel_mess";
            this.flowLayoutPanel_mess.Size = new System.Drawing.Size(631, 479);
            this.flowLayoutPanel_mess.TabIndex = 5;
            // 
            // button_video
            // 
            this.button_video.Location = new System.Drawing.Point(87, 509);
            this.button_video.Name = "button_video";
            this.button_video.Size = new System.Drawing.Size(75, 39);
            this.button_video.TabIndex = 6;
            this.button_video.Text = "video";
            this.button_video.UseVisualStyleBackColor = true;
            this.button_video.Click += new System.EventHandler(this.button_video_Click);
            // 
            // button_icons
            // 
            this.button_icons.Location = new System.Drawing.Point(168, 509);
            this.button_icons.Name = "button_icons";
            this.button_icons.Size = new System.Drawing.Size(80, 39);
            this.button_icons.TabIndex = 7;
            this.button_icons.Text = "Icon";
            this.button_icons.UseVisualStyleBackColor = true;
            this.button_icons.Click += new System.EventHandler(this.button_icons_Click);
            // 
            // Form_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 572);
            this.Controls.Add(this.button_icons);
            this.Controls.Add(this.button_video);
            this.Controls.Add(this.flowLayoutPanel_mess);
            this.Controls.Add(this.button_hinh);
            this.Controls.Add(this.textBox_inputmess);
            this.Controls.Add(this.button_gui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_chat";
            this.Text = "Form_chat";
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
    }
}