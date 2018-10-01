using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7pago_estudio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7) Una institución educativa estableció un programa para estimular a los alumnos con buen rendimiento académico y que consiste en lo siguiente:
	Si el promedio es de 9.5 o mas y el alumno es de preparatoria, entonces este podrá cursar 55 unidades y se le hará un 25% de descuento.
	Si el promedio es mayor o igual a 9 pero menor que 9.5 y el alumno es de preparatoria, entonces este podrá cursar 50 unidades y se le hará un 10% de descuento.
	Si el promedio es mayor que 7 y menor que 9 y el alumno es de preparatoria, este podrá cursar 50 unidades y no tendrá ningún descuento.
	Si el promedio es de 7 o menor,  el numero de materias reprobadas es de 0 a 3 y el alumno es de preparatoria, entonces podrá cursar 45 unidades y no tendrá descuento.
	Si el promedio es de 7 o menor, el numero de materias reprobadas es de 4 o mas y el alumno es de preparatoria, entonces podrá cursar 40 unidades y no tendrá ningún descuento.
	Si el promedio es mayor o igual a 9.5 y el alumno es de profesional, entonces podrá cursar 55 unidades y se le hará un 20% de descuento.
	Si el promedio es menor de 9.5 y el alumno es de profesional, entonces podrá cursar 55 unidades y no tendrá descuento.

	Obtener el total que tendrá que pagar un alumno si la colegiatura para alumnos de profesional es de $300 por cada cinco unidades y para alumnos de preparatoria 
    es de $180 por cada cinco unidades.
*/

            Console.WriteLine("Ingrese 1 si es alumno de preparatoria o 2 si es alumno profesional");
            string opc = Console.ReadLine();//pi
            float opcParseado = float.Parse(opc);

            Console.WriteLine("Ingrese su promedio final de materias");
            string prom = Console.ReadLine();//pi
            float promParseado = float.Parse(prom);

                       
            if (opcParseado == 1)
            {
                if (promParseado >= 9.5)
                {
                    float p = (180 * 55 / 5) - (55 / 5 * 25 / 100);
                    Console.WriteLine("El pago del alumno de preparatoria es de: {0}", p);
                }
                else if (promParseado >= 9 && promParseado < 9.5)
                {
                    float p = (180 * 50 / 5) - (50 / 5 * 10 / 100);
                    Console.WriteLine("El pago del alumno de preparatoria es de: {0}", p);
                }
                else if (promParseado > 7 && promParseado < 9)
                {
                    float  p = (180 * 50 / 5);
                    Console.WriteLine("El pago del alumno de preparatoria es de: {0}", p);
                }
                else if (promParseado <= 7)
                {
                    Console.WriteLine("Ingrese numero de materias reprobadas");
                    string m = Console.ReadLine();//pide # materias reprobadas
                    float mParseado = float.Parse(m);
                    if (mParseado >= 0 && mParseado <= 3)
                    {
                        float p = (180 * 40 / 5);
                        Console.WriteLine("El pago del alumno de preparatoria es de: {0}", p);
                    }
                }
            }
            else if (promParseado >= 9.5)
            {
                float p = (300 * 55 / 5) - (55 / 5 * 20 / 100);
                Console.WriteLine("El pago del alumno de profesional es de: {0}", p);
               
            }
            else
            {
                float p = (300 * 55 / 5);
                Console.WriteLine("El pago del alumno de profesional es de: {0}", p);
            }

           

            Console.ReadKey();
        }
    }
}
