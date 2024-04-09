namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);

        if (nota < 0)
        {
            return new Avaliacao(0);
        }
        else if (nota > 10)
        {
            return new Avaliacao(10);
        }
        else
        {
            return new Avaliacao(nota);
        }
    }
}
