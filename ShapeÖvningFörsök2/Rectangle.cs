using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeÖvningFörsök2
{
    public class Rektangel : IShape
    {
        int width, height;

        public Rektangel(int width, int height)
        {
            this.width = width;
            this.height = height;
        }



        public double Area()
        {
            return (width * height);
        }

        public double Omkrets()
        {
            return (width + width + height + height);
        }

    }
}
