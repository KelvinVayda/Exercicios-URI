using System;
using System.Globalization;

namespace URI_1118
{
    class Program
    {
        static void Main(string[] args)
        {
            int novoCalculo = 1; //Retorno De Entrada
            
            while (novoCalculo == 1) // Enquanto entrada for igual a 1 ou seja opção sim
            {
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0.0 || nota1 > 10.0) // Se a nota for fora de 0 a 10 nota invalida
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double media = (nota1 + nota2) / 2.0; // Resolução da média das notas
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao");
                novoCalculo = int.Parse(Console.ReadLine());
                while (novoCalculo != 1 && novoCalculo != 2)//Enquanto a opção for diferente de 1 ou 2, recebe um novo numero
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
