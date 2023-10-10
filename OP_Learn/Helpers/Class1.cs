using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public void MyArray()
        { 
            
        }

        public void MyArray(int[] a)
        {
            this._a = a;
        }

        /// <summary>
        /// Метод заполняет массив случайными числами
        /// </summary>
        public static void InputAll()
        {
            Console.WriteLine("Введите количество элементов одномерного массива");
            int size = int.Parse(Console.ReadLine());
            int[] _a = new int[size];
            Console.WriteLine("Введите нижнюю границу диапазона");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу диапазона");
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < _a.Length; i++) _a[i] = rnd.Next(min, max);
        }

        /// <summary>
        /// Метод заполняет массив случайными числами. Задаётся границы массива
        /// </summary>
        /// <param name="a">массив</param>
        /// <param name="min">нижняя граница диапазона</param>
        /// <param name="max">верхняя граница диапазона</param>
        public static void InputAll(int[] _a, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < _a.Length; i++) _a[i] = rnd.Next(min, max);
        }

        /// <summary>
        /// Возведение элементов массива в квадрат
        /// </summary>
        public static void SquaringMassive(int[] _a)
        {
            for (int i = 0; i < _a.Length; i++) _a[i] *= _a[i];
            Console.WriteLine();
        }

        /// <summary>
        /// Метод печати массива полностью
        /// </summary>
        public static void PrintAllArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        /// <summary>
        /// Метод пперевода элементов массива в положительные числа
        /// </summary>
        /// <param name="a">Ссылка на массив</param>
        public static void PositiveReversArray(int[] _a)
        {
            for (int i = 0; i < _a.Length; i++) if (_a[i] < 0) _a[i] = -_a[i];
        }

        /// <summary>
        /// Метод возврата максимального значения массива
        /// </summary>
        /// <returns>максимальное значение</returns>
        public static int MaxElementMassive(int[] _a)
        {
            int max = _a[0];
            for (int i = 1; i < _a.Length; i++) if (max < _a[i]) max = _a[i];
            Console.WriteLine(max);
            return max;            
        }

        /// <summary>
        /// Метод возврата минимального значения массива
        /// </summary>
        /// <returns>минимальное значение</returns>
        public static int MinElementMassive(int[] _a)
        {
            int min = _a[0];
            for (int i = 1; i < _a.Length; i++) if (min < _a[i]) min = _a[i];
            Console.WriteLine(min);
            return min;
        }

        /// <summary>
        /// Метод создающий масив определенного размера от начального занчения с заданным шагом
        /// </summary>
        /// <param name="lounch">Размер массива</param>
        /// <param name="start">Начальное значение массива</param>
        /// <param name="step">шаг заполнения массива</param>
        public static void InputMassive(int[]_a, int lounch, int start, int step)
        {
            _a[0] = start;
            for (int i = 1; i < lounch; i++) _a[i] = _a[i-1] + step;
        }

        /// <summary>
        /// Метод возврата суммы массива
        /// </summary>
        /// <param name="_a">массив</param>
        /// <returns></returns>
        public static int SumElementMassive(int[] _a)
        {
            int sum = 0;
            for (int i = 0; i < _a.Length; i++) sum += _a[i] ;
            Console.WriteLine(sum);
            return sum;
        }

        public static void InverseMassive(int[] _a) 
        {
            int[] res = _a;
            for (int i = 0; i < res.Length; i++) res[i] = -res[i];
            for (int i = 0; i < res.Length; i++) Console.Write("{0} ", res[i]);
            Console.WriteLine();
        }

        //            метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений)
        //            метод Multi, умножающий каждый элемент массива наопределённое число
        //            свойство MaxCount, возвращающее количество максимальных элементов.
        //            **Создать библиотеку содержащую класс для работы с массивом.
        //            Продемонстрировать работу библиотеки.
        //            2.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
        //            Создайте структуру Account, содержащую Login и Password.
        //            Переписывайте в начало программы условие и свою фамилию. Все программы сделать в одном решении.

        #endregion
    }

}
