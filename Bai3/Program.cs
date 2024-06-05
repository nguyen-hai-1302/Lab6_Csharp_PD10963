using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5};
            List<int> list2 = new List<int>() { 5, 6, 7, 8, 1};
            // 
            Console.WriteLine("Bai 1:");
            Console.WriteLine("Bai 1a: Union");
            var union = list1.Union(list2).OrderByDescending(x => x);
            foreach (int item in union)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            // 
            Console.WriteLine("Bai 1b: Intersect");
            var intersect = list1.Intersect(list2);
            foreach (int item in intersect)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            // 
            Console.WriteLine("Bai 1c: Concat");
            var concat = list1.Concat(list2).OrderBy(x => x);
            foreach (int item in concat)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            // 
            Console.WriteLine("Bai 1c: Except");
            var except = list1.Except(list2);
            foreach (int item in except)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
