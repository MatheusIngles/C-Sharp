namespace ConsoleApp1.GestaoDeRh
{
    internal class Funcionario
    {
        public int matricula;
        public string nome, cargoAtual;
        public double Salario;

        public Funcionario(int matricula, string nome, string cargoAtual, double Salario)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.Salario = Salario;
            this.cargoAtual = cargoAtual;
        }

        public void cadastrar() {
            Console.WriteLine("Funcionario Cadastrado");
        }
        public void consultar(string Nome) {
            if (nome == Nome)
            {
                Console.WriteLine("Ele Está na lista.");
            }
        }
        public void atualizarSalario(double Salario)
        {
            this.Salario = Salario;
        }
        public void listarDependentes() { }
    }
}
