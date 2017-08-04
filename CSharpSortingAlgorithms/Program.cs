using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using CSharpSortingAlgorithms.Class;
using CSharpSortingAlgorithms.Interface;
using CSharpSortingAlgorithms.Factory;

namespace CSharpSortingAlgorithms
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Constants.programName + " " + Constants.programVersion);
            Process();
        }
        public static void Process()
        {
            string input = "";
            string sortType = "";
            Console.WriteLine("Please enter your input numbers separated by comma: ");
            input = Console.ReadLine();
            Console.WriteLine("Thank you. Please enter mode of sorting\n1. Quick Sort\n2. Merge Sort\n3. Heap Sort\n4. Bubble Sort");
            sortType = Console.ReadLine();

            List<int> unsorted = input.Split(',').Select(int.Parse).ToList();
            ISortFactory sortFactory = new SortFactory();
            ISortedList sortedList = sortFactory.SortedList(sortType);


            (sortedList.Sort(unsorted)).ForEach(Console.WriteLine);

            Console.WriteLine("Do you want to continue...");

            switch(Console.ReadLine())
            {
                case "Y":
                    Process();
                    break;
            }
        }
    }
}
