using System;
using System.Globalization;
namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codA, qtdA, qtdB;
            double codB, valorA, valorB, TOTAL;

            string[] vetA = Console.ReadLine().Split(' ');
            codA = int.Parse(vetA[0]);
            qtdA = int.Parse(vetA[1]);
            valorA = double.Parse(vetA[2], CultureInfo.InvariantCulture);

            string[] vetB = Console.ReadLine().Split(' ');
            codB = int.Parse(vetB[0]);
            qtdB = int.Parse(vetB[1]);
            valorB = double.Parse(vetB[2], CultureInfo.InvariantCulture);

            TOTAL = (qtdA * valorA) + (qtdB * valorB);

            Console.WriteLine("VALOR A PAGAR: R$ " + TOTAL.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
