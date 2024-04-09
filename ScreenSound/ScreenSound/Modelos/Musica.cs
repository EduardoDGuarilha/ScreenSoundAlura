namespace ScreenSound.Modelos;

internal class Musica : IAvaliavel
{
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public double Media
    {
        get => notas.Count == 0 ? 0 : notas.Average(a => a.Nota);
    }

    public string Nome { get; }

    public Banda Artista { get; }

    public int Duracao { get; set; }

    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
