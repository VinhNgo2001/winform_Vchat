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
            string videoPath = "";

            if (message.StartsWith("[Image]"))
            {
                imagePath = message.Replace("[Image] ", "");
                message = "";
            }
            if (message.StartsWith("[Video]")){
                videoPath = message.Replace("[Video] ", "");
                message = "";
            }
            
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "INSERT INTO list_mess (messText, messDateTime,image,video) VALUES (@MessageText, @SentDateTime,@image,@video)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MessageText", message);
            command.Parameters.AddWithValue("@SentDateTime", now);
            command.Parameters.AddWithValue("@image", imagePath);
            command.Parameters.AddWithValue("@video", videoPath);


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
            flowLayoutPanel_mess.Controls.Add(bubble);
            bubble.Dock = DockStyle.Bottom;
            bubble.Messgae = message;
            totalMessages++;

        }

        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }
        
    private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            
            

        }

        private void panel_container_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog  openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                foreach (string imagePath in openFileDialog.FileNames)
                {
                    // Kiểm tra và gửi từng hình ảnh
                    
                    SendMessageWithImage(imagePath);
                }
                
            }
        }
        private void SendMessageWithImage(string imagePath)
        {
            
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
            DisplayMessage(message);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                // Thêm tin nhắn vào cơ sở dữ liệu
                SaveMessageToDatabase(connection, message);



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
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.ImageLocation = imagePath;

                    // Thêm PictureBox vào panel chat
                    
                    flowLayoutPanel_mess.Controls.Add(pictureBox);
                    pictureBox.Dock = DockStyle.Bottom;
                    //pictureBox.Location = new Point(0,    flowLayoutPanel_mess.Height - pictureBox.Height);

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

        private void button_video_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mp4;*.avi)|*.mp4;*.avi|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string videoPath = openFileDialog.FileName;

                // Gửi video
                 
               // AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();

                // Lưu trữ video
                SaveVideo(videoPath);
            }
        }
        private void SaveVideo(string videoPath)
        {
            string imageName = Path.GetFileName(videoPath);
            string customPath = @"D:\user\repos\testLogin\videos\" + imageName;
            File.Copy(videoPath, customPath, true);
            //
            string message = $"[Video] {customPath}";
            DisplayVideo(customPath);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                // Thêm tin nhắn vào cơ sở dữ liệu
                SaveMessageToDatabase(connection, message);



            }
        }
        private void DisplayVideo (string customPath)
        {
            AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            axWindowsMediaPlayer.Dock = DockStyle.Bottom;
            axWindowsMediaPlayer.Size = new Size(300, 200);
            flowLayoutPanel_mess.Controls.Add(axWindowsMediaPlayer);
            axWindowsMediaPlayer.URL = customPath;
        }

        private void button_icons_Click(object sender, EventArgs e)
        {
            Form_bangIcon form_BangIcon = new Form_bangIcon();
            form_BangIcon.ShowDialog();
            //formIcon.ShowDialog();
           
            // Lấy đường dẫn của icon được chọn
            string selectedIcon = form_BangIcon.SelectedIconSrc;
            Console.WriteLine("Đường dẫn của icon:", selectedIcon);

            // Hiển thị icon được chọn trên panel chat
            // Tạo một PictureBox mới để hiển thị hình ảnh
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(60, 60);
            pictureBox.ImageLocation = selectedIcon;
            //
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top; // Đặt DockStyle của Panel thành Top
            
            panel.Width = 400;
            panel.Controls.Add(pictureBox);
            // Thêm pictureBox vào panel chat của form chính
            flowLayoutPanel_mess.Controls.Add(panel);
           //gui vao list mess

            

        }
    }
}
