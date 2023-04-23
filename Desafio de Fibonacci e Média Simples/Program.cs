using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_Fibonacci_e_Média_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int opcoes;

            do
            {
                Console.WriteLine("Olá seja bem vindo ao meu Repositório! Qual desafio você quer acessar?");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("Média Simples(1) ou Fibonacci(2)");
                Int32.TryParse(Console.ReadLine(), out opcoes);
                Console.Clear();

            } while (opcoes != 1 && opcoes != 2);

            if (opcoes == 1)
            {
                Console.WriteLine("Você selecionou o Desafio da Média Simples!");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Digite a Primeira Nota: ");
                _ = float.TryParse(Console.ReadLine(), out float nota1);
                Console.WriteLine("Digite a Segunda Nota: ");
                _ = float.TryParse(Console.ReadLine(), out float nota2);
                Console.Clear();

                Console.WriteLine("Sua Média Final é: " + (nota1 + nota2) / 2);
                Console.WriteLine("------------------------------------------");

            }

            else if (opcoes == 2)
            {
                int soma, x=1, y=0;

                Console.WriteLine("Você selecionou o Desafio de Fibonacci!");
                Console.WriteLine("---------------------------------------");
                Console.Write("Defina um limite de exibição para a sequência de Fibonacci: ");
                Int32.TryParse(Console.ReadLine(), out int limite);

                for (int i = 1; i <= limite; i++)
                {
                    soma = (x + y);
                    y = x;
                    x = soma;
                    Console.WriteLine($"Aqui está: {soma}");
                }

                
            }
         Console.ReadKey();
            
        }
    }
}
