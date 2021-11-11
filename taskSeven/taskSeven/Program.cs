using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, direccion, rfc;
            double saldo;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Ingrese su direccion: ");
            direccion = Console.ReadLine();

            Console.Write("Ingrese su rfc: ");
            rfc = Console.ReadLine();

            Console.Write("Ingrese su saldo inicial: ");
            saldo = double.Parse(Console.ReadLine());

            CuentaBancaria cuenta = new CuentaBancaria(nombre, apellido, direccion, rfc, saldo);

            byte op;
            do
            {

                Console.WriteLine("\n1. Deposito\n2. Retiro\n3. Consultar Saldo\n4. Mostrar información de la cuenta\n5. Salir");
                Console.Write("\nIngrese una opcion valida: ");
                op = byte.Parse(Console.ReadLine());

            } while (op > 5 && op < 0);

            switch (op)
            {
                case 1:
                    Console.Write("\nIngrese la cantidad a depositar: ");
                    cuenta.Deposito(double.Parse(Console.ReadLine()));
                    cuenta.ConsultaSaldo();
                    break;

                case 2:
                    Console.Write("\nIngrese la cantidad a retirar: ");
                    cuenta.Retiro(double.Parse(Console.ReadLine()));
                    cuenta.ConsultaSaldo();
                    break;

                case 3:
                    cuenta.ConsultaSaldo();
                    break;

                case 4:
                    cuenta.ToString();
                    break;

                default:
                    break;
            }
        }
    }

    class CuentaBancaria
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string rfc { get; set; }
        public double saldo { get; set; }

        public CuentaBancaria(string nombre, string apellidos, string direccion, string rfc, double saldo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.rfc = rfc;
            this.saldo = saldo;
        }

        public void Deposito(double montoPa)
        {
            saldo += montoPa;
        }

        public void Retiro(double montoPa)
        {
            if (montoPa <= saldo)
            {
                saldo -= montoPa;
            }
            else
            {
                Console.WriteLine("\nNo posee esa cantidad en su cuenta");
            }
        }

        public void ConsultaSaldo()
        {
            Console.WriteLine("Su saldo es: {0}", saldo);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
