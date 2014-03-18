namespace freelancehunt
{
    partial class cntrlMessageInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbGo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcbAttach = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(60, 100);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::freelancehunt.Properties.Resources.user_9;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(199, 20);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAutor
            // 
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAutor.Location = new System.Drawing.Point(60, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(383, 20);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.TabStop = true;
            this.lblAutor.Text = "Автор";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAutor_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pcbGo);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(60, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 20);
            this.panel1.TabIndex = 6;
            // 
            // pcbGo
            // 
            this.pcbGo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcbGo.Image = global::freelancehunt.Properties.Resources.Button_Next_icon;
            this.pcbGo.Location = new System.Drawing.Point(363, 0);
            this.pcbGo.Name = "pcbGo";
            this.pcbGo.Size = new System.Drawing.Size(20, 20);
            this.pcbGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGo.TabIndex = 1;
            this.pcbGo.TabStop = false;
            this.pcbGo.Click += new System.EventHandler(this.pcbGo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pcbAttach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(60, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 20);
            this.panel3.TabIndex = 8;
            // 
            // pcbAttach
            // 
            this.pcbAttach.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbAttach.Image = global::freelancehunt.Properties.Resources.attach_gray;
            this.pcbAttach.Location = new System.Drawing.Point(0, 0);
            this.pcbAttach.Name = "pcbAttach";
            this.pcbAttach.Size = new System.Drawing.Size(20, 20);
            this.pcbAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAttach.TabIndex = 2;
            this.pcbAttach.TabStop = false;
            // 
            // cntrlMessageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "cntrlMessageInfo";
            this.Size = new System.Drawing.Size(443, 100);
            this.Load += new System.EventHandler(this.cntrlMessageInfo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.cntrlMessageInfo_Paint);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGo)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.LinkLabel lblAutor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbGo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcbAttach;
    }
}
