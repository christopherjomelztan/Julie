using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpSortingAlgorithms.Interface;

namespace CSharpSortingAlgorithms.Class
{
    public class BubbleSort : ISortedList
    {
        public List<int> Sort(List<int> unsorted)
        {
            int temp;

            // foreach(int i in a)
            for (int i = 1; i <= unsorted.Count; i++)
                for (int j = 0; j < unsorted.Count - i; j++)
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        temp = unsorted[j];
                        unsorted[j] = unsorted[j + 1];
                        unsorted[j + 1] = temp;

                    }
            return unsorted;
        }
    }
}
