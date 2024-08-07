using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public class Televisao
    {
        public int tamanho, canal;
        public string marca, tipo, estado;

        public Televisao(string marca, int tamanho, string tipo) { 
            this.marca = marca;
            this.tipo = tipo;
            this.tamanho = tamanho;
            estado = "Desligada";
            canal = 0;
        }

        public void ligar()
        {
            if (estado == "Ligada")
            {
                Console.WriteLine("\n !!! A televisão já está ligada !!! \n");
            }
            else
            {
                Console.WriteLine("\n !!! A televisão agora está ligada !!! \n");
                estado = "Ligada";
            }
        }
        public void desligar()
        {
            if (estado == "DesLigada")
            {
                Console.WriteLine("\n !!! A televisão já está Desligada !!! \n");
            }
            else
            {
                Console.WriteLine("\n !!! A televisão agora está desligada !!! \n");
                estado = "Desligada";
            }
        }
        public void mudarCanal(int canal)
        {
            if (estado == "Desligada")
            {
                Console.WriteLine("\n A TV está Desligada");
            }
            else if (canal == this.canal)
            {
                Console.WriteLine($"\n Já está no {canal}");
            }
            else {
                Console.WriteLine($"\n A Tv agora está no {canal}");
            }
        }
    }
}
