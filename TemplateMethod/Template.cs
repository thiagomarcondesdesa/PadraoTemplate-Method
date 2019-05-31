using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Template : Auxiliar
    {
        private int id;
        private DateTime data;
        private Double valortotal;
        private Pessoa pessoa;
        private List<Produto> itens;

        protected Template()
        {
            this.id = 0;
            this.data = DateTime.Now;
            this.valortotal = 0.00;
            this.Pessoa = null;
            this.itens = new List<Produto>();
        }
        protected Template(int id, DateTime data, Double valortotal, Pessoa pessoa, List<Produto> itens)
        {
            this.id = id;
            this.data = data;
            this.valortotal = valortotal;
            this.Pessoa = pessoa;
            this.itens = itens;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public Double Valortotal { get => valortotal; set => valortotal = value; }
        internal List<Produto> Itens { get => itens; set => itens = value; }
        internal Pessoa Pessoa { get => pessoa; set => pessoa = value; }

        public sealed override void gravar(int id, DateTime data, Pessoa p)
        {      
            //if (p.GetType() == typeof(Cliente))
            //{
            //    p = new Cliente();               
            //}
            //else if (p.GetType() == typeof(Fornecedor))
            //{
            //    p = new Fornecedor();                            
            //}
            Id = id;
            Data = data;
            Pessoa = p;
        }

        public abstract void atualizaEstoque(Produto produto, decimal quantidade);

        public void addItem(Produto produto, decimal quantidade)
        {
            produto.Estoque -= quantidade;
            if (!itens.Contains(produto))
            {           
                Itens.Add(produto);
            }
            Valortotal += produto.Valor;
        }

        public void removeItem(Produto produto, decimal quantidade)
        {
            produto.Estoque += quantidade;
            if (!itens.Contains(produto))
            {
                Itens.Add(produto);
            }
            Valortotal += produto.Valor;
        }

    }
}
