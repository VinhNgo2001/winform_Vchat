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
    public partial class Messcoming : UserControl
    {
        public Messcoming()
        {
            InitializeComponent();
        }
        public string Messgae
        {
            get
            {
                return label_messcome.Text;
            }
            set
            {
                label_messcome.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            pictureBox_user.Location = new Point(4, 3);
            label_messcome.Height = Utiles.GetTextHeight(label_messcome) + 10;
            panel_textcome.Height = label_messcome.Top + pictureBox_user.Top + label_messcome.Height;
            this.Height = panel_textcome.Bottom + 10;
        }
        public Image Avatar { get => pictureBox_user.Image;set=> pictureBox_user.Image = value; }

        private void Messcoming_Load(object sender, EventArgs e)
        {
            
        }
        private void Messcoming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void Messcoming_Resize_1(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
