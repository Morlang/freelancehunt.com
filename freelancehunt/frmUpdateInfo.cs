using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace freelancehunt
{
    public partial class frmUpdateInfo : Form
    {
        StringFormat textFormat = new StringFormat();

        public delegate void evCloseHandler(frmUpdateInfo sender);
        public event evCloseHandler evClose;

        Dictionary<cntrlNewAction, DateTime> dicAllLabel = new Dictionary<cntrlNewAction, DateTime>();

        void RefreshLebel()
        {
            int i = 0;

            while (i < dicAllLabel.Count)
            {
                if (dicAllLabel.ElementAt(i).Value < DateTime.Now)
                {
                    this.Controls.Remove(dicAllLabel.ElementAt(i).Key);
                    dicAllLabel.Remove(dicAllLabel.ElementAt(i).Key);
                }
                else
                    i++;
            }

            if (dicAllLabel.Count == 0)
                this.Hide();
            else
                setSize(dicAllLabel.ElementAt(0).Key.Height);
        }

        void setSize(int unitHeight)
        {
            this.BeginInvoke(new Action(() =>
                {
                    this.Height = panel1.Height + dicAllLabel.Count * unitHeight;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;

                    this.Left = rect.Width - this.Width;
                    this.Top = rect.Height - this.Height;

                    this.Show();
                }));
        }

        public frmUpdateInfo()
        {
            InitializeComponent();
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            if (evClose != null)
                evClose(this);

            //Hide();
            dicAllLabel.Clear();
            RefreshLebel();
        }

        public void addMessage(Image img, string text)
        {
            cntrlNewAction _new = new cntrlNewAction();
            _new.pcbImage.Image = img;
            _new.lblTime.Text = DateTime.Now.ToShortTimeString();
            _new.lblMessage.Text = text;
            _new.Dock = DockStyle.Bottom;
            _new.BackColor = Color.White;
            _new.lblTime.ForeColor = clsColors.textColor;
            _new.lblMessage.ForeColor = clsColors.textColor;

            this.BeginInvoke(new Action(() =>
                {
                    _new.Parent = this;

                    dicAllLabel.Add(_new, DateTime.Now.AddMinutes(2));

                    setSize(_new.Height);
                }));
        }

        void lbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshLebel();
        }
    }
}
