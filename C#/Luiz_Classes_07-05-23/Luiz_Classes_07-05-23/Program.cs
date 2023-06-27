using Luiz_Classes_07_05_23.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            int setor1 = 0, setor2 = 0, setor3 = 0;
            double soma1 = 0, soma2 = 0, soma3 = 0;

            Console.WriteLine("----- Bem vindo à MaxAlteirTesla -----");
            Console.WriteLine("\nComplete seu cadastro: ");
            Console.WriteLine("\nInicialmente, digite a quantidade de funcionáros a serem cadastrados: ");
            int.TryParse(Console.ReadLine(), out int quantidadeFuncionario);

            Console.Clear();

            var list = new List<Funcionario>();

            //var funcionarios = new Funcionario();
            for (int i = 0; i < quantidadeFuncionario; i++)
            {
                var funcionarios = new Funcionario();

                Console.WriteLine("Digite o nome do funcionário: ");
                funcionarios.nome = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\nDigite sua especialização: ");
                funcionarios.especializacao = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\nDigite o número referente ao seu setor: 1- Transporte | 2- Administrativo | 3- Secretaria");
                int.TryParse(Console.ReadLine(), out funcionarios.setor);
                Console.Clear();


                Console.WriteLine("\nDigite seu salário: ");
                double.TryParse(Console.ReadLine(), out funcionarios.salario);
                Console.Clear();

                //contagem para listagem de setores
                //media salarial por setor
                if (funcionarios.setor == 1)
                {
                    soma1 += funcionarios.salario;
                    setor1++;
                }
                else if (funcionarios.setor == 2)
                {
                    soma2 += funcionarios.salario;
                    setor2++;
                }
                else if (funcionarios.setor == 3)
                {
                    soma3 += funcionarios.salario;
                    setor3++;
                }

                Console.WriteLine($"\nGeramos um Número de registro aleatório para você...");
                funcionarios.numRegistro = random.Next(0, 40000);

                Console.ReadKey();
                Console.Clear();
                list.Add(funcionarios);

            }

            foreach (var item in list)
            {
                Console.WriteLine($"Nome: {item.nome}");
                Console.WriteLine($"Especialização: {item.especializacao}");
                Console.WriteLine($"Setor: {item.setor}");
                Console.WriteLine($"Salário: {item.salario}R$");
                Console.WriteLine($"Registro: {item.numRegistro} \n");
            }

            // Listagem de Funcionarios por setor

            Console.WriteLine($" Funcionários por Setor / Média Salarial \n\n Transportes: {setor1}\n Média Salarial: {soma1 / setor1}R$ \n\n Administração: {setor2} \n Média Salarial: {soma2 / setor2}R$ \n\n Secretaria: {setor3} \n Média Salarial: {soma3 / setor3}R$");

            Console.ReadKey();

        }
    }
}
