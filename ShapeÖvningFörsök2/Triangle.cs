using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeÖvningFörsök2
{
    public class Triangle : IShape
    {
        int width, height;

        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return ((width*height) / 2);
        }

        public double Omkrets()
        {
            return (Math.Round((height + width + Math.Sqrt(height*height + width * width)), 3));
        }
    }
}
