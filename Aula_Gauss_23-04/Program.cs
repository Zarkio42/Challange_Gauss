using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Gauss_23_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------------------  
            // Dado os valores 4, 5 e 8 construa um programa que calcule a média harmonica.
            //------------------------------------------------------------------------------------------

            /*
            double[] arrayNum = {4, 5, 8};

            Console.WriteLine("Vamos calcular a média harmonica entre 4, 5 e 8!");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"A média harmonica entre esses valores é: {arrayNum.Length / (1/arrayNum[0] + 1/arrayNum[1] + 1/arrayNum[2])}");

            Console.ReadKey();
            
            
            */
            
            int[] arrayNum = {};
            
            for(int i = 0; i <= arrayNum.Length; i++)
            {
                Console.WriteLine("Digite os valores que desejar: ");
                int.TryParse(Console.ReadLine(), out arrayNum[i]);
            }

            


        }
    }
}
