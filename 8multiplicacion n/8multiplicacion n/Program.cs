using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8multiplicacion_n
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8) Calcular e imprimir la tabla de multiplicar de un numero cualquiera. Imprimir el multiplicando, el multiplicador y el producto.
*/

            Console.WriteLine("Ingrese un número cualquiera");
            string numero = Console.ReadLine();//pide numero
            float numeroParseado = float.Parse(numero);

            for (int i=1; i <= numeroParseado; i++)
            {

                Console.WriteLine("La tabla de multiplicación es {0}", i+ "x"+numeroParseado+" ="+ i*numeroParseado);
            }
            

            Console.ReadKey();
            
        }
    }
}
