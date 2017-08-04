
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpSortingAlgorithms.Interface;

namespace CSharpSortingAlgorithms.Class
{
    public class QuickSort : ISortedList
    {
        public List<int> Concat(List<int> less, int pivot, List<int> greater)
        {
            List<int> sorted = new List<int>(less);
            sorted.Add(pivot);
            foreach (int i in greater)
            {

                sorted.Add(i);
            }

            return sorted;
        }


        public List<int> Sort(List<int> unsorted)
        {
            Random r = new Random();
            List<int> less = new List<int>();
            List<int> greater = new List<int>();
            if (unsorted.Count <= 1)
                return unsorted;
            int pos = r.Next(unsorted.Count);

            int pivot = unsorted[pos];
            unsorted.RemoveAt(pos);
            foreach (int x in unsorted)
            {
                if (x <= pivot)
                {
                    less.Add(x);
                }
                else
                {
                    greater.Add(x);
                }
            }
            return Concat(Sort(less), pivot, Sort(greater));
        }
    }
}
