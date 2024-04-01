namespace testLogin
{
    partial class Form_searchtext
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_timkiem = new System.Windows.Forms.TextBox();
            this.button_searchtext = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhap vao tin nhan can tim kiem";
            // 
            // textBox_timkiem
            // 
            this.textBox_timkiem.Location = new System.Drawing.Point(12, 45);
            this.textBox_timkiem.Multiline = true;
            this.textBox_timkiem.Name = "textBox_timkiem";
            this.textBox_timkiem.Size = new System.Drawing.Size(266, 42);
            this.textBox_timkiem.TabIndex = 1;
            // 
            // button_searchtext
            // 
            this.button_searchtext.Location = new System.Drawing.Point(284, 45);
            this.button_searchtext.Name = "button_searchtext";
            this.button_searchtext.Size = new System.Drawing.Size(73, 42);
            this.button_searchtext.TabIndex = 2;
            this.button_searchtext.Text = "tim";
            this.button_searchtext.UseVisualStyleBackColor = true;
            this.button_searchtext.Click += new System.EventHandler(this.button_searchtext_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 397);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form_searchtext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 524);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button_searchtext);
            this.Controls.Add(this.textBox_timkiem);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Form_searchtext";
            this.Text = "Form_searchtext";
            this.Load += new System.EventHandler(this.Form_searchtext_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_timkiem;
        private System.Windows.Forms.Button button_searchtext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}