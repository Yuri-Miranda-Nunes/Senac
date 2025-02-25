float peso = float.Parse(Console.ReadLine());
float altura = float.Parse(Console.ReadLine());

float alt = altura * altura;
float IMC = peso / alt;

Console.WriteLine($"IMC = {IMC}");