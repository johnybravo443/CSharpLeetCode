using System;

namespace seriesone.ArrayTest
{
    class ArrayCustom
    {
        private int[] arr;
        private int count;

        public ArrayCustom(int n = 0)
        {
            arr = new int[n];
            count = 0;
        }

        public void insert(int num)
        {
            //if (arr[0] == 0)
            //    arr[0] = num;
            //else if (arr[arr.Length-1] != 0)
            //{
            //    int[] temp = new int[arr.Length + 1];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        temp[i] = arr[i];
            //    }
            //    temp[temp.Length - 1] = num;
            //    arr = temp;
            //}
            //else
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] != 0)
            //            continue;
            //        else
            //        {
            //            arr[i] = num;
            //            break;
            //        }
            //    }
            //}

            if(arr.Length == 0)
            {
                int[] temp = new int[1];
                //temp[0] = num;
                arr = temp;
                //count = arr.Length;
            }
            else if (arr.Length == count)
            {
                int[] temp = new int[count * 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }
            arr[count++] = num;
        }

        public void InsertAt(int item, int index)
        {
            if (arr.Length == count)
            {
                int[] temp = new int[count * 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }

            if (index > Capacity())
                throw new IndexOutOfRangeException("index is out of range.");
            else if (index == (count + 1))
                insert(item);
            else
            {
                for (int i = count; i >= index; i--)
                {
                    arr[i] = arr[i - 1];
                    if (i == index)
                    {
                        arr[i - 1] = item;
                        ++count;
                    }
                }
            }
        }

        public void RemoveAll()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                arr[i] = 0;

            }
            count = 0;
        }

        public void RemoveAt(int index)
        {
            //check if the element exist at that index
            if (index <= count && index > 0)
            {
                //remove the element
                for (int i = index; i <= count; i++)
                {
                    //move the succeeding elements to the left
                    if(i == count)
                    {
                        arr[i-1] = 0;
                        break;
                    }

                    arr[i - 1] = arr[i];
                }
                count--;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
        }

        public void FindAt(int index)
        {

            Console.WriteLine("element at {0} is {1}", index, arr[index-1]);
        }

        public int IndexOf(int value)
        {
            for(int i = 0; i < count; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine("The index of element {0} is {1}", value, i + 1);
                    return i + 1;
                }
            }

            return -1;
        }

        public void Print()
        {
            Console.Write("array is -> ");
            //foreach (int val in arr)
            //    Console.WriteLine(val);
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public int Count()
        {
            Console.WriteLine("Array Element Count is -> {0}", count);
            return count;
        }

        public int Capacity()
        {
            var length = arr.Length;
            Console.WriteLine("Array capacity is -> {0}", length);
            return length;
        }

        //O(n): Best case is O(1), Worst case is O(n)
        public int Max()
        {
            if(count == 0)
            {
                throw new IndexOutOfRangeException("the array Capacity is 0");
            }
            else
            {
                int max = 0;
                for (int i = 0; i < count; i++)
                {
                    if (arr[i] >= max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }
        }

        //10,50,20,50,5
        //50,5
        public int[] Intersect(int[] arr1)
        {
            if(arr.Length != 0 && arr1.Length != 0)
            {
                //var tempArr = new int[arr1.Length];
                ArrayCustom tempArr = new ArrayCustom();
                //int i = 0;
                foreach (int val in arr)
                {
                    //int flag = 0;
                    foreach (int val1 in arr1)
                    {
                        if (val1 == val && ArrayCustom.Find(tempArr.arr, val1) == false)
                        {
                            tempArr.insert(val1); //tempArr[i++] = val1;
                            break;
                        }
                    }
                }
                //if (i == 0)
                    //  return Array.Empty<int>();
                //else
                    return tempArr.arr;
            }
            return Array.Empty<int>();
        }

        public static bool Find(int[] arr1, int value)
        {
            if (arr1.Length == 0)
            {
                return false;
            }
            else
            {
                foreach (int val in arr1)
                {
                    if (val == value)
                        return true;
                }
            }
            return false;
        }

        public void Reverse()
        {
            for(int i = 1; i <= (count/2); i++)
            {
                var temp = arr[i - 1];
                arr[i-1] = arr[count-i];
                arr[count-i] = temp;
            }
        }
    }
}

//test code
//ArrayCustom test
//ArrayCustom arr = new ArrayCustom(2);
//arr.Print();
//arr.Count();
//arr.Capacity();
//arr.insert(10);
//arr.Print();
//arr.Count();
//arr.Capacity();
//arr.insert(20);
//arr.insert(30);
//arr.insert(40);
//arr.insert(50);

//arr.FindAt(5);
//Console.WriteLine(arr.IndexOf(90));
//Console.WriteLine(arr.IndexOf(30));

//arr.RemoveAt(2);
//arr.Print();
//arr.Count();
//arr.Capacity();

//arr.RemoveAll();
//Console.WriteLine("After RemoveAll the array is ->");
//arr.Print();
//arr.Count();
//arr.Capacity();

//arr.insert(10);
//arr.insert(20);
//arr.insert(30);
//arr.insert(40);
//arr.insert(50);

//Console.WriteLine("max value is -> {0}", arr.Max());

//var tempArr = arr.Intersect(new int[] { 50, 30 });
//Console.WriteLine("the common items in both array are -> {0}", string.Join(",", tempArr));

//Console.WriteLine("Inserting an item at a given index");
//arr.InsertAt(60, 4);
//arr.Print();
//arr.Count();

//Console.WriteLine("Reversing the array");
//arr.Print();
//arr.Reverse();
//arr.Print();