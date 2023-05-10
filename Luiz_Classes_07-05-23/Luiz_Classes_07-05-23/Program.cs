using Luiz_Classes_07_05_23.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Luiz_Classes_07_05_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A empresa MaxAlteirTesla possui um numero de 40.000 funcionarios
            //Hoje em dia a empresa sofre com problemas de controle de funcionarios
            //O setor de RH nao consegue ter o controle do estado dos seus funcionarios
            //Exemplo: Quantidade de especializações, quantidade de funcionarios por setor,
            //média de salario de cada setor
            //Registro de tempo por setor
            //Cadastro de funcionarios por setor
            //Listagem de funcionarios por setor.

            Random random = new Random();

            Console.WriteLine("----- Bem vindo à MaxAlteirTesla -----");
            Console.WriteLine("\nComplete seu cadastro: ");
            Console.WriteLine("\nInicialmente, digite a quantidade de funcionáros a serem cadastrados: ")
            int.TryParse(Console.ReadLine(), out int quantidadeFuncionario)

            Console.ReadKey();
            Console.Clear();

            var list = new List<Funcionario>();
            //var funcionarios = new Funcionario();
            for (int i = 0; i < quantidadeFuncionario; i++)
            {
                var funcionarios = new Funcionario();
                Console.WriteLine("Digite o nome do funcionário: ");
                funcionarios.nome = Console.ReadLine();
                list.Add(funcionarios);
                Console.Clear();

                Console.WriteLine("\nDigite sua especialização: ");
                funcionarios.especializacao = Console.ReadLine();
                list.Add(funcionarios);
                Console.Clear();

                Console.WriteLine("\nDigite o seu setor: ");
                funcionarios.especializacao = Console.ReadLine();
                list.Add(funcionarios);
                Console.Clear();

                Console.WriteLine("\nDigite seu salário: ");
                double.TryParse(Console.ReadLine(), out funcionarios.salario);
                Console.Clear();

                funcionarios.numRegistro = random.Next(0, quantidadeFuncionario);
                Console.WriteLine($"\nGeramos um Número de registro aleatório para você...");

            }


            Console.WriteLine($"Seus dados {funcionarios.nome}");

            foreach(var item  in funcionarios) 
            {
                Console.WriteLine(item);
            }

            Console.Read();

        }
    }
}
