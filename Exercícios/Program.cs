using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;

            Console.WriteLine("Seja bem vindo à lista de exercícios de estruturas de repetição While. A seguir será fornecido o tópico dos 8 exercícios onde você poderá escolher um deles para testar.");

            while (continuar != 0)
            {
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Exercício 1 - Descobrir senha.");
                Console.WriteLine("Exercício 2 - Quadrante em pontos cartesianos.");
                Console.WriteLine("Exercício 3 - Preferência de combustível.");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Escola a opção do exercício desejado (se desejar encerrar o programa digite qualquer outro número): ");
                int opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                if (opcao == 1)
                {
                    Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem \"Senha Invalida\".Quando a senha for informada corretamente deve ser impressa a mensagem \"Acesso Permitido\" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.");

                    Console.Write("Digite um número inteiro de 4 dígitos = ");
                    int senha = int.Parse(Console.ReadLine());

                    while(senha != 2002)
                    {
                        Console.WriteLine("Senha Invalida");
                        Console.Write("Tente novamente = ");
                        senha = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Acesso Permitido");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano.Para cada ponto escrever o quadrante a que ele pertence.O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).");

                    Console.Write("Digite o valor de X w Y, sendo números inteiros, na mesma linha = ");
                    string[] temp = Console.ReadLine().Split(" ");
                    int x = int.Parse(temp[0]);
                    int y = int.Parse(temp[1]);

                    while(x != 0 && y != 0)
                    {
                        if(x > 0 && y > 0)
                            Console.WriteLine("primeiro");
                        else if(x < 0 && y > 0)
                            Console.WriteLine("segundo");
                        else if(x < 0 && y < 0)
                            Console.WriteLine("terceiro");
                        else if(x > 0 && y < 0)
                            Console.WriteLine("quarto");

                        Console.Write("Digite novos valores para X e Y = ");
                        string[] temp1 = Console.ReadLine().Split(" ");
                        x = int.Parse(temp1[0]);
                        y = int.Parse(temp1[1]);
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até que seja válido).O programa será encerrado quando o código informado for o número 4.Deve ser escrito a mensagem: \"MUITO OBRIGADO\" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.");

                    Console.Write("Digite o número desejado = ");
                    int codigo = int.Parse(Console.ReadLine());

                    int alcool = 0;
                    int gasolina = 0;
                    int diesel = 0;

                    while(codigo != 4)
                    {
                        if (codigo == 1)
                            alcool++;
                        else if (codigo == 2)
                            gasolina++;
                        else if (codigo == 3)
                            diesel++;

                        Console.Write("Digite o número desejado novamente = ");
                        codigo = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine($"Alcool: {alcool}");
                    Console.WriteLine($"Gasolina: {gasolina}");
                    Console.WriteLine($"Diesel: {diesel}");
                }

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Digite 1 caso queira verificar outro exercício ou 0 para encerrar: ");
                continuar = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Clear();
            }
        }
    }
}
