class Album
{

    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao)/60;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {

        Console.WriteLine($"Lista de musicas do álbum {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}\n");
            Console.WriteLine($"Artista/Banda: {musica.Artista.Nome}\n");
            Console.WriteLine($"Genero: {musica.GeneroMusical.Nome}\n");
            Console.WriteLine($"Duração: {musica.Duracao/60} Min\n");
            Console.WriteLine("-----------------------------");


        }

        Console.WriteLine($"Duração total do álbum: {DuracaoTotal} min");
    }

}