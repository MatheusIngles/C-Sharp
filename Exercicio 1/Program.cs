namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random numAleatorio = new Random();
            int NumeroSecreto = numAleatorio.Next(1, 1001), tentativas = 0;


            Console.WriteLine("Qual o Seu Nome?");
            var Nome = Console.ReadLine();

            do {

                Console.WriteLine("\nChute um Numero:");
                int chute = Convert.ToInt32(Console.ReadLine());

                if(NumeroSecreto - chute <= -500 || NumeroSecreto - chute >= 500) {
                    Console.WriteLine("\n Vc esta muito Longe do Numero \n");
                } else if (NumeroSecreto - chute <= -100 || NumeroSecreto - chute >= 100)
                {
                    Console.WriteLine("\n Vc esta perto do Numero \n");
                } else if (NumeroSecreto - chute <= -10 || NumeroSecreto - chute >= 10)
                {
                    Console.WriteLine("\n Vc esta muito Perto do Numero \n");
                }

                if(chute == NumeroSecreto)
                {
                    Console.WriteLine($"Parabens {Nome}!! Vc acertou o Numero Secreto realmente era: {NumeroSecreto}");
                    break;
                }

                if(tentativas == 13)
                {
                    Console.WriteLine($"Po {Nome}, Vc perdeu!! Vc errou o Numero Secreto, ele realmente era: {NumeroSecreto}");
                    break;
                }
                if (tentativas < 3){
                    tentativas++;
                }else if (3 >= tentativas || tentativas <= 5) {
                    Console.WriteLine($"Dica 1: Chuta um numero entre 1 e {numAleatorio.Next(1,100) + 1000 + (NumeroSecreto - 1000) }");
                    tentativas++;
                }else if (6 >= tentativas || tentativas <= 10) {
                    Console.WriteLine($"Dica 2: Chuta um numero entre {1 + (NumeroSecreto/2)} e {numAleatorio.Next(1, 100) + 1000 + (NumeroSecreto - 1000)}");
                    tentativas++;
                } else if (tentativas >= 11) {
                    Console.WriteLine($"Dica 3: Chuta um numero entre {NumeroSecreto - 10 } e {1010 + (NumeroSecreto - 1000)}");
                    tentativas++;
                }

                Console.WriteLine($"{tentativas}");
            } while (true);
        }
    }
}
