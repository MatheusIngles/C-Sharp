using Exercicio_4.Uvv_Fit;
namespace Exercicio_4
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string i, a;
            Console.WriteLine("sé é o que?");
            i = Console.ReadLine();
            if (i == "H")
            {
                Homem homem = new Homem();
                Console.WriteLine("Sua altura:");
                Console.WriteLine(homem.getPesoldeal(double.Parse(Console.ReadLine())));
            }
            else if (i == "M") { 
                Mulher mulher = new Mulher();

                Console.WriteLine("Sua altura:");
                Console.WriteLine(mulher.getPesoldeal(double.Parse(Console.ReadLine())));
            }
        }
    }
}
