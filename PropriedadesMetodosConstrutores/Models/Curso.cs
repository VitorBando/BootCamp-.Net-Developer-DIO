using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count();
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {   
            Console.WriteLine($"Alunos do curso: {Nome}");
            
            for (int count = 0; count < Alunos.Count; count++);
            {
                string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto; // concatenação
                string texto2 = $"Nº {count + 1} - {Alunos[count].NomeCompleto}"; // interpolação mais ajuste da numeração 
                Console.WriteLine(texto);
                Console.WriteLine(texto2);
            }
        }
    }
}
