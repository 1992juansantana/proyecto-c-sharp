using System;
using System.Security.Cryptography.X509Certificates;

namespace Proyecto1
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.WriteLine("ingrese el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.WriteLine($"el resultado es {resultado}");


         }


    }

}


