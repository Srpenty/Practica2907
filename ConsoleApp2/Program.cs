using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdusca un numero: ");
            int num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Introdusca otro numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("la suma de los numeros es: "+ (num1 + num2));
            Console.WriteLine("la resta de los numeros es: " + (num1 - num2));
            Console.WriteLine("la multiplicacion de los numeros es: " + (num1 * num2));
            Console.WriteLine("la divicion de los numeros es: " + (num1 / num2));
        }
    }
}
