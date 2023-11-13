class Banda
{

    public Banda(string nome)
    {
       Nome = nome; 
    }

    public string Nome { get; }
    private List<Album> albums = new List<Album>();


    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografica da banda {Nome}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome}");
        }
    }
}