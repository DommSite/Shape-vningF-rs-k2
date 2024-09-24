using ShapeÖvningFörsök2;
using System;

namespace shapeövning
{
    public class Huvudsak
    {
        public static void Main()
        {
            bool loop = true;
            Console.WriteLine("Välkommen");
            while (loop == true)
            {

                Console.WriteLine("1. Gör en ny form och få omkrets och area");
                Console.WriteLine("2. Stäng av programmet");
                string svar = Console.ReadLine();
                Console.Clear();
                switch (svar)
                {
                    case "1":
                        Console.WriteLine("Välj form:");
                        Console.WriteLine("1. Rektangel");
                        Console.WriteLine("2. Triangel");
                        System.Console.WriteLine("3. Cirkel");
                        string svar2 = Console.ReadLine();
                        Console.Clear();
                        try
                        {
                            Logik.HöjdoBredd(svar2);
                        }
                        catch
                        {
                            Console.WriteLine("Du skrev något fel, försök igen din jävla idiot");
                        }
                        break;
                    case "2":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Du skrev något fel, försök igen din jävla idiot");
                        break;
                }
            }
        }
    }
}