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
    public partial class Form_Vchat : Form
    {
        public Form_Vchat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fmdangnhap =new Form_dangnhap();
            fmdangnhap.Show();
            this.Close();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form formchat = new Form_chat();
            formchat.ShowDialog();
               
        }
    }
}
