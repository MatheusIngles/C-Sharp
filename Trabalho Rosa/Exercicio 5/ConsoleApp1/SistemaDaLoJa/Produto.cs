using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SistemaDaLoJa
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int estoque, id;

        public Produto(string nome, double preco, int estoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setPreco(double preco)
        {
            this.preco = preco;
        }
        public void setEstoque(int estoque)
        {
            this.estoque = estoque;
        }

        public void getNome() { 
            Console.WriteLine("Nome do produto:"+nome);
        }

        public void getPreco()
        {
            Console.WriteLine("Preco do produto"+preco);
        }

        public void getEstoque() { 
            Console.WriteLine("Quantidade no estoque:"+ estoque);
        }

        public int returnEstoque() { 
            return estoque;
        }
    }
}
