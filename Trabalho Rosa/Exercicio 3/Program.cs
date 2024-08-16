namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char Tipo;
            double Preco, PrecoTotal = 0, A = 0, L = 0, H = 0;

            List<Produto> ListaDeCompras = [];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Qual o Codigo do Produto?");
                Tipo = char.ToUpper(char.Parse(Console.ReadLine()));
                if (Tipo != 'L' && Tipo != 'A' && Tipo != 'H')
                {
                    Console.WriteLine("!!DIGITE UM CODIGO VALIDO!!");
                    i--;
                }
                else
                {
                    Console.WriteLine("Qual o Preço do Produto?");
                    Preco = double.Parse(Console.ReadLine());
                    Produto produto = new Produto();
                    produto.Preco = Preco;
                    produto.Tipo = Tipo;
                    ListaDeCompras.Add(produto);
                }
            }

            foreach (var t in ListaDeCompras)
            {
                PrecoTotal += t.Preco;
                switch (t.Tipo)
                {

                    case 'A':
                        A += t.Preco;
                        break;

                    case 'H':
                        H += t.Preco;
                        break;

                    case 'L':
                        L += t.Preco;
                        break;

                }
            }

            Console.WriteLine($"O Preço total da lista é: {PrecoTotal}\nPreço da Categoria Limpeza: {L}\nPreço da Categoria alimentação {A}\nPreço da Categoria higiene {H}");
        }
    }
}
