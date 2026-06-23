using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main()
    {
        double[] notas = new double[5];
        double soma = 0;
        double media;

        // Entrada de dados
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Informe a nota: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        // Processamento (soma)
        for (int i = 0; i < 5; i++)
        {
            soma += notas[i];
        }

        // Cálculo da média
        media = soma / 5;

        // Saída
        Console.WriteLine("Soma das notas: " + soma);
        Console.WriteLine("Média final: " + media);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
