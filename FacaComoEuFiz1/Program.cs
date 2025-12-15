/* 
Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os conhecimentos adquiridos.
Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o número gerado pelo programa.
O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o jogo acabou.
*/

Console.WriteLine("Adivinhe o número entre 1 a 100!");
Console.WriteLine("Você tem 10 tentativas!");
Random rnd = new Random();
int numero = rnd.Next(1, 100);
int tentativas = 0;

while (tentativas < 10)
{
    Console.Write("Digite um numero: ");
    string escolha = Console.ReadLine()!;
    int escolhaInt = int.Parse(escolha);

    if (escolhaInt > numero)
    {
        Console.WriteLine("O número é menor!");
    } 
    else if (escolhaInt < numero)
    {
        Console.WriteLine("O número é maior!");
    }
    else
    {
        Console.WriteLine("Parabéns, você acertou! O número era: " + numero);
        break;
    }
}