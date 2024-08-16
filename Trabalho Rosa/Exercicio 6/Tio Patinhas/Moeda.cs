using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6.Tio_Patinhas
{
    internal class Moeda
    {
        public double valor;
        public string nome;

        public Moeda(double valor, string nome) { 
            this.valor = valor;
            this.nome = nome;
        }

        public double getValor() { return valor; }
        public string getNome() { return nome; }
    }
}
