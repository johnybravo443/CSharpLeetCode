using System;
using System.Collections.Generic;

namespace seriesone.ArrayTest
{
    public class ListPractice
    {
        public void ListTest()
        {
            List<int> intList = new List<int>(3);
            
            List<int> arr1 = new List<int>(3);

            List<int> arr2 = new List<int>(3) { 1, 2, 3 };

            Console.WriteLine("capacity is -> {0}", intList.Capacity);
            intList.Insert(0, 1);
            intList.Insert(1, 2);
            intList.Insert(2, 3);
            intList.Insert(3, 4);
            intList.Insert(4, 5);
            intList.Insert(5, 2);
            Console.WriteLine("capacity is -> {0}", intList.Capacity);
            Console.WriteLine("--------------------------");
            foreach(int val in intList)
            {
                Console.Write(val + " - ");
            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Total elements in List are -> {0}", intList.Count);
            Console.WriteLine("index of 2 is -> {0}", intList.IndexOf(2));
            Console.WriteLine("last index of 2 is -> {0}", intList.LastIndexOf(2));
            intList.RemoveAt(4);
            Console.WriteLine("---------after removing at index 4-----------------");
            foreach (int val in intList)
            {
                Console.Write(val + " - ");
            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("capacity is -> {0}", intList.Capacity);
            Console.WriteLine("List contains 4 -> {0}", intList.Contains(4));
            var abc = intList.ToArray();
            Console.WriteLine("------converted to array--------------------");
            foreach (int val in abc)
            {
                Console.Write(val + " - ");
            }
            Console.WriteLine("\n--------------------------");
        }
    }
}
