using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    /// <summary>
    /// пост в ленте
    /// </summary>
    public class clsFeed
    {
        DateTime dtBase = new DateTime(1970, 1, 1);

        public DateTime date { get; private set; }

        public string message { get; private set; }
        public string link { get; private set; }
        public string justMessage { get; private set; }

        public bool is_new { get; private set; }
        public Int64 time_millis { get; private set; }
        /*public DateTime date
        {
            get
            {
                return dtBase.AddMilliseconds(this.time_millis);
            }
        }*/

        public clsFrom from { get; private set; }

        public clsFeed(clsJSON json)
        {
            string[] strFrom = new string[]
            {
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
            };

            #region обработка данных для этого класса

            foreach (string[] line in json.data)
            {
                if (line[0].ToLower().CompareTo("time") == 0) this.date = clsTimeConvert.dtFrom8061(line[1]);
                if (line[0].ToLower().CompareTo("message") == 0)
                {
                    this.message = line[1];

                    string[] dd = this.message.Split(new char[] { '<', '>' });

                    this.justMessage = string.Empty;
                    this.link = string.Empty;

                    foreach (string s in dd)
                    {
                        if (s.LastIndexOf("/a") > -1) continue;
                        if (s.LastIndexOf("href") > -1)
                            this.link = @"http://freelancehunt.com" + s.Split('=')[1];
                        else
                            this.justMessage += s.Trim() + " ";
                    }
                }

                if (line[0].ToLower().CompareTo("is_new") == 0) this.is_new = line[1].ToLower().CompareTo("true") == 0;
                /*if (line[0].ToLower().CompareTo("time_millis") == 0)
                {
                    Int64 date = 0;

                    if (Int64.TryParse(line[1], out date))
                    {
                        time_millis = date;
                    }
                }*/

            } 

            #endregion

            #region от кого
            
            clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("from") == 0);

            if (block != null)
            {
                foreach (string[] line in block.data)
                {
                    if (line[0].ToLower().CompareTo("profile_id") == 0) strFrom[0] = line[1];
                    if (line[0].ToLower().CompareTo("login") == 0) strFrom[1] = line[1];
                    if (line[0].ToLower().CompareTo("url") == 0) strFrom[2] = line[1];
                    if (line[0].ToLower().CompareTo("avatar") == 0) strFrom[3] = line[1];
                }
            }

            this.from = new clsFrom(strFrom);

            #endregion

            
        }
    }
}
