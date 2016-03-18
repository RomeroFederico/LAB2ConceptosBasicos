using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_1
{
    /*
    01.  Ingresar 5 números por consola, guardándolos en una variable 
    escalar. Luego calcular y  mostrar: el valor máximo, el valor 
    mínimo y el promedio.
    */

    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            double numero;
            double max = 0;
            double min = 0;
            double prom = 0;

            Console.Title = "Ejercicio Nro 1";

            for (int i = 0; i < 5; i++, Console.Clear())
            {
                Console.Write("Ingrese un numero (faltan {0}): ", 5 - i);
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Clear();
                    Console.Write("ERROR!!! No se ingreso un numero. Ingrese un numero (faltan {0}): ", 5 - i);
                }

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    if (numero < min)
                        min = numero;

                    if (numero > max)
                        max = numero;
                }

                prom = prom + numero;
            }

            prom /= 5;

            Console.WriteLine("El valor minimo fue: {0}.\nEl valor maximo fue: {1}.\nEl promedio fue de {2,0:#,###.00}. ", min, max, prom);

            Console.ReadKey();
        }
    }
}