namespace ConsoleApp1;
using ConsoleApp1.GestaoDeRh;

    internal class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            string nome;
            double Salario;
            Diretor diretor = new Diretor();

            while (true)
            {
                Console.WriteLine("O que vc quer fazer?\n 1-Cadastrar um novo Funcionario?\n 2-Consultar um funcionario?\n 3-Atualizar salario de um Funcionario\n 4-ListarDependentes\n 5-Sair");
                resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    int matricula;
                    string cargoAtual;
                    

                    Console.WriteLine("Escreva nessa ordem a caracteristica do funcionarios: (matricula,nome,cargoAtual,Salario)");
                    matricula = int.Parse(Console.ReadLine());
                    nome = Console.ReadLine();
                    cargoAtual = Console.ReadLine();
                    Salario = double.Parse(Console.ReadLine()); 

                    Funcionario f = new Funcionario(matricula, nome, cargoAtual, Salario);
                    diretor.cadastrar(f);
                }
                else if (resposta == 2) {
                    Console.WriteLine("Qual O nome do funcionario?");
                    nome = Console.ReadLine();
                    diretor.consultar(nome);
                }
                else if (resposta == 3) {
                    Console.WriteLine("Qual O nome do funcionario?");
                    nome = Console.ReadLine();
                    Console.WriteLine("Qual o salario:");
                    Salario = int.Parse(Console.ReadLine());
                    diretor.atualizarSalario(nome, Salario);
                }
                else if (resposta == 4) { 
                    diretor.listarDependentes();    
                }
                else if (resposta == 5)
                {
                    break;
                }
                else { Console.WriteLine("!!Escreve Certo!!"); }
            }
        }
    }
