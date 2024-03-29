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
    public partial class Form_dangnhap : Form
    {
        public Form_dangnhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UC0QD5C\QUANGVINH;Initial Catalog=Vchat;Integrated Security=True");
        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = textBox_taikhoan.Text;
            user_password = textBox_matkhau.Text;
            try 
            { 
                conn.Open();
                string query = "select * from list_users where username='" + username + "' and password='" + user_password + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    username = textBox_taikhoan.Text;
                    user_password = textBox_matkhau.Text;
                    MessageBox.Show("dang nhap thanh cong");

                }
                else
                {
                    MessageBox.Show("sai tai khoan mat khau");
                }
            } 
            catch 
            { 
            }
            finally
            {
                conn.Close();
            }

        }

        private void label_matkhau_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_taotaikhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_dangky form_Dangky = new Form_dangky();
            form_Dangky.Show();
            this.Close();
        }
    }
}
