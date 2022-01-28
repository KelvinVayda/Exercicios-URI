using System;
using System.Globalization;
namespace URI_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());       //Entrada de Numeros Indeterminados//
            int soma = 0;
            int cont = 0;

            while (idade >= 0) //Enquanto idade for maior igual a 0, ou seja numeros positivos//
            {
                soma += idade; // Soma+idade
                cont++;        //cont +1
                idade = int.Parse(Console.ReadLine());
            }
            double media = (double)soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
