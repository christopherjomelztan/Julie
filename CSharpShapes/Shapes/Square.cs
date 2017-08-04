using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class Square : IShape, IArea
    {
        private int width;
        public Square()
        {
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            double area = Width * Width;
            return area;
        }
    }
}
