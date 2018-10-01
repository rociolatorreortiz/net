using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
        /*#4-:En un hospital existen tres áreas: Ginecología, Pediatría, Traumatologia. 
            El presupuesto anual del hospital se reparte conforme a la sig.tabla:
            	
			Área Porcentaje del presupuesto

            Ginecología         40 %
            Traumatologia       30 %
            Pediatría           30 %

            Obtener la cantidad de dinero que recibirá cada área, para cualquier monto presupuestal.*/

            Console.WriteLine("Ingrese el valor de la inversión para el hospital");
            string v1 = Console.ReadLine();//pide valor inversión
            float v1Parseado = float.Parse(v1);

            Console.WriteLine("El dinero que recibe el área de Ginecología es: {0}", v1Parseado * 0.4);
            Console.WriteLine("El dinero que recibe el área de Traumatología es: {0}", v1Parseado * 0.3);
            Console.WriteLine("El dinero que recibe el área de Pediatría es: {0}", v1Parseado * 0.3);

            Console.ReadKey();
        }
    }
}
