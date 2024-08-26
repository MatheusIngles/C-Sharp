using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1.Professor
{
    internal class ProfHorista : Professor
    {

        double valorHora;

        public ProfHorista(string nome, int matricula, int cargaHoraria, double valorHora) { 
            this.nome = nome;
            this.matricula = matricula;
            this.valorHora = valorHora;
            this.cargaHoraria = cargaHoraria;
        }

        public override void CalcularBeneficio()
        {
            beneficio = valorHora * matricula;
        }

        public override double getBeneficio()
        {
            return beneficio;
        }

    }
}
