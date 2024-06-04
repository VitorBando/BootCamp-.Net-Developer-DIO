using PropriedadesMetodosConstrutores.Models;
using System.Globalization;

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
