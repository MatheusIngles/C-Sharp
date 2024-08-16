using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SistemaDaLoJa
{
    internal class Loja
    {

        string Nome, endereço;
        double lucro = 0;
        int id = 0;
        bool Flag = false;

        List<Produto> ListaDeProdutos = [];

        public void adicionarProduto(Produto p) {
            id++;
            p.id = id;
            ListaDeProdutos.Add(p);
        }

        public void pesquisarProduto(string nome)
        {
            foreach (var produ in ListaDeProdutos)
            {
                if (nome == produ.nome && produ.estoque > 0) {
                    Console.WriteLine($"O Produto esta no estoque com {produ.estoque}");
                    produ.getNome();
                    produ.getPreco();
                    produ.getEstoque();
                }
            }
        }

        public void venderProduto(string nome)
        {
            foreach (var produ in ListaDeProdutos)
            {
                if (nome == produ.nome && produ.estoque > 0)
                {
                    Console.WriteLine("Venda Feita");
                    produ.setEstoque(produ.estoque - 1);
                    lucro += produ.preco;
                    Flag = true;
                }
                else if (Flag){
                    Console.WriteLine("O produto não pode ser vendido ou não existe na loja");
                }
            }
        }

        public void RetirarProdutoDaLoja(string nome)
        {
            for(int i =0; i < ListaDeProdutos.Count;i++)
            {
                if (nome == ListaDeProdutos[i].nome)
                {
                    ListaDeProdutos.Remove(ListaDeProdutos[i]);
                    Console.WriteLine("Retirado Chefe");
                }
            }
        }

        public void VerLucro()
        {
            Console.WriteLine($"Lucro da loja : {lucro}");
        }

    }
}
