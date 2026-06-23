using System;

class Program
{
    static void Main()
    {
        int[] idades = new int[8];
        int menores = 0, maiores = 0;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Informe a idade do estudante: ");
            idades[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 8; i++)
        {
            if (idades[i] < 18)
                menores++;
            else
                maiores++;
        }

        Console.WriteLine("Quantidade de menores de idade: " + menores);
        Console.WriteLine("Quantidade de maiores de idade: " + maiores);
    }
}