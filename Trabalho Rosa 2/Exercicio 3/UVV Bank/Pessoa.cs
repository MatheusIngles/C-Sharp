using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.UVV_Bank
{
    internal abstract class Pessoa
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }

        public abstract void exibirDados();

    }
}
