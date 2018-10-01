using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9) Un Zoólogo pretende determinar el porcentaje de animales que hay en las siguientes tres categorías de edades: 
             * de 0 a 1 año, de mas de 1 año y menos de 3 y de 3 o mas años. El  zoológico todavía no esta seguro del animal 
             * que va a estudiar. Si se decide por elefantes solo tomara una muestra de 4 de ellos; si se decide por las jirafas, 
             * tomara 3 muestras, y si son chimpancés tomara 8.*/

            Console.WriteLine("Ingrese que animal quiere investigar: 1 si es Elefante, 2 si es Jirafa, 3 si es Chimpacé");
            string opc = Console.ReadLine();//pide numero
            float opcParseado = float.Parse(opc);

            int me=0,cd=0,ma=0;

            if (opcParseado == 1)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("Ingrese que edad tiene el Elefante {0}",i+" en años");
                    string anos = Console.ReadLine();//pide años
                    float anosParseado = float.Parse(anos);
                    
                    if (anosParseado <= 1)
                    {
                        me = me + 1;
                    }
                    else if (anosParseado < 3)
                    {
                        cd = cd + 1;
                    }
                    else
                    {
                        ma = ma + 1;
                    }
                }
                float p1 = (me * 100 / 4);
                float p2 = (cd * 100 / 4);
                float p3 = (ma * 100 / 4);

                Console.WriteLine("El porcentaje de Elefantes de un año o menos es: "+p1+" porciento, de más un año y menos de 3 años es: "+p2+" porciento y de 3 años o más es: "+p3+" porciento");

            }
            else if (opcParseado == 2)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Ingrese que edad tiene el Jirafa {0}", i + " en años");
                    string anos = Console.ReadLine();//pide años
                    float anosParseado = float.Parse(anos);

                    if (anosParseado <= 1)
                    {
                        me = me + 1;
                    }
                    else if (anosParseado < 3)
                    {
                        cd = cd + 1;
                    }
                    else
                    {
                        ma = ma + 1;
                    }
                }
                float p1 = (me * 100 / 3);
                float p2 = (cd * 100 / 3);
                float p3 = (ma * 100 / 3);

                Console.WriteLine("El porcentaje de Jirafas de un año o menos es: "+p1+" porciento, de más un año y menos de 3 años es: "+p2+" porciento y de 3 años o más es: "+p3+" porciento");

            }
            else if (opcParseado == 3)
            {
                for (int i = 1; i <= 8; i++)
                {
                    Console.WriteLine("Ingrese que edad tiene el Chimpancé ", i + " en años");
                    string anos = Console.ReadLine();//pide años

                    float anosParseado = float.Parse(anos);

                    if (anosParseado <= 1)
                    {
                        me = me + 1;
                    }
                    else if (anosParseado < 3)
                    {
                        cd = cd + 1;
                    }
                    else
                    {
                        ma = ma + 1;
                    }
                }
                float p1 = (me * 100 / 8);
                float p2 = (cd * 100 / 8);
                float p3 = (ma * 100 / 8);

                Console.WriteLine("El porcentaje de Chimpances de un año o menos es: {0}", p1+" porciento, de más un ano y menos de 3 años es: "+p2+" porciento y de 3 años o más es: "+p3+" porciento");
            }
            else
            {
                Console.WriteLine("Ingresaste una opción inválida");
            }
            Console.ReadKey();
        }
    }
}
