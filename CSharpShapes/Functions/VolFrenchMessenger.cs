using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class VolFrenchMessenger : IMessenger
    {
        public void Message(double volume)
        {
            Console.WriteLine("Le volume total est " + volume);
        }
    }
}
