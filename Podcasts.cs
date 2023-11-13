using System.Dynamic;

class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host {get;}
    public string Nome { get;}

    private List<Episodio> episodios = new();

    public int TotalDeEpisodios => episodios.Count;

    public void AdicionarEpisodio (Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibisDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} aprensentado por {Host}\n");

        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"Este pode cast possui {TotalDeEpisodios} episódios.");
    }
}