class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album (string nome) 
    {
        nome = Nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome} - Duracao: {musica.Duracao}");
        }
        Console.WriteLine($"Duracao Total: {DuracaoTotal} segundos. ");
    }
}