namespace Exercicio2FilaNumeros
{
    internal class Numero
    {
        int valor;
        Numero proximo;

        public Numero(int valor)
        {
            this.valor = valor;
            proximo = null;
        }

        public override string ToString()
        {
            return "\n\nValor do número da fila: " + valor;
        }

        public void setNext(Numero numero)
        {
            proximo = numero;
        }

        public Numero getNext()
        {
            return proximo;
        }

        public int getValor()
        {
            return this.valor;
        }
    }
}
