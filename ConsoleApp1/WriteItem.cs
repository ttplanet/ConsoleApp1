using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ConsoleApp1.Const;
using ConsoleApp1.Base;

namespace ConsoleApp1.Write
{
    class WriteItem:SingletonBase<WriteItem>
    {
        private const string doneWrite = "書き込みました";
        /// <summary>
        /// ファイルに書き込み
        /// </summary>
        /// <param name="input"></param>
        public void WriteInput(string input)
        {
            StreamWriter writer =
              new StreamWriter(ConstPath.PATH_ITEM_FILE, true, ConstEncoding.ENC_UTF8);
            writer.WriteLine(input);
            writer.Close();
            Console.WriteLine(doneWrite);
        }
    }
}
