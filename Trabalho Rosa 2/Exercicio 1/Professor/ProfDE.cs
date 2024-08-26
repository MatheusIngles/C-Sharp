using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Professor
{
    internal class ProfDE : Professor
    {
        public ProfDE(string nome, int matricula, int cargaHoraria) { 
           this.nome = nome;
           this.matricula = matricula;
           this.cargaHoraria = cargaHoraria;
        }

        public override void CalcularBeneficio() {
            beneficio = cargaHoraria * matricula;
        }

        public override double getBeneficio()
        {
            return beneficio;
        }
    }
}
