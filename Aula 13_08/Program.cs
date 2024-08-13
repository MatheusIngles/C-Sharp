using ConsoleApp2.Att;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item i01 = new Item()
            {
                Qtd = 1,
                Tipo = "Borracha"
            };

            Item i02 = new Item()
            {
                Qtd = 2,
                Tipo = "lÁPIS"
            };

            Notas notas = new Notas();
            notas.Nota01 = 10;
            notas.Nota02 = 4;

            Aluno a1 = new Aluno()
            {
                Name = "Matheus",
                Mat = 1
            };

            a1.NotasAluno = notas;
            a1.ListaItens.Add(i02);
            a1.ListaItens.Add(i01);
            a1.ListarAlunos();
        }
    }
}
