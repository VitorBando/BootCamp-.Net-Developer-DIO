using PropriedadesMetodosConstrutores.Models;

Pessoa p1 = new Pessoa(nome:"Vitor", sobrenome:"Bando");
Pessoa p2 = new Pessoa(nome:"Ana", sobrenome:"Rocha");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


// Pessoa p1 = new Pessoa();

// p1.Nome = "Vitor";
// p1.Sobrenome = "Bando";
// p1.Idade = 25;
// p1.Apresentar();