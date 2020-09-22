using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Debera ingresar cinco (5) cadenas!");
            args = new string [5];
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Ingrese una cadena: ");
                string cad = Console.ReadLine();
                string aux = "";
                foreach(char letra in cad)
                {
                    aux = letra + aux;
                }
                args.SetValue(aux, i);
               }
            for(int m = 0; m <=args.Length-1; m++)
            {
                for (int j = 0; j <= args.Length - 1; j++)
                {
                    if (args[m].Length > args[j].Length)
                    {
                        string ord = args[j];
                        args[j] = args[m];
                        args[m] = ord;
                    }
                }
            }
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
