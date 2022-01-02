using System;
using System.Globalization;
namespace URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double porc = 15.0;
            double novoSal, valorporc;
            if (valor <= 400.0) //  *******400.00
            {
                valorporc = valor * porc / 100.0;
                novoSal = valor + valorporc;
                Console.WriteLine("Novo salario: " + novoSal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorporc.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porc + " %");
            }
            else if (valor >= 400.01 && valor <= 800.00) //  *******800.00
            {
                porc = 12.0;
                valorporc = valor * porc / 100.0;
                novoSal = valor + valorporc;
                Console.WriteLine("Novo salario: " + novoSal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorporc.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porc + " %");
            }

            else if (valor >= 800.01 && valor <= 1200.00) //  *******1200.00
            {
                porc = 10.0;
                valorporc = valor * porc / 100.0;
                novoSal = valor + valorporc;
                Console.WriteLine("Novo salario: " + novoSal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorporc.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porc + " %");
            }
            else if (valor >= 1200.01 && valor <= 2000.00) //  *******2000.00
            {
                porc = 7.0;
                valorporc = valor * porc / 100.0;
                novoSal = valor + valorporc;
                Console.WriteLine("Novo salario: " + novoSal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorporc.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porc + " %");
            }
            else if (valor > 2000.00) //  *******Acima de 2000.00
            {
                porc = 4.0;
                valorporc = valor * porc / 100.0;
                novoSal = valor + valorporc;
                Console.WriteLine("Novo salario: " + novoSal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorporc.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porc + " %");
            }
        }
    }
}