using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessenger volEnglishMessenger = new VolEnglishMessenger();
            IMessenger areaEnglishMessenger = new AreaEnglishMessenger();
            IAreaCalculator areaCalc = new AreaCalculator();
            IVolumeCalculator volumeCalc = new VolumeCalculator();
            IShapeFactory sf = new ShapeFactory();

            IList<IArea> iArea = new List<IArea>();
            iArea.Add((IArea)sf.CreateShape("Circle", 1));

            IList<IVolume> iVolume = new List<IVolume>();
            iVolume.Add((IVolume)sf.CreateShape("Cube", 5));

            areaEnglishMessenger.Message(areaCalc.CalculateArea(iArea));
            volEnglishMessenger.Message(volumeCalc.CalculateVolume(iVolume));
            Console.ReadKey();
        }
    }
}
