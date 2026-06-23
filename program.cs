using System;

class Program
{
    static void Main()
    {
        int[] votos = new int[12];
        int pizza = 0, hamburguer = 0, pastel = 0;

        for (int i = 0; i < 12; i++)
        {
            Console.Write("Informe o voto: ");
            votos[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 12; i++)
        {
            if (votos[i] == 1) pizza++;
            else if (votos[i] == 2) hamburguer++;
            else if (votos[i] == 3) pastel++;
        }

        Console.WriteLine("Pizza: " + pizza);
        Console.WriteLine("Hambúrguer: " + hamburguer);
        Console.WriteLine("Pastel: " + pastel);
    }
}