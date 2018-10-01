using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6numero_medio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6) Que lea tres números diferentes y determine el numero medio del conjunto de los tres números 
             * (el numero medio es aquel numero que no es ni mayor, ni menor).
*/

            Console.WriteLine("Ingrese el número 1");
            string n1 = Console.ReadLine();//pi
            float n1Parseado = float.Parse(n1);

            Console.WriteLine("Ingrese el número 2");
            string n2 = Console.ReadLine();//pi
            float n2Parseado = float.Parse(n2);

            Console.WriteLine("Ingrese el número 3");
            string n3 = Console.ReadLine();//pi
            float n3Parseado = float.Parse(n3);

            if ((n1Parseado > n2Parseado && n1Parseado < n3Parseado) || (n1Parseado < n2Parseado && n1Parseado > n3Parseado))
            {
                
            Console.WriteLine("El del medio es: {0}", n1Parseado);
        }
            else if ((n2Parseado > n1Parseado && n2Parseado < n3Parseado) || (n2Parseado < n1Parseado && n2Parseado > n3Parseado))
            {
                Console.WriteLine("El del medio es: {0}", n2Parseado);
            }
            else if ((n3Parseado > n1Parseado && n3Parseado < n2Parseado) || (n3Parseado < n1Parseado && n3Parseado > n2Parseado))
            {
                Console.WriteLine("El del medio es: {0}", n3Parseado);
            }
            
            Console.ReadKey();
        }
    }
}
