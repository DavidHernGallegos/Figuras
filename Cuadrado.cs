using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Cuadrado: Figura
    {
    

        public override int Area(int lados)
        {
            var ladoTotal = base.Area(lados);
            var area = ladoTotal * ladoTotal;

            return area;
        }
    }
}
