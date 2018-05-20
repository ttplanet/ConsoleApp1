using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Base
{
    /// <summary>
    /// クラスをインスタンスするクラスs
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SingletonBase<T> where T:new()
    {

        public static T Instance()
        {
            return new T();
        }
    }
}
