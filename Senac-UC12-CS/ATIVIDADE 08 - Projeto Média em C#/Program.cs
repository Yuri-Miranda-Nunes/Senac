using System; // Importa o namespace System

namespace Aprendendo // Define um namespace chamado "Aprendendo"
{
    class media // Declara uma classe chamada "media"
    {
        static void Main(string[] args) // O código dentro deste método será executado quando o programa iniciar.
        {
            Console.Write("Digite o primeiro número decimal: "); // Faz a pergunta ao usuario sobre o primeiro numero com uma frase
            decimal num1 = Convert.ToDecimal(Console.ReadLine()); // Coleta o numero escrito e "aloca" ele como num1


            Console.Write(" Digite o segundo número "); // Faz a pergunta ao usuario sobre o segundo numero com uma frase
            decimal num2 = Convert.ToDecimal(Console.ReadLine()); // Coleta o numero escrito e "aloca" ele como num2

            decimal media = (num1 + num2) / 2; // Pega as variaveis armazenadas como num1 e num2, soma elas entre si e divide por 2

            Console.WriteLine($"A média de {num1} e {num2} é {media}"); // Monta uma frase falando qual foi num1 e num2 e finalizando com a media calculada
        }
    }
}