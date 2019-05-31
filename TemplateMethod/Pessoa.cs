using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Pessoa
    {
        private int id;
        private string nome;


        public Pessoa()
        {
            this.id = 0;
            this.nome = "";
        }

        public Pessoa(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
