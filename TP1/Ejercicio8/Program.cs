using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 0;
            long num2 = 1;
            long calculo = 0;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 1; i <= 50; i++)
            {
                calculo = num2 + num1;
                num1 = num2;
                num2 = calculo;
                Console.WriteLine(calculo);
            }
        }
    }
}
