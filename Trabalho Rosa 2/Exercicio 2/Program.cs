using Exercicio_2.Att;
namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            aeroporto aeroporto = new aeroporto();

            int x = 0, x2, i;
            string n/*Origem*/, n2 = ""/*destino*/, n1, n22;

            Console.WriteLine("Qual a plataforma que vc quer voar?");
            n = Console.ReadLine();
            switch (n)
            {

                case "Helicoptero":
                    Helicopter h = new Helicopter();
                    Console.WriteLine("Quantidade de Passageiros, origem e destino:");
                    x = int.Parse(Console.ReadLine());
                    n = Console.ReadLine();
                    n2 = Console.ReadLine();
                    aeroporto.accept(h, n, n2, x);
                    break;

                case "Grifo":
                    Grifo grifo = new Grifo();
                    Console.WriteLine("Quantidade de Passageiros, origem e destino:");
                    x = int.Parse(Console.ReadLine());
                    n = Console.ReadLine();
                    n2 = Console.ReadLine();
                    aeroporto.accept(grifo, n, n2, x);
                    break;

                case "Aviao":
                    Aviao a = new Aviao();
                    Console.WriteLine("Quantidade de Passageiros, origem e destino:");
                    x = int.Parse(Console.ReadLine());
                    n = Console.ReadLine();
                    n2 = Console.ReadLine();
                    aeroporto.accept(a, n, n2, x);
                    break;

                default:
                    Console.WriteLine("Parece que vc não sabe viajar");
                    break;

            }

            if (aeroporto.returnt())
            {
                while (true)
                {

                    Console.WriteLine($"O: {n} / {n2} / Pessoas: {x}\n" +
                        $"O que deseja Fazer? \n" +
                        $"1- ir para o proximo voo\n" +
                        $"2- Fazer chekkin\n" +
                        $"3- Sair do aeroporto");

                    i = int.Parse(Console.ReadLine());

                    if (i == 1)
                    {
                        if (aeroporto.returnt())
                        {
                            Console.WriteLine("Deve fazer o chekkin antes");
                        }
                        else
                        {
                            Console.WriteLine("Qual a plataforma que vc quer voar?");
                            n = Console.ReadLine();
                            switch (n)
                            {

                                case "Helicoptero":
                                    Helicopter h = new Helicopter();
                                    Console.WriteLine("Quantidade de Passageiros, origem e destino:");
                                    x = int.Parse(Console.ReadLine());
                                    n = Console.ReadLine();
                                    n2 = Console.ReadLine();
                                    aeroporto.accept(h, n, n2, x);
                                    break;

                                case "Grifo":
                                    Grifo grifo = new Grifo();
                                    Console.WriteLine("Quantidade de Passageiros, origem e destino:");
                                    x = int.Parse(Console.ReadLine());
                                    n = Console.ReadLine();
                                    n2 = Console.ReadLine();
                                    aeroporto.accept(grifo, n, n2, x);
                                    break;

                                case "Aviao":
                                    Aviao a = new Aviao();
                                    Console.WriteLine("Quantidade de Passageiros, origem e destino:");
                                    x = int.Parse(Console.ReadLine());
                                    n = Console.ReadLine();
                                    n2 = Console.ReadLine();
                                    aeroporto.accept(a, n, n2, x);
                                    break;

                                default:
                                    Console.WriteLine("Parece que vc não sabe viajar");
                                    break;

                            }

                        }
                    }
                    else if (i == 2)
                    {
                        aeroporto.liberar();
                        x = 0;
                        n = "";
                        n2 = "";
                    }
                    else if (i == 3)
                    {
                        break;
                    }

                }

            }
        }
    }
}
