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
            this.panel_container = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_gui
            // 
            this.button_gui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gui.Location = new System.Drawing.Point(536, 510);
            this.button_gui.Name = "button_gui";
            this.button_gui.Size = new System.Drawing.Size(77, 39);
            this.button_gui.TabIndex = 0;
            this.button_gui.Text = "Gui";
            this.button_gui.UseVisualStyleBackColor = true;
            this.button_gui.Click += new System.EventHandler(this.button_gui_Click);
            // 
            // textBox_inputmess
            // 
            this.textBox_inputmess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_inputmess.Location = new System.Drawing.Point(124, 510);
            this.textBox_inputmess.Multiline = true;
            this.textBox_inputmess.Name = "textBox_inputmess";
            this.textBox_inputmess.Size = new System.Drawing.Size(406, 39);
            this.textBox_inputmess.TabIndex = 1;
            this.textBox_inputmess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel_container
            // 
            this.panel_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_container.Location = new System.Drawing.Point(12, 12);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(577, 492);
            this.panel_container.TabIndex = 2;
            this.panel_container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_container_Paint_1);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(592, 15);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 492);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "hinh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.textBox_inputmess);
            this.Controls.Add(this.button_gui);
            this.Name = "Form_chat";
            this.Text = "Form_chat";
            this.Load += new System.EventHandler(this.Form_chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gui;
        private System.Windows.Forms.TextBox textBox_inputmess;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}