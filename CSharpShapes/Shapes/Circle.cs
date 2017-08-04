using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class Circle : IShape, IArea
    {
        private int width;
        public Circle()
        {
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            double area = Math.PI * (width / 2.0) * (width / 2.0);
            return area;
        }
    }
}
