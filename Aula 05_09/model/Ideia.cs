using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.percistencia;

namespace WpfApp1.model
{
    internal class Ideia
    {
        public int Custo { get; set; }
        public string Area { get; set; }
        public string idea { get; set; }
        public string Nivel { get; set; }

        public Boolean CadastarIdeia(Ideia idea) { 
            BD.SalvarBD(idea);
            return true;
        }
    }
}
