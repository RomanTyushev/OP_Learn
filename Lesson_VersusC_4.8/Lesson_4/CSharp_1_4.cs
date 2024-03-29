﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4
{
    static class MyArrayTask1
    {
        // 2.Реализуйте задачу 1 в виде статического класса StaticClass;
        // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        // б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        // в)*Добавьте обработку ситуации отсутствия файла на диске.



        public static void Decision()
        {
            int n = 0;
            Helper.MyArray arr = new Helper.MyArray(Helper.MyArray.InputAll());

            Helper.MyArray.PrintAllArray();
            Helper.MyArray.PositiveNumberArray();
            for (byte i = 0; i < arr.Length - 1; i++) if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0)) n++;
            Console.WriteLine("");
            Console.WriteLine($"Всего {n} пар удовлетворяют условиям задачи из представленного выше массива.");
        }
    }

    internal class CSharp_1_4
    {
        static void Print(int n, int[] a)
        // n – размерность массива, а – ссылка на массив
        {
            for (int i = 0; i < n; i++) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static void Change(int n, int[] a)
        {
            for (int i = 0; i < n; i++)
                if (a[i] < 0) a[i] = -a[i];
            // изменяются элементы массива 
        }

        static void Menu()
        {
            bool f = true;
            byte task;
            while (f)
            {
                Console.Clear();
                Console.WriteLine("Меню");
                Console.WriteLine("################################################");
                Console.WriteLine("1 -> Работа с массивами. Задача 1.");
                Console.WriteLine("2 -> Выполнение 1-ой задачи в виде метода.");
                Console.WriteLine("3 -> Доработка задачи № 2.");
                Console.WriteLine("4 -> Доработать задачу логин и пароль.");
                Console.WriteLine("5 -> Организовать библиотеку с классом по работе с массивами.");
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
                    default: Console.WriteLine("Некорректный номер задачи, повторите ввод: "); break;
                } 
            }
        }

        static void Task_1()
        {
            Console.Clear();
            Helper.Print.Header("Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. \nЗаполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. \nВ данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.");
            // 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            // Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
            // В данной задаче под парой подразумевается два подряд идущих элемента массива.
            // Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

            int[] a = new int[20]; //Создаём пустой массив из 20 членов
            byte n = 0; //инициализируем переменную и присваиваем её значений = 0
            Random rnd = new Random(); //создаём новый объект типа случаёного значения
            for (byte i = 0; i < 20; i++) a[i] = rnd.Next(-10000, 10001); //записываем в массив случайные значения в диапзоне от -10000 до 10001
            for (byte i = 0; i < 20; i++) Console.Write("{0} ", a[i]); // выводим содержимое массива на экран
            int[] b = a; // инициализируем новый массив б и присваиваем ему значения массива а
            Console.WriteLine(""); //делаем разрыв между строками
            for (byte i = 0; i < 20; i++) if (b[i] < 0) b[i] = -b[i]; // меня элементы массива с отрицательного значения на положительное
            for (byte i = 0; i < 20; i++) Console.Write("{0} ", b[i]); // выводим значения массива для проверки формулы выше
            for (byte i = 0; i < 19; i++) if ((b[i] % 3 == 0 && b[i + 1] % 3 != 0) || (b[i] % 3 != 0 && b[i + 1] % 3 == 0)) n++; // решение задачи по озвученным выше условиям
            Console.WriteLine(""); // делаем разрыв между строками
            Console.WriteLine($"Всего {n} пар удовлетворяют условиям задачи из представленного выше массива."); //выводим результат

            Console.ReadLine(); // задержка черного экрана
        }

        static void Task_2()
        {
            Console.Clear();
            Helper.Print.Header("Реализовать задачу 1 в виде статического класса StaticClass \n Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1 \n Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел. \n *Добавьте обработку ситуации отсутствия файла на диске");

            // б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
            // в)*Добавьте обработку ситуации отсутствия файла на диске.

            MyArrayTask1.Decision();
            Helper.Pause.PauseBlack();
        }

        static void Task_3()
        {
            // 3.
            // а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
            // б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            // в) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)
            Console.Clear();
            Helper.Print.Center("Pause");
            Console.ReadLine();
        }

        static void Task_4()
        {
            // 4.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.
            Console.Clear();
            Helper.Print.Center("Pause");
            Console.ReadLine();
        }

        static void Task_5()
        {
            // 5.
            // а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
            // *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            // * *в) Обработать возможные исключительные ситуации при работе с файлами.
            Console.Clear();
            Helper.Print.Center("Pause");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Menu();         
        }
    }
}
