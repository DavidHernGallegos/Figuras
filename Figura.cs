using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Figura
    {
        public int Lados { get; set; }
        public int Altura { get; set; }
        public int Base { get; set; }


        public virtual int Area(int altura, int baseA)
        {
            
            return 0;
        }

        public virtual int Area(int lados)
        {
            return lados;
        }


    }
}
