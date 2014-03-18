using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    /// <summary>
    /// блок входящий в состав структуры
    /// </summary>
    public class clsJSON_block
    {
        /// <summary>
        /// название блока
        /// </summary>
        public string name { get; private set; }

        /// <summary>
        /// данные блока
        /// </summary>
        public List<string[]> data { get; private set; }

        public clsJSON_block(string name)
        {
            this.data = new List<string[]>();
            this.name = name;
        }

        public void addData(string[] data)
        {
            this.data.Add(data);
        }

    }

    /// <summary>
    /// еденичная структура
    /// </summary>
    public class clsJSON
    {
        /// <summary>
        /// данные структуры
        /// </summary>
        public List<string[]> data { get; private set; }

        /// <summary>
        /// блоки структуры
        /// </summary>
        public List<clsJSON_block> bloks { get; private set; }

        public clsJSON(List<string[]> data, List<clsJSON_block> bloks)
        {
            this.bloks = bloks;
            this.data = data;
        }

        public static List<clsJSON> parce(string text)
        {
            List<clsJSON> rezult = new List<clsJSON>();

            string text2 = text.Replace("[", "[\r\n");
            text2 = text2.Replace("{", "\r\n{\r\n");
            text2 = text2.Replace("}", "\r\n}\r\n");

            List<string[]> data = new List<string[]>();
            List<clsJSON_block> bloks = null;
            clsJSON_block blok = null;

            bool inBlock = false;
            string blockName = string.Empty;
            int brckNum = 0;

            string[] lines = text2.Split(new char[] { '\r', '\n' });

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line)) continue;
                if (line.CompareTo("[") == 0) continue;
                if (line.CompareTo("]") == 0) continue;

                if (line.CompareTo("{") == 0)
                {
                    brckNum++;
                    continue;
                }

                if (line.CompareTo("}") == 0)
                {
                    brckNum--;

                    if (brckNum == 0)
                    {
                        // закончили JSON
                        rezult.Add(new clsJSON(data, bloks));

                        data = new List<string[]>();
                        bloks = null;
                        blok = null;

                        inBlock = false;
                        blockName = string.Empty;
                    }
                    else
                    { 
                        // закончили блок
                        if (blok != null)
                            bloks.Add(blok);

                        blok = null;
                        inBlock = false;
                        blockName = string.Empty;
                    }

                    continue;
                }

                string[] param = line.Split(':');

                if (param.Count() == 1) continue;

                param[0] = param[0].Replace("\"", "");

                #region название блока
                
                if (string.IsNullOrEmpty(param[1]))
                {
                    inBlock = true;

                    blok = new clsJSON_block(param[0]);

                    if (bloks == null)
                        bloks = new List<clsJSON_block>();

                    continue;
                } 

                #endregion

                param[1] = line.Substring(line.IndexOf(":") + 1).Replace("\"", "").Replace(",", "");

                if (inBlock)
                    blok.addData(new string[] { param[0], param[1] });
                else
                    data.Add(new string[] { param[0], param[1] });
            }

            

            return rezult;
        }
    }
}
