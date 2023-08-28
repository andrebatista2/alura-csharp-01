// List<string> listaBandas = new List<string> {"U2", "Beatles", "Black Sabbath"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Pink Floyd", new List<int> { 10, 10, 10 });
bandasRegistradas.Add("Linkin Park", new List<int>());

void ExibeCaracteres(string message = "Welcome to the Screen Sound app")
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(message);
}

void ExibirOpcoesMenu()
{
    ExibeCaracteres();
    Console.WriteLine("\n");
    Console.WriteLine("1 - Registrar uma Banda");
    Console.WriteLine("2 - Listar todas as Banda");
    Console.WriteLine("3 - Avaliar uma Banda");
    Console.WriteLine("4 - Exibir a média de uma Banda");
    Console.WriteLine("0 - Sair da aplicação");
    Console.WriteLine("\n");
    Console.Write("Digite a sua opção: ");

    int opcaoEscolhida = int.Parse(Console.ReadLine()!); // ! - Avoid the variable to receive null values

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            Console.WriteLine($"Foi digitada a opção {opcaoEscolhida}");
            break;
        case 4:
            Console.WriteLine($"Foi digitada a opção {opcaoEscolhida}");
            break;
        case 0:
            Console.WriteLine($"Foi digitada a opção {opcaoEscolhida}");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

void ExibirTituloOpcao(string titulo)
{
    int quantLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantLetras, '*');
    
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de Banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); // Adiciona uma banda no dicionário, com uma lista de notas vazias
    
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!"); // Interpolação de Strings
    
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Listagem das Bandas cadastradas");
    foreach (string registro in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Nome da Banda: {registro}");
    }
    
    Thread.Sleep(2000);
    Console.WriteLine("\nPressione qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

// Screen Sound Application
ExibirOpcoesMenu();
