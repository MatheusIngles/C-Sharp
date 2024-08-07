namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Cozinha cozinha = new Cozinha();
            Boolean resposta = true;
            string NomeDoChef, respo;

            Console.WriteLine("Qual o nome do Chef?");
            NomeDoChef = Console.ReadLine();
            Console.WriteLine("\nBem vindo a Sua Cozinha!");

            while (resposta)
            {
                Console.WriteLine("\nO que Deseja fazer na sua cozinha\n- Fazer um prato?\n- Usar o Spray nas Baratinhas!\n- Acabar turno!");
                respo = Console.ReadLine();

                switch (respo) {
                    case "Fazer um prato":
                        cozinha.fazerPrato();
                        break;
                    case "Usar o Spray":
                        cozinha.usarSpray();
                        break;
                    case "Acabar turno!":
                        Console.WriteLine("\nBoa Noite Chef!");
                        break;
                    default: 
                        Console.WriteLine("\n Fala portugues \n");
                        break;
                }
            }

        }
    }
}
