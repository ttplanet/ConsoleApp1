using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Base;
using ConsoleApp1.Const;
namespace ConsoleApp1.Program
{
    /// <summary>
    /// メニュー画面
    /// </summary>
    class MenuWindow:SingletonBase<MenuWindow>
    {
        private string _menuStr = "メニュー:書き込み→w、検索→s、メニューに戻る→m、表示、終わる";

        public enum MenuItem
        {
            Write,
            Seach,
            Return,
            End

        }
        private MenuItem _currentSelect;

        /// <summary>
        /// メニューの表示
        /// </summary>
        public void ShowMenu()
        {
            Console.WriteLine(_menuStr);
            string input = Console.ReadLine();
            //押されたキーによって判別当てはまらなかったらまたメニューが表示される
            switch (input)
            {
                case ConstString.STR_SELECT_W:
                    _currentSelect = MenuItem.Write;
                    break;
                case ConstString.STR_SELECT_S:
                    _currentSelect = MenuItem.Seach;
                    break;
                case ConstString.STR_SELECT_M:
                    _currentSelect = MenuItem.Return;
                    break;
                case ConstString.STR_SELECT_E:
                    _currentSelect = MenuItem.End;
                    break;

                default:
                    _currentSelect = MenuItem.Return;
                    break;
            }
            ChangeWindow();
        }
        /// <summary>
        /// 画面切り替え
        /// </summary>
        public void ChangeWindow()
        {
            switch (_currentSelect) {
                case MenuItem.Write:
                    WriteWindow.Instance.ShowWrite();
                    break;
                case MenuItem.Seach:
                    SeachWindow.Instance.ShowSeachWindow();
                    break;
                case MenuItem.Return:
                    break;
                case MenuItem.End:
                    break;

            }

        }
    }
}
