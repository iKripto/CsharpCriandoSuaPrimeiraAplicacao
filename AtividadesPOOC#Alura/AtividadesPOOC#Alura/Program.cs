
// Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
// Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.

Conta Conta1 = new Conta();
Conta1.NIndicador = 12345;
Conta1.Titular = "João Silva";
Conta1.Saldo = 2500.75;
Conta1.Senha = "senha123";

// Desenvolver um método da classe Conta que exibe suas informações.

public class Conta
{
    public int NIndicador;
    public string Titular;
    public double Saldo;
    public string Senha;
}

// Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

public class Carro
{
    public string cor;
    public int ano;
    public string modelo;
    public string marca;

    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando.");
    }

    public void Frear()
    {
        Console.WriteLine("O carro está freando.");
    }

    public void Buzinar()
    {
        Console.WriteLine("Bibi.");
    }

}