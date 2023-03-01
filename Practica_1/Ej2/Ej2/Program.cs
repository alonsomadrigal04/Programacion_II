using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una cadena");
            string cadena = Console.ReadLine();

            int i = 0;
            bool esCapicua = true; 
            while (cadena[i] < cadena.Length /2 && esCapicua)
            {
                if (cadena[i] == cadena[cadena.Length - i - 1])
                {
                    esCapicua = false;
                }
                i++;
            }
            if (isCapicua)
            {
                Console.WriteLine("La cadena es capicua");
            }
            else
            {
                Console.WriteLine("La cadena no es capicua");
            }
            Console.Read();



        }
    }
}
