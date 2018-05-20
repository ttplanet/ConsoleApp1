using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ConsoleApp1.Const;
using ConsoleApp1.Base;
namespace ConsoleApp1.Read
{
    class ReadItem:SingletonBase<ReadItem>
    {
        
        /// <summary>
        /// 読み込みを行い文字列として返す
        /// </summary>
        public string ReadFileItem()
        {
            string readItem="";
            StreamReader streamReader = new StreamReader(ConstPath.PATH_ITEM_FILE, ConstEncoding.ENC_UTF8);
            readItem = streamReader.ReadToEnd();
            return readItem;
        }
    }
}
