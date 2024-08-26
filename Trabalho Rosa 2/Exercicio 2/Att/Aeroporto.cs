using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2.Att
{
    internal class aeroporto
    {
        transporteAerio tranporte { get; set; }

        public void accept(transporteAerio t, string origem, string destino, int passageiros) {

            if (tranporte != null)
            {
                Console.WriteLine("O aeroposto está oculpado");

            }
            else
            {
                tranporte = t;
                tranporte.fly(origem, destino, passageiros);
            }
        }

        public void liberar()
        {
            tranporte = null;
        }

        public bool returnt()
        {
            if (tranporte != null) {
                return true;
            }

            return false;
        }
    }
}
