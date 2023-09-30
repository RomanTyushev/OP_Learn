using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Helpers
{
    public class Helper
    {
        #region Pause

        /// <summary>
        /// Задержка темного экрана
        /// </summary>

        public static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        /// <param name="interval">миллисекунд (1000 мс = 1 с)</param>
        public static void Sleep(int interval)
        {
            Thread.Sleep(interval);
        }

        #endregion

        #region Print

        /// <summary>
        /// Напечатать текст
        /// </summary>
        /// <param name="text">Выводимый текст</param>
        static public void Print(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
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
        /// Вывод текста по центру экрана
        /// </summary>
        /// <param name="text">Передаваемый текст</param>
        public static void Center(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.Write(text);
        }

        #endregion

        #region MyArray

        private int[] _a;

        /// <summary>
        /// Запись/чтение массива
        /// </summary>
        /// <param name="index">массив</param>
        /// <returns></returns>
        public int this[int index]
        {
            get { return _a[index]; }
            set { _a[index] = value; }
        }

        public MyArray()
        { 
            
        }

        public MyArray(int[] a)
        {
            this._a = a;
        }

        /// <summary>
        /// Метод заполняет массив случайными числами
        /// </summary>
        public void InputAll()
        {
            Console.WriteLine("Введите количество элементов одномерного массива");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Введите нижнюю границу диапозона");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу диапозона");
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < _a.Length; i++) _a[i] = rnd.Next(min, max);
        }

        /// <summary>
        /// Метод печати массива полностью
        /// </summary>
        public void PrintAllArray()
        {
            for (int i = 0; i < _a.Length; i++) Console.Write("{0} ", _a[i]);
            Console.WriteLine();
        }

        /// <summary>
        /// Метод пперевода элементов массива в положительные числа
        /// </summary>
        /// <param name="a">Ссылка на массив</param>
        public void PositiveNumberArray()
        {
            for (int i = 0; i < _a.Length; i++) if (_a[i] < 0) _a[i] = -_a[i];
        }

        #endregion
    }

}
