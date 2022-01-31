using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {

    static void Main(string[] args)
        {
            #region Урок 1 задание 1
            /*// Написать программу «Анкета».
            // Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            // В результате вся информация выводится в одну строчку:
            // а) используя склеивание;

            string name, femaly, are, height, mass;
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            femaly = Console.ReadLine();
            Console.Write("Введите возраст: ");
            are = Console.ReadLine();
            Console.Write("Введите рост: ");
            height = Console.ReadLine();
            Console.Write("Введите вес: ");
            mass = Console.ReadLine();

            Console.WriteLine(name + " " + femaly + ", " + are + " лет, " + height + " см, " + mass + " кг.");
            Helper.Pause();

            //б) используя форматированный вывод;

            Console.WriteLine($" {name:G} {femaly:G7}, {are:G} лет, {height:G} см, {mass:G} кг.");
            Helper.Pause();

            //в) используя вывод со знаком $.

            Console.WriteLine($"{name} {femaly}, {are} лет, {height} см, {mass} кг.");
            Helper.Pause();
            */
            #endregion

            #region Урок 1 задание 2
            /*
            //Ввести вес и рост человека.

            int mass, height, I;
            Console.Write("Введите ваш вес в киллограммах: ");
            mass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Ваш рост в метрах: ");
            height = Convert.ToInt32(Console.ReadLine());

            //Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);

            I = mass / (height * height);
            Console.WriteLine($"Индекс массы Вашего тела равен {I}");

            Helper.Pause();

            //где m — масса тела в килограммах, h — рост в метрах.
            */
            #endregion

            #region Урок 1 задание 3

            // а) Написать программу, которая подсчитывает расстояние между точками
            // с координатами x1, y1 и x2,y2 по формуле
            // r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            // Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            /*
            Console.Write("Введите координаты первой точки по оси х: ");
            string x1Uzer = Console.ReadLine();
            int x1 = Convert.ToInt32(x1Uzer);
            Console.Write("Введите координаты первой точки по оси у: ");
            string y1Uzer = Console.ReadLine();
            int y1 = Convert.ToInt32(y1Uzer);
            Console.Write("Введите координаты второй точки по оси х: ");
            string x2Uzer = Console.ReadLine();
            int x2 = Convert.ToInt32(x2Uzer);
            Console.Write("Введите координаты второй точки по оси у: ");
            string y2Uzer = Console.ReadLine();
            int y2 = Convert.ToInt32(y2Uzer);
            double L = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками по введённым координатам составляет {L:F2} единиц.");
            Helper.Pause();
            */
            /*б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/



            #endregion

            #region Урок 1 задание 4
            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;

            /*static void Main()
        {
            byte a = 5, b = 3, c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }*/

            // б) *без использования третьей переменной.

            /*
            int a, b;
            Console.WriteLine("Введите а : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  b : ");
            b = Convert.ToInt32(Console.ReadLine());
            a = b - a;
            b = b - a;
            a = a + b;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.ReadKey();
       */
            #endregion

            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // б) *Сделать задание, только вывод организовать в центре экрана.
            // в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            // *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
            // *Сделано класс Helper


        }
    }
}
