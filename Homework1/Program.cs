using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("STOP");
            System.Threading.Thread.Sleep(1000);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("READY");
            System.Threading.Thread.Sleep(1000);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO");
            System.Threading.Thread.Sleep(1000);



            Console.ReadLine();


        }
    }
}
