// Screen Sound
List<string> listaDeBandas = new List<string>{"U2", "Beatles", "Black Sabbath", "Charlie Brown Junior"};

void ExibirLogo()
{
    Console.WriteLine(
        @"
            
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
        Boas vindas ao Screen Sound.
    "
    );
}

void exibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para Sair");
    Console.Write("Escolha uma opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            registrarBanda();
            break;
        case 2:
            mostrarBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção 3");
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção 4");
            break;
        case -1:
            Console.WriteLine("Você escolheu sair");
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
}

void registrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas: ");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine();
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoesDoMenu();
}

void mostrarBandas()
{
    Console.Clear();
    Console.WriteLine(@"
    *********************************
    *** Exibindo bandas registradas: 
    *********************************
    ");
    for (int i = 0; i < listaDeBandas.Count; i++)
    {
        Console.WriteLine($"Nome da banda: {listaDeBandas[i]}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();
}

exibirOpcoesDoMenu();
