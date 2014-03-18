using System.Windows.Forms;
using System.Drawing;
using System;
using freelancehunt.Properties;
namespace freelancehunt
{
    partial class cntrlProject
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.lblBidCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcbShowInWondow = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbIsJob = new System.Windows.Forms.PictureBox();
            this.pcbIsFeatured = new System.Windows.Forms.PictureBox();
            this.pcbIsIdentityVerified = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAutor = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlSkills = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShowInWondow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIsJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIsFeatured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIsIdentityVerified)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pcbAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(60, 200);
            this.panel2.TabIndex = 4;
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pcbAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbAvatar.Image = global::freelancehunt.Properties.Resources.user_9;
            this.pcbAvatar.Location = new System.Drawing.Point(5, 5);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(50, 190);
            this.pcbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAvatar.TabIndex = 0;
            this.pcbAvatar.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.lblNumber);
            this.pnlTitle.Controls.Add(this.panel4);
            this.pnlTitle.Controls.Add(this.panel3);
            this.pnlTitle.Controls.Add(this.panel1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(60, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pnlTitle.Size = new System.Drawing.Size(594, 24);
            this.pnlTitle.TabIndex = 5;
            // 
            // lblNumber
            // 
            this.lblNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumber.Location = new System.Drawing.Point(71, 4);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(281, 20);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "label1";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblState);
            this.panel4.Controls.Add(this.lblBidCount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(352, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 20);
            this.panel4.TabIndex = 1;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.Location = new System.Drawing.Point(0, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(161, 20);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "label1";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBidCount
            // 
            this.lblBidCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBidCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBidCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBidCount.Location = new System.Drawing.Point(161, 0);
            this.lblBidCount.Name = "lblBidCount";
            this.lblBidCount.Size = new System.Drawing.Size(30, 20);
            this.lblBidCount.TabIndex = 0;
            this.lblBidCount.Text = "100";
            this.lblBidCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pcbShowInWondow);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(543, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 2, 2, 3);
            this.panel3.Size = new System.Drawing.Size(51, 20);
            this.panel3.TabIndex = 0;
            // 
            // pcbShowInWondow
            // 
            this.pcbShowInWondow.BackColor = System.Drawing.Color.Transparent;
            this.pcbShowInWondow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcbShowInWondow.Image = global::freelancehunt.Properties.Resources.external;
            this.pcbShowInWondow.Location = new System.Drawing.Point(5, 2);
            this.pcbShowInWondow.Name = "pcbShowInWondow";
            this.pcbShowInWondow.Size = new System.Drawing.Size(22, 15);
            this.pcbShowInWondow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbShowInWondow.TabIndex = 2;
            this.pcbShowInWondow.TabStop = false;
            this.pcbShowInWondow.Click += new System.EventHandler(this.pcbShowInWondow_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::freelancehunt.Properties.Resources.world;
            this.pictureBox2.Location = new System.Drawing.Point(27, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pcbIsJob);
            this.panel1.Controls.Add(this.pcbIsFeatured);
            this.panel1.Controls.Add(this.pcbIsIdentityVerified);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.panel1.Size = new System.Drawing.Size(71, 20);
            this.panel1.TabIndex = 0;
            // 
            // pcbIsJob
            // 
            this.pcbIsJob.BackColor = System.Drawing.Color.Transparent;
            this.pcbIsJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbIsJob.Image = global::freelancehunt.Properties.Resources.prj_is_job_gray;
            this.pcbIsJob.Location = new System.Drawing.Point(44, 2);
            this.pcbIsJob.Name = "pcbIsJob";
            this.pcbIsJob.Size = new System.Drawing.Size(22, 15);
            this.pcbIsJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIsJob.TabIndex = 2;
            this.pcbIsJob.TabStop = false;
            // 
            // pcbIsFeatured
            // 
            this.pcbIsFeatured.BackColor = System.Drawing.Color.Transparent;
            this.pcbIsFeatured.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbIsFeatured.Image = global::freelancehunt.Properties.Resources.prj_is_featured_gray;
            this.pcbIsFeatured.Location = new System.Drawing.Point(22, 2);
            this.pcbIsFeatured.Name = "pcbIsFeatured";
            this.pcbIsFeatured.Size = new System.Drawing.Size(22, 15);
            this.pcbIsFeatured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIsFeatured.TabIndex = 3;
            this.pcbIsFeatured.TabStop = false;
            // 
            // pcbIsIdentityVerified
            // 
            this.pcbIsIdentityVerified.BackColor = System.Drawing.Color.Transparent;
            this.pcbIsIdentityVerified.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbIsIdentityVerified.Image = global::freelancehunt.Properties.Resources.prj_is_identity_verified_gray;
            this.pcbIsIdentityVerified.Location = new System.Drawing.Point(0, 2);
            this.pcbIsIdentityVerified.Name = "pcbIsIdentityVerified";
            this.pcbIsIdentityVerified.Size = new System.Drawing.Size(22, 15);
            this.pcbIsIdentityVerified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIsIdentityVerified.TabIndex = 4;
            this.pcbIsIdentityVerified.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblAutor);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(60, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(594, 24);
            this.panel5.TabIndex = 6;
            // 
            // lblAutor
            // 
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutor.Location = new System.Drawing.Point(0, 0);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(543, 24);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.TabStop = true;
            this.lblAutor.Text = "Автор";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAutor_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(543, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 6, 2, 3);
            this.panel6.Size = new System.Drawing.Size(51, 24);
            this.panel6.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::freelancehunt.Properties.Resources.information;
            this.pictureBox3.Location = new System.Drawing.Point(5, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::freelancehunt.Properties.Resources.world;
            this.pictureBox4.Location = new System.Drawing.Point(27, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pnlSkills
            // 
            this.pnlSkills.BackColor = System.Drawing.Color.Transparent;
            this.pnlSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSkills.Location = new System.Drawing.Point(60, 147);
            this.pnlSkills.Name = "pnlSkills";
            this.pnlSkills.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.pnlSkills.Size = new System.Drawing.Size(594, 29);
            this.pnlSkills.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(60, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(594, 64);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Название";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(60, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(594, 59);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Описание";
            // 
            // cntrlProject
            // 
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlSkills);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.panel2);
            this.Name = "cntrlProject";
            this.Size = new System.Drawing.Size(654, 200);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbShowInWondow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIsJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIsFeatured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIsIdentityVerified)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox pcbAvatar;
        private Panel pnlTitle;
        private Panel panel1;
        private PictureBox pcbIsIdentityVerified;
        private PictureBox pcbIsFeatured;
        private PictureBox pcbIsJob;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pcbShowInWondow;
        private Panel panel4;
        private Label lblBidCount;
        private Label lblState;
        private Label lblNumber;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private LinkLabel lblAutor;
        private Panel pnlSkills;
        private Label lblName;
        private Label lblDescription;


	

    }
}

