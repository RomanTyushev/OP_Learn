using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Helper
    {
        /// <summary>
        /// Задержка темного экрана
        /// </summary>

        public static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Напечатать текст
        /// </summary>
        /// <param name="text">Выводимый текст</param>
        static public void Print(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }

        public static void PrintCenter(string text)
        {
            Console.WriteLine(text);

        }
    }
   
}
