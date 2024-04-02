namespace testLogin
{
    partial class Form_bangIcon
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
            this.flowLayoutPanel_icons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_icons
            // 
            this.flowLayoutPanel_icons.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_icons.Location = new System.Drawing.Point(12, 23);
            this.flowLayoutPanel_icons.Name = "flowLayoutPanel_icons";
            this.flowLayoutPanel_icons.Size = new System.Drawing.Size(644, 160);
            this.flowLayoutPanel_icons.TabIndex = 0;
            this.flowLayoutPanel_icons.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_icons_Paint);
            // 
            // Form_bangIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 195);
            this.Controls.Add(this.flowLayoutPanel_icons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_bangIcon";
            this.Text = "Icons";
            this.Load += new System.EventHandler(this.Form_bangIcon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_icons;
    }
}