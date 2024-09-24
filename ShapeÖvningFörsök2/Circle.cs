using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeÖvningFörsök2
{
    public class Circle : IShape
    {
        int radie;

        public Circle(int radie)
        {
            this.radie = radie;
        }

         public double Area()
        {
            return (Math.Round((radie*radie*Math.PI), 3));
        }

        public double Omkrets()
        {
            return (Math.Round(((radie + radie) * Math.PI),3));
        }

    }
}
