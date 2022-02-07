using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class GB_cSharp_1_3
    {
        /// <summary>
        /// Комплексное число
        /// </summary>
        class ComplexClass
        {
            /// <summary>
            /// Мнимая часть комплексного числа
            /// </summary>
            double im;

            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            double re;

            /// <summary>
            /// Свойство перезаписи действительного числа
            /// </summary>
            public double Re
            {
                get
                {
                    return re;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new Exception("На ноль делить нелья!");
                    }
                    re = value;
                }
            }

            public double Im
            {
                get
                {
                    return im;
                }
                set
                {
                    im = value;
                }
            }


            public ComplexClass()
            {

            }

            /// <summary>
            /// Изменение приватных мнимого и действительного числа
            /// </summary>
            /// <param name="re">новое действительное число</param>
            /// <param name="im">новре мнимое число</param>
            public ComplexClass(double re, double im)
            {
                if (re == 0)
                {
                    throw new Exception("На ноль делить нелья!");
                }

                this.re = re;
                this.im = im;
            }

            /// <summary>
            /// Сложение комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public ComplexClass Plus(ComplexClass x)
            {
                return new ComplexClass(re + x.re, im + x.im);
            }

            /// <summary>
            /// Методы вычитания комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public ComplexClass Sabtraction(ComplexClass x)
            {
                return new ComplexClass(re - x.re, im - x.im);   
            }

            /// <summary>
            /// Метод умножения комплексных чисел
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public ComplexClass Multiplication(ComplexClass x)
            {
                Re = re * x.re + im * x.re;
                Im = im * x.re + im * x.im;
                return new ComplexClass(Re, Im);
            }

            public override string ToString()
            {
                return $"{re} + {im}i";
            }
        }


        static void Main(string[] args)
        {
            ComplexClass complex01 = new ComplexClass(5, 3);
            //complex01.Re = 0;

            Console.WriteLine(complex01.Re);

            // complex01.re = 0;
            //complex01.im = 5;

            ComplexClass complex02 = new ComplexClass(3, -1);

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");


            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
            Console.WriteLine($"Разница комплексных чисел {complex01} и {complex02} = {complex01.Sabtraction(complex02)}");
            Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} = {complex01.Multiplication(complex02)}");

            Console.ReadLine();
        }

    }
}
