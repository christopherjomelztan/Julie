using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class DefaultShape : IShape, IArea
    {
        private int width;
        public DefaultShape()
        {
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            return 0;
        }
    }
}
