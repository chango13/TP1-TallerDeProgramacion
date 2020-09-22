using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer valor (límite inferior): ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor (límite superior): ");
            int max = int.Parse(Console.ReadLine());
            float suma = min + max;
            float promedio = suma / 2;
            Console.WriteLine("Promedio: " + promedio);
            int total = min;
            while (min <= max)
            {
                Console.WriteLine(total);
                min++;
                total += min;
                
            }
        }
    }
}
