using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testLogin
{
    public partial class Form_searchtext : Form
    {
        string connectionString = @"Data Source=DESKTOP-UC0QD5C\QUANGVINH;Initial Catalog=Vchat;Integrated Security=True";
        public List<string> listMessfound { get; private set; }
        public string findmess {  get; private set; }
        
        
        public Form_searchtext()
        {
            InitializeComponent();
            ReturnedData = "Dữ liệu mặc định";
        }
        public string ReturnedData { get; private set; }
        private void Form_searchtext_Load(object sender, EventArgs e)
        {
            
        }
        private void loadOldMess()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT messText FROM list_mess";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        string mess = (string)reader["messText"];

                        
                    }
                }
            }
        }

        private void button_searchtext_Click(object sender, EventArgs e)
        {
            string keyword = textBox_timkiem.Text.Trim();
            ReturnedData = textBox_timkiem.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT  messText, messDateTime FROM list_mess WHERE messText LIKE @Keyword";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ câu truy vấn
                    listMessfound = new List<string>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo một đối tượng Message từ dữ liệu đọc từ cơ sở dữ liệu
                            string mess = (string)reader["messText"];



                            // Thêm tin nhắn vào danh sách foundMessages
                            var bubble = new Messcoming();
                            flowLayoutPanel1.Controls.Add(bubble);
                            bubble.Dock = DockStyle.Bottom;
                            bubble.Messgae = mess;
                            listMessfound.Add(mess);
                        }
                    }
                    Console.WriteLine("check here"+ listMessfound);
                    if (listMessfound == null)
                    {
                        MessageBox.Show("Không có tin nhắn chứa từ khóa ");
                    }
                    else
                    {
                        MessageBox.Show("Tìm kiếm được "+ listMessfound.Count+ " tin nhắn chứa từ khóa");
                        
                        
                        
                    }

                }

            }
            else 
            {
                MessageBox.Show("vui lòng nhập từ khóa ");
                   }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_timkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
