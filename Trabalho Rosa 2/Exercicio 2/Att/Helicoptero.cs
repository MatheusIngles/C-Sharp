using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2.Att
{
    internal class Helicopter : transporteAerio 
    {
        public void fly(string origem, string destino, int passageros)
        {
            Console.WriteLine($"Helicoptero está voando." +
                $"\n O Voo tem {passageros} vindo de {origem} e indo até {destino}");
        }
    }
}
