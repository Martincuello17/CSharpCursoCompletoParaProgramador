using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskSix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            byte i, j, numAlumnos, salones;
            double sumaCalif = 0, totalAlumnos = 0, promedio, califMin = 10, califMax = 0, acumuladorCalifSalon;

            //Pedimos el número de salones
            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            //Creación de la matriz
            double[][] calificaciones = new double[salones][];

            Console.WriteLine();

            // Pedimos el número de alumnos por salón
            for (i = 0; i < salones; i++)
            {
                Console.Write("Ingrese el número de alumnos para el salón {0}: ", i);
                numAlumnos = Convert.ToByte(Console.ReadLine());

                //Acumulamos el número de alumnos totales, para el promedio de toda la escuela
                totalAlumnos += numAlumnos;

                //Instanciamos las matrices internas (alumnos en cada salón)
                calificaciones[i] = new double[numAlumnos];
            }

            Console.WriteLine();

            double[] califMinSalon = new double[salones];
            double[] califMaxSalon = new double[salones];
            double[] promedioSalon = new double[salones];

            //Pedimos las calificaciones de los alumnos de cada salón
            for (i = 0; i < salones; i++)
            {
                acumuladorCalifSalon = 0;
                califMin = 10;
                califMax = 0;

                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    //Pedimos la califiación
                    Console.Write("Ingresa la calificación del alumno {0}: ", j);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    //Acumulamos las califiaciones
                    sumaCalif += calificaciones[i][j];

                    acumuladorCalifSalon += calificaciones[i][j];

                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }

                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
                califMinSalon[i] = califMin;
                califMaxSalon[i] = califMax;

                promedioSalon[i] = acumuladorCalifSalon / calificaciones[i].Length;
            }

            //Calculamos el promedio
            promedio = sumaCalif / totalAlumnos;

            //Calculamos la calificación mínima y maxima
            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("DATOS DE LA ESCUELA");

            Console.WriteLine();

            //Mostramos las calificaciones de todos los alumnos de la escuela
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón {0}", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("El alumno {0}, tiene {1} de calificación", j, calificaciones[i][j]);
                }
            }

            Console.WriteLine();

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("INFORMACION DEL SALON {0}: ", i);
                Console.WriteLine("Calificacion maxima: {0}, calificacion minima: {1}", califMaxSalon[i], califMinSalon[i]);
                Console.WriteLine("Promedio: {0}", promedioSalon[i]);
            }

            Console.WriteLine();

            //Mostramos los resultados
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La califiación mínima es: {0}", califMin);
            Console.WriteLine("La califiación máxima es: {0}", califMax);
        }
    }
}
