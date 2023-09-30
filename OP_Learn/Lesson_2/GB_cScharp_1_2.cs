using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class GB_cScharp_1_2
    {
        /// <summary>
        /// Цикличное меню
        /// </summary>
        static void Menu()
        {
            bool f = true;
            byte task;
            while (f)
            {
                Console.WriteLine("Меню");
                Console.WriteLine("################################################");
                Console.WriteLine("1 -> Написать метод, возвращающий минимальное из трёх чисел.");
                Console.WriteLine("2 -> Написать метод подсчета количества цифр числа.");
                Console.WriteLine("3 -> С клавиатуры вводятся числа, пока не будет введен 0. \n Подсчитать сумму всех нечетных положительных чисел.");
                Console.WriteLine("4 -> Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.\nС помощью цикла do while ограничить ввод пароля тремя попытками.");
                Console.WriteLine("5 -> а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норм \n б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.");
                Console.WriteLine("6 -> Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать подсчёт времени выполнения программы, используя структуру DateTime.");
                Console.WriteLine("7 -> // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).\n *Разработать рекурсивный метод, который считает сумму чисел от a до b.");
                Console.WriteLine("0 -> Выйти из программы");
                Console.WriteLine("#############################");
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
                    case 7: Task_7(); break;
                    default: Console.WriteLine("Введите корректно номер задачи."); break;
                }
            }
        }

        /// <summary>
        /// Mетод возвращающий минимальное из трёх чисел
        /// </summary>
        static void Task_1()
        {
            Console.WriteLine("#######################################################");
            Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел.");
            Console.WriteLine("#######################################################");
            int a, b, c;
            Console.Write("Введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine($"Минимальное число - {a}.");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"Минимальное число - {b}.");
            }
            else if (c < b && c < a)
            {
                Console.WriteLine($"Минимальное число - {c}.");
            }
            else Console.WriteLine("Значения равны.");
           
            // Второй вариант записи решения:
            // int min = a < b && a < c ? a : b < a && b < c ? b : c < b && c < a ? c : 0;
            // Console.WriteLine(min);

            Helper.Pause();
        }

        /// <summary>
        /// Метод подсчёта количества цифр в числе
        /// </summary>
        /// 
        static void Task_2()
        {
            Console.WriteLine("##############################################");
            Console.WriteLine("Hаписать метод подсчета количества цифр числа.");
            Console.WriteLine("##############################################");

            Console.Write("Введите целое число: ");
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                a = a / 10;
                i++;                
            }
            while (a > 10);
            Console.WriteLine($"В ведённом вами числе - {i} чисел");
            Console.ReadKey();
        }
                
        static void Task_3()
        {
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введен 0. /n Подсчитать сумму всех нечетных положительных чисел.");
            // С клавиатуры вводятся числа, пока не будет введен 0.
            // Подсчитать сумму всех нечетных положительных чисел.
            int number = 1;
            int sum = 0;
            while (number != 0)
            {
                Console.Write("Введите любое число кроме 0: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 != 0 && number > 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine($"Сумма всех нечётных положительных чисел = {sum}.");
            Console.ReadKey();
        }

        static void Task_4()
        {
            //Реализовать метод проверки логина и пароля.
            //На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел
            //(Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу:
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
            // 

            string login = "root";
            string password = "GeekBrains";

            string log, pass;
            sbyte i = 3;

            while (i != 0)
            {
                Console.Write("Введите логин: ");
                log = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pass = Console.ReadLine();
                if (log == login && pass == password)
                {
                    Console.WriteLine("######################");
                    Console.WriteLine($"Хорошего дня, {login}");
                    break;
                }
                else if (log != login && pass == password)
                {
                    Console.WriteLine("######################");
                    Console.WriteLine("!!! Вы ввели не правильный логин !!!");
                }
                else if (log == login && pass != password)
                {
                    Console.WriteLine("######################");
                    Console.WriteLine("!!! Вы ввели не правильный пароль !!!");
                }
                else Console.WriteLine("Не работает? Может ну его? Ну правда ...");
                Console.WriteLine("######################");
                i--;
                Console.WriteLine($"У вас осталось {i} попыток ввода :))");
                Console.WriteLine("######################");
            }

            Helper.Pause();
        }
                        
        static void Task_5()
        {
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
            // нужно ли человеку похудеть, набрать вес или всё в норме.
            double mass, height, BMI, massMinNorm, massMaxNorm;
            Console.Write("Введите ваш вес в киллограммах: ");
            mass = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш рост в метрах: ");
            height = double.Parse(Console.ReadLine());
            BMI = mass / (height * height);
            massMinNorm = 18.5 * height * height;
            massMaxNorm = 25 * height * height;
            Console.WriteLine($"{massMinNorm} {massMaxNorm} {BMI}");
            
            if (BMI <= 16)
            {
                Console.WriteLine($"У Вас выраженный дефицит массы тела. Вам необхоимо набрать {massMinNorm - mass} кг.");
            }
            else if (BMI > 16 && BMI <= 18.5)
            {
                Console.WriteLine($"У Вас дефицит массы тела. Вам необхоимо набрать {massMinNorm - mass} кг.");
            }
            else if (BMI > 18.5 && BMI <= 25)
            {
                Console.WriteLine("У вас нормальный вес.");
            }
            else if (BMI > 25 && BMI <= 30)
            {
                Console.WriteLine($"У Вас избыточная масса тела. Необходимо похудеть на {mass - massMaxNorm} кг.");
            }
            else if (BMI > 30 && BMI <= 35)
            {
                Console.WriteLine($"У Вас ожирение 1 степени. Необходимо похудеть на {mass - massMaxNorm} кг.");
            }
            else if (BMI > 35 && BMI <= 40)
            {
                Console.WriteLine($"У Вас ожирение 2 степени. Необходимо похудеть на {mass - massMaxNorm} кг.");
            }
            else if (BMI > 40)
            {
                Console.WriteLine($"У Вас ожирение 3 степени. Необходимо похудеть на {mass - massMaxNorm} кг.");
            }
            else Console.WriteLine("Результат отсутствует. Проверьте правильность введенных данных.");


            // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            Console.ReadKey();

        }

        static void Task_6()
        {
            // Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
            // «Хорошим» называется число, которое делится на сумму своих цифр.
            // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            Console.WriteLine("#################################################################");
            Console.WriteLine("Эта программа подсчитывает 'хорошие' числа в указанном диапазоне.");
            Console.WriteLine("#################################################################");
            Console.WriteLine("");
            Console.Write("Введите нижнее число диапозона: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Введите верхнее число диапозона: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Производится подсчёт, ждите ...");
            DateTime start = DateTime.Now;
            int counter = 0;
            int sum = 0;

            for (int a = min; a <= max; a++)
            {
                if (a % GetSum(a) == 0)
                {
                    counter++;
                    sum += a;
                }
            }

            DateTime finish = DateTime.Now;

            Console.WriteLine($"Количество 'хороших' чисел в диапазоне от {min} до {max} = {counter}, общая сумма = {sum}");
            Console.WriteLine($"Время работы программы заняло {finish - start}");

            Console.ReadKey();
        }

        static int GetSum(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static void Task_7()
        {
            // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Console.WriteLine(RecursiveSum(13));
            
        }

        static long RecursiveSum(long a)
        {
            if (a == 0)
                return 0;
            else return RecursiveSum(a / 10) + a % 10;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("################################################################");
            Console.WriteLine("Домашняя задание студента Тюшева Романа Леонидовича по уроку № 2");
            Console.WriteLine("################################################################");

            Menu();                                    
        }
    }
}
