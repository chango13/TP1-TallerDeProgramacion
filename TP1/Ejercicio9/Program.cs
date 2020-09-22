using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int primos = 0;
            int cant = 0;
            for (int i = 35; i <= 1977; i++)
            {
                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0 || i % 9 == 0) { 

                }else {
                    primos += i;
                    Console.WriteLine(i + " ES PRIMO!");
                    cant += 1;
                }
            }
            Console.WriteLine("total: " + primos);
            Console.WriteLine("Son " + cant + " números primos");
        }
    }
}
