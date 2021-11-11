using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    class Program
    {
        static void Main(string[] args)
        {
            byte op;

            do
            {
                Console.WriteLine("1. Calcular la potencia de un número.");
                Console.WriteLine("2. Calcular números primos que existen entre 1 y 100.");
                Console.Write("\nElija una opcion valida: ");
                op = Convert.ToByte(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CalculatePower();
                        op = 0;
                        break;

                    case 2:
                        CalculatePrimes();
                        op = 0;
                        break;

                    default:
                        op = 0;
                        break;
                }

            } while ((op > 0) || (op < 2));
        }

        private static void CalculatePrimes()
        {
            int divider = 0;
            int accountant = 0;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divider++;
                    }
                }

                if (divider <= 2)
                {
                    accountant++;
                }
                divider = 0;
            }

            Console.WriteLine("\nLa cantidad de números primos que hay entre 0 y 100 es: {0}\n", accountant);
        }

        private static void CalculatePower()
        {
            int @base, exponentInicial, exponent;

            Console.Write("\nIngrese la base: ");
            @base = Convert.ToInt32(Console.ReadLine());


            Console.Write("Ingrese el exponente: ");
            exponentInicial = exponent = Convert.ToInt32(Console.ReadLine());

            if (exponentInicial < 0) exponent *= -1;

            double operation = 1;
            for (int i = 1; i <= exponent; i++)
            {
                operation *= @base;
            }

            if (exponentInicial < 0) operation = 1 / operation;

            Console.WriteLine("La potencia {0} del número {1} es igual a {2}\n", exponentInicial, @base, operation);
        }
    }
}
