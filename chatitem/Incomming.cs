using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testLogin.chatitem
{
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public string Message {
            get
            {
                return label_messincomming.Text;
            }
            set
            {
                label_messincomming.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            boxPicture_avt.Location = new Point(4, 3);
            label_messincomming.Height = Utiles.GetTextHeight(label_messincomming) + 10;
            panel_iscomming.Height = label_messincomming.Top + boxPicture_avt.Top + label_messincomming.Height;
            this.Height = panel_iscomming.Bottom + 10;
        }
        public Image Avatar { get; set; }
    }
}
