using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Drawing;

namespace freelancehunt
{
    [Flags]
    public enum getInfoType
    { 
        /// <summary>
        /// сообщения
        /// </summary>
        messages = 0,

        /// <summary>
        /// лента
        /// </summary>
        feed,

        /// <summary>
        /// профайлы
        /// </summary>
        profiles,

        projects,
    }

    class clsUpdate
    {
        #region событие обновления
        
        public delegate void evRefreshHandle(getInfoType type, string text);
        public static event evRefreshHandle evRefresh;

        public delegate void evRefreshStartHandle(getInfoType type);
        public static event evRefreshStartHandle evRefreshStart;

        public delegate void evRefreshEndHandle(getInfoType type);
        public static event evRefreshEndHandle evRefreshEnd;

        #endregion

        /// <summary>
        /// искомый логин профиля
        /// </summary>
        public static string proFile = string.Empty;

        public static bool Pause = true;

        /// <summary>
        /// идентификатор
        /// </summary>
        public static string id = string.Empty;

        /// <summary>
        /// пароль
        /// </summary>
        public static string pass = string.Empty;

        /// <summary>
        /// для остановки основного потока
        /// </summary>
        public static bool isStop = false;

        static object lockFiles = new object();

        /// <summary>
        /// выполнить запрос
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        static string cmdExecWithWait(string command)
        {
            //string bat = Application.StartupPath + @"\req.bat";
            //string reqRez = Application.StartupPath + @"\msgs.txt";

            string output = string.Empty;

            lock (lockFiles)
            {
                /*File.Delete(bat);
                File.Delete(reqRez);

                using (StreamWriter wr = new StreamWriter(bat, false, Encoding.GetEncoding(1251)))
                {
                    wr.WriteLine("chcp 1251>nul");
                    wr.WriteLine(command + " >> msgs.txt");
                    //wr.WriteLine(command);
                    wr.Flush();
                    wr.Close();
                }*/

                Process p = new Process();
                
                //p.StartInfo = new ProcessStartInfo(bat)
                p.StartInfo = new ProcessStartInfo("cmd", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                /*using (StreamWriter wr = new StreamWriter(Application.StartupPath + @"\commands.txt", true, Encoding.GetEncoding(1251)))
                {
                    wr.WriteLine(command);
                    wr.Flush();
                    wr.Close();
                }*/

                p.Start();

                output = p.StandardOutput.ReadToEnd();

                p.WaitForExit();

                /*output = string.Empty;

                if (File.Exists(reqRez))
                {
                    using (StreamReader rd = new StreamReader(reqRez, Encoding.UTF8))
                    {
                        output = rd.ReadToEnd();
                        rd.Close();
                    }
                }*/
            }

            #region преобразование

            /*using (StreamWriter wr = new StreamWriter(Application.StartupPath + @"\output.txt", true, Encoding.GetEncoding(1251)))
            {
                wr.WriteLine(output);
                wr.WriteLine("\r\n\r\n");
                wr.Flush();
                wr.Close();
            }*/

            output = output.Replace("\r\n", "|");

            output = output.Replace("\\", "");

            output = output.Replace("[", "[\r\n");
            output = output.Replace("]", "\r\n]");

            output = output.Replace("\",", "\",\r\n");
            output = output.Replace("},", "},\r\n");

            output = output.Replace("{", "\r\n{\r\n");
            output = output.Replace("}", "\r\n}\r\n");

            output = output.Replace("false,", "false,\r\n");
            output = output.Replace("true,", "true,\r\n");
            output = output.Replace("null,", "null,\r\n");
            output = output.Replace(" ,", " ,\r\n");

            output = output.Replace("0,", "0,\r\n");
            output = output.Replace("1,", "1,\r\n");
            output = output.Replace("2,", "2,\r\n");
            output = output.Replace("2,", "3,\r\n");
            output = output.Replace("4,", "4,\r\n");
            output = output.Replace("5,", "5,\r\n");
            output = output.Replace("6,", "6,\r\n");
            output = output.Replace("7,", "7,\r\n");
            output = output.Replace("8,", "8,\r\n");
            output = output.Replace("9,", "9,\r\n");

            output = output.Replace("|", "\r\n");

            #endregion

            /*using (StreamWriter wr = new StreamWriter(Application.StartupPath + @"\output.txt", true, Encoding.GetEncoding(1251)))
            {
                wr.WriteLine(output);
                wr.WriteLine("");
                wr.WriteLine("");
                wr.Flush();
                wr.Close();
            }*/

            return output;
        }

        public static string CreateToken(string message)
        {
            //secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(pass);
            byte[] messageBytes = encoding.GetBytes(message + "GET");
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }

        public static string cmdReq(getInfoType type)
        {
            string url = string.Empty;
            switch (type)
            {
                case getInfoType.feed:
                    url = @"https://api.freelancehunt.com/my/feed";
                    break;

                case getInfoType.messages:
                    url = @"https://api.freelancehunt.com/threads?filter=new";
                    break;

                case getInfoType.profiles:
                    if (!string.IsNullOrEmpty(proFile))
                    {
                        url = @"https://api.freelancehunt.com/profiles/" + proFile;
                        proFile = string.Empty;
                    }
                    break;

                case getInfoType.projects:
                    url = @"https://api.freelancehunt.com/projects/";
                    break;
            }

            if (string.IsNullOrEmpty(url)) return string.Empty;

            string ret = @"curl -u " + id + ":" + CreateToken(url) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + url;

            if(type == getInfoType.profiles)
                return ret;

            return ret;
        }

        public static string getData(getInfoType type)
        {
            string exe = cmdReq(type);

            if (evRefreshStart != null)
                evRefreshStart(type);

            string rez = cmdExecWithWait(exe);

            if (evRefreshEnd != null)
                evRefreshEnd(type);

            return rez;
        }

        public static string getProjectFullInfo(Int64 projectID)
        {
            string url = @"https://api.freelancehunt.com/projects/" + projectID;
            string exe = @"curl -u " + id + ":" + CreateToken(url) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + url;
            return cmdExecWithWait(exe);
        }

        public static string getProgectes(string skills, int pageNum)
        {
            string url = @"https://api.freelancehunt.com/projects?page=" + pageNum + "&" + skills + "&per_page=10";
            string exe = @"curl -u " + id + ":" + CreateToken(url) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + "\"" + url + "\"";
            return cmdExecWithWait(exe);
        }

        public static clsJSON getProfileFullInfo(string login)
        {
            string url = @"https://api.freelancehunt.com/profiles/" + login;
            string exe = @"curl -u " + id + ":" + CreateToken(url) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + url;
            string req = cmdExecWithWait(exe);

            List<clsJSON> jsones = clsJSON.parce(req);

            if (jsones == null) return null;
            if (jsones.Count != 1) return null;
            //if (jsones[0].bloks == null) return null;
            //if (jsones[0].bloks.Count == 0) return null;

            return jsones[0];
        }

        /// <summary>
        /// автообновление записей
        /// </summary>
        public static void autoRefresh()
        {
            int num = 0;
            int max = Enum.GetNames(typeof(getInfoType)).Length;

            while (!isStop)
            {
                while (!clsPing.isConnect)
                    Thread.Sleep(100);

                string data = getData((getInfoType)num);

                if (evRefresh != null)
                    if (!string.IsNullOrEmpty(data))
                        evRefresh((getInfoType)num, data);

                num++;
                if (num == max)
                {
                    num = 0;

                    Pause = true;

                    DateTime dtEnd = DateTime.Now.AddMinutes(1);

                    while (Pause && 
                           dtEnd >= DateTime.Now)
                    {
                        if (isStop) return;

                        Thread.Sleep(100);
                    }
                }

                Thread.Sleep(250);
            }
        }
    }
}