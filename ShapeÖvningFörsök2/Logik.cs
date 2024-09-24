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
            switch (form)
            {
                case "2":
                    Console.WriteLine("Skriv bredden på formen");
                    width = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Skriv höjden på formen");
                    height = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Triangle triangel = new Triangle(width, height);
                    Console.WriteLine("Arean på din form är: " + triangel.Area() + " areaenheter");
                    Console.WriteLine("Omkretsen på din form är: " + triangel.Omkrets() + " längdenheter");
                    Console.ReadKey();
                    Console.Clear();

                    break;


                case "1":
                    Console.WriteLine("Skriv bredden på formen");
                    width = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Skriv höjden på formen");
                    height = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Rektangel rektangel = new Rektangel(width, height);
                    Console.WriteLine("Arean på din rektangel är: " + rektangel.Area() + " areaenheter");
                    Console.WriteLine("Omkretsen på din rektangel är: " + rektangel.Omkrets() + " längdenheter");
                    Console.ReadKey();
                    Console.Clear();

                    break;


                case "3":
                    Console.WriteLine("Skriv radien på cirkeln");
                    radie = int.Parse(Console.ReadLine());
                    Circle circle = new Circle(radie);
                    Console.WriteLine("Arean på din cirkel är: " + circle.Area() + " areaenheter");
                    Console.WriteLine("Omkretsen på din cirkel är: " + circle.Omkrets() + " längdenheter");
                    Console.ReadKey();
                    Console.Clear();

                    break;

                case "4":
                    Console.WriteLine("Skriv radien på sfären");
                    radie = int.Parse(Console.ReadLine());
                    Sphere sphere = new Sphere(radie);
                    Console.WriteLine("Arean på din sfär är: " + sphere.Area() + " areaenheter");
                    Console.WriteLine("Omkretsen på din sfär är: " + sphere.Omkrets() + " längdenheter");
                    Console.ReadKey();
                    Console.Clear();

                    break;

                case "5":
                    Console.WriteLine("Skriv radien på cylindern");
                    radie = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv höjden på cylindern");
                    height = int.Parse(Console.ReadLine());
                    Cylinder cylinder = new Cylinder(radie, height);
                    Console.WriteLine("Arean på din sfär är: " + cylinder.Area() + " areaenheter");
                    Console.WriteLine("Omkretsen på din sfär är: " + cylinder.Omkrets() + " längdenheter");
                    Console.ReadKey();
                    Console.Clear();

                    break;


                default:
                    Console.WriteLine("Du valde inte en giltlig siffra");
                    break;

            }
            return;
        }
        /*
        try
        {
            int width, height;
            Console.WriteLine("Skriv bredden på formen");
            width = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv höjden på formen");
            height = int.Parse(Console.ReadLine());
            Console.Clear();
            skickarättform(height, width, form);
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Du skrev något fel din jävla idiot");
            Console.WriteLine();
        }

        return;
        /
}
/
    private static void skickarättform(int height, int width, string form)
    {
        switch(form)
        {
            case "2":
                Triangle triangel = new Triangle(width, height);
                Console.WriteLine("Arean på din form är: " + triangel.Area() + " areaenheter");
                Console.WriteLine("Omkretsen på din form är: " + triangel.Omkrets() + " längdenheter");
                Console.ReadKey();
                Console.Clear();
                break;

            case "1":
                Rektangel rektangel = new Rektangel(width, height);
                Console.WriteLine("Arean på din rektangel är: " + rektangel.Area() + " areaenheter");
                Console.WriteLine("Omkretsen på din rektangel är: " + rektangel.Omkrets() + " längdenheter");
                Console.ReadKey();
                Console.Clear();
                break;


        }
        return;
    }*/
    }
}
