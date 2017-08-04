using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class Cube : IShape, IArea, IVolume
    {
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public double GetArea()
        {
            return 6 * Width * Width;
        }

        public double GetVolume()
        {
            return Width * Width * Width;
        }
    }
}
