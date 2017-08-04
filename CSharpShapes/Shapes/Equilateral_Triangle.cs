using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class Equilateral_Triangle : IShape, IArea
    {
        private int width;
        public Equilateral_Triangle()
        {
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            double area = (Math.Sqrt(3) / 4) * width * width;
            return area;
        }

    }
}
