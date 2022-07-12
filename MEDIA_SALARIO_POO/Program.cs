using System;
using System.Globalization;

namespace MEDIA_SALARIO_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FUNCIONARIO f1 = new FUNCIONARIO();
            FUNCIONARIO f2 = new FUNCIONARIO();
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine($"O salário médio é {media.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
    }
}
