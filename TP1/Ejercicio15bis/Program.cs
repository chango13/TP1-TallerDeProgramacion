using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio15bis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[50];
            for (int i = 0; i <= numeros.Length - 1; i++)
            {
                numeros[i] = new Random().Next(0,1000);
            }
       
            for (int m = 0; m <= numeros.Length - 1; m++)
            {
               
              for (int k=0; k<=numeros.Length-1;k++ )
                {
                    if (numeros[m] < numeros[k])
                    {
                        int ord = numeros[k];
                        numeros[k] = numeros[m];
                        numeros[m] = ord;
                    }
                }
            }
            foreach (int n in numeros)
            {
                Console.Write(" " + n + " ");
            }
            Console.WriteLine("Ingrese dos valores para ordenar el arreglo");
            Console.WriteLine("primer valor: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            int max = int.Parse(Console.ReadLine());
            if (min > max)
            {
                int aux = min;
                min = max;
                max = min;
            }
            List<int> listaNum= new List<int>();
            for (int j = 0; j <= numeros.Length - 1; j++)
            {
                    if (min<=numeros[j] && max>=numeros[j])
                    {
                    listaNum.Add(numeros[j]);
                }
                
            }
            int[] numFinal = listaNum.ToArray();
            foreach (int item in numFinal)
            {
                Console.WriteLine("valores entre los parámetros: " + item);
            }
        }
    }
}
