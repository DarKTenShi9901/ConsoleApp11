using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>()
            {
                "Ana", "Felipe", "Juan"
            };
            Console.WriteLine($"Cantidad de nombres: {nombres.Count}");

            nombres.Add("María");

            nombres.Insert(1, "Pedro");

            nombres.Remove("Juan");

            Console.WriteLine("\nLista de nombres:");
            foreach (var nombre in nombres) 
            {
                Console.WriteLine($"- {nombre}");
            }

            bool estaAnaEnLaLista = nombres.Contains("Ana");
            Console.WriteLine($"\nAna está en la lista? {estaAnaEnLaLista}");

            nombres= nombres.OrderBy (nombre => nombre.Length).ToList();

            Console.WriteLine("\nLista ordenada por longitud:");
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"- {nombre}");
            }
            Console.WriteLine("\nLista en mayúsculas:");
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"- {nombre.ToUpper()}");
            }

        }
    }
}
