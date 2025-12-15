Episodio ep1 = new Episodio(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new Episodio(1, "Técnicas de aprendizado", 45);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcela");
ep2.AdicionarConvidados("João");

Podcast podcast = new Podcast("Flowda-se podcre", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();