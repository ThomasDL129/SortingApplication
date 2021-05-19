using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    public enum SortingAlgorithm
    {
        BubbleSort,
        ShakerSort,
        QuickSort
    }

    class SortingAlgorithmTester
    {
        

        public void Test()
        {
            var values = (SortingAlgorithm[])Enum.GetValues(typeof(SortingAlgorithm));
            var sortAlgorithms = new List<ASort>();

            for (int i = 0; i < values.Length; i++)
            {
                sortAlgorithms.Add(SortingFactory.Create(values[i].ToString()));
            }
            
            foreach (var algorithm in sortAlgorithms)
            {
                algorithm.Swapped = 0;
                int[] array = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
                algorithm.Sort(array);
                Console.WriteLine($"sorting done using {algorithm}, needed {algorithm.Swapped} swaps to sort the array");
            }

            Console.ReadKey();
        }
    }
}
