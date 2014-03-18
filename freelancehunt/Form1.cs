using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;

namespace freelancehunt
{
    public partial class Form1 : Form
    {
        SolidBrush textBrush = null;
        StringFormat textFormat = new StringFormat();

        List<cntrlFeed> lstFeeds = new List<cntrlFeed>();
        List<cntrlMessageInfo> lstMessages = new List<cntrlMessageInfo>();
        List<cntrlProject> lstProjects = new List<cntrlProject>();

        List<frmUpdateInfo> lstFrmInfo = new List<frmUpdateInfo>();

        frmUpdateInfo frmUpdInfo = new frmUpdateInfo();

        string fileErrors = Application.StartupPath + @"\errors.log";
        string fileID_and_Psss = Application.StartupPath + @"\id_and_pass.txt";

        #region данные для идентификаторов проектов
        
        /// <summary>
        /// дата 1 янв 2014
        /// </summary>
        DateTime dt2014 = new DateTime(2014, 1, 1);
        /// <summary>
        /// путь к номерам проектов
        /// </summary>
        string projectsIDs = Application.StartupPath + @"\projects.log";
        /// <summary>
        /// первое это ИД второе время от 1 янв 2014 г
        /// </summary>
        Dictionary<Int64, Int64> prjIDs = new Dictionary<long, long>(); 

        #endregion

        /// <summary>
        /// найденные проекты
        /// </summary>
        List<clsSerchedProject> searchedProject = new List<clsSerchedProject>();
        string skillsURL = string.Empty;

        int imgDownloadTryCount = 0;
        clsProfile profile = null;
        void downLoadImage()
        {
            try
            {
                Image img = Properties.Resources.user_9;

                if (this.profile == null) return;

                using (WebClient wClient = new WebClient())
                {
                    Uri uri = new Uri(this.profile.url_avatar);

                    byte[] imageByte = wClient.DownloadData(uri);
                    using (MemoryStream ms = new MemoryStream(imageByte, 0, imageByte.Length))
                    {
                        ms.Write(imageByte, 0, imageByte.Length);
                        img = Image.FromStream(ms, true);
                    }
                }

                pcbProfileAvatar.BeginInvoke(new Action(() =>
                {
                    pcbProfileAvatar.Image = img;
                }));
            }
            catch (Exception)
            {
                try
                {
                    imgDownloadTryCount++;

                    if (imgDownloadTryCount < 10)
                    {
                        Thread.Sleep(270);

                        Thread th = new Thread(downLoadImage);
                        th.Start();

                        return;
                    }
                }
                catch (Exception) { }
            }
        }

        /// <summary>
        /// добавить идентификатор в файл
        /// </summary>
        /// <param name="id"></param>
        void addProjectIDToFile(Int64 id)
        {
            using (StreamWriter wr = new StreamWriter(projectsIDs, true, Encoding.GetEncoding(1251)))
            {
                Int64 timeStamp = (Int64)(DateTime.Now - dt2014).TotalSeconds;

                wr.WriteLine(id.ToString() + "\t" + timeStamp);
                wr.Flush();
                wr.Close();

                prjIDs.Add(id, timeStamp);
            }
        }

        void setSizeForReviews()
        {
            if (this.profile == null) return;

            #region размеры

            int wMax = panel10.Width - 20;

            panel9.BeginInvoke(new Action(() =>
                {
                    pcbUserNegative.Visible = pcbUserPositive.Visible = false;

                    int sum = profile.negative_reviews + profile.positive_reviews;

                    if (sum > 0)
                    {
                        float byOne = 1.0F * wMax / sum;

                        pcbUserNegative.Width = (int)(profile.negative_reviews * byOne);
                        pcbUserPositive.Width = (int)(profile.positive_reviews * byOne);

                        pcbUserNegative.Visible = pcbUserPositive.Visible = true;
                    }
                }));

            #endregion
        }

        string uniq()
        {
            string ret = string.Empty;

            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            
            foreach (ManagementObject mo in moc)
            {
                ret += mo.Properties["ProcessorId"].Value.ToString();
            }

            return ret;
        }

        byte[] uncBytes()
        {
            return System.Text.Encoding.UTF8.GetBytes(uniq());
        }

