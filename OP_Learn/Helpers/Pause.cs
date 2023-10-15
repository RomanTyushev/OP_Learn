using System;
using System.Threading;

namespace Helpers
{
    public class Pause
    {

        /// <summary>
        /// Задержка темного экрана
        /// </summary>

        public static void PauseProgramm()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        /// <param name="interval">миллисекунд (1000 мс = 1 с)</param>
        public static void Sleep(int interval)
        {
            Thread.Sleep(interval);
        }
    }
}