using ScreenSound.Menus;
using ScreenSound.Modelos;

Dictionary<string, Banda> bandasRegistradas = new();

Dictionary<int, Menu> opcoes =
    new()
    {
        { 1, new MenuRegistrarBanda() },
        { 2, new MenuRegistrarAlbum() },
        { 3, new MenuRegistrarMusica() },
        { 4, new MenuMostrarBandasRegistradas() },
        { 5, new MenuAvaliarBanda() },
        { 6, new MenuAvaliarAlbum() },
        { 7, new MenuAvaliarMusica() },
        { 8, new MenuExibirDetalhes() },
        { -1, new MenuSair() }
    };

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
"
    );
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para registrar uma música");
    Console.WriteLine("Digite 4 para mostrar todas as bandas");
    Console.WriteLine("Digite 5 para avaliar uma banda");
    Console.WriteLine("Digite 6 para avaliar um álbum");
    Console.WriteLine("Digite 7 para avaliar uma música");
    Console.WriteLine("Digite 8 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menu = opcoes[opcaoEscolhidaNumerica];
        menu.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0)
            ExibirOpcoesDoMenu();
    }
    else
    {
        Console.Write("Escolha inválida! Tente outra opção.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
ExibirOpcoesDoMenu();
