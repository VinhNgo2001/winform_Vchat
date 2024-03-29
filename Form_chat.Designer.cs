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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_gui
            // 
            this.button_gui.Location = new System.Drawing.Point(551, 579);
            this.button_gui.Name = "button_gui";
            this.button_gui.Size = new System.Drawing.Size(77, 39);
            this.button_gui.TabIndex = 0;
            this.button_gui.Text = "Gui";
            this.button_gui.UseVisualStyleBackColor = true;
            this.button_gui.Click += new System.EventHandler(this.button_gui_Click);
            // 
            // textBox_inputmess
            // 
            this.textBox_inputmess.Location = new System.Drawing.Point(37, 579);
            this.textBox_inputmess.Multiline = true;
            this.textBox_inputmess.Name = "textBox_inputmess";
            this.textBox_inputmess.Size = new System.Drawing.Size(498, 39);
            this.textBox_inputmess.TabIndex = 1;
            this.textBox_inputmess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(37, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(591, 484);
            this.listBox1.TabIndex = 2;
            // 
            // Form_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 656);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
    }
}