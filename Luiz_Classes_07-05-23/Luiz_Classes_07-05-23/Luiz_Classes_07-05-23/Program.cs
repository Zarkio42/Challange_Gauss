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

            Console.WriteLine("----- Bem vindo à MaxAlteirTesla -----");
            Console.WriteLine("\nComplete seu cadastro: ");

            Console.ReadKey();
            Console.Clear();

            var list = new List<Funcionario>();
            //var funcionarios = new Funcionario();
            for (int i = 0; i < 3; i++)
            {
                var funcionarios = new Funcionario();
                Console.WriteLine("Digite o nome");
                funcionarios.nome = Console.ReadLine();
                list.Add(funcionarios);


                

            }

            Console.WriteLine("1) Qual o seu nome? ");
            //criar um for
            funcionarios.nome = Console.ReadLine();

            Console.WriteLine("2) Qual a sua especialização? ");
            funcionarios.especializacao = Console.ReadLine();

            Console.WriteLine("3) Qual a seu salário? ");
            int.TryParse(Console.ReadLine(), out funcionarios.salario);

            Console.WriteLine("4) Qual a seu salário? ");
            int.TryParse(Console.ReadLine(), out funcionarios.salario);

            Console.WriteLine("5) Qual o seu setor? ");
            funcionarios.setor = Console.ReadLine();

            //gerar numero de registro
            var registro = 0;
            do
            {
                registro++;
            }while( registro > 0 );


            Console.WriteLine($"Seus dados {funcionarios.nome}");

            foreach(var item  in funcionarios) 
            {
                Console.WriteLine(item);
            }

            Console.Read();

        }
    }
}
