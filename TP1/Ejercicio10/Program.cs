using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1900; i <= 2015; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i + " es bisiesto");
                }
            }
        }
    }
}
