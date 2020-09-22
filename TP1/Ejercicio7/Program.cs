using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor límite: ");
            int limite = int.Parse(Console.ReadLine());
            double calc=1;
            double den = 0;
            for (int i = 1; i <= limite; i++)
            {
                den = i * 2 + 1;
                if (i % 2 == 0)
                {
                    calc += (1 / den);
                }
                else
                {
                    calc -= (1/den);
                }
            }
            calc *= 4;
            double aux = ((Math.PI * 100) / calc);
            Console.WriteLine("aproximación: " + aux);
        }
    }
}
