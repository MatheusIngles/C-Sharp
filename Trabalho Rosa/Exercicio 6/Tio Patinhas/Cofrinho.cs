using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6.Tio_Patinhas
{
    internal class Cofrinho
    {
        List<Moeda> Cofrinh = [];

        public Cofrinho() { }

        public void adicionarMoeda(Moeda m) {
            Cofrinh.Add(m);
        }

        public void contarMoeda(double valor)
        {
            int domedario = 0;

            foreach (var moeda in Cofrinh)
            {
                if (valor == moeda.valor)
                { domedario++; }
            }

            Console.WriteLine("A Quantidade de moedas do valor " + valor + " no cofre é de " + domedario);
        }

        public void maiorMoeda()
        {
            double Maiormoeda = 0;

            foreach(var moeda in Cofrinh)
            {
                if(Maiormoeda < moeda.valor)
                {
                    Maiormoeda = moeda.valor;
                }
            }
            Console.WriteLine("A maior moeda é de " + Maiormoeda); 
        }

        public double calcularTotal() { 
            double total = 0;

            foreach (var moeda in Cofrinh) {
                total += moeda.getValor();
            }

            return total;
        }
    }
}
