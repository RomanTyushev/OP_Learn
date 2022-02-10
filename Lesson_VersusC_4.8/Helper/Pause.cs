using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Helper
{
    internal class Pause
    {
        /// <summary>
        /// Задержка экрана
        /// </summary>
        public static void PauseBlack()
        {
            Console.ReadLine();
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
