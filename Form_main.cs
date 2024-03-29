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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_dangki_Click(object sender, EventArgs e)
        {
            Form_dangky formdk = new Form_dangky();
            formdk.ShowDialog();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            Form_dangnhap formdn = new Form_dangnhap();
            formdn.ShowDialog();
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
