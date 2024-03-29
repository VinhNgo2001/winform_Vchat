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
            this.button_dangnhap.Size = new System.Drawing.Size(186, 71);
            this.button_dangnhap.TabIndex = 1;
            this.button_dangnhap.Text = "dang nhap";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 516);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.button_dangki);
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dangki;
        private System.Windows.Forms.Button button_dangnhap;
    }
}