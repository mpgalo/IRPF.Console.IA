using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o seu salário: ");
        decimal salario = decimal.Parse(Console.ReadLine());

        decimal baseCalculo = salario;
        decimal aliquota = 0;
        decimal deducao = 0;

        if (baseCalculo <= 2259.20m)
        {
            aliquota = 0;
            deducao = 0;
        }
        else if (baseCalculo <= 2826.65m)
        {
            aliquota = 0.075m;
            deducao = 169.44m;
        }
        else if (baseCalculo <= 3751.05m)
        {
            aliquota = 0.15m;
            deducao = 381.44m;
        }
        else if (baseCalculo <= 4664.68m)
        {
            aliquota = 0.225m;
            deducao = 662.77m;
        }
        else
        {
            aliquota = 0.275m;
            deducao = 896.00m;
        }

        decimal imposto = baseCalculo * aliquota - deducao;

        Console.WriteLine($"O imposto de renda calculado é: {imposto}");
    }
}