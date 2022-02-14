using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Print
    { 
        /// <summary>
        /// Метод пчатающий заголовок с разделителями
        /// </summary>
        /// <param name="header">Текст заголовка</param>
        public static void Header(string header)
        {
            Console.WriteLine("#####################################");
            Console.WriteLine(header);
            Console.WriteLine("#####################################");
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Вывод текста по центру экрана
        /// </summary>
        /// <param name="text">Передаваемый текст</param>
        public static void Center(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.Write(text);
        }

        /// <summary>
        /// Добавление пункта меню
        /// </summary>
        /// <param name="i">Номер пункта</param>
        /// <param name="text">текст пункта</param>
        public static void MenuPunkt(byte i, string text)
        {
            Console.WriteLine($"{i} -> {text}");
        }

        /*public static void MenuSwitch(int i)
        {
            switch (task)
            {
                case 0: break;
                case 1: Task_1(); break;
            }
        }*/
    }    
}
