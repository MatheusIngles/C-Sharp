using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.percistencia
{
    internal class BD
    {
      public static List<Ideia> list = [];

      public static void SalvarBD(Ideia ideia) => list.Add(ideia);

      public static List<Ideia> RetornarBd() => list;
    }
}
