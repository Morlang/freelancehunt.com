using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace freelancehunt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                #region Обновление версии

                string fn = @"..\..\..\Properties\AssemblyInfo.cs";

                if (File.Exists(fn))
                {
                    StreamReader rd = new StreamReader(fn, System.Text.Encoding.Unicode);
                    string[] lines = rd.ReadToEnd().Split(new char[] { '\r', '\n' });
                    rd.Close();
                    rd.Dispose();

                    StreamWriter wr = new StreamWriter(fn, false, System.Text.Encoding.Unicode);

                    foreach (string l in lines)
                    {
                        if (string.IsNullOrEmpty(l)) continue;

                        if (l.StartsWith(@"[assembly: AssemblyVersion("))
                        {
                            #region выбор и подсчет новой версии

                            string[] param_1 = l.Split('"');
                            string[] num_str = param_1[1].Split('.');

                            int[] num = new int[4];

                            int.TryParse(num_str[0], out num[0]);
                            int.TryParse(num_str[1], out num[1]);
                            int.TryParse(num_str[2], out num[2]);
                            int.TryParse(num_str[3], out num[3]);

                            num[3]++;

                            if (num[3] > 99)
                            {
                                num[3] = 0;
                                num[2]++;

                                if (num[2] > 99)
                                {
                                    num[2] = 0;
                                    num[1]++;

                                    if (num[1] > 99)
                                    {
                                        num[1] = 0;
                                        num[0]++;
                                    }
                                }
                            }

                            #endregion

                            wr.WriteLine("[assembly: AssemblyVersion(\"" + num[0].ToString() + "." + num[1].ToString() + "." + num[2].ToString() + "." + num[3].ToString() + "\")]");
                            wr.WriteLine("[assembly: AssemblyFileVersion(\"" + num[0].ToString() + "." + num[1].ToString() + "." + num[2].ToString() + "." + num[3].ToString() + "\")]");
                        }
                        else
                        {
                            if (l.StartsWith("[assembly: AssemblyFileVersion(")) continue;
                            wr.WriteLine(l);
                        }

                        wr.Flush();
                    }

                    wr.Flush();
                    wr.Close();
                    wr.Dispose();
                }

                #endregion
            }
            catch { }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
