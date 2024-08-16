using ConsoleApp1.SistemaDaLoJa;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int resposta;
            string nome;

            Loja L = new Loja();

            while (true) {
                Console.WriteLine("O que vc quer fazer no seu dia de trabalho?\n 0-Ver Lucro\n 1-Adicionar Um Produto\n 2-Adicionar Uma Coleção\n 3-Pesquisar no Estoque?\n 4-Vender um Produto?\n 5-Retirar da loja um Produto\n 6-Acabar o dia.");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 0) { 
                    L.VerLucro();
                }
                else if (resposta == 1) {
                    adicionarProd();
                }
                else if (resposta == 2) { 
                    Console.WriteLine("A coleção tem quantos produtos novos?");
                    resposta = int.Parse(Console.ReadLine());

                    for (int i = 0;i < resposta; i++)
                    {
                        adicionarProd();
                    } 

                }
                else if (resposta == 3) {
                    Console.WriteLine("Qual o nome do produto?");
                    nome = Console.ReadLine();
                    L.pesquisarProduto(nome);
                }
                else if (resposta == 4) {
                    Console.WriteLine("Qual o nome do produto?");
                    nome = Console.ReadLine();
                    L.venderProduto(nome);
                }
                else if (resposta == 5) { 
                    Console.WriteLine("Qual o nome do produto?");
                    nome = Console.ReadLine();
                    L.RetirarProdutoDaLoja(nome);
                }
                else if (resposta == 6)
                {
                    break;
                }
                else {
                    Console.WriteLine("Digita Certo ANimal");
                }
            
            }


            void adicionarProd()
            {
                double preco;
                int estoque;

                Console.WriteLine("Qual o nome do produto?");
                nome = Console.ReadLine();
                Console.WriteLine("Qual o preco do produto?");
                preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de produtos?");
                estoque = int.Parse(Console.ReadLine());

                Produto p = new Produto(nome, preco,estoque);
                L.adicionarProduto(p);
            }
        }
    }
}