        public string encode(string text)
        {
            byte[] bytes = uncBytes();

            byte[] mybyte = System.Text.Encoding.UTF8.GetBytes(text);

            int num = 0;

            for (int i = 0; i < mybyte.Count(); i++ )
            {
                mybyte[i] = (byte)(mybyte[i] ^ bytes[num]);

                num++;
                if (num >= bytes.Count())
                    num = 0;
            }

            string returntext = System.Convert.ToBase64String(mybyte);
            return returntext;
        }

        public string decode(string text)
        {
            byte[] bytes = uncBytes();

            byte[] mybyte = System.Convert.FromBase64String(text);

            int num = 0;

            for (int i = 0; i < mybyte.Count(); i++)
            {
                mybyte[i] = (byte)(mybyte[i] ^ bytes[num]);

                num++;
                if (num >= bytes.Count())
                    num = 0;
            }

            string returntext = System.Text.Encoding.UTF8.GetString(mybyte);
            return returntext;
        }

        public Form1()
        {
            textBrush = new SolidBrush(clsColors.textColor);
            textFormat.Alignment = StringAlignment.Center;
            textFormat.LineAlignment = StringAlignment.Far;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region скрываем переключатель у таб элемента
            
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed; 

            #endregion

            #region идентификаторы проектов из файла

            if (File.Exists(projectsIDs))
            {
                using (StreamReader rd = new StreamReader(projectsIDs, Encoding.GetEncoding(1251)))
                {
                    while (!rd.EndOfStream)
                    {
                        string line = rd.ReadLine();

                        if (string.IsNullOrEmpty(line)) continue;

                        string[] data = line.Split('\t');

                        Int64 _i = 0;

                        Int64 id = 0;
                        Int64 timeStamp = 0;

                        if (!Int64.TryParse(data[0], out _i)) continue;
                        id = _i;
                        if (!Int64.TryParse(data[1], out _i)) continue;
                        timeStamp = _i;

                        prjIDs.Add(id, timeStamp);
                    }
                }
            }

            #endregion

            frmUpdInfo.Show();
            frmUpdInfo.Hide();
        }

        private void toolStripButton_Paint(object sender, PaintEventArgs e)
        {
            Size size = ((ToolStripButton)sender).Size;
            

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                                             new Point(0, 0),
                                             new Point(0, size.Height),
                                             clsColors.lnrColorTop,
                                             clsColors.lnrColorBottom);  // Opaque blue

            Rectangle rect = new Rectangle(new Point(0, 0), size);

            e.Graphics.FillRectangle(linGrBrush, rect);

            #region текст
            
            rect.Height -= 3;
            e.Graphics.DrawString(((ToolStripButton)sender).Text, ((ToolStripButton)sender).Font, textBrush, rect, textFormat);
            rect.Height += 3; 

            #endregion

            #region картинка

            Image img = ((ToolStripButton)sender).Image;

            int x = (size.Width - img.Width) / 2;

            e.Graphics.DrawImage(img, x, 3);

            #endregion

            #region окантовка
            
            rect.Height--;
            rect.Width--;
            e.Graphics.DrawRectangle(clsColors.borderPen, rect); 

            #endregion
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(fileID_and_Psss))
            {
                using (frmLogin frm = new frmLogin())
                {
                    while (frm.ShowDialog() == DialogResult.OK)
                    {
                        #region проверка данных

                        if (string.IsNullOrEmpty(frm.txtLogin.Text) ||
                            string.IsNullOrEmpty(frm.txtPass.Text))
                        {
                            continue;
                        }

                        #endregion

                        clsUpdate.id = frm.txtLogin.Text;
                        clsUpdate.pass = frm.txtPass.Text;

                        using (StreamWriter wr = new StreamWriter(fileID_and_Psss, false, Encoding.GetEncoding(1251)))
                        {
                            //wr.WriteLine(clsUpdate.id + "," + clsUpdate.pass);
                            wr.WriteLine(encode(clsUpdate.id + "," + clsUpdate.pass));
                            wr.Flush();
                            wr.Close();
                        }

                        break;
                    }
                }
            }
            else
            {
                using (StreamReader rd = new StreamReader(fileID_and_Psss, Encoding.GetEncoding(1251)))
                {
                    try
                    {
                        string[] data = decode(rd.ReadLine()).Split(',');
                        rd.Close();

                        if (data.Count() == 2)
                        {
                            clsUpdate.id = data[0];
                            clsUpdate.pass = data[1];
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка в ключах", 
                                        "Ошибка", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Error);


                        mnuExit.PerformClick();
                        return;
                    }
                }
            }

