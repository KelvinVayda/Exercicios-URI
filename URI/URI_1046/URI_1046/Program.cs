using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vet[0]);
            int fim = int.Parse(vet[1]);

            int duracao;
            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
