using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Att
{
    internal class Aluno
    {

        public string Name { get; set; }
        public int Mat {  get; set; }

        public Notas NotasAluno { get; set; }

        public List<Item> ListaItens { get; set; } = new List<Item>();

        public void ListarAlunos()
        {
            foreach (var item in ListaItens)
            {
                Console.WriteLine(item.Qtd);
                Console.WriteLine(item.Tipo);
            }
        }
    }
}
