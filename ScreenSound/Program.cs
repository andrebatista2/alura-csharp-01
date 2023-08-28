List<string> listaBandas = new List<string>();

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

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!"); // Interpolação de Strings
    
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ListarBandas()
{
    Console.Clear();
    Console.WriteLine("Bandas registradas: ");
    for (int i = 0; i < listaBandas.Count; i += 1)
    {
        Console.WriteLine($"Nome da Banda: {listaBandas[i]}");
    }
    
    Thread.Sleep(2000);
    Console.WriteLine("\nPressione qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

// Screen Sound
ExibirOpcoesMenu();
