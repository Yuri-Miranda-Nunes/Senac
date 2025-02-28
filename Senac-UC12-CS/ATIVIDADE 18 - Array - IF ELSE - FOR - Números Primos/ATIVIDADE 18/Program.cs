using System; // Importa o namespace System

class Program
{
    static void Main()
    {
        // Declaração e inicialização do array de números
        int[] numeros = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 2, 3, 3, 13 };

        // Arrays para armazenar primos e não primos
        int[] primos = new int[numeros.Length];
        int[] naoPrimos = new int[numeros.Length];

        // Arrays para contar ocorrências
        int[] valoresUnicos = new int[numeros.Length];
        int[] contagemOcorrencias = new int[numeros.Length];

        // Índices para os arrays
        int indicePrimos = 0;
        int indiceNaoPrimos = 0;
        int indiceOcorrencias = 0;

        // Percorre o array de números
        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i]; // Obtém o número atual

            // Verifica se o número é primo
            if (EhPrimo(numero))
            {
                primos[indicePrimos] = numero; // Adiciona o número ao array de primos
                indicePrimos++; // Incrementa o índice de primos
            }
            else
            {
                naoPrimos[indiceNaoPrimos] = numero; // Adiciona o número ao array de não primos
                indiceNaoPrimos++; // Incrementa o índice de não primos
            }

        }

        // Conta as ocorrências
        bool encontrado = false; // Flag para verificar se o número já foi encontrado
        for (int j = 0; j < indiceOcorrencias; j++)
        {
            if (valoresUnicos[j] == numero)
            {
                contagemOcorrencias[j]++; // Incrementa a contagem de ocorrências
                encontrado = true; // Marca como encontrado
                break; // Sai do loop
            }
        }

        if (!encontrado)
        {
            valoresUnicos[indiceOcorrencias] = numero; // Adiciona o número ao array de valores únicos
            contagemOcorrencias[indiceOcorrencias] = 1; // Inicializa a contagem de ocorrências
            indiceOcorrencias++; // Incrementa o índice de ocorrências
        }

        // Redimensiona os arrays para remover posições não utilizadas
        Array.Resize(ref primos, indicePrimos);
        Array.Resize(ref naoPrimos, indiceNaoPrimos);
        Array.Resize(ref valoresUnicos, indiceOcorrencias);
        Array.Resize(ref contagemOcorrencias, indiceOcorrencias);

        // Exibe os resultados
        Console.WriteLine("Números primos: [" + string.Join(", ", primos) + "]");
        Console.WriteLine("Números não primos: [" + string.Join(", ", naoPrimos) + "]");
        Console.WriteLine("Ocorrências:");
        for (int i = 0; i < valoresUnicos.Length; i++)
        {
            Console.WriteLine($"- {valoresUnicos[i]}: {contagemOcorrencias[i]} vez(es)");
        }

        // Função para verificar se um número é primo
        static bool EhPrimo(int numero)
        {
            if (numero < 2)
                return false; // Números menores que 2 não são primos

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false; // Se divisível por i, não é primo
            }
            return true; // Se não divisível por nenhum i, é primo


        }

    }


}
