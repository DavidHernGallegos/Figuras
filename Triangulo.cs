using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Triangulo : Figura
    {
        protected int NLados { get; set; }
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }

        public int Lado3 { get; set; }
       
        public Triangulo() { }

        public Triangulo(int lado1, int lado2, int lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
            
        }

        public Triangulo(int altura, int baseA) {
        
            this.Altura = altura;
            this.Base = baseA;

        
        }

        public override int Area(int altura, int baseA)
        {
            int area = baseA * altura / 2; 
            return area;
        }



    }
}
