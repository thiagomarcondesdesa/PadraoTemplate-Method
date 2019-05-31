using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Produto
    {
        private int pro_codigo;
        private string pro_nome;
        private Double valor;
        private decimal estoque;

        public Produto()
        {
            this.Pro_codigo = 0;
            this.Pro_nome = "";
            this.Valor = 0;
            this.Estoque = 0;
        }

        public Produto(int pro_codigo, string pro_nome, Double valor, decimal estoque)
        {
            this.Pro_codigo = pro_codigo;
            this.Pro_nome = pro_nome;
            this.Valor = valor;
            this.Estoque = estoque;
        }

        public int Pro_codigo { get => pro_codigo; set => pro_codigo = value; }
        public string Pro_nome { get => pro_nome; set => pro_nome = value; }
        public Double Valor { get => valor; set => valor = value; }
        public decimal Estoque { get => estoque; set => estoque = value; }
    }
}
