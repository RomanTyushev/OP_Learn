using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
    }

    
    
    internal class GB_cSharp_1_4
    {
        static void Main(string[] args)
        {

            //Massive massive = new Massive();
            //massive[1] = 123;

            //Console.WriteLine(massive["world"]);
            //Console.ReadLine();

            #region Sistem.IO

            //string text = File.ReadAllText("D:\\Роман\\test.txt");
            //Console.WriteLine(text);
            //Console.ReadLine();

            //string[] textArr = File.ReadAllLines("D:\\Роман\\test.txt");

            //foreach (var item in textArr) { Console.WriteLine($">>>-{item}-<<<"); }

            //string outText = String.Empty;

            //for (int i = 0; i < 10; i++) 
            //{
            //    outText += $"{Guid.NewGuid().ToString().Substring(10)}";
            //}

            //File.WriteAllText("D:\\Роман\\test.txt", outText);

            //string[] vs = new string[] { "46532","23543","54651","d" };
            //File.WriteAllLines("D:\\Роман\\test.txt", vs);

            //Console.ReadLine();

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
