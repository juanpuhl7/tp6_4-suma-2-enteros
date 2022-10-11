using System;

namespace tp6_4_suma_2_enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma;

            Console.WriteLine("Ingrese el numero 1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            num2=Convert.ToInt32(Console.ReadLine());
            suma= num1 + num2;
            Console.WriteLine("La suma de: " + num1 + " y " +  num2  + " es: " +suma);
            Console.ReadKey(); 
        }
    }
}
