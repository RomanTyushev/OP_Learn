using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    public class Helper
    {
        /// <summary>
        /// Задержка темного экрана
        /// </summary>
        static public void Pause()
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

    }
}
