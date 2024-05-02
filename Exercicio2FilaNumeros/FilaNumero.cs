using System;

namespace Exercicio2FilaNumeros
{
    internal class FilaNumero
    {
        Numero headNumero;
        Numero tailNumero;
        int quantidadeNumeros;

        public FilaNumero()
        {
            this.headNumero = null;
            this.tailNumero = null;
            quantidadeNumeros = 0;
            Console.WriteLine("\nFila Criada!");
        }

        public int tamanhoFila()
        {
            return quantidadeNumeros;
        }

        public void push(Numero auxNumero)
        {
            if (Empty())
            {
                headNumero = auxNumero;
                tailNumero = auxNumero;
            }
            else
            {
                tailNumero.setNext(auxNumero);
                tailNumero = auxNumero;
            }
            quantidadeNumeros++;
        }

        bool Empty()
        {
            return headNumero == null;
        }

        public Numero pop()
        {
            if (Empty())
            {
                Console.WriteLine("Fila Vazia! Impossível Remover.");
                Console.Write("Pressione qualquer tecla para continuar:");
                Console.ReadKey();
                return null;
            }
            else
            {
                Numero numeroRemovido = headNumero;
                headNumero = headNumero.getNext();
                if (headNumero == null)
                {
                    tailNumero = null;
                }
                quantidadeNumeros--;
                return numeroRemovido;
            }
        }

        public Numero ProcurarPorNumero()
        {
            Numero numeroAtual = headNumero;
            Numero maiorNumero = numeroAtual;

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() > maiorNumero.getValor())
                {
                    maiorNumero = numeroAtual;
                }

                numeroAtual = numeroAtual.getNext();
            }

            return maiorNumero;
        }

        public double CalcularMedia()
        {
            if (Empty())
            {
                Console.WriteLine("Fila Vazia! Não é possível calcular a média.");
                return 0;
            }

            double soma = 0;
            Numero numeroAtual = headNumero;
            int contador = 0;

            while (numeroAtual != null)
            {
                soma += numeroAtual.getValor();
                contador++;
                numeroAtual = numeroAtual.getNext();
            }

            return soma / contador;
        }

        public double EncontrarMaiorValor()
        {
            if (Empty())
            {
                Console.WriteLine("Fila Vazia! Não há maior valor.");
                return 0;
            }

            Numero numeroAtual = headNumero;
            double maiorValor = numeroAtual.getValor();

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() > maiorValor)
                {
                    maiorValor = numeroAtual.getValor();
                }

                numeroAtual = numeroAtual.getNext();
            }

            return maiorValor;
        }

        public double EncontrarMenorValor()
        {
            if (Empty())
            {
                Console.WriteLine("Fila Vazia! Não há menor valor.");
                return 0;
            }

            Numero numeroAtual = headNumero;
            double menorValor = numeroAtual.getValor();

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() < menorValor)
                {
                    menorValor = numeroAtual.getValor();
                }

                numeroAtual = numeroAtual.getNext();
            }

            return menorValor;
        }

        public void transferirFila(FilaNumero filaOrigem)
        {
            while (!filaOrigem.Empty())
            {
                Numero numero = filaOrigem.pop();
                this.push(numero);
            }
        }

        public void imprimirFila()
        {
            Console.WriteLine("Valores na fila:");
            Numero numeroAtual = headNumero;
            while (numeroAtual != null)
            {
                Console.WriteLine(numeroAtual.getValor());
                numeroAtual = numeroAtual.getNext();
            }
        }

        public void imprimirValoresImpares()
        {
            Numero numeroAtual = headNumero;

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() % 2 != 0)
                {
                    Console.WriteLine(numeroAtual.getValor());
                }
                numeroAtual = numeroAtual.getNext();
            }
        }

        public void imprimirValoresPares()
        {
            Numero numeroAtual = headNumero;

            while (numeroAtual != null)
            {
                if (numeroAtual.getValor() % 2 == 0)
                {
                    Console.WriteLine(numeroAtual.getValor());
                }
                numeroAtual = numeroAtual.getNext();
            }
        }
    }
}
