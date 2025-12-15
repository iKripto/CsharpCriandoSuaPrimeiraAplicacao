class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    // CORREÇÃO 1: O construtor é 'public Podcast', não 'class Podcast'
    public Podcast(string nome, string host)
    {
        // CORREÇÃO 2: Removemos o 'string' para atribuir à PROPRIEDADE, não criar uma variável nova
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        // O OrderBy funciona bem aqui (assumindo que System.Linq esteja importado)
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nTotal de Episódios: {TotalEpisodios}");
    }
}