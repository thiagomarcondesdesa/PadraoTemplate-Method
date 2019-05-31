using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(1, "Thiago", "111.111.111-11", "22.222.222-2");
            Fornecedor fornecedor1 = new Fornecedor(2, "MICROSOFT SA", "45.555.666/0001-22", "333.366.445-6");


            Produto produto1 = new Produto(1, "MOUSE", 25.5, 10);
            Produto produto2 = new Produto(2, "MONITOR", 350, 10);
            Produto produto3 = new Produto(3, "TECLADO", 19.9, 10);

            Console.WriteLine("*** Estoque Inicial *** \n");
            Console.WriteLine("Produto : " + produto1.Pro_codigo.ToString()+        
                              "Nome: "+produto1.Pro_nome+
                              "Estoque: "+produto1.Estoque.ToString()+"\n");



            Venda venda1 = new Venda();                                    
            venda1.addItem(produto1,2);
            venda1.addItem(produto2,4);
            venda1.addItem(produto3,6);

            venda1.gravar(10,DateTime.Now,cliente1);

            Compra compra1 = new Compra();
            compra1.Data = DateTime.Now;
            compra1.addItem(produto1, 1);
            compra1.addItem(produto2, 2);
            compra1.addItem(produto3, 3);
            compra1.gravar(20, DateTime.Now, fornecedor1);



            Console.WriteLine("*** Venda *** \n");
            Console.WriteLine("Código da venda: " + venda1.Id);
            Console.WriteLine("Código do Cliente: " + venda1.Pessoa.Id);
            Console.WriteLine("Nome do Cliente: " + venda1.Pessoa.Nome.ToString());
            Console.WriteLine("Dada da Venda: " + venda1.Data.ToString());
            Console.WriteLine("Valor Total da Venda: " + venda1.Valortotal);

            Console.ReadKey();


        }
    }
}
