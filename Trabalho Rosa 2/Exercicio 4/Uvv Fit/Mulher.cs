using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4.Uvv_Fit
{
    internal class Mulher : PesoldealPessoa
    {

        public override double getPesoldeal(double altura)
        {
            return ((62.1 * altura) - 44.7);
        }

    }
}
