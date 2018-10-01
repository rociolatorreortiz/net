using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#1- Un obrero necesita calcular su salario semanal, el cual se obtiene de la sig. manera: 
                Si trabaja 40 horas o menos se le paga $16 por hora
                Si trabaja mas de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20 por cada hora extra.*/

            Console.WriteLine("Ingrese el número de horas trabajadas");
            string horas = Console.ReadLine();//pide horas
            int horasParseado = int.Parse(horas);

            if (horasParseado<=40)
            {
                Console.WriteLine("Su salario es de: {0}", horasParseado*16);//muestra numero

            }
            else
            {
                int extra = horasParseado - 40;
                Console.WriteLine("Su salario es de: {0}", (40*16)+(extra * 20));//muestra numero
            }
            Console.ReadKey();




        }
    }
}
