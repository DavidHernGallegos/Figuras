using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class TrianguloIsoceles : Triangulo
    {

        public void EsTrianguloIsoceles(int lado1, int lado2, int lado3)
        {
            
            

            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo no es isósceles.");
            }
        }
    }
}
