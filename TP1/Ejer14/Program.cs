using System;
using System.Linq;

namespace Ejer14
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[30];
            for (int i = 0; i <= numeros.Length - 1; i++)
            {
                numeros[i] = new Random().NextDouble();
            }
            double suma = 0;
            foreach (double num in numeros)
            {
                suma += num;
                Console.WriteLine(num);
            }
            double max, min, promedio;
            max = numeros.Max();
            min = numeros.Min();
            promedio = suma / numeros.Length;
            Console.WriteLine("suma= " + suma);
            Console.WriteLine("promedio= " + promedio);
            Console.WriteLine("Máximo= " + max);
            Console.WriteLine("Mínimo= " + min);
        }
    }
}
