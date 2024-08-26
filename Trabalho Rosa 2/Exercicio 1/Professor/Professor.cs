using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Professor
{
    internal abstract class Professor
    {

        public string nome;
        public int matricula, cargaHoraria;
        public double beneficio;

        public abstract void CalcularBeneficio();

        public abstract double getBeneficio();


    }
}
