using System;

class Program
{
    static void Main()
    {
        double[] gastos = new double[7];
        double total = 0, maior, menor;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Informe o gasto do dia: ");
            gastos[i] = double.Parse(Console.ReadLine());
        }

        maior = menor = gastos[0];

        for (int i = 0; i < 7; i++)
        {
            total += gastos[i];

            if (gastos[i] > maior) maior = gastos[i];
            if (gastos[i] < menor) menor = gastos[i];
        }

        double media = total / 7;

        Console.WriteLine("Total gasto na semana: R$ " + total);
        Console.WriteLine("Média diária: R$ " + media);
        Console.WriteLine("Maior gasto: R$ " + maior);
        Console.WriteLine("Menor gasto: R$ " + menor);
    }
}