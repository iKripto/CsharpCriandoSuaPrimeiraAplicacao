// Dicionários:
// Um Dictionary<TKey, TValue> é uma estrutura que armazena pares chave-valor.
// Chave(Key): é única. Não pode haver duas iguais.
// Valor (Value): é o dado associado à chave. Pode ser qualquer tipo.





// Criação de um dicionário vazio:
Dictionary<string, int> idades = new Dictionary<string, int>();


// Criação de um dicionário com valores:
Dictionary<string, int> idades = new Dictionary<string, int>()
{
    { "João", 20 },
    { "Maria", 30 }
};


// Adicionar valores:
idades.Add("Carlos", 25);


// Ler valor:
int idadeMaria = idades["Maria"];
Console.WriteLine(idadeMaria);


// Isso é equivalente a acessar um índice numa lista, porém usando o nome da chave:
// Lista:
lista[0]
// Dicionário:
dicionario["Maria"]


// Verificar se a chave existe:
if (idades.ContainsKey("João"))
{
    Console.WriteLine("A chave existe!");
}


// Remover:
idades.Remove("Carlos");


// Percorrer:
foreach (var item in idades)
{
    Console.WriteLine($"Nome: {item.Key}, Idade: {item.Value}");
}