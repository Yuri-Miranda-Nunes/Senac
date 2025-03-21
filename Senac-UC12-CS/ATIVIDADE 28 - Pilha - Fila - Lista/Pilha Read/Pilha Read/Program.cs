using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma expressão com parênteses:");
        string expressao = Console.ReadLine();

        bool isValida = VerificarBalanceamento(expressao);

        if (isValida)
        {
            Console.WriteLine("A expressão é válida!");
        }
        else
        {
            Console.WriteLine("A expressão não é válida!");
        }
    }

    static bool VerificarBalanceamento(string expressao)
    {
        Stack<char> pilha = new Stack<char>();

        foreach (char caractere in expressao)
        {
            if (caractere == '(')
            {
                // Se for um parêntese aberto, adiciona à pilha
                pilha.Push(caractere);
            }
            else if (caractere == ')')
            {
                // Se for um parêntese fechado, verifica se há um correspondente na pilha
                if (pilha.Count == 0)
                {
                    // Se a pilha estiver vazia, significa que não há parêntese aberto correspondente
                    return false;
                }
                // Remove o último parêntese aberto da pilha
                pilha.Pop();
            }
        }

        return pilha.Count == 0;
    }
}