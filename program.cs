using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[8];
        string busca;
        bool encontrado = false;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Informe o nome: ");
            nomes[i] = Console.ReadLine();
        }

        Console.Write("Informe o nome para busca: ");
        busca = Console.ReadLine();

        for (int i = 0; i < 8; i++)
        {
            if (nomes[i] == busca)
            {
                Console.WriteLine("Encontrado na posição " + (i + 1));
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Estudante não encontrado.");
        }
    }
}