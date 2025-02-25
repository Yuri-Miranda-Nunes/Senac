using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a temperatura em Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit:F2} °F");
    }
}