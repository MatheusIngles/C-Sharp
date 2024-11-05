using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class Autor
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public Autor() { }

        public Autor(string Nome)
        {
            this.Nome = Nome;
        }

        public override string ToString() {
            return $"Autor -> {Nome}";
        }
    }
}
