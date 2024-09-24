using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeÖvningFörsök2
{
    public class Sphere : IShape
    {
        int radie;

        public Sphere(int radie)
        {
            this.radie = radie;
        }

        public double Area()
        {
            return (Math.Round((4 * radie * radie * Math.PI), 3));
        }

        public double Omkrets()
        {
            return (Math.Round(((radie + radie) * Math.PI), 3));
        }

    }
}
