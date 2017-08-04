using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class AreaEnglishMessenger : IMessenger
    {
        public void Message(double area)
        {
            Console.WriteLine("The total area is " + area);
        }
    }
}
