using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class Livro
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public Autor AutordoLivro { get; set; }

        public Livro() { }

        public Livro(string titulo, Autor autordoLivro)
        {
            Titulo = titulo;
            AutordoLivro = autordoLivro;
        }

        public override string ToString()
        {
            return $"Livro -> Id:{id}| Titulo: '{Titulo}'";
        }
    }
}
