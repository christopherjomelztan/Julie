using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShapes
{
    public class StringAreaEnglishMessenger : IStringMessenger
    {
        public string Message(double area)
        {
            return "The total area is " + area;
        }
    }
}
