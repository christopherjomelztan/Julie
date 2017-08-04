using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpSortingAlgorithms.Interface;

namespace CSharpSortingAlgorithms.Factory
{
    public interface ISortFactory
    {
        ISortedList SortedList(string sortType);
    }
}
