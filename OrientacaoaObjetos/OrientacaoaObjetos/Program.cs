Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life", 234, true);

Musica musica2 = new Musica(queen, "Bohemian Rhapsody", 354, false);

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

musica1.exibirFichaTecnica();
musica2.exibirFichaTecnica();

albumDoQueen.ExibirMusicas();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();