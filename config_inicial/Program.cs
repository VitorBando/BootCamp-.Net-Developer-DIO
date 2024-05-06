using config_inicial.Models;

string aprensetacao = "Olá, seja bem vindo!";
int quantidade = 1;
quantidade = 10;
double altura = 1.80;
decimal salario = 9832.40M;
bool status = true;

Console.WriteLine("Valor da variável aprensetacao: " + aprensetacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável salario: " + salario);
Console.WriteLine("Valor da variável status: " + status);

DateTime dataAtual = DateTime.Now;
Console.WriteLine("Agora são: " + dataAtual);

dataAtual.AddDays(5);
Console.WriteLine("Daqui 5 dias será: " + dataAtual.ToString("dd/MM/yyyy"));

//Pessoa p = new Pessoa();
//
//p.Nome = "Vitor";
//p.Idade = 24;
//p.Apresentar();

