using System;

namespace _27._10._2021tap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 48;

            int i = 1;
            while (i * i <= num) 
            {
                i++;
            }
            Console.WriteLine("result: " + (i-1));
        }
    }
}
