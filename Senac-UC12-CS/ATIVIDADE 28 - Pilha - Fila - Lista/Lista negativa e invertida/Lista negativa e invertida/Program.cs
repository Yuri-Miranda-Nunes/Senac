using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<int> pilha = new List<int> { 10, -5, 7, -3, 0 };

        Console.WriteLine("Pilha inicial: " + string.Join(", ", pilha));

        List<int> pilhaFiltrada = new List<int>();
        while (pilha.Count > 0)
        {
            int numero = pilha[pilha.Count - 1]; // Pega o último elemento
            pilha.RemoveAt(pilha.Count - 1);     // Remove o último elemento
            if (numero >= 0)                     // Verifica se é positivo ou zero
            {
                pilhaFiltrada.Add(numero);       // Adiciona à nova pilha filtrada
            }
        }

        Console.WriteLine("Pilha após remover números negativos: " + string.Join(", ", pilhaFiltrada));

        List<int> pilhaInvertida = new List<int>();
        while (pilhaFiltrada.Count > 0)
        {
            int numero = pilhaFiltrada[pilhaFiltrada.Count - 1]; // Pega o último elemento
            pilhaFiltrada.RemoveAt(pilhaFiltrada.Count - 1);      // Remove o último elemento
            pilhaInvertida.Add(numero);                          // Adiciona à pilha invertida
        }

        Console.WriteLine("Pilha invertida: " + string.Join(", ", pilhaInvertida));
    }
}