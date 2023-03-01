using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Introduce 2 arrays para poder ordenarlos.");
            Console.Write("1º array: ");
            int[] array1 = { 1, 2, 5, 6 };

            Console.Write("2º array: ");
            int[] array2 = { 3, 4, 7, 8 };

            Console.WriteLine("");

            int[] arrayOrdeado = p.OrdenarArrays(array1, array2);
            foreach (int i in arrayOrdeado)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
        public int[] OrdenarArrays(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length + array2.Length];
            int cont = 0;

            int i = 0, j = 0;
            while (i+1 <= array1.Length && j+1 <= array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    array3[cont] = array1[i];
                    i++;
                    cont++;
                }
                else
                {
                    array3[cont] = array2[j];
                    j++;
                    cont++;
                }
            }
            while (j < array2.Length || i < array1.Length)
            {
                if (i == array1.Length)
                {
                    array3[cont] = array2[j];
                    j++;
                }
                else if(j == array2.Length)
                {
                    array3[cont] = array1[i];
                    i++;
                }
                cont++;
            }
            return array3;
        }
    }
}
