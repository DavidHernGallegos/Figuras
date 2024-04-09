using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(5,12);

            int areaTriangulo = triangulo.Area(triangulo.Altura, triangulo.Base);

            Console.WriteLine("El area del triangulo es: " + areaTriangulo);

            
            Cuadrado cuadrado = new Cuadrado();

            int areaCuadrado = cuadrado.Area(4);

            Console.WriteLine("El area del cuadrado es: " + areaCuadrado);

            Triangulo triangulo2 = new Triangulo(5,5,8);

            TrianguloIsoceles isoceles = new TrianguloIsoceles();

            isoceles.EsTrianguloIsoceles(triangulo2.Lado1, triangulo2.Lado2, triangulo2.Lado3);

            Console.ReadKey();

            

        }
    }
}
