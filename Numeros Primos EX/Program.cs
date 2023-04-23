using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_números_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, i, divisor;

            i = 3; //contador começa em 3, pois já temos condições para os números 0, 1 e 2.
            divisor = 1; //divisor começa em 1, pois todo número é divisivel por 1

            Console.WriteLine("Digite um número para verificar se ele é Primo: " + "\n");
            int.TryParse(Console.ReadLine(), out num);

            if (num < 2)
            {
                do //looping até ser digitado o número correto.
                {
                    Console.WriteLine("Digite um número maior que 1!");
                    int.TryParse(Console.ReadLine(), out num);
                } while (num < 2);

            }

            Console.Clear();

            if (num == 2) //Exceção de número primo par
            {
                Console.WriteLine("O número " + num + " É PRIMO! Curiosamente, o único número primo que é par!");
            }

            else if (num % 2 == 0) //Verif. números pares.
            {
                Console.WriteLine("O número " + num + " NÃO É PRIMO!");
            }

            else
            {
                while (i <= num)
                {
                    if (num % i == 0) //Se o resto dessa divisão for 0, achamos um divisor!
                    {
                        divisor++;
                    }

                    i += 2;
                }

                if (divisor > 2) //Se houver mais de 2 divisores, esse número não é primo
                {
                    Console.WriteLine("O número " + num + " NÃO É PRIMO");
                }

                else
                {
                    Console.WriteLine("O número " + num + " É PRIMO!");
                }

            }
            //Gato em ASCII
            Console.WriteLine(".                .                    \r\n       :\"-.          .-\";                    \r\n       |:`.`.__..__.'.';|                    \r\n       || :-\"      \"-; ||                    \r\n       :;              :;                    \r\n       /  .==.    .==.  \\                    \r\n      :      _.--._      ;                   \r\n      ; .--.' `--' `.--. :                   \r\n     :   __;`      ':__   ;                  \r\n     ;  '  '-._:;_.-'  '  :                  \r\n     '.       `--'       .'                  \r\n      .\"-._          _.-\".                   \r\n    .'     \"\"------\"\"     `.                 \r\n   /`-                    -'\\                \r\n  /`-                      -'\\               \r\n :`-   .'              `.   -';              \r\n ;    /                  \\    :              \r\n:    :                    ;    ;             \r\n;    ;                    :    :             \r\n':_:.'                    '.;_;'             \r\n   :_                      _;                \r\n   ; \"-._                -\" :`-.     _.._    \r\n   :_          ()          _;   \"--::__. `.  \r\n    \\\"-                  -\"/`._           :  \r\n   .-\"-.                 -\"-.  \"\"--..____.'  \r\n  /         .__  __.         \\               \r\n : / ,       / \"\" \\       . \\ ; zzz          \r\n  \"-:___..--\"      \"--..___;-\"");

            Console.ReadKey();

        }
    }
}
