using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpSortingAlgorithms.Interface;

namespace CSharpSortingAlgorithms.Class
{
    public class MergeSort : ISortedList
    {
        public List<int> Sort(List<int> unsorted)
        {
            List<int> result = new List<int>();
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            if (unsorted.Count <= 1)
                return unsorted;

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
                left.Add(unsorted[i]);
            for (int i = middle; i < unsorted.Count; i++)
                right.Add(unsorted[i]);
            left = Sort(left);
            right = Sort(right);
            if (left[left.Count - 1] <= right[0])
                return append(left, right);
            result = merge(left, right);
            return result;
        }

        private List<int> append(List<int> a, List<int> b)
        {
            List<int> result = new List<int>(a);
            foreach (int x in b)
                result.Add(x);
            return result;
        }

        private List<int> merge(List<int> a, List<int> b)
        {
            List<int> s = new List<int>();
            while (a.Count > 0 && b.Count > 0)
            {
                if (a[0] < b[0])
                {

                    s.Add(a[0]);
                    a.RemoveAt(0);
                }
                else
                {

                    s.Add(b[0]);
                    b.RemoveAt(0);
                }
            }
            while (a.Count > 0)
            {
                s.Add(a[0]);
                a.RemoveAt(0);
            }

            while (b.Count > 0)
            {
                s.Add(b[0]);
                b.RemoveAt(0);
            }


            return s;
        }
    }
}
