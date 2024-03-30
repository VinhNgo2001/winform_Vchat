namespace testLogin
{
    partial class Messcoming
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.panel_textcome = new System.Windows.Forms.Panel();
            this.label_messcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.panel_textcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Image = global::testLogin.Properties.Resources.hinhdaidien;
            this.pictureBox_user.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(55, 50);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 0;
            this.pictureBox_user.TabStop = false;
            // 
            // panel_textcome
            // 
            this.panel_textcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_textcome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_textcome.Controls.Add(this.label_messcome);
            this.panel_textcome.Location = new System.Drawing.Point(64, 10);
            this.panel_textcome.Name = "panel_textcome";
            this.panel_textcome.Size = new System.Drawing.Size(346, 176);
            this.panel_textcome.TabIndex = 1;
            // 
            // label_messcome
            // 
            this.label_messcome.Location = new System.Drawing.Point(19, 17);
            this.label_messcome.Name = "label_messcome";
            this.label_messcome.Size = new System.Drawing.Size(381, 50);
            this.label_messcome.TabIndex = 0;
            this.label_messcome.Text = "Helloooooooooooooo";
            // 
            // Messcoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_textcome);
            this.Controls.Add(this.pictureBox_user);
            this.Name = "Messcoming";
            this.Size = new System.Drawing.Size(411, 189);
            this.Load += new System.EventHandler(this.Messcoming_Load);
            this.Resize += new System.EventHandler(this.Messcoming_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.panel_textcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Panel panel_textcome;
        private System.Windows.Forms.Label label_messcome;
    }
}
