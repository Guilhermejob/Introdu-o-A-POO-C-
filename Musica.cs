class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;

    }

    public string Nome {get;}
    public Banda Artista {get;}
    public int Duracao {get; set;}
    public bool Disponivel {get; set;}
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";
    public GeneroMusical GeneroMusical {get; set;}


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}"); 
        Console.WriteLine($"Duração: {Duracao/60} min");
        Console.WriteLine($"Genero: {GeneroMusical}");

        if(Disponivel)
        {
            Console.WriteLine("Dísponivel no plano Normal");
        }else
        {
            Console.WriteLine("Dísponivel no plano Plus+");
        }
        
    }
}
