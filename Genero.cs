class GeneroMusical
{
    public string Nome { get; set; }

    private List<Musica> musicas = new List<Musica>();

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoGenero()
    {
        Console.WriteLine($"\nMusicas do Genero {Nome}\n");

        foreach(var musica in musicas)
        {
            Console.WriteLine($"Nome da música: {musica.Nome}");
        }
    }

}