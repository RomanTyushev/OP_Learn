using System;

namespace Helpers
{
    public class Print
    {

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
        /// Напечатать текст
        /// </summary>
        /// <param name="text">Выводимый текст</param>
        static public void PrintText(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}