using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Compra : Template
    {
        private Fornecedor fornecedor;

        internal Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }

        public override void atualizaEstoque(Produto produto, decimal quantidade)
        {
            if (quantidade > 0)
                produto.Estoque += quantidade;
        }
    }
}
