using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testLogin
{
    public partial class Form_chat : Form
    {
        public Form_chat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_gui_Click(object sender, EventArgs e)
        {
            // Lấy nội dung của tin nhắn từ TextBox
            string messageContent = textBox_inputmess.Text.Trim();

            // Kiểm tra xem nội dung có rỗng không
            if (string.IsNullOrEmpty(messageContent))
            {
                MessageBox.Show("Vui lòng nhập nội dung tin nhắn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị tin nhắn trong ListBox
            listBox1.Items.Add($"Bạn: {messageContent}");

            // Xóa nội dung của TextBox sau khi gửi tin nhắn
            textBox_inputmess.Clear();
        }

        private void Form_chat_Load(object sender, EventArgs e)
        {

        }
    }
}
