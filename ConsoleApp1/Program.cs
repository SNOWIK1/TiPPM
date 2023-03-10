using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[100];
            int i;
            Random r = new Random(5);
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine(r.Next(0,100));
            }
                
            Console.ReadLine();

            if (0 < M[i]) Console.WriteLine("Числа больше нуля");
            else Console.WriteLine("Число меньше или равно нулю");

            if (M[i] < 125) Console.WriteLine("Но меньше 125");
            else Console.WriteLine("Число больше или равно 125");
            Console.ReadLine();

            
        }
    }
}
