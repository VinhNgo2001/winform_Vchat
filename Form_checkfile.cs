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
using static System.Net.Mime.MediaTypeNames;

namespace testLogin
{
    public partial class Form_checkfile : Form
    {
        string connectionString = @"Data Source=DESKTOP-UC0QD5C\QUANGVINH;Initial Catalog=Vchat;Integrated Security=True";
        public Form_checkfile()
        {
            InitializeComponent();
        }

        private void Form_checkfile_Load(object sender, EventArgs e)
        {
            LoadImagesFromDatabase();
        }
        private void LoadImagesFromDatabase()
        {
            // Kết nối đến cơ sở dữ liệu SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn dữ liệu từ bảng list_mess chỉ với hai cột: date và image
                string query = "SELECT messDateTime, image FROM list_mess";
                SqlCommand command = new SqlCommand(query, connection);

                // Sử dụng SqlDataReader để đọc dữ liệu từ truy vấn
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Lấy thông tin từ mỗi hàng của kết quả truy vấn
                        string dateString = (string)reader["messDateTime"];
                        object imageValue = reader["image"];
                        if (imageValue != DBNull.Value)
                        {
                            string imagePath = (string)reader["image"];
                            if (imagePath !="") {
                                Panel panel = new Panel();
                                panel.Dock = DockStyle.Top; // Panel được đặt ở trên cùng của FlowLayoutPanel
                                panel.Size = new Size(210, 230);
                                // tao picture box chua hinh anh
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.ImageLocation = imagePath;
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Tuỳ chỉnh chế độ hiển thị hình ảnh
                                pictureBox.Size = new Size(200, 200); // Tuỳ chỉnh kích thước PictureBox
                                pictureBox.Margin = new Padding(10);
                                //tao lable chua ngay gui
                                Label label = new Label();
                                label.Text = dateString;
                                // tao panel chua hinh va ngay

                                panel.Controls.Add(pictureBox);
                                panel.Controls.Add(label);
                                label.Dock = DockStyle.Bottom;
                                //
                                flowLayoutPanel_checkfile.Controls.Add(panel);
                            }
                            //
                           

                        }
                        
                    }
                }
            }
        }

        private void flowLayoutPanel_checkfile_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
