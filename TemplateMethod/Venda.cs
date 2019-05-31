using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Venda : Template
    {
        private Cliente cliente;

        internal Cliente Cliente { get => cliente; set => cliente = value; }

        public override void atualizaEstoque(Produto produto, decimal quantidade)
        {
            if (quantidade>0)
                produto.Estoque -= quantidade;
        }
    }
}
