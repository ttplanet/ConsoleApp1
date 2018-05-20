using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ConsoleApp1.Const;
using ConsoleApp1.Write;
using ConsoleApp1.Read;

namespace ConsoleApp1.Program
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //インスタンス
            WriteItem writeItem = WriteItem.Instance();
            ReadItem readItem = ReadItem.Instance();
 
            string _input = "";
            while (_input != "end")
            {
                _input = Console.ReadLine();

                writeItem.WriteInput(_input);
            }


            string _read = readItem.ReadFileItem();

            //読み込まれたアイテムをファイルに保存していく。
            Console.WriteLine(_read);
        }



    }
}
