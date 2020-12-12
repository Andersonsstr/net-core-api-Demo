using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Demo.src.Model
{
    public class Usuario
    {
        public string nome { get; set; }
        public string idade { get; set; }

        public Usuario(string nome, string idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Usuario()
        {
        }
    }
}
