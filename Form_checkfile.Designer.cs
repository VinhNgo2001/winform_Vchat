namespace testLogin
{
    partial class Form_checkfile
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
            this.flowLayoutPanel_checkfile = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_checkfile
            // 
            this.flowLayoutPanel_checkfile.AutoScroll = true;
            this.flowLayoutPanel_checkfile.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel_checkfile.Name = "flowLayoutPanel_checkfile";
            this.flowLayoutPanel_checkfile.Size = new System.Drawing.Size(596, 604);
            this.flowLayoutPanel_checkfile.TabIndex = 0;
            this.flowLayoutPanel_checkfile.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_checkfile_Paint);
            // 
            // Form_checkfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 628);
            this.Controls.Add(this.flowLayoutPanel_checkfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_checkfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hình ảnh đã gửi";
            this.Load += new System.EventHandler(this.Form_checkfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_checkfile;
    }
}