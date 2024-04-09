using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarMusica : Menu
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
                if (album.Musicas.Any(a => a.Nome.Equals(nomeDaMusica)))
                {
                    Musica musica = new Musica(banda, nomeDaMusica);
                    Console.Write($"Qual a nota que a música {nomeDaMusica} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    musica.AdicionarNota(nota);
                    Console.WriteLine(
                        $"\nA nota {nota.Nota} foi registrada com sucesso para a música {nomeDaMusica} do álbum {tituloAlbum}, da banda {nomeDaBanda}"
                    );
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nA música {nomeDaMusica} não foi encontrada!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
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
