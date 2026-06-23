using System;

class Program
{
    static void Main()
    {
        double[] horas = new double[7];
        double total = 0;
        int meta = 0, naoMeta = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Informe as horas estudadas no dia: ");
            horas[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 7; i++)
        {
            total += horas[i];

            if (horas[i] >= 2)
                meta++;
            else
                naoMeta++;
        }

        Console.WriteLine("Total de horas: " + total);
        Console.WriteLine("Dias com meta atingida: " + meta);
        Console.WriteLine("Dias sem meta: " + naoMeta);
    }
}