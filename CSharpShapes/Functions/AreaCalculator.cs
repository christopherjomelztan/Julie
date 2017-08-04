using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class AreaCalculator : IAreaCalculator
    {
        public double CalculateArea(IList<IArea> shapes)
        {
            double totalArea = 0;
            foreach (IArea shape in shapes)
            {
                totalArea += shape.GetArea();
            }
            return totalArea;
        }
    }
}
