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
    public partial class Form_bangIcon : Form
    {
        
        // string connectionString = @"Data Source=DESKTOP-UC0QD5C\QUANGVINH;Initial Catalog=Vchat;Integrated Security=True";
        public class Icon
        {
            public string Name { get; set; }
            public string Source { get; set; }

            public Icon(string name, string source)
            {
                Name = name;
                Source = source;
            }

            // Phương thức để tải danh sách icon từ cơ sở dữ liệu SQL
            public static Icon[] LoadIconsFromDatabase()
            {
                // Kết nối tới cơ sở dữ liệu SQL
                string connectionString = @"Data Source=DESKTOP-UC0QD5C\QUANGVINH;Initial Catalog=Vchat;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SELECT nameicon, srcicon FROM list_icons", connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo một mảng icon từ dữ liệu trả về từ cơ sở dữ liệu
                    var icons = new List<Icon>();
                    while (reader.Read())
                    {
                        string name = reader["nameicon"].ToString();
                        string source = reader["srcicon"].ToString();
                        icons.Add(new Icon(name, source));
                    }

                    return icons.ToArray();
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ khi tải dữ liệu từ cơ sở dữ liệu
                    Console.WriteLine("Error loading icons from database: " + ex.Message);
                    return null;
                }
                finally
                {
                    // Đảm bảo rằng kết nối được đóng sau khi sử dụng
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }
        public string SelectedIconSrc { get; private set; }
        public Form_bangIcon()
        {
            InitializeComponent();
            Icon[] icons = Icon.LoadIconsFromDatabase();
            DisplayIconsInFlowLayoutPanel(icons);

        }
        private void DisplayIconsInFlowLayoutPanel(Icon[] icons)
        {
            // Clear existing controls in FlowLayoutPanel
            flowLayoutPanel_icons.Controls.Clear();

            // Add PictureBox for each icon to FlowLayoutPanel
            foreach (var icon in icons)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 60; // Customize width as needed
                pictureBox.Height = 60; // Customize height as needed

                pictureBox.Image = Image.FromFile(icon.Source);
                pictureBox.Tag = icon.Source;
                flowLayoutPanel_icons.Controls.Add(pictureBox);

                // You can handle click event for each PictureBox here
                if (icon != null)
                {
                    // You can handle click event for each PictureBox here
                    pictureBox.Click += (sender, e) =>
                    {
                        // Handle click event
                        MessageBox.Show($"Icon clicked: {icon.Name}");
                       // Console.WriteLine($"loi o day icon src: {icon.Source}");
                        SelectedIconSrc = pictureBox.Tag.ToString();
                    };
                }
                else
                {
                    // Handle the case where icon is null (if needed)
                }

            }
        }

            private void Form_bangIcon_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel_icons_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
