using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskThree
{
    class Principal
    {
        static void Main(string[] args)
        {
            byte op;

            Console.WriteLine("1. Nombre del mes indicando el número.");
            Console.WriteLine("2. Validador de numero par/impar.");
            Console.WriteLine("3. Precio del Estacionamiento.");

            Console.Write("Ingrese el programa que desea utilizar: ");

            op = Convert.ToByte(Console.ReadLine());

            switch (op)
            {
                case 1:
                    CalculatorMonthPerNumber();
                    break;

                case 2:
                    ValidatorNumberParity();
                    break;

                case 3:
                    ParkingPrice();
                    break;
            } 

        }

        private static void CalculatorMonthPerNumber()
        {
            int numberMonth;
            string nameMonth;
            Console.Write("Ingrese el número del mes: ");
            numberMonth = Convert.ToInt32(Console.ReadLine());
            nameMonth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numberMonth);
            Console.WriteLine("El nombre del mes número {0} es: {1}", numberMonth, nameMonth);
        }

        private static void ValidatorNumberParity()
        {
            int number, calculator;
            Console.Write("Ingrese el número para comprobar la paridad: ");
            number = Convert.ToInt32(Console.ReadLine());

            calculator = number % 2;

            if (calculator == 0)
            {
                Console.WriteLine("El número {0} es par", number);
            }
            else
            {
                Console.WriteLine("El número {0} es impar", number);
            }
        }

        private static void ParkingPrice()
        {
            int minutes;
            Console.Write("Ingrese la cantidad de minutos que estuvo en el estacionamiento: ");
            minutes = Convert.ToInt32(Console.ReadLine());

            if(minutes <= 60)
            {
                Console.WriteLine("El precio del estacionamiento para {0} minutos es de: $5.00", minutes);
            } 
            else if(minutes <= 120)
            {
                Console.WriteLine("El precio del estacionamiento para {0} minutos es de: $15.00", minutes);
            } else 
            {
                Console.WriteLine("El precio del estacionamiento para {0} minutos es de: $40.00", minutes);
            }
        }
    }
}
