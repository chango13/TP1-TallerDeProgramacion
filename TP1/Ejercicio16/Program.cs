using System;
using System.Collections.Generic;
using System.Threading;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese primer cadena a comparar: ");
            string cadenaUno = Console.ReadLine();
            Console.WriteLine("ingrese segunda cadena a comparar: ");
            string cadenaDos = Console.ReadLine();
            int cant = 0;
            if (cadenaUno.Length == cadenaDos.Length)
            {
                    foreach(char letra in cadenaDos)
                    {
                        if (cadenaUno.Contains(letra))
                        {
                        cant += 1;
                        }
                    }
               }
            if(cant==cadenaUno.Length && cant == cadenaDos.Length)
            {
                Console.WriteLine("son anagramas!");
            }
            else
            {
                Console.WriteLine("no son anagramas");
            }
        }
    }
}
