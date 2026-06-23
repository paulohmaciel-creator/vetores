using System;

class Program
{
    static void Main()
    {
        double[] temp = new double[6];
        double soma = 0;

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Informe a temperatura: ");
            temp[i] = double.Parse(Console.ReadLine());
            soma += temp[i];
        }

        double media = soma / 6;
        int acima = 0;
        double maior = temp[0], menor = temp[0];

        for (int i = 0; i < 6; i++)
        {
            if (temp[i] > media) acima++;
            if (temp[i] > maior) maior = temp[i];
            if (temp[i] < menor) menor = temp[i];
        }

        Console.WriteLine("Média: " + media);
        Console.WriteLine("Dias acima da média: " + acima);
        Console.WriteLine("Maior temperatura: " + maior);
        Console.WriteLine("Menor temperatura: " + menor);
    }
}