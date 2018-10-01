using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

        /*# 2- Una persona enferma, que pesa 70 kg, se encuentra en reposo y desea saber cuantas calorías consume su cuerpo durante todo 
            el tiempo que realice una misma actividad.Las actividades que tiene permitido realizar son únicamente dormir o estar sentado en
           reposo.Los datos que tiene son que estando dormido consume 1.08 calorías por minuto y estando sentado en reposo consume 1.66
           calorías por minuto.*/



            Console.WriteLine("Ingrese el tipo de actividad, dormir 1 y sentado 2");
            string opc = Console.ReadLine();//pide opción
            int opcParseado = int.Parse(opc);


            if (opcParseado == 1)
            {
                Console.WriteLine("Ingrese los minutos que estuvo dormido");
                string minutos = Console.ReadLine();//pide horas
                float minutosParseado = float.Parse(minutos);

                Console.WriteLine("las calorias consumidas estando dormido fueron de {0}", 1.08 * minutosParseado);

            }
            else if (opcParseado == 2)

            {
                Console.WriteLine("Ingrese los minutos que estuvo sentado");
                string minutos = Console.ReadLine();//pide horas
                int minutosParseado = int.Parse(minutos);

                Console.WriteLine("las calorias consumidas estando dormido fueron de {0}", 1.66 * minutosParseado);

            }
            else
            {
                Console.WriteLine("La opción es invalida");
            }
            Console.ReadKey();


        }
    }
}
