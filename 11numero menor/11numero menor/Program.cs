using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11numero_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11) Encontrar el menor valor de un conjunto de n números dados.*/

            Console.WriteLine("Ingrese el numero limite");
            string nl = Console.ReadLine();//pide numero
            float nlParseado = float.Parse(nl);

             Console.WriteLine("Ingrese el numero 1");
            string n1 = Console.ReadLine();//pide numero
            float n1Parseado = float.Parse(n1);
            
            for (int i = 2; i <= nlParseado; i++)
            {
                Console.WriteLine("Ingrese el numero {0}", i);
                string n = Console.ReadLine();//pide numero
                float nParseado = float.Parse(n);

                if (nParseado < n1Parseado)
                {
                    n1Parseado = nParseado;
                }
            }
            Console.WriteLine("El numero menor es: {0}", n1);
                        
            Console.ReadKey();
        }
    }
}
