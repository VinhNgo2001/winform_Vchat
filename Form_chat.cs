using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace testLogin
{
    public partial class Form_chat : Form
    {
        private int totalMessages;
        string connectionString = @"Data Source=DESKTOP-UC0QD5C\QUANGVINH;Initial Catalog=Vchat;Integrated Security=True";
        public Form_chat()
        {
            InitializeComponent();
            

            vScrollBar1.Value = vScrollBar1.Maximum - vScrollBar1.LargeChange + 1;
            panel_container.Top = -vScrollBar1.Value;
        }
        private void UpdateScrollBar()
        {
            // Tính toán giá trị của thanh cuộn
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = totalMessages * 20 - panel_container.Height;
            vScrollBar1.LargeChange = panel_container.Height;
            vScrollBar1.SmallChange = 20;
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
            

            // Xóa nội dung của TextBox sau khi gửi tin nhắn
            AddMesscoming(textBox_inputmess.Text);
            if (!string.IsNullOrEmpty(messageContent))
            {
                using (SqlConnection connection = new  SqlConnection(connectionString))
                {

                    connection.Open();
                    // Thêm tin nhắn vào cơ sở dữ liệu
                    SaveMessageToDatabase(connection, messageContent);

                    // Xóa nội dung của hộp văn bản sau khi gửi
                    textBox_inputmess.Clear();

                }
            }
               

            
            

        }
        // luu tin nhan den sql
        private void SaveMessageToDatabase(SqlConnection connection, string message)
        {
            string imagePath="";

            if (message.StartsWith("[Image]"))
            {
                imagePath = message.Replace("[Image] ", "");
                message = "";
            }
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "INSERT INTO list_mess (messText, messDateTime,image) VALUES (@MessageText, @SentDateTime,@image)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MessageText", message);
            command.Parameters.AddWithValue("@SentDateTime", now);
            command.Parameters.AddWithValue("@image", imagePath);


            command.ExecuteNonQuery();

            
        }

        private void Form_chat_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void AddMesscoming(string message)
        {
            var bubble = new Messcoming();
            panel_container.Controls.Add(bubble);
            bubble.Dock = DockStyle.Bottom;
            bubble.Messgae = message;
            totalMessages++;

        }

        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }
        
    private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            panel_container.Top = -vScrollBar1.Value ;
            

        }

        private void panel_container_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog  openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                string imageName = Path.GetFileName(imagePath);

                //tao duong dan luu vao muc image D:\user\repos\testLogin\images\
                string customPath = @"D:\user\repos\testLogin\images\" + imageName;
                // Kiểm tra và tạo thư mục "Images" nếu không tồn tại

                string customDirectory = Path.GetDirectoryName(customPath);
                if (!Directory.Exists(customDirectory))
                {
                    Directory.CreateDirectory(customDirectory);
                }

                // Lưu trữ hình ảnh vào thư mục trên local
                File.Copy(imagePath, customPath, true);

                // Gửi tin nhắn chứa đường dẫn của hình ảnh
                string message = $"[Image] {customPath}";
                DisplayMessage( message);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    // Thêm tin nhắn vào cơ sở dữ liệu
                    SaveMessageToDatabase(connection, message);

                    

                }
            }
        }
        private void DisplayMessage(string message)
        {
            if (message.StartsWith("[Image]"))
            {
                string imagePath = message.Replace("[Image] ", "");

                // Kiểm tra xem hình ảnh có tồn tại không
                if (File.Exists(imagePath))
                {
                    // Tạo một PictureBox mới để hiển thị hình ảnh
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = 200;
                    pictureBox.Height = 200;
                    pictureBox.ImageLocation = imagePath;

                    // Thêm PictureBox vào panel chat
                    
                    panel_container.Controls.Add(pictureBox);
                    pictureBox.Dock = DockStyle.Bottom;
                }
                else
                {
                    MessageBox.Show("Image not found.");
                }
            }
            else
            {
                // Hiển thị tin nhắn văn bản bình thường
                // ...
            }
        }

    }
}
