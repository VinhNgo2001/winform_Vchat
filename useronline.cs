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
    public partial class useronline : UserControl
    {
        public useronline()
        {
            InitializeComponent();
        }

        private void useronline_Load(object sender, EventArgs e)
        {

        }
        public string UserName
        {
            get { return button_nameuser.Text; }
            set { button_nameuser.Text = value; }
        }
        public string UserImage
        {
            get { return pictureBox_avtar.ImageLocation; }
            set { pictureBox_avtar.ImageLocation = value; }
        }

        private void button_nameuser_Click(object sender, EventArgs e)
        {
            Form formchat = new Form_chat();
            formchat.ShowDialog();

        }
    }
}
