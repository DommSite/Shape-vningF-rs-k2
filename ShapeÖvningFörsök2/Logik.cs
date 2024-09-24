using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeÖvningFörsök2
{
    public class Logik
    {
        public static void HöjdoBredd(string form)
        {
            int width, height, radie;
            IShape shape = null;
            switch (form)
            {
                case "1":
                    Console.WriteLine("Skriv bredden på formen");
                    width = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Skriv höjden på formen");
                    height = int.Parse(Console.ReadLine());
                    Console.Clear();
                    shape = new Rektangel(width, height);
                    Console.Clear();

                    break;


                case "2":
                    Console.WriteLine("Skriv bredden på formen");
                    width = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Skriv höjden på formen");
                    height = int.Parse(Console.ReadLine());
                    Console.Clear();
                    shape = new Triangle(width, height);
                    Console.Clear();

                    break;


                case "3":
                    Console.WriteLine("Skriv radien på cirkeln");
                    radie = int.Parse(Console.ReadLine());
                    shape = new Circle(radie);
                    Console.Clear();

                    break;

                case "4":
                    Console.WriteLine("Skriv radien på sfären");
                    radie = int.Parse(Console.ReadLine());
                    shape = new Sphere(radie);
                    Console.Clear();
                    break;

                case "5":
                    Console.WriteLine("Skriv radien på cylindern");
                    radie = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv höjden på cylindern");
                    height = int.Parse(Console.ReadLine());
                    shape = new Cylinder(radie, height);
                    Console.Clear();

                    break;


                default:
                    Console.WriteLine("Du valde inte en giltlig siffra");
                    break;

            }
            Console.WriteLine("Area: " + shape.Area() + " areaenheter");
            Console.WriteLine("Omkrets: " + shape.Omkrets() + " längdenheter");
            Console.ReadKey();
            Console.Clear();
            return;
        }
    }
}
