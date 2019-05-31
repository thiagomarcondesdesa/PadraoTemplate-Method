using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Fornecedor : Pessoa
    {
        private string cnpj;
        private string inscricao;

        public Fornecedor() : base()
        {
            Id = 0;
            Nome = "";
            this.Cnpj = "";
            this.Inscricao = "";
        }

        public Fornecedor(int id, string nome, string cnpj, string inscricao):base(id,nome)
        {
            Id = id;
            Nome = nome;
            this.Cnpj = cnpj;
            this.Inscricao = inscricao;
        }

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Inscricao { get => inscricao; set => inscricao = value; }
    }
}
