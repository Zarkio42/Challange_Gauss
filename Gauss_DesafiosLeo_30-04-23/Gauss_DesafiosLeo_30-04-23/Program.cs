using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss_DesafiosLeo_30_04_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------
            //DESAFIO FÁCIL: Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.
            //Use 1. LINQ - 2.FOR - 3.FOREACH - 4.LIST - 5. ARRAY - 6. ARRAYLIST
            //--------------------------------------------------------------------------------------------------

            /*
            for (int i = 100; i > 0; i--) 
            {
                Console.WriteLine(i);
            }

            Console.Read();

            */

            //FOREACH

            int[] numQuery = new int[99];

            foreach (int num in Enumerable.Range(1, 100).Reverse())
            {
                Console.WriteLine(num);
            }

            Console.Read();

            //LINQ



        }
    }
}
