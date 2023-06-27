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

            

            //FOREACH

            foreach (int num in Enumerable.Range(1, 100).Reverse())
            {
                Console.WriteLine(num);
            }

            Console.Read();
            
            

            //LINQ

            //--------------------------------------------------------------------------------------------------
            //DESAFIO MEDIO: Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.
            //A CADA MULTIPLO DE 5 NÃO EXIBA O NÚMERO E SIM SEU NOME!
            //--------------------------------------------------------------------------------------------------

            for (int i = 100; i > 0; i--)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Pedro");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Ou utilizando ternário => for (int i = 100; i > 0; i--)
            // { i % 5 == 0 ? Console.WriteLine("Pedro"); : Console.WriteLine(i); }

            Console.Read();
            
            */

            //--------------------------------------------------------------------------------------------------
            //DESAFIO DIFICIL: Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.
            //A cada multiplo de 5 não exiba o número e sim o seu nome. Some todos os números pares e exiba
            //o resultado no final do código.
            //--------------------------------------------------------------------------------------------------

            var soma = 0;

            for (int i = 100; i > 0; i--)
            {
                if (i % 2 == 0) //Aqui ele conta até os números pares que são convertidos no meu nome!
                {
                    soma += i;
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("Pedro");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"\n-- Soma dos números pares: {soma} --");

            Console.Read();

            

            

        }
    }
}
