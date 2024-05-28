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

// Operador Condicional IF|ELSE IF| ELSE na prática

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}

else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else 
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

// Aprendendo Switch case

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine(); // Entrada de dados via terminal

// V3

switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":  
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é vogal");
        break;
}

// V2

if (
    letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u"
)
{
    Console.WriteLine("Vogal");
}
else
{  
    Console.WriteLine("Não é vogal");
}

// V1

if (letra == "a")
{
    Console.WriteLine("Vogal");
}
else if (letra == "e")
{
    Console.WriteLine("Vogal");
}
else if (letra == "i")
{
    Console.WriteLine("Vogal");
}
else if (letra == "o")
{
    Console.WriteLine("Vogal");
}
else if (letra == "u")
{
    Console.WriteLine("Vogal");
}
else 
{
    Console.WriteLine("Não é uma vogal");
}

// Operadores lógicos

// OR (||)
bool maiorIdade = true;
bool temAutorizacaoResponsavel = false;

if (maiorIdade || temAutorizacaoResponsavel)
{
    Console.WriteLine("Entrada Autorizada!");
}
else
{
    Console.WriteLine("Entrada não permitida");
}

// AND (&&)

bool presencaMinima = true;
double media = 7.5;

if (presencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

// NOT (!)

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar outro dia!");
}


// Operadores Aritméticos e a classe Math
Calculadora calc = new Calculadora();

calc.Somar(573,974);
calc.Subtrair(942,654);
calc.Multiplicar(9,87);
calc.Divisao(10,5);

calc.Potencia(3,3);

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

calc.RaizQuadrada(9);

// Incremento e Decremento

int numero = 10;

Console.WriteLine(numero);
Console.WriteLine("Incrementando o numero 10");
numero ++;
Console.WriteLine(numero);
Console.WriteLine("Decremantando o numero 10 duas vezes");
numero --;
numero --;
Console.WriteLine(numero);


// Estrutura de Repetição

//FOR

int numero1 = 5;

for(int contador1 = 0; contador1 <= 10; contador1++)
{
    Console.WriteLine($"{numero1} x {contador1} = {numero1 * contador1}");
}

//WHILE 

int numero2 = 5; 
int contador2 = 1;

while (contador2 < 10)
{
    Console.WriteLine($"{contador2}° Execução: {numero2} x {contador2} = {numero2 * contador2}");
    contador2++;

    if (contador2 == 5)
    {
        break;
    }
}

// DO WHILE

int soma = 0, numero3 = 0;

do 
{
    Console.WriteLine("Digite um número: (0 para parar)");
    numero  = Convert.ToInt32(Console.ReadLine());

    soma += numero3;

} while (numero3 != 0);

Console.WriteLine($"Total de soma dos números digitados é: {soma}");

// CONSTRUINDO MENU INTERATIVO

string opcao;
bool exibirMenu = true;
while (exibirMenu)
{   
    Console.Clear();
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente: ");
    Console.WriteLine("2 - Buscar cliente: ");
    Console.WriteLine("3 - Apagar cliente: ");
    Console.WriteLine("4 - Encerrar: ");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apaga cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            // Environment.Exit(0); refatorado
            exibirMenu = false;
            break;
        
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    
}

Console.WriteLine("O programa se encerrou");


int[] arrayInteiros = new int[4];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Aumentando o tamanho do array

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Console.WriteLine("Percorrendo Array com o For");
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo Array com o ForEach");
int contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
    contadorForeach++;
}

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");


// Testando implementações das listas
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

Console.WriteLine("Percorrendo Lista com o For");
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}
Console.WriteLine("Percorrendo Lista com o ForEach");
foreach (string item in listaString)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {item}");
    contadorForeach++;
}