using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3.1
{
    /// <summary>
    /// Класс для работы с дробятми
    /// </summary>
    class Fraction
    {

        /// <summary>
        /// Числитель (рациональное число)
        /// </summary>
        private int _numerator;

        /// <summary>
        /// Знаменатель (натуральное число)
        /// </summary>
        private int _denominator;

        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator
        {
            get { return _numerator; }
            set { value = _numerator; }
        }

        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                value = _denominator;
            }
        }

        /// <summary>
        /// Получить десятичную дробь
        /// </summary>
        public double GetFraction
        {
            get { return (double)_numerator / _denominator; }
        }

        /// <summary>
        /// Инициализация дроби
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        public Fraction(int numerator, int denominator)
        {
            if (denominator <= 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");
            _numerator = numerator;
            _denominator = denominator;
            // Автоматическая нормализация дроби (при необходимости)
            Nod();
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="f">Дробь</param>
        /// <returns>Результат сложения дробей</returns>
        public Fraction Plus(Fraction f)
        {
            var den = _denominator * f.Denominator;
            var num = _numerator * f.Denominator + f.Numerator * Denominator;
            return new Fraction(num, den);
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="f">Дробь</param>
        /// <returns>Результат вычитания дробей</returns>
        public Fraction Minus(Fraction f)
        {
            var den = _denominator * f.Denominator;
            var num = _numerator * f.Denominator - f.Numerator * Denominator;
            return new Fraction(num, den);
        }

        /// <summary>
        /// Произведение дробей
        /// </summary>
        /// <param name="f">Дробь</param>
        /// <returns>Результат произведения дробей</returns>
        public Fraction Multi(Fraction f)
        {
            var den = _denominator * f.Denominator;
            var num = _numerator * f.Numerator;
            return new Fraction(num, den);
        }

        /// <summary>
        /// Нормальизация дроби
        /// </summary>
        private void Nod()
        {
            // Пусть мы решили упростить дробь -4/6

            var num = Math.Abs(_numerator); // Создаем вспомогательную переменную, модуль числителя (4)
            var den = Math.Abs(_denominator); // Создаем вспомогательную переменную, модуль знаменателя (6)
            int temp; // Вспомогательная переменная

            while (num != 0 && den != 0) // Цикл, до тех пор, пока обе вспомогательные переменные не равны нулю
            {
                if (num % den > 0) // Если остаток от деления числителя на знаменатель больше нуля ( т е остаток присутствует)
                {
                    // При первой итерации: 4 % 6 = 4

                    temp = num; // Вспомогательная переменная теперь хранит значение числителя (4)
                    num = den; // Переменная числителя сохраняет значение знаменателя
                    den = temp % den; // Знаменатель теперь хранит тот самый остаток от деления числителя на занаменатель 4 % 6 = 4, теперь тут лежит 4
                }
                else
                    break;
                // При повторой итерации цикла, у нас выполняется выражение 6 % 4 = 2
                // Теперь в переменной temp хранится 6, в перменной num хранится 4, в переменной den = 6 % 4 = 2

                // Третья итерация цикла 4 % 2 = 0 и вот тут мы понимаем, что 4 делится на 2 без остатка, следовательно цикл while завершает свою работу, 
                // мы выходим через break;

            }


            // Что мы получаем? теперь мы берем начальные значения числителя и знаменателя и делим их на последнее значение переменной den (которое равно 2)
            if (num != 0 && den != 0)
            {
                _numerator = _numerator / den; // -4/2 = -2
                _denominator = _denominator / den; // 6/2 = 3
            }
            // Итого, у нас была дробь -4/6, стала -2/3, что и требовалось получить, мы сократили дробь на 2
        }

        public override string ToString()
        {
            Nod();
            return $"{_numerator}/{_denominator}";
        }
    }

    /// <summary>
    /// Класс по работе с комплексными числами
    /// </summary>
    class Complex
    {
        double im; // приватное поле мнимой части комплексного числа
        double re; // приватное поле действительной части комплексного числа

        /// <summary>
        /// Конструктор комплесного числа без параметров
        /// </summary>
        public Complex()
        {
            im = 0;
            re = 0;
        }

        /// <summary>
        /// Конструктор задания полей комплексного числа
        /// </summary>
        /// <param name="_im">Мнимая часть</param>
        /// <param name="re">Деятвительная часть</param>
        public Complex(double _im, double re)
        {
            im = _im;
            this.re = re; // к полю нашего класса присваиваем параметр, используя ключевое слово this
        }

        /// <summary>
        /// Метод сложения комплексных чисел
        /// </summary>
        /// <param name="x2">Второе комплексное число</param>
        /// <returns></returns>
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        /// <summary>
        /// Метод вычитания комплексных чисел
        /// </summary>
        /// <param name="x2">Второе комплексное число</param>
        /// <returns></returns>
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - im;
            x3.re = x2.re - re;
            return x3;
        }

        /// <summary>
        /// Метод перемножения комплексных чисел
        /// </summary>
        /// <param name="x2">Второе комплексное число</param>
        /// <returns></returns>
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.re * im + x2.im * im + im * re;
            x3.re = x2.re * re;
            return x3;
        }

        /// <summary>
        /// Поле чтения и изменения мнимой части комплексного числа
        /// </summary>
        public double Im
        {
            get { return im; } // метод чтения
            set // метод перезаписи мнимой части комплексного числа
            {
                if (value >= 0) im = value;
            }
        }

        /// <summary>
        /// Метод вывода комплексного числа
        /// </summary>
        /// <returns>Комплексное число</returns>
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    internal class CSharp_1_3
    {
        static void Menu()
        {
            bool f = true;
            byte task;
            while (f)
            {
                Console.WriteLine("Меню");
                Console.WriteLine("################################################");
                Console.WriteLine("1 -> Работа с комплексными числами");
                Console.WriteLine("2 -> Работа с числами");
                Console.WriteLine("3 -> Работа с дробями");
                Console.WriteLine("0 -> Выход из программы");
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
                }
            }
        }

        /// <summary>
        /// Задача по работе с комплексными числами
        /// </summary>
        public static void Task_1()
        {
            Complex complex1 = new Complex(1, 1); // создаём новый объект комплексное число
            Complex complex2 = new Complex(2, 2); // создаём новый объект комплексное число
            complex2.Im = 3; // меняем приватное поле im
            Complex result = complex1.Plus(complex2); // вызывам метод сложения двух комплексных чисел
            Console.WriteLine(result.ToString()); // выводим результат методом ToString()
            result = complex1.Minus(complex2); // вызываем метод вычитания комплексных чисел
            Console.WriteLine(result.ToString()); // выводим результат методом ToString()
            result = complex1.Multi(complex2); // Вызываем метод умножения комплексных чисел
            Console.WriteLine(result.ToString()); // выводим результат методом ToString()
            Console.ReadLine(); // Ожидание нажатие клавиши Enter
        }
        
        /// <summary>
        /// Работа с числами
        /// </summary>
        public static void Task_2()
        {
            Console.Clear();

            Helper.Print.Header("Работа с числами");
            Console.WriteLine("Вводите числа (0 - завершение работы приложения): ");
            int number, sum = 0;

            do
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    sum += Sum(number);
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное число, повторите ввод.");
                    number = -1;
                }
            } while (number != 0);

            Console.WriteLine($"Сумма всех положительных, нечётных чисел = {sum}");
            Console.ReadLine();
        }

        /// <summary>
        /// Работа с дробями
        /// </summary>
        public static void Task_3()
        {
            
        }

        /// <summary>
        /// Метод проверки числа.
        /// Число должно быть положительное и нечётное
        /// </summary>
        /// <param name="x">Число для проверки</param>
        /// <returns>Результат проверки числа</returns>
        static int Sum(int x)
        {
            return (x > 0 && x % 2 != 0) ? x : 0;
        }

        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu();            
        }
    }
}
