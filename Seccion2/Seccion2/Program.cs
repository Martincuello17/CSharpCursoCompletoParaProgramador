using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal celsius, fahrenheit;

            Console.WriteLine("Calculador de °C a °F");
            Console.Write("Ingrese los Grados celsius: ");

            celsius = Convert.ToDecimal(Console.ReadLine());

            fahrenheit = (celsius * (9 / 5)) + 32;

            Console.WriteLine("La formula es: ({0} °C × 9/5) + 32", celsius);

            Console.WriteLine("{0} °C son {1} °F", celsius, fahrenheit);

        }
    }
}
