using Exercicio_3.UVV_Bank;
namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pessoa, n, n1, n2, n3, n4, n5;
            Console.WriteLine("Vc é o que?");
            pessoa = Console.ReadLine();

            if (pessoa == "PessoaFisica")
            {
                Console.WriteLine("Nome, endereco, telefone, cpf,  estado civil");
                n = Console.ReadLine();
                n1 = Console.ReadLine();
                n2 = Console.ReadLine();
                n3 = Console.ReadLine();
                n4 = Console.ReadLine();
                PessoaFisica pessoaFisica = new PessoaFisica(n, n1, n2, n3, int.Parse(n4));
                pessoaFisica.exibirDados();
            }
            else if (pessoa == "PessoaJuridica")
            {
                Console.WriteLine("Nome, endereco, telefone, razaoSocial,  cnpj, nomeRepresentante");
                n = Console.ReadLine();
                n1 = Console.ReadLine();
                n2 = Console.ReadLine();
                n3 = Console.ReadLine();
                n4 = Console.ReadLine();
                n5 = Console.ReadLine();
                PessoaJuridica pessoaJuridica = new PessoaJuridica(n, n1, n2, n3, n5, int.Parse(n4));
                pessoaJuridica.exibirDados();
            }
        }
    }
}
