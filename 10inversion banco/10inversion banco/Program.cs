using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10inversion_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10) Una persona desea invertir su dinero en un banco, el cual le otorga un 2% de interés. 
             * Cual será la cantidad de dinero que esta persona tendrá al cabo de un año si la ganancia de cada mes es reinvertida?.*/

            Console.WriteLine("Ingrese el valor del dinero que dejara en el banco");
            string valor = Console.ReadLine();//pide numero
            float valorParseado = float.Parse(valor);

            float valor1 = valorParseado;
            float g = 0;


            for (int i = 1; i <= 12; i++)
            {
                g = valor1 + (valorParseado * 2/100);
                valorParseado = g + valorParseado;

                Console.WriteLine("La ganancia del dinero que esta persona tendra al cabo del mes {0}",i+" es: "+g);
            }

            float va = valor1 + g;
            Console.WriteLine("La cantidad de dinero que esta persona tendra al cabo de un ano es: {0}",va);
            
            
            Console.ReadKey();
        }
    }
}
