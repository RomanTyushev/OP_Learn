using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    /// <summary>
    /// Класс для работы с массивами
    /// </summary>
    public class MyArray
    {
        private int[] a;

        public int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }

        public MyArray(int[] a)
        {
            this.a = a;
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
            for (int i = 0; i < a.Length; i++) a[i] = rnd.Next(min, max);            
        }

        /// <summary>
        /// Метод печати массива полностью
        /// </summary>
        public void PrintAllArray()
        {
            for (int i = 0; i < a.Length; i++) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        /// <summary>
        /// Метод пперевода элементов массива в положительные числа
        /// </summary>
        /// <param name="a">Ссылка на массив</param>
        public void PositiveNumberArray()
        {
            for (int i = 0; i < a.Length; i++) if (a[i] < 0) a[i] = -a[i];
        }

        
    }
}
