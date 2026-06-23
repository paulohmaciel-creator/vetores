using System;

class Program
{
    static void Main()
    {
        int[] num = new int[10];
        int pos = 0, neg = 0, zero = 0, par = 0, impar = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Informe um número: ");
            num[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            if (num[i] > 0) pos++;
            else if (num[i] < 0) neg++;
            else zero++;

            if (num[i] % 2 == 0) par++;
            else impar++;
        }

        Console.WriteLine("Positivos: " + pos);
        Console.WriteLine("Negativos: " + neg);
        Console.WriteLine("Zeros: " + zero);
        Console.WriteLine("Pares: " + par);
        Console.WriteLine("Ímpares: " + impar);
    }
}