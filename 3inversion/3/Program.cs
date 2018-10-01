using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

        /*#3-:Tres personas deciden invertir su dinero para fundar una empresa. Cada una de ellas invierte una cantidad distinta. 
            Obtener el porcentaje que cada quien invierte con respecto a la cantidad total invertida.*/


            Console.WriteLine("Ingrese el valor de la inversión de la primera persona");
            string v1 = Console.ReadLine();//pide valor inversión
            int v1Parseado = int.Parse(v1);

            Console.WriteLine("Ingrese el valor de la inversión de la segunda persona");
            string v2 = Console.ReadLine();//pide valor inversión
            int v2Parseado = int.Parse(v2);

            Console.WriteLine("Ingrese el valor de la inversión de la tercera persona");
            string v3 = Console.ReadLine();//pide valor inversión
            int v3Parseado = int.Parse(v3);

            float suma = v1Parseado + v2Parseado + v3Parseado;

            Console.WriteLine("El porcentaje de cada inversor es de: ");
            Console.WriteLine("Primero: {0}", 100 * v1Parseado / suma);
            Console.WriteLine("Segundo: {0}", 100 * v2Parseado / suma);
            Console.WriteLine("Tercero: {0}", 100 * v3Parseado / suma);
            Console.ReadKey();


        }
    }
}
