class Musica
{

    public Musica (Banda artista, string nome, int duracao, bool disponivel)
    {
        Artista = artista;
        Nome = nome;
        Duracao = duracao;
        Disponivel = disponivel;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; }
    public bool Disponivel { get; }

    public string DescricaoResumida { 
        get 
        {
            return $"A música {Nome} pertence a banda {Artista}";
         }
    }

    public void exibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (Disponivel)
        {
            Console.WriteLine("A música está disponível para reprodução.");
        }
        else
        {
            Console.WriteLine("A música não está disponível para reprodução.");
        }
    }
}