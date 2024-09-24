using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeÖvningFörsök2
{
    public class Cylinder : IShape
    {
        int radie;
        int height;

        public Cylinder(int radie, int height)
        {
            this.radie = radie;
            this.height = height;
        }

        public double Area()
        {
            return (Math.Round(((radie + radie) * Math.PI*height)+(2* radie * radie * Math.PI), 3));
        }

        public double Omkrets()
        {
            return (Math.Round(((radie + radie) * Math.PI), 3));
        }

    }
}
