using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class VolumeCalculator : IVolumeCalculator
    {
        public double CalculateVolume(IList<IVolume> shapes)
        {
            double totalVolume = 0;
            foreach (var shape in shapes)
            {
                totalVolume += shape.GetVolume();
            }
            return totalVolume;
        }
    }
}
