using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class UsarTelevisao
    {

        Televisao TV;


        public UsarTelevisao(string marca, int tamanho, string tipo) {
           TV = new Televisao(marca, tamanho, tipo);
        }

        public void UsarBotaoLigar() {
            TV.ligar();
        }

        public void UsarBotaoDesligar()
        {
            TV.desligar();
        }

        public void MudarCanal(int Canal)
        {
            TV.mudarCanal(Canal);
        }
    }
}
