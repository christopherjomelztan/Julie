using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpSortingAlgorithms.Interface;
using CSharpSortingAlgorithms.Class;

namespace CSharpSortingAlgorithms.Factory
{
    public class SortFactory : ISortFactory
    {
        public ISortedList SortedList(string sortType)
        {
            switch (sortType) { 
                case "Quick Sort":
                    return new QuickSort();
                case "Merge Sort":
                    return new MergeSort();
                case "Heap Sort":
                    return new HeapSort();
                case "Bubble Sort":
                    return new BubbleSort();   
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
