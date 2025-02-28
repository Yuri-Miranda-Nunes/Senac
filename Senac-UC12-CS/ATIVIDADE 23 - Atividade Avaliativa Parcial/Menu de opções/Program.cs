using System; 

class Programa
{
    static void Main()
    {
        string[] nomes = new string[10];
        string[] especies = new string[10];
        double[] precos = new double[10];
        string[] opcoes = { "Cadastrar Animal", "Cadastrar Cliente", "Registrar Venda", "Exibir Animais Disponíveis", "Exibir Clientes Cadastrados", "Sair" };
        bool executando = true;
        int contador = 0;
        string[] nomesClientes = new string[10];
        string[] telefones = new string[10];
        int contadorClientes = 0;


        while (executando)
        {
            Console.WriteLine("=== Loja de Pets ===");
            
            for (int i = 0; i < opcoes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {opcoes[i]}");
            }

            
            Console.WriteLine("Escolha uma opção (1-6): ");
            string escolha = Console.ReadLine(); 

            
            if (escolha == "1")
            {
                if (contador < nomes.Length)
                {
                    Console.Write("Digite o nome do animal: ");
                    nomes[contador] = Console.ReadLine();

                    Console.Write("Digite a espécie do animal: ");
                    especies[contador] = Console.ReadLine();

                    Console.Write("Digite o preço do animal: ");
                    while (!double.TryParse(Console.ReadLine(), out precos[contador]) || precos[contador] <= 0)
                    {
                        Console.WriteLine("Preço inválido! Digite um valor positivo:");
                    }

                    contador++;
                    Console.WriteLine("Cachorro adicionado com sucesso!");
                }
                else
                {
                    Console.WriteLine("A lista está cheia! Não é possível adicionar mais cachorros.");
                }
            }
            else if (escolha == "2")
            {
                if (contadorClientes < nomesClientes.Length)
                {
                    Console.Write("Digite o nome do cliente: ");
                    nomesClientes[contadorClientes] = Console.ReadLine();

                    Console.Write("Digite o telefone do cliente: ");
                    telefones[contadorClientes] = Console.ReadLine();

                    contadorClientes++;
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("A lista de clientes está cheia!");
                }
            }
            else if (escolha == "3")
            {
                if (contador == 0 || contadorClientes == 0)
                {
                    Console.WriteLine("Não é possível registrar uma venda. Certifique-se de que há animais e clientes cadastrados.");
                }
                else
                {
                    Console.WriteLine("Selecione o animal vendido:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"{i + 1}: {nomes[i]} ({especies[i]}) - R$ {precos[i]:F2}");
                    }
                    Console.Write("Digite o número do animal: ");
                    int indiceAnimal;
                    while (!int.TryParse(Console.ReadLine(), out indiceAnimal) || indiceAnimal < 1 || indiceAnimal > contador)
                    {
                        Console.WriteLine("Opção inválida! Digite o número correspondente ao animal:");
                    }
                    string animalSelecionado = nomes[indiceAnimal - 1];

                    Console.WriteLine("Selecione o cliente:");
                    for (int i = 0; i < contadorClientes; i++)
                    {
                        Console.WriteLine($"{i + 1}: {nomesClientes[i]} - {telefones[i]}");
                    }
                    Console.Write("Digite o número do cliente: ");
                    int indiceCliente;
                    while (!int.TryParse(Console.ReadLine(), out indiceCliente) || indiceCliente < 1 || indiceCliente > contadorClientes)
                    {
                        Console.WriteLine("Opção inválida! Digite o número correspondente ao cliente:");
                    }
                    string clienteSelecionado = nomesClientes[indiceCliente - 1];

                    Console.WriteLine($"Venda registrada com sucesso!");
                }
            }
            else if (escolha == "4")
            {
                if (contador > 0)
                {
                    Console.WriteLine("Cachorros na lista:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"{i + 1}: {nomes[i]} ({especies[i]}) - R$ {precos[i]:F2}");
                    }
                }
                else
                {
                    Console.WriteLine("A lista está vazia.");
                }
            }
            else if (escolha == "5")
            {
                if (contadorClientes > 0)
                {
                    Console.WriteLine("Clientes cadastrados:");
                    for (int i = 0; i < contadorClientes; i++)
                    {
                        Console.WriteLine($"{i + 1} {nomesClientes[i]} {telefones[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados.");
                }
            }
            else if (escolha == "6")
            {
                executando = false; 
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente."); 
            }

            Console.WriteLine(); 
        }

        Console.WriteLine("Programa encerrado."); 
    }
}
