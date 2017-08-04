using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public interface IShapeFactory
    {
        IShape CreateShape(string type, int width);
    }
}
