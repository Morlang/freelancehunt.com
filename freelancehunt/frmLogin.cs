using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace freelancehunt
{
    public partial class frmLogin : Form
    {
        string fileParam = Application.StartupPath + @"\param.txt";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(fileParam))
            {
                try
                {
                    using (StreamReader rd = new StreamReader(fileParam, Encoding.GetEncoding(1251)))
                    {
                        txtLogin.Text = rd.ReadLine();
                        txtPass.Text = rd.ReadLine();

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

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
