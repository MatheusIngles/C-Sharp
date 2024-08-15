namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperatura;
            int r, i = 0;
            bool F = false, C = false, K = false;

            Console.WriteLine("Qual o a temperatura inicial?");
            temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a temperatura está em qual forma?\n1-Celsius\n2-Fahrenheit\n3-Kelvin");
            r = int.Parse(Console.ReadLine());

            switch (r)
            {
                case 1:
                    C = true;
                    break;

                case 2:
                    F = true;
                    break;

                case 3:
                    K = true;
                    break;

                default:
                    Console.WriteLine("!!Digite Certo!!");
                    break;
            }

            Conversor converso = new Conversor(temperatura, C, F, K);

            while (true)
            {
                Console.WriteLine($"Sua temperatura atual : {converso.Temperatura:F2}\nO que deseja fazer?\n1-Converter a Temperatura?\n2-Fazer a media do Verão.\n0-Sair");
                r = int.Parse(Console.ReadLine());
                if (r == 0)
                {
                    break;
                }
                else if (r == 1)
                {
                    Console.WriteLine("Qual Conversão vc quer fazer?\n1-CpF\n2-FpC\n3-CpK\n4-KpC");
                    r = int.Parse(Console.ReadLine());

                    switch (r)
                    {
                        case 1:
                            converso.CpF();
                            break;

                        case 2:
                            converso.FpC();
                            break;

                        case 3:
                            converso.CpK();
                            break;

                        case 4:
                            converso.KpC();
                            break;

                        default:
                            Console.WriteLine("!!Digite Certo!!");
                            break;
                    }
                }
                else if (r == 2)
                {
                    for (; i < 15; i++)
                    {

                    PegarTemperatura();

                    }
                }
            }


            void PegarTemperatura()
            {
                Console.WriteLine($"Qual o a temperatura do {i + 1}° dia?\n");
                temperatura = double.Parse(Console.ReadLine());

                if (temperatura <= 28)
                {
                    Console.WriteLine($"!!Digite Certo!!");
                    i--;
                }
                else
                {
                    converso.FazerMedia(temperatura);
                    Console.WriteLine($"A media Atual é {converso.media}");
                }
            }
        }
    }
}
