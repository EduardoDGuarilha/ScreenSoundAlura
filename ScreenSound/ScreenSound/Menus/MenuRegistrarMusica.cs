using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite a banda cuja música deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write("Digite o nome da música: ");
                string nomeDaMusica = Console.ReadLine()!;
                Musica musica = new Musica(banda, nomeDaMusica);
                album.AdicionarMusica(musica);
                Console.WriteLine(
                    $"\nA música {nomeDaMusica} foi registrada com sucesso para o álbum {tituloAlbum} da banda {nomeDaBanda}"
                );
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
