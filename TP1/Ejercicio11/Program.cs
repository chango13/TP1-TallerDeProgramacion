using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese medida: ");
            decimal radio=decimal.Parse(Console.ReadLine());
            Console.WriteLine("Radio= " + radio);
            decimal radioCuadrado = radio * radio;
            decimal area = (decimal)Math.PI * radioCuadrado;
            Console.WriteLine("Area= " + area);
            decimal diametro = radio * 2;
            decimal perimetro = (decimal)Math.PI*diametro;
            Console.WriteLine("Perímetro= " + perimetro);
        }
    }
}
