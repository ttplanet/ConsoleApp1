using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Base;
using ConsoleApp1.Write;
using ConsoleApp1.Const;


namespace ConsoleApp1.Program
{
    /// <summary>
    /// 書き込みウィンドウ
    /// </summary>
    class WriteWindow:SingletonBase<WriteWindow>
    {
        private const string _writeStr = "書き込み："+ ConstString.STR_END + "でメニューに戻る";
        /// <summary>
        /// 書き込みウィンドウを見せる
        /// </summary>
        public void ShowWrite()
        {
            Console.WriteLine(_writeStr);

            string input = Console.ReadLine();
            while (input != ConstString.STR_END)
            {
                WriteItem.Instance.WriteInput(input);

                input = Console.ReadLine();
            }
            MenuWindow.Instance.ShowMenu();//メニューに戻る
        }
    }
}
