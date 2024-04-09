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



            Menu();

            
            

           

            

            

        }


        public static void Menu()
        {

            int opc = 0;

            while (opc!= 4) { 
            Console.WriteLine("Elige una opcion, 1- Calcular area cuadrado, 2- calcular area tringulo, 3-¿Es isoceles?, 4-Salir");
            opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingresa cuanto mide un lado del cuadrado");
                        int lado = int.Parse(Console.ReadLine());
                        Cuadrado cuadrado = new Cuadrado();

                        int areaCuadrado = cuadrado.Area(lado);

                        Console.WriteLine("El area del cuadrado es: " + areaCuadrado);

                        break;

                    case 2:
                        Console.WriteLine("Ingresa el area del triangulo");
                        int area = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa la base del triangulo");
                        int baseT = int.Parse(Console.ReadLine());

                        Triangulo triangulo = new Triangulo(area, baseT);

                        int areaTriangulo = triangulo.Area(triangulo.Altura, triangulo.Base);

                        Console.WriteLine("El area del triangulo es: " + areaTriangulo);

                        break;
                    case 3:
                        Console.WriteLine("Ingresa el tamaño del lado1");
                        int lado1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el tamaño del lado2");
                        int lado2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el tamaño del lado3");
                        int lado3 = int.Parse(Console.ReadLine());

                        Triangulo triangulo2 = new Triangulo(lado1, lado2, lado3);

                        TrianguloIsoceles isoceles = new TrianguloIsoceles();

                        isoceles.EsTrianguloIsoceles(triangulo2.Lado1, triangulo2.Lado2, triangulo2.Lado3);

                        break;

                }
                   
            }
        }
    }
}
