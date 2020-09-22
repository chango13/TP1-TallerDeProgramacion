using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for(int valor = 1; valor<=100; valor++)
            {
                if(valor == 1 || valor % 2 == 1)
                {
                    suma += valor;
                    Console.Write(suma+", ");
                }
            }
            Console.WriteLine("Promedio: " + suma / 2);
        }
    }
}
