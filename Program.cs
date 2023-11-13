Episodio ep1 = new(1, "Técnicas de facilitação", 2700);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Eduardo");
ep1.AdicionarConvidados("Juliana");

Episodio ep2 = new(2, "Técnicas de aprendizado", 4520);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Renato");
ep2.AdicionarConvidados("Catia");

Podcast podcast = new("Daniel", "Especial");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibisDetalhes();
