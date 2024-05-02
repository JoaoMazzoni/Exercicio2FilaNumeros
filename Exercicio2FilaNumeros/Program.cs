using System;

namespace Exercicio2FilaNumeros
{
    

  
    internal class Program
    {
        static Numero cadastroNumero()
        {
            int numero;
            Console.Write("\nInforme o valor do número: ");
            numero = int.Parse(Console.ReadLine());
            return new Numero(numero); // 1 - CRIANDO LIVRO - livro1
        }

        private static void Main(string[] args)
        {
            FilaNumero fila1 = new FilaNumero();
            FilaNumero fila2 = new FilaNumero();
            FilaNumero fila3 = new FilaNumero();
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\n---- MENU ----\n");
                Console.WriteLine("|1| - Inserir Numero");
                Console.WriteLine("|2| - Remover Numero");
                Console.WriteLine("|3| - Quantidade Fila");
                Console.WriteLine("|4| - Média dos Valores");
                Console.WriteLine("|5| - Transferir Fila");
                Console.WriteLine("|6| - Imprimir Números Ímpares");
                Console.WriteLine("|7| - Imprimir Números Pares");
                Console.Write("\nInforme a opção desejada: ");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        int qualFila = 0;
                        Console.Write("\nInforme qual fila você deseja inserir um valor (1 ou 2): ");
                        qualFila = int.Parse(Console.ReadLine());
                        if (qualFila == 1)
                        {
                            fila1.push(cadastroNumero());
                        }
                        else if (qualFila == 2)
                        {
                            fila2.push(cadastroNumero());
                        }
                        break;

                    case 2:
                        qualFila = 0;
                        Console.Write("\nInforme qual fila você deseja remover um valor (1 ou 2): ");
                        qualFila = int.Parse(Console.ReadLine());
                        if (qualFila == 1)
                        {
                            fila1.pop();
                        }
                        else if (qualFila == 2)
                        {
                            fila2.pop();
                        }
                        break;

                    case 3:
                        Console.WriteLine($"\nQuantidade de números cadastrados na fila 1: {fila1.tamanhoFila()} números");
                        Console.WriteLine($"\nQuantidade de números cadastrados na fila 2: {fila2.tamanhoFila()} números");
                        Console.ReadLine();

                        if (fila1.tamanhoFila() == fila2.tamanhoFila())
                        {
                            Console.WriteLine("\nAs filas possuem o mesmo tamanho, ou seja, mesma quantidade de valores inseridos.");
                        }
                        else
                        {
                            Console.WriteLine("\nAs filas são diferentes");
                            if (fila1.tamanhoFila() > fila2.tamanhoFila())
                            {
                                Console.WriteLine("\nA fila 1 é maior do que a fila 2.");
                            }
                            else
                            {
                                Console.WriteLine("\nA fila 2 é maior do que a fila 1.");
                            }
                        }
                        Console.ReadLine();
                        break;

                    case 4:
                        double media = fila1.CalcularMedia();
                        double maiorValor = fila1.EncontrarMaiorValor();
                        double menorValor = fila1.EncontrarMenorValor();

                        Console.WriteLine();
                        Console.WriteLine($"A média dos números na fila 1 é: {media}");
                        Console.WriteLine($"O maior valor na fila 1 é: {maiorValor}");
                        Console.WriteLine($"O menor valor na fila 1 é: {menorValor}");

                        media = fila2.CalcularMedia();
                        maiorValor = fila2.EncontrarMaiorValor();
                        menorValor = fila2.EncontrarMenorValor();

                        Console.WriteLine();
                        Console.WriteLine($"A média dos números na fila 2 é: {media}");
                        Console.WriteLine($"O maior valor na fila 2 é: {maiorValor}");
                        Console.WriteLine($"O menor valor na fila 2 é: {menorValor}");
                        Console.ReadLine();
                        break;

                    case 5:
                        qualFila = 0;
                        Console.Write("\nInforme de qual fila você deseja transferir os valores (1 ou 2): ");
                        qualFila = int.Parse(Console.ReadLine());

                        if (qualFila == 1)
                        {
                            fila3.transferirFila(fila1);
                        }
                        else if (qualFila == 2)
                        {
                            fila3.transferirFila(fila2);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida! Digite 1 ou 2.");
                        }
                        Console.WriteLine("\nValores transferidos para a fila 3!");
                        Console.WriteLine($"\nFila 3: ");
                        fila3.imprimirFila();
                        Console.ReadLine();
                        break;

                    case 6:
                        Console.WriteLine("\nValores ímpares das filas");

                        Console.WriteLine("\nValores ímpares na fila 1:");
                        fila1.imprimirValoresImpares();

                        Console.WriteLine("\nValores ímpares na fila 2:");
                        fila2.imprimirValoresImpares();

                        Console.ReadLine();
                        break;

                    case 7:
                        Console.WriteLine("\nValores pares das filas");

                        Console.WriteLine("\nValores pares na fila 1:");
                        fila1.imprimirValoresPares();

                        Console.WriteLine("\nValores pares na fila 2:");
                        fila2.imprimirValoresPares();
                        Console.ReadLine();
                        break;
                }

            } while (opc != 0);
        }
    }
}
