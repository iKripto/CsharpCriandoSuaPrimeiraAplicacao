// Screen Sound
//List<string> listaDeBandas = new List<string>{"U2", "Beatles", "Black Sabbath", "Charlie Brown Junior"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary <string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 6});
bandasRegistradas.Add("Beatles", new List<int> {10, 7, 4, 2});

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
    Console.WriteLine("Digite 0 para Sair");
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
            avaliarUmaBanda();
            break;
        case 4:
            exibirMediaBanda();
            break;
        case 0:
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
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine();
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoesDoMenu();
}

void mostrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas registradas");
    //for (int i = 0; i < listaDeBandas.Count; i++)
    //{
    //    Console.WriteLine($"Nome da banda: {listaDeBandas[i]}");
    //}

    foreach (var banda in bandasRegistradas)
    {
        string nome = banda.Key;      
        List<int> notas = banda.Value; 

        Console.WriteLine($"Banda: {nome}");

        foreach (int nota in notas)    
        {
            Console.WriteLine($"  Nota: {nota} \n");
        }
    }


    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void avaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    string NomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(NomeDaBanda))
    {
        Console.Write($"Qual nota a banda {NomeDaBanda} merece? | ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[NomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {NomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        exibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {NomeDaBanda} não foi encontrada. ");
        Console.WriteLine("Digite qualquer tecla para continuar. \n");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
    }
   
}

void exibirMediaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média da banda");
    Console.WriteLine("Digite o nome da banda que deseja ver a média: ");
    string NomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(NomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[NomeDaBanda];
        double media = notasDaBanda.Average();
        Console.WriteLine($"A média da banda {NomeDaBanda} é {media}");
        Console.WriteLine("Digite qualquer tecla para continuar. \n");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {NomeDaBanda} não foi encontrada. ");
        Console.WriteLine("Digite qualquer tecla para continuar. \n");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
    }
}

exibirOpcoesDoMenu();
