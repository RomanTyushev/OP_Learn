using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("##################################################################################");
            Console.WriteLine("Эта программа подсчитывает количество и сумму /хороших/ чисел в заданном диапазоне");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("");

            Console.Write("Введите нижний параметр диапазона: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Введите верхний параметр диапазона: ");
            int max = int.Parse(Console.ReadLine());
            int minBeggin = min;

            Console.WriteLine("Программа выполняется, ждите ...");

            DateTime start = DateTime.Now;
            var counter = 0;
            var sum = 0;
            for (min = min; min <= max; min++)
            {
                if (min % GetSum(min) == 0)
                {
                    counter++;
                    sum += min;
                }
            }
            DateTime finish = DateTime.Now;

            Console.WriteLine($"Диапазон от {minBeggin} до {max} содержит {counter} /хороших/ чисел, сумма чисел = {sum}. Время выполнения программы = {finish - start}");
            Console.ReadLine();
        }

        public static int GetSum(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