            if (string.IsNullOrEmpty(clsUpdate.id) || string.IsNullOrEmpty(clsUpdate.pass))
            {
                Close();
                return;
            }

            clsUpdate.evRefresh += new clsUpdate.evRefreshHandle(clsMeessages_evRefresh);
            clsUpdate.evRefreshStart += new clsUpdate.evRefreshStartHandle(clsUpdate_evRefreshStart);
            clsUpdate.evRefreshEnd += new clsUpdate.evRefreshEndHandle(clsUpdate_evRefreshEnd);

            clsPing.evInternetConnectChange += new clsPing.evInternetConnectChangeHandle(clsPing_evInternetConnectChange);

            Thread th = new Thread(clsUpdate.autoRefresh);
            th.Start();
        }

        void clsPing_evInternetConnectChange(bool connect)
        {
            pcbPing.BeginInvoke(new Action(() => pcbPing.Image = connect ? Properties.Resources.world : Properties.Resources.world_gray));

            if (clsGlobalSkills.skills == null)
            {
                clsGlobalSkills.Refresh();

                if (clsGlobalSkills.skills == null) return;

                lstSkill.BeginInvoke(new Action(() =>
                    {
                        foreach (KeyValuePair<int, string> key in clsGlobalSkills.skills)
                            lstSkill.Items.Add(key.Value);
                    }));
            }
        }

        void clsUpdate_evRefreshEnd(getInfoType type)
        {
            try
            {
                lblLastAction.BeginInvoke(new Action(() =>
                    {
                        lblLastAction.Text = "Обновление: ";
                        switch (type)
                        {
                            case getInfoType.feed:
                                lblLastAction.Text += "лента";
                                break;

                            case getInfoType.messages:
                                lblLastAction.Text += "личные сообщения";
                                break;

                            case getInfoType.profiles:
                                lblLastAction.Text += "профиля";
                                break;

                            case getInfoType.projects:
                                lblLastAction.Text += "проектов";
                                break;
                        }

                        lblLastAction.Text += ", закончено";
                    }));
            }
            catch (Exception) { }
        }

        void clsUpdate_evRefreshStart(getInfoType type)
        {
            try
            {
                lblLastAction.BeginInvoke(new Action(() =>
                        {
                            lblLastAction.Text = "Обновление: ";
                            switch (type)
                            {
                                case getInfoType.feed:
                                    lblLastAction.Text += "лента";
                                    break;

                                case getInfoType.messages:
                                    lblLastAction.Text += "личные сообщения";
                                    break;

                                case getInfoType.profiles:
                                    lblLastAction.Text += "профиля";
                                    break;

                                case getInfoType.projects:
                                    lblLastAction.Text += "проектов";
                                    break;
                            }

                            lblLastAction.Text += ", начато";
                        }));
            }
            catch (Exception) { }
        }

        void saveError(string title, string message)
        {
            using (StreamWriter wr = new StreamWriter(fileErrors, true, Encoding.GetEncoding(1251)))
            {
                wr.WriteLine(DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortTimeString());

                wr.WriteLine(title);
                wr.WriteLine(message);
                wr.WriteLine("");

                wr.Flush();
                wr.Close();
            }
        }

        void clsMeessages_evRefresh(getInfoType type, string text)
        {
            List<clsJSON> jsons = clsJSON.parce(text);

            if (jsons == null || jsons.Count == 0) return;

            if (text.LastIndexOf("error") > -1)
            {
                #region обработка ошибок

                if (jsons == null)
                {
                    saveError("Обновление " + type.ToString(), "Ничего не получено");
                    return;
                }

                if (jsons.Count == 1)
                {
                    if (jsons[0].bloks != null)
                    {
                        if (jsons[0].bloks.Count > 0)
                        {
                            clsJSON_block block = jsons[0].bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                            if (block != null)
                            {
                                string inf = clsUpdate.cmdReq(type) + "\r\n";

                                foreach (string[] line in block.data)
                                {
                                    inf += line[0] + ":" + line[1] + "\r\n";
                                }

                                saveError("Обновление " + type.ToString(), inf);
                            }
                        }
                    }
                }

                #endregion
            }

            #region обновление ленты

            if (type == getInfoType.feed)
            {
                foreach (clsJSON json in jsons)
                {
                    #region проверка на ошибку
                    
                    if (json.bloks != null)
                    {
                        clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                        if (block != null) continue;
                    } 

                    #endregion

                    clsFeed feed = new clsFeed(json);

                    cntrlFeed ff = lstFeeds.FirstOrDefault(f => f.feed.message.CompareTo(feed.message) == 0);

                    if (ff != null) continue;

                    cntrlFeed cf = new cntrlFeed(feed);

                    lstFeeds.Add(cf);

                    cf.Dock = DockStyle.Top;
                    try
                    {
                        scrollFeed.BeginInvoke(new Action(() =>
                        {
                            cf.Parent = scrollFeed;
                            cf.BringToFront();
                        }));
                    }
                    catch (Exception) { }

                    if (feed.is_new)
                        frmUpdInfo.addMessage(Properties.Resources.feed, "Новый пост в ленте от " + feed.from.login);
                }
            }
 
            #endregion

            #region сообщения
            
            if (type == getInfoType.messages)
            {
                foreach (clsJSON json in jsons)
                {
                    #region проверка на ошибку

                    if (json.bloks != null)
                    {
                        clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                        if (block != null) continue;
                    }

                    #endregion

                    clsMessage msg = new clsMessage(json);

                    cntrlMessageInfo fmi = lstMessages.FirstOrDefault(f => f.message.post_time.CompareTo(msg.post_time) == 0);

                    if (fmi != null) continue;

                    cntrlMessageInfo cf = new cntrlMessageInfo(msg);

                    lstMessages.Add(cf);

                    cf.Dock = DockStyle.Top;
                    try
                    {
                        scrollMessages.BeginInvoke(new Action(() =>
                        {
                            cf.Parent = scrollMessages;
                            cf.BringToFront();
                        }));
                    }
                    catch (Exception) { }

                    frmUpdInfo.addMessage(Properties.Resources.emails_stack, "Новое сообщение");
                }
            }
 
            #endregion

            #region профайл

            if (type == getInfoType.profiles)
            {
                #region проверка на ошибку

                if (jsons == null) return;
                if (jsons.Count != 1) return;

                if (jsons[0].bloks != null)
                {
                    clsJSON_block block = jsons[0].bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                    if (block != null) return;
                }

                #endregion

                profile = new clsProfile(jsons[0]);

                dataGridView1.BeginInvoke(new Action(() =>
                    {
                        dataGridView1.Rows.Clear();

                        foreach (object[] line in profile.table)
                            dataGridView1.Rows.Add(line);
                    }));

                frmUpdInfo.addMessage(Properties.Resources.reseller_programm, "Информация о профиле " + profile.fname + " " + profile.sname + " (" + profile.login + ")");

                #region изображения

                pnlUserParam.BeginInvoke(new Action(() =>
                    {
                        pcbUser_Day.Image = profile.is_birth_date_verified ? Properties.Resources.user_date : Properties.Resources.user_date_gray;
                        pcbUser_email.Image = profile.is_email_verified ? Properties.Resources.user_email : Properties.Resources.user_email_gray;
                        pcbUser_OKPAY.Image = profile.is_okpay_verified ? Properties.Resources.user_okpay : Properties.Resources.user_okpay_gray;
                        pcbUser_Phone.Image = profile.is_phone_verifie ? Properties.Resources.user_phone : Properties.Resources.user_phone_gray;
                        pcbUser_WMID.Image = profile.is_wmid_verified ? Properties.Resources.user_wmid : Properties.Resources.user_wmid_gray;
                    }));

                pcbProfileAvatar.BeginInvoke(new Action(() => pcbProfileAvatar.Image = Properties.Resources.user_9));
                txtProfileName.BeginInvoke(new Action(() => txtProfileName.Text = profile.login));

                imgDownloadTryCount = 0;

                Thread th = new Thread(downLoadImage);
                th.Start();

                setSizeForReviews();

                #endregion
            }

            #endregion

            #region проекты

            if (type == getInfoType.projects)
            {
                foreach (clsJSON json in jsons)
                {
                    #region проверка на ошибку

                    if (json.bloks != null)
                    {
                        clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("error") == 0);

                        if (block != null) continue;
                    }

                    #endregion

                    clsProject prj = new clsProject(json);

                    cntrlProject fp = lstProjects.FirstOrDefault(p => p.project.id == prj.id);

                    if (fp != null) continue;

                    cntrlProject cp = new cntrlProject(prj);

                    lstProjects.Add(cp);

                    cp.Dock = DockStyle.Top;
                    try
                    {
                        scrollProjects.BeginInvoke(new Action(() =>
                        {
                            cp.Parent = scrollProjects;
                            cp.BringToFront();
                        }));
                    }
                    catch (Exception) { }

                    if (!prjIDs.ContainsKey(prj.id))
                    {
                        addProjectIDToFile(prj.id);

                        frmUpdInfo.addMessage(Properties.Resources.hammer, "Новый проект, #" + prj.id);
                    }
                }
            }

            #endregion

            try
            {
                lblLastUpdate.BeginInvoke(new Action(() => lblLastUpdate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString()));
            }
            catch (Exception) { }
        }

        void frm_evClose(frmUpdateInfo sender)
        {
            sender.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabFeeds"];
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabMessages"];
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabUsers"];
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            clsUpdate.proFile = txtProfileName.Text;
            clsUpdate.Pause = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            using (frmAbout frm = new frmAbout())
                frm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabProjects"];
        }

        private void notify_Click(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            clsUpdate.isStop = true;
            notify.Visible = false;
            notify.Dispose();

            Thread.Sleep(5000);

            try
            {
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception) { }
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            clsUpdate.Pause = false;
        }

        private void notify_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.Focus();
            }
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
        }

        private void btnGoToProfileURL_Click(object sender, EventArgs e)
        {
            if (this.profile == null) return;
            System.Diagnostics.Process.Start(this.profile.url);
        }

        private void btnProfileSendMessage_Click(object sender, EventArgs e)
        {
            if (this.profile == null) return;
            System.Diagnostics.Process.Start(this.profile.url_private_message);
        }

        private void reviews_Paint(object sender, PaintEventArgs e)
        {
            if (this.profile == null) return;

            PictureBox pcb = (PictureBox)sender;

            Rectangle rect = new Rectangle(0, 0, pcb.Width, pcb.Height);

            LinearGradientBrush lnr = new LinearGradientBrush(rect, pcb == pcbUserPositive ? clsColors.posiriveColor : clsColors.negativeColor, Color.White, 90);

            e.Graphics.FillRectangle(lnr, rect);

            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(clsColors.borderPen, rect);
        }

        private void panel9_SizeChanged(object sender, EventArgs e)
        {
            setSizeForReviews();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabSearchProj"];
        }

        private void btnSaveSkills_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Текстовые файлы|*.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string str = string.Empty;
                    
                    for (int i = 0; i < lstSkill.Items.Count; i++ )
                    {
                        if (lstSkill.GetItemChecked(i))
                            str += clsGlobalSkills.skills.ElementAt(i).Key.ToString() + ",";
                    }

                    try
                    {
                        using (StreamWriter wr = new StreamWriter(save.FileName, false, Encoding.GetEncoding(1251)))
                        {
                            wr.Write(str);
                            wr.Flush();
                            wr.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnOpenSkill_Click(object sender, EventArgs e)
        {
            string[] data = null;

            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Текстовые файлы|*.txt";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader rd = new StreamReader(open.FileName, Encoding.GetEncoding(1251)))
                        {
                            data = rd.ReadLine().Split(',');
                            rd.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }

            if (data == null) return;

            List<int> _int = new List<int>();

            foreach (string str in data)
            {
                if (string.IsNullOrEmpty(str)) continue;

                int _i = 0;
                if (int.TryParse(str, out _i))
                    _int.Add(_i);
            }

            lstSkill.Items.Clear();

            foreach (KeyValuePair<int, string> key in clsGlobalSkills.skills)
            {
                int _i = _int.FirstOrDefault(i => i == key.Key);

                lstSkill.Items.Add(key.Value, _i > 0);
            }
        }

        private void mnuSkills_selectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSkill.Items.Count; i++)
                lstSkill.SetItemChecked(i, true);
        }

        private void mnuSkills_unSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSkill.Items.Count; i++)
                lstSkill.SetItemChecked(i, false);
        }

        private void mnuSkills_invert_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSkill.Items.Count; i++)
                lstSkill.SetItemChecked(i, !lstSkill.GetItemChecked(i));
        }

        private void lstSkill_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            searchedProject.Clear();

            searchedProject = new List<clsSerchedProject>();

            cmbPageNum.Items.Clear();
            cmbPageNum.Items.Add("1");
            cmbPageNum.SelectedIndex = 0;
            skillsURL = string.Empty;
        }

        private void pcbPageMinus_Click(object sender, EventArgs e)
        {
            if (cmbPageNum.Items.Count == 0) return;
            if (cmbPageNum.SelectedIndex == 0) return;

            cmbPageNum.SelectedIndex--;
        }

        private void pcbPagePlus_Click(object sender, EventArgs e)
        {
            if (cmbPageNum.Items.Count == 0) return;

            if (cmbPageNum.SelectedIndex == cmbPageNum.Items.Count - 1)
            {
                cmbPageNum.Items.Add((cmbPageNum.Items.Count + 1).ToString());
            }
            
            cmbPageNum.SelectedIndex++;
        }

        void loadProjectes()
        {
            scrollSearchedProject.Controls.Clear();

            int PageNum = cmbPageNum.SelectedIndex + 1;

            {
                var lst = from z in searchedProject where z.pageNum == PageNum select z;

                if (lst != null && lst.Count() > 0)
                {
                    scrollSearchedProject.Visible = false;

                    foreach (clsSerchedProject p in lst)
                    {
                        p.control.Dock = DockStyle.Top;
                        p.control.Parent = scrollSearchedProject;
                        p.control.BringToFront();
                    }

                    scrollSearchedProject.Visible = true;

                    return;
                }
            }

            string s = getSkills();
            string data = clsUpdate.getProgectes(s, PageNum);

            List<clsJSON> jsons = clsJSON.parce(data);

            if (jsons == null)
            {
                MessageBox.Show("Ошибка при получении списка проектов", 
                                "Ошибка", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);

                return;
            }

            if (jsons.Count == 0)
            {
                MessageBox.Show("Ничего не найднео",
                                "информация", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return;
            }

            foreach (clsJSON json in jsons)
            {
                clsProject pro = new clsProject(json);
                cntrlProject cp = new cntrlProject(pro);

                searchedProject.Add(new clsSerchedProject(PageNum, cp));
            }

            {
                var lst = from z in searchedProject where z.pageNum == PageNum select z;

                if (lst != null && lst.Count() > 0)
                {
                    scrollSearchedProject.Visible = false;

                    foreach (clsSerchedProject p in lst)
                    {
                        p.control.Dock = DockStyle.Top;
                        p.control.Parent = scrollSearchedProject;
                        p.control.BringToFront();
                    }

                    scrollSearchedProject.Visible = true;
                }
            }
        }

        string getSkills()
        {
            string str = "skills=";

            for (int i = 0; i < lstSkill.Items.Count; i++)
            {
                if (lstSkill.GetItemChecked(i))
                {
                    string skill = clsGlobalSkills.skills.ElementAt(i).Key.ToString();
                    str += skill + ",";
                }
            }

            if (str.EndsWith(","))
                str = str.Substring(0, str.Length - 1);

            return str;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            #region начальные данные

            this.skillsURL = "skills=";

            searchedProject.Clear();

            searchedProject = new List<clsSerchedProject>();

            cmbPageNum.Items.Clear();
            cmbPageNum.Items.Add("1");
            cmbPageNum.SelectedIndex = 0;

            for (int i = 0; i < lstSkill.Items.Count; i++)
            {
                if (lstSkill.GetItemChecked(i))
                {
                    string skill = clsGlobalSkills.skills.ElementAt(i).Key.ToString();
                    this.skillsURL += skill + ",";
                }
            }

            if (this.skillsURL.EndsWith(","))
                this.skillsURL = this.skillsURL.Substring(0, this.skillsURL.Length - 1);

            #endregion

            loadProjectes();
        }

        private void cmbPageNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProjectes();
        }

        
    }
}