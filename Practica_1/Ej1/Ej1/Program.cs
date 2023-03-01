using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.Unicode;
            Console.WriteLine("Cuantos paquetes desea?");
            int paquetes = Convert.ToInt32(Console.ReadLine());
            double precio;
            if (paquetes < 200)
            {
                precio = 4.50;
            }
            else if (paquetes < 500) 
            {
                precio = 3.75;
            }
            else
            {
                precio = 3.25;
            }
            Console.WriteLine("El precio de tu tande de paquetes es {0}€", precio);
            Console.ReadLine();
        }
    }
}
