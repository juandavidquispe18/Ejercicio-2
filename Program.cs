using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar y deefinir datos
            Console.Write("Ingrese la base: ");
            float base_01 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el exponente: ");
            int potencia = int.Parse(Console.ReadLine());

            double resultado = 1;
            
            //Hallar la potencia
            for (int i = 0; i < potencia; i++) {
                resultado *= base_01;
            }

            //Mostrar resultado
            Console.WriteLine($"La potencia es: {resultado}");
            Console.ReadKey();
        }
    }
}
