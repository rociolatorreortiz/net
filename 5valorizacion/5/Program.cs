using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#5 Una persona se encuentra con un problema de comprar un automóvil o un terreno, 
             * los cuales cuestan exactamente lo mismo. Sabe que mientras el automóvil se devalúa, 
             * con el terreno sucede lo contrario. Esta persona comprara el automóvil si al cabo de tres años la devaluación de este 
             * no es mayor que la mitad del incremento del valor del terreno. Ayúdale a esta persona a determinar si debe o no comprar el automóvil
*/

            Console.WriteLine("Ingrese el valor del automóvil que es el mismo del terreno");
            string valor = Console.ReadLine();//pi
            float valorParseado = float.Parse(valor);

            float daut = valorParseado * 10 / 100;
            float iter = valorParseado * 30 / 100;
            float caut = valorParseado - daut;
            float cter = valorParseado + iter;

            if (daut * 3 < iter * 3 / 2)
            {
                Console.WriteLine("Es mejor comprar el automovil por que el valor a 3 años será de {0}", caut);

            }
            else
            {
                Console.WriteLine("Es mejor comprar el terreno por que el valora 3 años será de {0}", cter);

            }

            
           

            Console.ReadKey();
        }
    }
}
