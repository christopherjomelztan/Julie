using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class VolEnglishMessenger : IMessenger
    {
        public void Message(double volume)
        {
            Console.WriteLine("The total Volume is " + volume);
        }
    }
}
