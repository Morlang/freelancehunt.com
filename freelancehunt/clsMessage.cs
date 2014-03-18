using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    /// <summary>
    /// сообщение
    /// </summary>
    public class clsMessage
    {
        public string url { get; private set; }
        public int attachCount { get; private set; }
        public DateTime last_post_time { get; private set; }
        public DateTime post_time { get; private set; }
        public int unread_count { get; private set; }

        public clsFrom from { get; private set; }

        public clsMessage(clsJSON json)
        {
            string[] strFrom = new string[]
            {
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
            };

            #region данные класса
            
            foreach (string[] line in json.data)
            {
                if (line[0].ToLower().CompareTo("url") == 0)            this.url = line[1];
                if (line[0].ToLower().CompareTo("has_attach") == 0)
                {
                    int _i = 0;
                    if (int.TryParse(line[1], out _i))
                        this.attachCount = _i;
                }
                if (line[0].ToLower().CompareTo("last_post_time") == 0) this.last_post_time = clsTimeConvert.dtFrom8061(line[1]);
                if (line[0].ToLower().CompareTo("post_time") == 0) this.post_time = clsTimeConvert.dtFrom8061(line[1]);
                if (line[0].ToLower().CompareTo("unread_count") == 0)
                {
                    int _i = 0;
                    if (int.TryParse(line[1], out _i))
                        this.unread_count = _i;
                }
            } 

            #endregion

            #region от кого
            
            if (json.bloks != null)
            {
                clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("from") == 0);

                if (block != null)
                {
                    foreach (string[] line in block.data)
                    {
                        if (line[0].ToLower().CompareTo("profile_id") == 0) strFrom[0] = line[1];
                        if (line[0].ToLower().CompareTo("login") == 0)      strFrom[1] = line[1];
                        if (line[0].ToLower().CompareTo("url") == 0)        strFrom[2] = line[1];
                        if (line[0].ToLower().CompareTo("avatar") == 0)     strFrom[3] = line[1];
                    }
                }
            }

            this.from = new clsFrom(strFrom); 

            #endregion
            
        }
    }
}
