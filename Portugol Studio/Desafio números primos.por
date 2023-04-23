programa
{
	
	funcao inicio()
	{
		inteiro num, divisores, i

		escreva("Digite um numero para verificarmos se é ou não número primo: " + "\n")
		leia(num)

          i = 3         //Contador começando em 3 pois no decorrer do código vamos adicionar condições para os números 0, 1 e 2.
		divisores = 1 //Começa em 1 porque todo número é divisivel por 1

          se (num <= 1) {
          	
			faca{ //Looping até o usuário digitar um número certo
			
			escreva("O número digitado deve ser maior que 1 \n")
			leia(num)
			
			}enquanto (num <= 1)

          }

		limpa() //Limpa a bagunça do looping acima

		se (num == 2) { //O 2 é uma exceção!

			escreva("O número " + num + " É PRIMO! Curiosamente é o único número par pertencente ao conjunto de números primos!")
		}

		senao se (num % 2 == 0) { //Se for par diferente de 2, não é primo!

			escreva("O número " + num + " NÂO É PRIMO!")
			
		}
		
          senao { //Laço de repetição para identificar quantos divisores a variável 'num' tem. Se esse número for maior que 2, então 'num' não é primo!
          	
			enquanto(i <= num) {
									
					se (num % i ==0) { //Se o resto for igual a zero, então encontramos um divisor e ele será incrementado com 'divisores++'.
						divisores++
					}
					
					i += 2
				
			}

		

				se (divisores > 2) {

				escreva("O número " + num + " NÃO É PRIMO!")
				}

				senao {

				escreva("O número " + num + " É PRIMO!")
				}

          }

			
      }

}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1216; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
