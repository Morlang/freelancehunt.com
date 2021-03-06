﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    public class clsProject
    {
        public clsFrom from { get; private set; }
        
        public Int64 id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }

        public int status_id { get; private set; }
        public string status_name { get; private set; }
        public int bid_count { get; private set; }

        public string start_time { get; private set; }
        public string expire_time { get; private set; }

        public string url { get; private set; }

        /// <summary>
        /// постоянная работа
        /// </summary>
        public bool is_job { get; private set; }

        /// <summary>
        /// премиум проект
        /// </summary>
        public bool is_featured { get; private set; }

        /// <summary>
        /// личность заказчика проверена
        /// </summary>
        public bool is_identity_verified { get; private set; }

        public Dictionary<int, string> skills { get; private set; }

        public clsProject(clsJSON json)
        {
            string[] strFrom = new string[] 
            { 
                string.Empty, 
                string.Empty, 
                string.Empty, 
                string.Empty 
            };

            #region обработка данных для этого класса

            foreach (string[] param in json.data)
            {
                if (param[0].ToLower().CompareTo("project_id") == 0)
                {
                    Int64 _i = 0;

                    if (Int64.TryParse(param[1], out _i))
                        this.id = _i;
                }

                if (param[0].ToLower().CompareTo("name") == 0) this.name = param[1];
                if (param[0].ToLower().CompareTo("url") == 0) this.url = param[1];
                if (param[0].ToLower().CompareTo("description") == 0) this.description = param[1].Replace("rn", "\r\n");

                if (param[0].ToLower().CompareTo("status_id") == 0)
                {
                    int _i = 0;

                    if (int.TryParse(param[1], out _i))
                        this.status_id = _i;
                }

                if (param[0].ToLower().CompareTo("status_name") == 0) this.status_name = param[1];

                if (param[0].ToLower().CompareTo("bid_count") == 0)
                {
                    int _i = 0;

                    if (int.TryParse(param[1], out _i))
                        this.bid_count = _i;
                }

                if (param[0].ToLower().CompareTo("start_time") == 0) this.start_time = param[1];
                if (param[0].ToLower().CompareTo("expire_time") == 0) this.expire_time = param[1];

                if (param[0].ToLower().CompareTo("is_job") == 0)
                    this.is_job = param[1].CompareTo("1") == 0 || param[1].ToLower().CompareTo("true") == 0;

                if (param[0].ToLower().CompareTo("is_featured") == 0)
                    this.is_featured = param[1].CompareTo("1") == 0 || param[1].ToLower().CompareTo("true") == 0;

                if (param[0].ToLower().CompareTo("is_identity_verified") == 0)
                    this.is_identity_verified = param[1].CompareTo("1") == 0 || param[1].ToLower().CompareTo("true") == 0;
            }

            #endregion

            #region skills

            if (json.bloks != null)
            {
                clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("skills") == 0);

                if (block != null)
                {
                    this.skills = new Dictionary<int, string>();

                    foreach (string[] param in block.data)
                    {
                        int _i = 0;

                        if (!int.TryParse(param[0], out _i)) continue;

                        this.skills.Add(_i, param[1]);
                    }
                }
            }

            #endregion

            #region from

            if (json.bloks != null)
            {
                clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("from") == 0);

                if (block != null)
                {
                    foreach (string[] param in block.data)
                    {
                        if (param[0].ToLower().CompareTo("profile_id") == 0) strFrom[0] = param[1];
                        if (param[0].ToLower().CompareTo("login") == 0) strFrom[1] = param[1];
                        if (param[0].ToLower().CompareTo("url") == 0) strFrom[2] = param[1];
                        if (param[0].ToLower().CompareTo("avatar") == 0) strFrom[3] = param[1];
                    }
                }
            }
            
            #endregion

            this.from = new clsFrom(strFrom);
        }
    }
}
