using PropriedadesMetodosConstrutores.Models;
using System.Globalization;


// Estrutura de dados dicionario chave,valor
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - Alterado";

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o Elemento {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}


// Estruta de dados pilha LIFO
Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(3);
pilha.Push(5);
pilha.Push(7);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o item do topo {pilha.Pop()}");
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

// Estruta de dados fila FIFO
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);
fila.Enqueue(6);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

// implementando exceções
new ExemploExcecao().Metodo1();

// Introdução exceções
try{
string[] linhas  = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}
} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Aconteceu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui.");
}


// Alterando a região do código
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// Personalizando no time DateTime
DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// formatando para apenas data
Console.WriteLine(data.ToShortDateString());
// formatando para apenas hora
Console.WriteLine(data.ToShortTimeString());
                  
// Personalizando um tipo de valor ex: cpf
int numero = 01234567890;
Console.WriteLine(numero.ToString("###.###.###-##"));

// Formato de %
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

decimal valorMonetario = 82.40M;
Console.WriteLine($"{valorMonetario:C}");
// Alterando região/cultura para uma parte do código
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
// Personalizando a formatação
Console.WriteLine(valorMonetario.ToString("C8"));



// Concatenado valores
string numero1 = "10";
string numero2 = "20";

string resultado = numero1 + numero2;

Console.WriteLine(resultado);

Pessoa p1 = new Pessoa(nome:"Vitor", sobrenome:"Bando");
Pessoa p2 = new Pessoa(nome:"Ana", sobrenome:"Rocha");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


Pessoa p3 = new Pessoa();

p3.Nome = "Vitor";
p3.Sobrenome = "Bando";
p3.Idade = 25;
p3.Apresentar();
