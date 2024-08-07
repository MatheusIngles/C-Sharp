namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca, tipo, escolha;
            int tamanho, canal;
            bool t= true;

            Console.WriteLine("Qual a Marca da tv?");
            marca = Console.ReadLine();
            Console.WriteLine("\nQual o Tipo da tv?");
            tipo = Console.ReadLine();
            Console.WriteLine("\nQual o Tamanho da tv");
            tamanho = int.Parse(Console.ReadLine());

            UsarTelevisao usarTelevisao =  new UsarTelevisao(marca,tamanho,tipo);

            while (t) {
                Console.WriteLine("\n O que deseja fazer com a tv?\n - Ligar?\n - Desligar?\n - Trocar de Canal?\n - Sair da Sala?");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "Ligar":
                        usarTelevisao.UsarBotaoLigar();
                        break;

                    case "Desligar":
                        usarTelevisao.UsarBotaoDesligar();
                        break;

                    case "Trocar de Canal":
                        Console.WriteLine("\n Qual o canal que vc escolheu assistir?");
                        canal = int.Parse(Console.ReadLine());
                        usarTelevisao.MudarCanal(canal);
                        break;

                    case "Sair":
                        t = false;
                        break;

                    default:
                        Console.WriteLine("\n !!Digite Certo!! \n");
                        break;
                }
            }

        }
    }
}
