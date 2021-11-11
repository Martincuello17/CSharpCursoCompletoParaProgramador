using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskFive
{
    class Program
    {
        static void Main(string[] args)
        {
            byte op;

            do
            {
                Console.WriteLine("\n1. Transformar de grados a radianes.");
                Console.WriteLine("2. Calcular el area de una figura.");
                Console.Write("\nElija una opcion valida: ");
                op = Convert.ToByte(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        TransformDegreesToRadians();
                        op = 0;
                        break;

                    case 2:
                        CalculateAreaFigure();
                        op = 0;
                        break;

                    default:
                        op = 0;
                        break;
                }

            } while ((op > 0) || (op < 2));
        }

        private static void CalculateAreaFigure()
        {
            byte op;
            do
            {
                Console.WriteLine("\n1. Area de un Circulo.");
                Console.WriteLine("2. Area de un Cuadrado");
                Console.WriteLine("3. Area de un Triangulo");
                Console.Write("\nElija una opcion valida: ");
                op = Convert.ToByte(Console.ReadLine());

            } while ((op < 0) || (op > 3));

            switch (op)
            {
                case 1:
                    Console.WriteLine("\nEl area del circulo es: {0}", AreaCircule());
                    op = 0;
                    break;

                case 2:
                    Console.WriteLine("\nEl area del Cuadrado es: {0}", AreaSquare());
                    op = 0;
                    break;
                case 3:
                    Console.WriteLine("\nEl area del Triangulo es: {0}", AreaTriangle());
                    op = 0;
                    break;
                default:
                    op = 0;
                    break;
            }
        }

        private static double AreaTriangle()
        {
            Console.Write("\nIngrese la base: ");
            var @base = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIngrese la altura: ");
            var height = Convert.ToDouble(Console.ReadLine());

            return (@base * height) / 2;
        }

        private static double AreaSquare()
        {
            Console.Write("\nIngrese la base: ");
            var @base = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIngrese la altura: ");
            var height = Convert.ToDouble(Console.ReadLine());

            return (@base * height);
        }

        private static double AreaCircule()
        {
            Console.Write("\nIngrese el radio: ");
            var radio = Convert.ToDouble(Console.ReadLine());

            return Math.PI * Math.Pow(radio, 2);
        }

        private static void TransformDegreesToRadians()
        {
            Console.Write("\nIngrese los grados: ");
            var degrees = Convert.ToDouble(Console.ReadLine());

            var radians = degrees * (Math.PI / 180);

            Console.WriteLine("Los {0}° son {1} radianes\n", degrees, radians);
        }
    }
}
