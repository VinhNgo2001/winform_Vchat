namespace testLogin
{
    partial class useronline
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
            this.button_nameuser = new System.Windows.Forms.Button();
            this.pictureBox_avtar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avtar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_nameuser
            // 
            this.button_nameuser.BackColor = System.Drawing.Color.Aqua;
            this.button_nameuser.Location = new System.Drawing.Point(59, 3);
            this.button_nameuser.Name = "button_nameuser";
            this.button_nameuser.Size = new System.Drawing.Size(203, 50);
            this.button_nameuser.TabIndex = 1;
            this.button_nameuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nameuser.UseVisualStyleBackColor = false;
            this.button_nameuser.Click += new System.EventHandler(this.button_nameuser_Click);
            // 
            // pictureBox_avtar
            // 
            this.pictureBox_avtar.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_avtar.Name = "pictureBox_avtar";
            this.pictureBox_avtar.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_avtar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_avtar.TabIndex = 0;
            this.pictureBox_avtar.TabStop = false;
            // 
            // useronline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_nameuser);
            this.Controls.Add(this.pictureBox_avtar);
            this.Name = "useronline";
            this.Size = new System.Drawing.Size(280, 60);
            this.Load += new System.EventHandler(this.useronline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avtar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_avtar;
        private System.Windows.Forms.Button button_nameuser;
    }
}
