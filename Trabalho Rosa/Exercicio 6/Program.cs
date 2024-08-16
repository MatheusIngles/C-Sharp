using Exercicio_6.Tio_Patinhas;
namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Valor;
            int resposta;
            Cofrinho cofrinho = new Cofrinho();
            while (true)
            {
                Console.WriteLine("O que vc quer fazer no seu dia?\n 1-Adicionar Uma Moeda" +
                    "\n 2-Calcula total de Moedas" +
                    "\n 3-Maior moeda" +
                    "\n 4-Calcular moeda" +
                    "\n 5-Acabar o dia.");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {
                    string nome;
                    Console.WriteLine("Escreva respectivamente: valor e nome");
                    nome = Console.ReadLine();
                    Valor = double.Parse(Console.ReadLine());
                    Moeda m = new Moeda(Valor, nome);
                    cofrinho.adicionarMoeda(m);
                    Console.WriteLine("Adicionado");
                }
                else if (resposta == 2)
                {
                    Valor = cofrinho.calcularTotal();
                    Console.WriteLine($"O Total é:{Valor}");
                }
                else if (resposta == 4)
                {
                    Console.WriteLine("Escreva respectivamente: valor");
                    Valor = double.Parse(Console.ReadLine());
                    cofrinho.contarMoeda(Valor);
                }
                else if (resposta == 3)
                {
                    cofrinho.maiorMoeda();
                }
                else if (resposta == 5)
                {
                    break;
                }
            }
        }
    }
}
