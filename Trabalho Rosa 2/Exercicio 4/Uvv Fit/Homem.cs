using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4.Uvv_Fit
{
    internal class Homem : PesoldealPessoa
    {

        public override double getPesoldeal(double altura)
    {
        return ((72.7 * altura) - 58);
    }


}
}
