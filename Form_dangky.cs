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
using static testLogin.Form_dangky;

namespace testLogin
{
    public partial class Form_dangky : Form
    {
        public Form_dangky()
        {
            InitializeComponent();
            
        }
        public class newUser
        {
            public string imagePath{get;set;}
        }
        newUser newuser = new newUser();
        private void button_dangky_Click(object sender, EventArgs e)
        {
            string username, password, email, phonenumer, fullname, confpassword, khac;
            username =textBox_taikhoan.Text;
            password = textBox_matkhau.Text;
            confpassword = textBox_xacnhanmk.Text;
            email = textBox_email.Text;
            phonenumer = textBox_sdt.Text;
            fullname = textBox_hovaten.Text;
            
            khac = newuser.imagePath;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng ký.");
                return;
            }
            if (password != confpassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = Connection.OpenConnection())
                {
                    // Tạo câu lệnh SQL để thêm người dùng mới vào cơ sở dữ liệu
                    string query = "INSERT INTO list_users (username, password, email,phonenumber,fullname,khac ) VALUES (@Username, @Password, @Email,@phonenumber,@fullname,@khac )";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@phonenumber", phonenumer);
                    command.Parameters.AddWithValue("@fullname", fullname);
                    command.Parameters.AddWithValue("@khac ", khac);

                    // Thực thi câu lệnh SQL
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                        // Sau khi đăng ký thành công, bạn có thể chuyển hướng đến Form khác hoặc thực hiện các hành động khác ở đây
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại sau.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối đến cơ sở dữ liệu
                Connection.CloseConnection();
            }
        }

        private void linkLabel_dangnhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form_dangnhap loginForm = new Form_dangnhap();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               string  imagepath = openFileDialog.FileName;
                newuser.imagePath = imagepath;
                

            }
        }
    }
}
