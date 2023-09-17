using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de notas: ");
            int cant = int.Parse(Console.ReadLine());
            int promedio = 0;
            for (int i = 1; i <= cant; i++)
            {
                Console.Write("Ingrese la nota "+ i + ": ");
                int nota = int.Parse(Console.ReadLine());
                promedio = nota + promedio;
            }
            Console.WriteLine();
            Console.Write("El promedio de las notas es: " + (promedio/cant));
            Console.ReadKey();
        }
    }
}
