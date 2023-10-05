using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Lesson_4
{
    class Massive
    {
        //public int[] arr = new int[10];

        //public int this[int index]
        //{ 
        //    get { return index; }
        //    set { arr[index] = value; }
        //}

        //public int this[string word]
        //{
        //    get
        //    { 
        //        switch (word) 
        //        {
        //            case "world": return 1;
        //            case "Bin": return MaxLife();
        //                default: return 0;
        //        }
        //    }
        //}
        //public int Life = 0;


        //public int MaxLife()
        //{
        //    return Life = 35;
        //}

        //Massive massive = new Massive();
        //massive[1] = 123;

        //Console.WriteLine(massive["world"]);
        //Console.ReadLine();
    }


    internal class GB_cSharp_1_4
    {
        static void Main(string[] args)
        {

            // Описание объекта типа массив
            int[] array0;
            // Выделение места под массив
            array0 = new int[5];
            // Объявление одномерного массива из 5 элементов
            int[] array1 = new int[5];
            // Объявление массива и заполнение его элементами
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            // Альтернативный вариант создания заполненного массива
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            //возведение каждого элемента массива в квадрат


//            1.а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива наопределённое число, свойство MaxCount, возвращающее количество максимальных элементов. б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки. 
                //2.Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую
                //Login и Password. Достаточно решить 2 задачи.Старайтесь разбивать программы на подпрограммы.Переписывайте в //начало программы условие и свою фамилию. Все программы сделать в одном решении.


            #region Sistem.IO

            //записываем в строку данные из файла
            //string text = File.ReadAllText("D:\\Роман\\test.txt");
            //Console.WriteLine(text);
            //Console.ReadLine();

            //записываем в массив данные из файла
            //string[] textArr = File.ReadAllLines("D:\\Роман\\test.txt");

            //печатаем на консоли массив из данных фаайла
            //foreach (var item in textArr) { Console.WriteLine($">>>-{item}-<<<"); }

            //заполняем строку случайными элементами
            //string outText = String.Empty;

            //for (int i = 0; i < 10; i++) 
            //{
            //    outText += $"{Guid.NewGuid().ToString().Substring(10)}";
            //}

            //записываем в файл сгенерированную строку
            //File.WriteAllText("D:\\Роман\\test.txt", outText);

            //string[] vs = new string[] { "46532","23543","54651","d" };
            //File.WriteAllLines("D:\\Роман\\test.txt", vs);

            //Console.ReadLine();


            //сособ из методички
            //// Создаем объект sr и связываем его с файлом data.txt.
            //StreamReader sr = new StreamReader("..\\..\\data.txt");
            //// Считаем количество чисел.
            //int n = int.Parse(sr.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    int a = int.Parse(sr.ReadLine());
            //    Console.WriteLine(a);
            //}
            //// Освобождаем файл data.txt для использования другими программами.
            //sr.Close();



            ////Обработка исключений при работе с файлами

            //StreamReader sr = new StreamReader("..\\..\\data.txt");
            //int sum = 0, count = 0;
            //while (!sr.EndOfStream) // Пока не конец потока (файла)
            //{
            //    string s = sr.ReadLine();
            //    Console.WriteLine("Считали строку:" + s);
            //    try
            //    {
            //        int a = int.Parse(s);
            //        sum = sum + a;
            //        count++;
            //        Console.WriteLine("{0}.Преобразовали в число:{1}", count,
            //        a);
            //    }
            //    // В экземпляре exc класса Exception будет храниться информация об ошибке.
            //    catch (Exception exc)
            //    {
            //        Console.WriteLine(exc.Message);
            //    }
            //}
            //sr.Close();
            //Console.WriteLine("Среднее арифметическое:{0:f2}", (double)sum /
            //count);
            //// Обратите внимание! Если не поставить явное преобразование типов перед sum, sum/ count получит целое число.Попробуйте убрать(double) перед sum.
}


        #endregion

        #region try catch

        //try
        //{
        //    Console.WriteLine("Число:   ");
        //    Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Ok");
        //    Console.WriteLine("1");
        //}
        //catch (FormatException) { Console.WriteLine("Неверный формат данных"); }
        //finally { Console.WriteLine("Finally"); }

        #endregion
    }
}
}
