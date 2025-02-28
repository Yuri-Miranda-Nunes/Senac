int[] numeros = { 15, 42, 7, 89, 33, 56 };

int maior = numeros[0];

foreach (int numero in numeros)
{
    if (numero > maior)
    {
        maior = numero; 
    }
}

Console.WriteLine("O maior valor no array é: " + maior);