using freelancehunt.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace freelancehunt
{
    public partial class frmProjectFullInfo : Form
    {

        private long projectId = 0L;
        private long profileId = 0L;
        private int imgDownloadTryCount = 0;
        private clsProfile profile = (clsProfile)null;
        private int auction_hammer_gavel_count = 0;

        public frmProjectFullInfo(long projectId, long profileId)
        {
            this.projectId = projectId;
            this.profileId = profileId;
            InitializeComponent();
        }

        private void setSizeForReviews()
        {
            if (this.profile == null)
                return;
            int wMax = this.panel10.Width - 20;
            this.panel9.BeginInvoke(new Action(() =>
            {
                this.pcbUserNegative.Visible = this.pcbUserPositive.Visible = false;
                int local_0 = this.profile.negative_reviews + this.profile.positive_reviews;
                if (local_0 <= 0)
                    return;
                float local_1 = 1f * (float)wMax / (float)local_0;
                this.pcbUserNegative.Width = (int)((double)this.profile.negative_reviews * (double)local_1);
                this.pcbUserPositive.Width = (int)((double)this.profile.positive_reviews * (double)local_1);
                this.pcbUserNegative.Visible = this.pcbUserPositive.Visible = true;
            }));
        }

        private void downLoadImage()
        {
            try
            {
                Image img = (Image)Resources.user_9;
                if (this.profile == null)
                    return;
                using (WebClient webClient = new WebClient())
                {
                    Uri address = new Uri(this.profile.url_avatar);
                    byte[] buffer = webClient.DownloadData(address);
                    using (MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length))
                    {
                        memoryStream.Write(buffer, 0, buffer.Length);
                        img = Image.FromStream((Stream)memoryStream, true);
                    }
                }
                this.pcbProfileAvatar.BeginInvoke(new Action(() => this.pcbProfileAvatar.Image = img));
            }
            catch (Exception ex1)
            {
                try
                {
                    ++this.imgDownloadTryCount;
                    if (this.imgDownloadTryCount < 10)
                        new Thread(new ThreadStart(this.downLoadImage)).Start();
                }
                catch (Exception ex2)
                {
                }
            }
        }

        private void frmProjectFullInfo_Load(object sender, EventArgs e)
        {
            List<clsJSON> list = clsJSON.parce(clsUpdate.getProjectFullInfo(this.projectId));
            if (list == null)
                this.Close();
            else if (list.Count != 1)
                this.Close();
            else if (list[0].bloks == null)
                this.Close();
            else if (list[0].bloks.Count == 0)
                this.Close();
            else if (Enumerable.FirstOrDefault<clsJSON_block>((IEnumerable<clsJSON_block>)list[0].bloks, (Func<clsJSON_block, bool>)(b => b.name.CompareTo("from") == 0)) == null)
            {
                this.Close();
            }
            else
            {
                clsProject clsProject = new clsProject(list[0]);
                this.lblID.Text = "#" + (object)clsProject.id;
                this.lblStateName.Text = clsProject.status_name;
                this.lblName.Text = clsProject.name;
                this.lblDescription.Text = clsProject.description;
                this.auction_hammer_gavel_count = clsProject.bid_count;
                switch (clsProject.status_id)
                {
                    case 11:
                        this.pcbState.Image = (Image)Resources.prj_state_11;
                        break;
                    case 12:
                        this.pcbState.Image = (Image)Resources.prj_state_12;
                        break;
                    case 13:
                        this.pcbState.Image = (Image)Resources.prj_state_13;
                        break;
                    case 21:
                        this.pcbState.Image = (Image)Resources.prj_state_21;
                        break;
                    case 22:
                        this.pcbState.Image = (Image)Resources.prj_state_22;
                        break;
                    case 23:
                        this.pcbState.Image = (Image)Resources.prj_state_23;
                        break;
                    case 24:
                        this.pcbState.Image = (Image)Resources.prj_state_24;
                        break;
                    case 25:
                        this.pcbState.Image = (Image)Resources.prj_state_25;
                        break;
                    case 26:
                        this.pcbState.Image = (Image)Resources.prj_state_26;
                        break;
                    case 31:
                        this.pcbState.Image = (Image)Resources.prj_state_31;
                        break;
                    case 32:
                        this.pcbState.Image = (Image)Resources.prj_state_32;
                        break;
                    case 33:
                        this.pcbState.Image = (Image)Resources.prj_state_33;
                        break;
                }
                this.pcbIsFeatured.Image = clsProject.is_featured ? (Image)Resources.prj_is_featured : (Image)Resources.prj_is_featured_gray;
                this.pcbIsIdentityVerified.Image = clsProject.is_identity_verified ? (Image)Resources.prj_is_identity_verified : (Image)Resources.prj_is_identity_verified_gray;
                this.pcbIsJob.Image = clsProject.is_job ? (Image)Resources.prj_is_job : (Image)Resources.prj_is_job_gray;

                this.lblLogin.Text = clsProject.from.login;
                clsJSON profileFullInfo = clsUpdate.getProfileFullInfo(clsProject.from.login);
                if (profileFullInfo == null)
                {
                    this.Close();
                }
                else
                {
                    this.profile = new clsProfile(profileFullInfo);
                    this.pnlUserParam.BeginInvoke(new Action(() =>
                    {
                        this.pcbUser_Day.Image = this.profile.is_birth_date_verified ? (Image)Resources.user_date : (Image)Resources.user_date_gray;
                        this.pcbUser_email.Image = this.profile.is_email_verified ? (Image)Resources.user_email : (Image)Resources.user_email_gray;
                        this.pcbUser_OKPAY.Image = this.profile.is_okpay_verified ? (Image)Resources.user_okpay : (Image)Resources.user_okpay_gray;
                        this.pcbUser_Phone.Image = this.profile.is_phone_verifie ? (Image)Resources.user_phone : (Image)Resources.user_phone_gray;
                        this.pcbUser_WMID.Image = this.profile.is_wmid_verified ? (Image)Resources.user_wmid : (Image)Resources.user_wmid_gray;
                    }));
                    this.pcbProfileAvatar.BeginInvoke(new Action(() => this.pcbProfileAvatar.Image = (Image)Resources.user_9));
                    this.imgDownloadTryCount = 0;
                    new Thread(new ThreadStart(this.downLoadImage)).Start();
                    this.setSizeForReviews();
                    new Thread(new ThreadStart(this.downLoadImage)).Start();
                }
            }
        }

        private void lblStateName_Click(object sender, EventArgs e)
        {
        }

        private void pcbAucrion_Paint(object sender, PaintEventArgs e)
        {
            for (int index = 0; index < this.auction_hammer_gavel_count; ++index)
                e.Graphics.DrawImage((Image)Resources.auction_hammer_gavel, index * 20, 0);
        }
    }
}

