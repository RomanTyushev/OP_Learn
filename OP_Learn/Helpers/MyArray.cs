using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Helpers
{
    public class MyArray
    {
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

        public MyArray(int n)
        { 
            _a = new int[n];
        }

        public MyArray(int[] a)
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

        //Надо доделать
        /// <summary>
        /// Метод возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений)
        /// </summary>
        /// <param name="_a">массив</param>
        /// <returns></returns>
        public static int InverseMassive(int[] _a) //надо доделать, изменяет первый массив
        {
            int[] res = _a;
            for (int i = 0; i < res.Length; i++) res[i] = -res[i];
            for (int i = 0; i < res.Length; i++) Console.Write("{0} ", res[i]);
            Console.WriteLine();
            return res[0];
        }

        /// <summary>
        /// Метод умножающий каждый элемент массива на определённое число
        /// </summary>
        /// <param name="_a">массив</param>
        /// <param name="m">множитель</param>
        /// <returns></returns>
        public static int Multi(int[] _a, int m)
        {
            for (int i = 0; i < _a.Length; i++) _a[i] *= m;
            return _a[0];
        }

        //Надо доделать
        /// <summary>
        /// Cвойство, возвращающее количество максимальных элементов
        /// </summary>
        //public static int MaxCount(int[] _a)
        //{
        //    int sum = 0;
        //    Array.Sort(_a);
        //    for (int i = _a.Length; i > 0; i--)
        //    {
        //        if (_a[i] == _a.Last())
        //        {
        //            sum += 1;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //    return sum;
        //}
    }

}
