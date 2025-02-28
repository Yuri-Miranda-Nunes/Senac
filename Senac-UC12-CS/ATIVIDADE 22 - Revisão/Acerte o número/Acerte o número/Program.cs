using System;

class Program
{
    static void Main()
    {

        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        Console.WriteLine("Bem-vindo ao jogo 'Adivinhe o Número'!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        bool acertou = false;
        int tentativas = 0;

 
        while (!acertou)
        {
            Console.Write("Digite seu palpite: ");
            string entrada = Console.ReadLine();


            if (int.TryParse(entrada, out int palpite))
            {
                tentativas++;

                if (palpite < numeroAleatorio)
                {
                    Console.WriteLine("O número é maior. Tente novamente.");
                }
                else if (palpite > numeroAleatorio)
                {
                    Console.WriteLine("O número é menor. Tente novamente.");
                }
                else
                {
                    acertou = true;
                    Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativa(s).");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }
    }
}