// usando classe Pessoa
using config_inicial.Models;

Pessoa p = new Pessoa();

p.Nome = "Vitor";
p.Idade = 24;
p.Apresentar();

// Declarando e Manipulando Variaveis
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

// Operadores de atribuição
int a = 10;
int b = 20;

int c = a + b;

Console.WriteLine(c);

// Combinando operadores
c += 5;

Console.WriteLine(c);

// Conversão de tipos de variáveis do tipo int
// Cast - Castin
int a2 = Convert.ToInt32("5");
a2 = int.Parse("5");

Console.WriteLine(a2);

// Convertendo para string
int inteiro = 5;
string k = inteiro.ToString();

Console.WriteLine(k);

// Cast implícito
int a3 = 5;
long b3 = a3;
double c3 = b3;

Console.WriteLine(c3);

int a4 = int.MaxValue;
long b4 = a4;

Console.WriteLine(a4);

// Order dos operadores
double a5 = 4 / (2 + 2);

Console.WriteLine(a5);

// Convertendo de maneira segura

string a6 = "15";

int b6 = 0;

int.TryParse(a6, out b6);

Console.WriteLine(b6);

