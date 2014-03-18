using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace freelancehunt
{
    public partial class cntrlTagtext : UserControl
    {
        string text = string.Empty;
        StringFormat format = new StringFormat();
        SizeF size = new SizeF();

        int x = 0;
        int y = 0;

        SizeF MeasureString(string s, Font font)
        {
            SizeF result;
            using (var image = new Bitmap(1, 1))
            {
                using (var g = Graphics.FromImage(image))
                {
                    result = g.MeasureString(s, font);
                }
            }

            return result;
        }

        public cntrlTagtext(string text)
        {
            this.text = text;

            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Far;

            InitializeComponent();

            size = MeasureString(this.text, this.Font);

            this.Width = (int)(pictureBox1.Width + size.Width + 2);

            x = (int)(pictureBox2.Width - size.Width) - 2;
            y = (int)(pictureBox2.Height - size.Height) / 2;
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(this.text, this.Font, Brushes.Black, x, y);
        }
    }
}
