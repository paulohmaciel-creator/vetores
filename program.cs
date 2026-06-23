using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] precos = new double[5];
        double total = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Preço: ");
            precos[i] = double.Parse(Console.ReadLine());
        }

        double maior = precos[0], menor = precos[0];
        int iMaior = 0, iMenor = 0;

        for (int i = 0; i < 5; i++)
        {
            total += precos[i];

            if (precos[i] > maior)
            {
                maior = precos[i];
                iMaior = i;
            }

            if (precos[i] < menor)
            {
                menor = precos[i];
                iMenor = i;
            }
        }

        Console.WriteLine("Mais caro: " + nomes[iMaior] + " R$ " + maior);
        Console.WriteLine("Mais barato: " + nomes[iMenor] + " R$ " + menor);
        Console.WriteLine("Total: R$ " + total);
    }
}