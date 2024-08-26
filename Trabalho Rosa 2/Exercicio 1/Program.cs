using Exercicio_1.Professor;
namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int escolha,matricula,cargaHoraria;
            double valorHora;

            Console.WriteLine("Qual o Professor?\n" +
                               "1-Horista\n" +
                               "2-Professor De");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha) {
                case 1:
                    Console.WriteLine("Qual o nome, matricula, carga horaria e valor hora:");
                    nome = Console.ReadLine();
                    matricula = int.Parse(Console.ReadLine());
                    cargaHoraria = int.Parse(Console.ReadLine());
                    valorHora = double.Parse(Console.ReadLine());
                    ProfHorista p = new ProfHorista(nome, matricula, cargaHoraria, valorHora);
                    p.CalcularBeneficio();
                    Console.WriteLine($"Beneficio: {p.getBeneficio}");
                    break;

                case 2:
                    Console.WriteLine("Qual o nome, matricula, carga horaria e valor hora:");
                    nome = Console.ReadLine();
                    matricula = int.Parse(Console.ReadLine());
                    cargaHoraria = int.Parse(Console.ReadLine());
                    valorHora = double.Parse(Console.ReadLine());
                    ProfDE p1 = new ProfDE(nome,matricula,cargaHoraria);
                    p1.CalcularBeneficio();
                    Console.WriteLine($"Beneficio: {p1.getBeneficio}");
                    break;

                default: Console.WriteLine("Escreva certo");
            }
        }
    }
}
