using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace config_inicial.Models
{
    public class Pessoa
    {
        //public string NomeRepLegal { get; set; } Nome de Atributo Abreviado
        //public string NomeRepresentanteLegaL { get; set; } Nome de Atributo Inteiro
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
            //Console.WriteLine($"Olá, meu nome é {Nome}\nE tenho {Idade} anos."); pulando linha com "\n"
        }
    }
}