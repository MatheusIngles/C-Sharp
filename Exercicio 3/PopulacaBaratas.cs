using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class PopulacaBaratas
    {
        Random random = new Random();
        public int populacao;


        public PopulacaBaratas() {
            populacao = random.Next(1, 100);
        }

        public void aumentarBaratas()
        {
            populacao *= 2;
        }

        public void spray() { 
            populacao -= populacao * (10/100);
        }

        public void getQtdBaratas()
        {
            Console.WriteLine($"\nA populacao atual de Baratas é {populacao}!");
        }
    }
}
