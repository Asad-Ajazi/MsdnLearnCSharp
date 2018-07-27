using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerEventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_ElapsedSecond;
            myTimer.Start();
            Console.WriteLine("press enter to remove the red numbered events.");
            Console.ReadLine();
            myTimer.Elapsed -= MyTimer_ElapsedSecond;


            Console.ReadLine();
        }

        private static void MyTimer_ElapsedSecond(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ElapsedSecond: {0:mm:ss:fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elapsed: {0:HH:mm:ss:fff}",e.SignalTime);
                        
        }
    }
}
