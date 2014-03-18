using freelancehunt.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace freelancehunt
{
    public partial class cntrlProject : UserControl
    {
        public clsProject project = (clsProject)null;
        private int imgDownloadTryCount = 0;

        public cntrlProject(clsProject project)
        {
            InitializeComponent();
            this.project = project;
            this.lblAutor.Text = project.from.login;
            this.lblBidCount.Text = project.bid_count.ToString();
            this.lblDescription.Text = project.description;
            this.lblName.Text = project.name;
            this.lblState.Text = project.status_name;
            this.lblNumber.Text = "#" + project.id.ToString();
            this.pcbIsFeatured.Image = project.is_featured ? (Image)Resources.prj_is_featured : (Image)Resources.prj_is_featured_gray;
            this.pcbIsIdentityVerified.Image = project.is_identity_verified ? (Image)Resources.prj_is_identity_verified : (Image)Resources.prj_is_identity_verified_gray;
            this.pcbIsJob.Image = project.is_job ? (Image)Resources.prj_is_job : (Image)Resources.prj_is_job_gray;
            if (project.skills != null)
            {
                foreach (KeyValuePair<int, string> keyValuePair in project.skills)
                {
                    cntrlTagtext cntrlTagtext = new cntrlTagtext(keyValuePair.Value);
                    cntrlTagtext.Dock = DockStyle.Left;
                    cntrlTagtext.Parent = (Control)this.pnlSkills;
                }
            }
            new Thread(new ThreadStart(this.downLoadImage)).Start();
        }

        private void downLoadImage()
        {
            try
            {
                Image img = (Image)Resources.freelancehunt;
                using (WebClient webClient = new WebClient())
                {
                    Uri address = new Uri(this.project.from.avatar);
                    byte[] buffer = webClient.DownloadData(address);
                    using (MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length))
                    {
                        memoryStream.Write(buffer, 0, buffer.Length);
                        img = Image.FromStream((Stream)memoryStream, true);
                    }
                }
                this.pcbAvatar.BeginInvoke(new Action(() => this.pcbAvatar.Image = img));
            }
            catch (Exception ex1)
            {
                try
                {
                    ++this.imgDownloadTryCount;
                    if (this.imgDownloadTryCount < 10)
                    {
                        Thread.Sleep(300);
                        new Thread(new ThreadStart(this.downLoadImage)).Start();
                    }
                    else
                        this.pcbAvatar.BeginInvoke(new Action(() => this.pcbAvatar.Image = (Image)Resources.user_9));
                }
                catch (Exception ex2)
                {
                }
            }
        }

        private void cntrlProject_Paint(object sender, PaintEventArgs e)
        {
            Size size = this.Size;
            size.Height -= 4;
            size.Width -= 4;
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, size.Height), clsColors.lnrColorTop, clsColors.lnrColorBottom);
            Rectangle rect = new Rectangle(new Point(2, 2), size);
            e.Graphics.FillRectangle((Brush)linearGradientBrush, rect);
            --rect.Height;
            --rect.Width;
            e.Graphics.DrawRectangle(clsColors.borderPen, rect);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(this.project.url);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(this.project.from.url);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clsUpdate.proFile = this.project.from.login;
            clsUpdate.Pause = false;
        }

        private void lblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(this.project.from.url);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            Process.Start(this.project.url);
        }

        private void pcbShowInWondow_Click(object sender, EventArgs e)
        {
            foreach (Form form in (ReadOnlyCollectionBase)Application.OpenForms)
            {
                if (form is frmProjectFullInfo && (long)form.Tag == this.project.id)
                {
                    form.Focus();
                    return;
                }
            }
            frmProjectFullInfo frmProjectFullInfo = new frmProjectFullInfo(this.project.id, this.project.from.profile_id);
            frmProjectFullInfo.Tag = (object)this.project.id;
            ((Control)frmProjectFullInfo).Show();
        }
    }
}