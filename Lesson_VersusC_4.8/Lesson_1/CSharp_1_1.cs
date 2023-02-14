using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program
    {

        static void Menu()
        {
            bool f = true;
            byte task;
            while (f)
            {
                Console.Clear();
                Console.WriteLine("Меню");
                Console.WriteLine("################################################");
                Console.WriteLine("1 -> Вывод данных различными способами.");
                Console.WriteLine("2 -> Индекс массы тела.");
                Console.WriteLine("3 -> Расстояние между точками.");
                Console.WriteLine("4 -> Обмен значениями переменых.");
                Console.WriteLine("5 -> Вывод сообщения по центру.");
                Console.WriteLine("6 -> Организовать библиотеку помощник.");
                Console.WriteLine("0 -> Выход из программы.");
                Console.WriteLine("################################################");
                Console.WriteLine("");
                Console.Write("Введите номер задачи: ");
                task = byte.Parse(Console.ReadLine());

                switch (task)
                {
                    case 0: f = false; break;
                    case 1: Task_1(); break;
                    case 2: Task_2(); break;
                    case 3: Task_3(); break;
                    case 4: Task_4(); break;
                    case 5: Task_5(); break;
                    case 6: Task_6(); break;
                    default: Console.WriteLine("Некорректный номер задачи, повторите ввод: "); break;
                }
            }
        }

        static void Task_1()
        {
            Console.WriteLine("##################################################################################");
            Console.WriteLine("Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).\n В результате вся информация выводится в одну строчку.\n а) используя склеивание;\n б) используя форматированный вывод;\n в) *используя вывод со знаком $.");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("");

            Console.WriteLine("Введите своё имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию: ");
            var f_name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст: ");
            var are = Console.ReadLine();
            Console.WriteLine("Введите свой рост: ");
            var height = Console.ReadLine();
            Console.WriteLine("Введите свой вес: ");
            var width = Console.ReadLine();
            Console.WriteLine("Имя - " + name + "Фамилия - " + f_name + "Возраст - " + are + "Рост - " + height + "Вес - " + width);
            Console.WriteLine("{1} {0} {2} лет {3} метра {4} киллограмм", name, f_name, are, height, width);
            Console.WriteLine($"{f_name} {name} {are} {height} {width}");
            Console.ReadKey();

        }
        
        static void Task_2() 
        {
            Console.WriteLine("##################################################################################");
            Console.WriteLine("Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);\n где m — масса тела в килограммах, h — рост в метрах.");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("");

            Console.WriteLine("Введите свой вес в киллограммах: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой рост в метрах: ");
            double h = Convert.ToDouble(Console.ReadLine());

            var I = m / (h * h);

            Console.WriteLine($"Индекс массы Вашего тела составляет - {I} единиц");
        }

        static void Task_3() 
        {
            Console.WriteLine("##################################################################################");
            Console.WriteLine("Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле\n r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).\nВывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);\n *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("");

            Console.Write("Введите координаты первой точки по оси х: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты первой точки по оси у: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты второй точки по оси х: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты второй точки по оси у: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double L = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками по введённым координатам составляет {L:F2} единиц.");
        }

        static void Task_4() 
        {
            Console.WriteLine("##################################################################################");
            Console.WriteLine("Написать программу обмена значениями двух переменных.\r\nа) с использованием третьей переменной;\r\nб) *без использования третьей переменной.");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("");

            Console.WriteLine("var - a");
            byte a = 5, b = 3, c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

            Console.WriteLine("var - b");
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
        }

        static void Task_5() 
        {
            Console.WriteLine("##################################################################################");
            Console.WriteLine("а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.\r\nб) Сделать задание, только вывод организуйте в центре экрана\r\nв) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("");

            Console.WriteLine("Реализовано в классе Helper.Print");
        }

        static void Task_6()
        {
            Console.WriteLine("##################################################################################");
            Console.WriteLine("*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).");
            Console.WriteLine("##################################################################################");
            Console.WriteLine("");

            Console.WriteLine("Реализовано в классе Helper");
        }

        static void Main(string[] args)
        {
            Menu();
        }      
    }
}