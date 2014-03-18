using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Drawing.Drawing2D;

namespace freelancehunt
{
    public partial class cntrlMessageInfo : UserControl
    {
        public clsMessage message = null;

        void downLoadImage()
        {
            try
            {
                Image img = Properties.Resources.freelancehunt;

                using (WebClient wClient = new WebClient())
                {
                    Uri uri = new Uri(this.message.from.avatar);

                    byte[] imageByte = wClient.DownloadData(uri);
                    using (MemoryStream ms = new MemoryStream(imageByte, 0, imageByte.Length))
                    {
                        ms.Write(imageByte, 0, imageByte.Length);
                        img = Image.FromStream(ms, true);
                    }
                }

                pictureBox1.BeginInvoke(new Action(() =>
                {
                    pictureBox1.Image = img;
                }));
            }
            catch (Exception) { }
        }

        public cntrlMessageInfo(clsMessage message)
        {
            InitializeComponent();
            
            this.message = message;

            Thread th = new Thread(downLoadImage);
            th.Start();
        }

        private void cntrlMessageInfo_Load(object sender, EventArgs e)
        {
            lblAutor.Text = this.message.from.login;
            lblTime.Text = this.message.post_time.ToLongDateString() + " " + this.message.post_time.ToShortTimeString();
            pcbAttach.Image = this.message.attachCount > 0 ? Properties.Resources.attach : Properties.Resources.attach_gray;
        }

        private void lblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.message.from.url);
        }

        private void pcbGo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.message.url);
        }

        private void cntrlMessageInfo_Paint(object sender, PaintEventArgs e)
        {
            Size size = this.Size;

            size.Height -= 4;
            size.Width -= 4;

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                                             new Point(0, 0),
                                             new Point(0, size.Height),
                                             clsColors.lnrColorTop,
                                             clsColors.lnrColorBottom);

            Rectangle rect = new Rectangle(new Point(2, 2), size);

            e.Graphics.FillRectangle(linGrBrush, rect);

            #region окантовка

            rect.Height--;
            rect.Width--;
            e.Graphics.DrawRectangle(clsColors.borderPen, rect);

            #endregion
        }
    }
}
