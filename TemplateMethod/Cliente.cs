using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Cliente :  Pessoa
    {
        private string cpf;
        private string rg;

        public Cliente() : base()
        {
            Id = 0;
            Nome = "";
            this.Cpf = "";
            this.Rg = "";
        }

        public Cliente(int id,string nome,string cpf, string rg):base(id,nome)
        {
            Id = id;
            Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
    }
}
