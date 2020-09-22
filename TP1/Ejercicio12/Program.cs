using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FACTORIAL!");
            Console.WriteLine("Ingrese número a calcular: ");
            int fact = int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 2; i <= fact; i++)
            {
                res *= i;
            }
            Console.WriteLine("Resultado= " + res);
        }
    }
}
