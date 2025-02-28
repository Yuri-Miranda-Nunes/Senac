using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        int numero;

        Console.WriteLine("Digite números para somar. Digite 0 para encerrar.");

        do
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                soma += numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        } while (numero != 0);

        Console.WriteLine($"A soma de todos os números digitados é: {soma}");
    }
}