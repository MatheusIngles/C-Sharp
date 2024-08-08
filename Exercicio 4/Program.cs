namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, numero, resposta;
            float saldo;

            Console.WriteLine("\n Qual o Nome Do dono da conta:");
            nome = Console.ReadLine();
            Console.WriteLine("\n Qual o Numero Do dono da conta:");
            numero = Console.ReadLine();
            Console.WriteLine("\n Qual o Saldo Do dono da conta:");
            saldo = float.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(nome, numero, saldo);

            while (true) {
                Console.WriteLine("\n O que voce quer fazer:\n- Fazer Deposito!\n- Fazer Saque!\n- Sair do Banco");
                resposta = Console.ReadLine();

                if (resposta == "Fazer Deposito")
                {
                    Console.WriteLine("\nQuanto quer depositar?");
                    saldo = float.Parse(Console.ReadLine());
                    account.MakeDeposit(saldo);
                    Console.WriteLine($"\n Sua conta tem {account.Balance}.");
                }

                if (resposta == "Fazer Saque")
                {
                    Console.WriteLine("\nQuanto quer tirar?");
                    saldo = float.Parse(Console.ReadLine());
                    account.MakeWithdrawal(saldo);

                    if (account.Balance < 0)
                    {
                        Console.WriteLine($"Seu Saldo Agr está no Vermelho. Cuidado! R$:{account.Balance}");
                    }
                    else {
                        Console.WriteLine($"Seu Saldo Agr é {account.Balance}");
                    }
                }
                if( resposta == "Sair")
                {
                    break;
                }
            }


        }
    }
}

