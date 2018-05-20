using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Base;
using ConsoleApp1.Const;
using ConsoleApp1.Read;

namespace ConsoleApp1.Program
{
    class SeachWindow:SingletonBase<SeachWindow>
    {
        private const string _seachStr = "検索:" + ConstString.STR_END + "でメニューに戻る";
        private const string _resultStr = "結果:";

        private const string _noneResult = "該当なし";
        /// <summary>
        /// 検索ウィンドウの表示
        /// </summary>
        public void ShowSeachWindow()
        {
            Console.WriteLine(_seachStr);
            string input = Console.ReadLine();
            while (input != ConstString.STR_END)
            {
                List<string> item = new List<string>(ReadItem.Instance.ReadFileItem(input));

                //結果を一覧表示
                Console.WriteLine(_resultStr);
                if (item.Count == 0)
                {
                    Console.WriteLine(_noneResult);
                }
                for (int i = 0; i < item.Count; i++)
                {
                    Console.WriteLine(item[i]);
                }
                input = Console.ReadLine();
            }

            //メニューに戻る
            MenuWindow.Instance.ShowMenu();
        }
    }
}
