using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace freelancehunt
{
    public partial class cntrlFeed : UserControl
    {
        public clsFeed feed = null;

        int imgDownloadTryCount = 0;

        string StripHtmlTagsUsingRegex(string inputString)
        {
            return Regex.Replace(inputString, @"<[^>]*>", String.Empty);
        }

        void downLoadImage()
        {
            try
            {
                Image img = Properties.Resources.freelancehunt;

                using (WebClient wClient = new WebClient())
                {
                    Uri uri = new Uri(this.feed.from.avatar);

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
            catch (Exception) 
            {
                try
                {
                    imgDownloadTryCount++;

                    if (imgDownloadTryCount < 10)
                    {
                        Thread.Sleep(250);

                        Thread th = new Thread(downLoadImage);
                        th.Start();

                        return;
                    }

                    pictureBox1.BeginInvoke(new Action(() =>
                            {
                                pictureBox1.Image = Properties.Resources.user_9;
                            }));
                }
                catch (Exception) { }
            }
        }

        public cntrlFeed(clsFeed feed)
        {
            InitializeComponent();

            this.feed = feed;

            Thread th = new Thread(downLoadImage);
            th.Start();
        }

        private void cntrlFeed_Load(object sender, EventArgs e)
        {
            lblAutor.Text = this.feed.from.login;
            lblTime.Text = this.feed.date.ToLongDateString() + " " + this.feed.date.ToLongTimeString();

            pcbNew.Image = this.feed.is_new ? Properties.Resources.new_icon : Properties.Resources.new_icon_gray;

            lblMessage.Text = StripHtmlTagsUsingRegex(this.feed.justMessage);
        }

        private void cntrlFeed_Paint(object sender, PaintEventArgs e)
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

        private void lblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.feed.from.url);
        }

        private void lblMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.feed.link);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.feed.from.url);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clsUpdate.proFile = this.feed.from.login;
            clsUpdate.Pause = false;
        }
    }
}