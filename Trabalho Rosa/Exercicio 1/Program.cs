namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            List<int> listA = [];
            List<int> listB = [];
            List<int> listC = [];
            List<int> listD = [];
            List<int> listE = [];


            while (true)
            {
                Console.WriteLine("Qual a sua idade?");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0)
                {
                    verificarPorcentagem();
                    break;
                }

                Check(idade);

            }

            void Check(int idade)
            {


                if (idade >= 1 && idade <= 15)
                {
                    Console.WriteLine("\nA");
                    listA.Add(idade);
                    verificarPorcentagem();
                }
                else if (idade >= 16 && idade <= 30)
                {
                    Console.WriteLine("\nB");
                    listB.Add(idade);
                    verificarPorcentagem();

                }
                else if (idade >= 31 && idade <= 45)
                {
                    Console.WriteLine("\nC");
                    listC.Add(idade);
                    verificarPorcentagem();

                }
                else if (idade >= 46 && idade <= 60)
                {
                    Console.WriteLine("\nD");
                    listD.Add(idade);
                    verificarPorcentagem();
                }
                else if (idade >= 61)
                {
                    Console.WriteLine("\nE");
                    listE.Add(idade);
                    verificarPorcentagem();
                }
            }

            void verificarPorcentagem()
            {
                int Tamanho = listA.Count + listB.Count + listC.Count + listD.Count + listE.Count;
                int PorcA = (listA.Count / Tamanho) * 100;
                int PorcB = (listB.Count / Tamanho) * 100;
                int PorcC = (listC.Count / Tamanho) * 100;
                int PorcD = (listD.Count / Tamanho) * 100;
                int PorcE = (listE.Count / Tamanho) * 100;

                Console.WriteLine($"A porcentagem de cada categoria é:\nCategoria A: {PorcA}%\nCategoria B: {PorcB}%\nCategoria C: {PorcC}%\nCategoria D: {PorcD}%\nCategoria E: {PorcE}%");

                Console.WriteLine("Lista de pessoas na faxa mais populosa:");

                if (listA.Count > Tamanho - listA.Count)
                {
                    foreach (var item in listA)
                    {
                        Console.WriteLine("- " + item.ToString());
                    }
                }
                else if (listB.Count >= Tamanho - listB.Count)
                {
                    foreach (var item in listB)
                    {
                        Console.WriteLine("- " + item.ToString());
                    }
                }
                else if (listC.Count > Tamanho - listC.Count)
                {
                    foreach (var item in listC)
                    {
                        Console.WriteLine("- " + item.ToString());
                    }
                }
                else if (listD.Count > Tamanho - listD.Count)
                {
                    foreach (var item in listB)
                    {
                        Console.WriteLine("- " + item.ToString());
                    }
                }
                else if (listE.Count > Tamanho - listE.Count)
                {
                    foreach (var item in listE)
                    {
                        Console.WriteLine("- " + item.ToString());
                    }
                }
            }

        }
    }
}
