using System;
using System.Linq;

namespace seriesone.ArrayTest
{
    public class ArrayTest
    {
        public void Check()
        {
            int[,] bb = new int[2, 2];

            int[,] aa = new int[,]
            {
                { 1,2},
                { 3,4}
            };

            int[,] cc = new int[2, 2]
            {
                { 1,2},
                { 3,4}
            };

            int[,] dd =
            {
                { 1, 2},
                { 3, 4}
            };

            int[] arr = new int[5];
            arr[1] = 1;
            arr.SetValue(2, 2);
            arr[3] = 3;
            arr.SetValue(4, 4);
            Console.WriteLine(arr.GetValue(2));
            Console.WriteLine(arr[1]);
            Console.WriteLine("-----------");
            foreach (int val in arr)
            {
                Console.Write(val + " - ");
            }
            Console.WriteLine("-----------");
            Console.WriteLine("index of 2 is -> {0}", Array.IndexOf(arr, 2));
            Console.WriteLine("Lenth of array is -> {0} ", arr.Length);
            Console.WriteLine("Element 3 exists -> {0}", Array.Exists(arr, a => a == 3));
            Console.WriteLine("Element 3 exists -> {0}", Array.Find(arr, a => a == 4));
            var rArr = arr.Reverse();
            Console.WriteLine("-----Reverse array is------");
            foreach (int val in rArr)
            {
                Console.Write(val + " - ");
            }
            Console.WriteLine("-----------");
        }
    }
}
