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
using static testLogin.Form_menu;

namespace testLogin
{
    public partial class Form_menu : Form
    {
        public class User
        {
            
            public string UserName { get; set; }
            public string UserImage { get; set; }
        }
        
        string connectionString = @"Data Source=DESKTOP-UC0QD5C\QUANGVINH;Initial Catalog=Vchat;Integrated Security=True";
        public Form_menu()
        {
            InitializeComponent();
            List<User> userList = LoadUsersFromDatabase();
            PopulateUserControls(userList);
        }
            private List<User> LoadUsersFromDatabase()
            {
            List<User> userList = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT fullname, khac FROM list_users";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string userName = reader["fullname"].ToString();
                        string image = reader["khac"].ToString();
                        

                        userList.Add(new User { UserName = userName, UserImage = image });
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return userList;
        }
        private void PopulateUserControls(List<User> userList)
        {
            foreach (var user in userList)
            {
                // Tạo UserControl
                useronline userInfoControl = new useronline();
                userInfoControl.UserName = user.UserName;
                userInfoControl.UserImage = user.UserImage;
                // Đăng ký sự kiện Click
                
                // Thêm UserControl vào Panel
                flowLayoutPanel1.Controls.Add(userInfoControl);
            }
        }
        private void UserInfoControl_UserClicked(object sender, EventArgs e)
        {
            // Xử lý khi UserControl được nhấp vào
            // Chuyển đến Form khác hoặc thực hiện hành động khác
            MessageBox.Show("User clicked!");
        }
        
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_dangxuat_Click(object sender, EventArgs e)
        {
            Form fmdangnhap = new Form_dangnhap();
            fmdangnhap.Show();
            this.Close();
        }
    }
}
