Console.WriteLine("Digite um número inteiro positivo: ");
int n = int.Parse(Console.ReadLine());

int soma = 0;

for (int i = 1; i <= n; i++)
{
    soma += i;
}

Console.WriteLine($"A soma dos primeiros {n} números é: {soma}");