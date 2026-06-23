using System;

class Program
{
    static void Main()
    {
        string[] tarefas = new string[5];
        int[] prioridade = new int[5];
        int baixa = 0, media = 0, alta = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Tarefa: ");
            tarefas[i] = Console.ReadLine();

            Console.Write("Prioridade: ");
            prioridade[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if (prioridade[i] == 1) baixa++;
            else if (prioridade[i] == 2) media++;
            else if (prioridade[i] == 3) alta++;
        }

        Console.WriteLine("Baixa: " + baixa);
        Console.WriteLine("Média: " + media);
        Console.WriteLine("Alta: " + alta);

        Console.WriteLine("Tarefas de alta prioridade:");
        for (int i = 0; i < 5; i++)
        {
            if (prioridade[i] == 3)
                Console.WriteLine("- " + tarefas[i]);
        }
    }
}