using System;

/*test code
 * 
 *         public static void Main(string[] args)
        {
            Program p = new Program();
            p.AddFirst(1);
            p.AddFirst(2);
            p.AddFirst(3);
            p.AddFirst(4);
            p.AddLast(5);
            p.AddLast(6);
            p.Count();
            p.FindMiddle();
            //p.Display();
            //p.KthNodeFromEndMosh(-2);
            //p.Reverse();
            //p.ReverseMosh(); ;
            //p.Reverse();
            //p.Count();
            //p.IndexOf(5);
            //p.Display();
            //p.DeleteFirst();
            //p.Count();
            //p.Display();
            //p.DeleteLast();
            //p.Count();
            //p.Display();
            //p.IndexOf(3);
            //Console.WriteLine("===> {0}", p.Contains(3));
            //p.ToArray();
        }
 * 
 * 
 */
namespace seriesone.LinkedListTest
{
    class CreateLinkedList
    {
        private class Node
        {
            public Node node;
            public int value;
        }

        private Node first;
        private Node last;
        private int count;

        public CreateLinkedList()
        {
            first = null;
            last = null;
        }

        public void FindMiddle()
        {
            if (first == null)
                throw new NullReferenceException("Linked List is empty");
            if (first.node == null)
                Console.WriteLine($"--middle is {count}");

            var next = first;
            var mid = first;

            if (count % 2 != 0)
            {
                for (int i = 1; i < count; i += 2)
                {
                    next = next.node.node;
                    mid = mid.node;
                }
                Console.WriteLine($"middle is {mid.value}");
            }
            else
            {
                next = next.node;
                for (int i = 2; i < count; i += 2)
                {
                    next = next.node.node;
                    mid = mid.node;
                }
                Console.WriteLine($"middle is {mid.value} and {mid.node.value}");
            }
        }

        // 1 2 3 4 5
        // 3
        public int KthNodeFromEnd(int index)
        {
            if (first == null)
                throw new NullReferenceException("Linked List is empty");

            var next = first;
            Node second = null;
            int counter = 0;
            while (next != null)
            {
                if (second != null)
                    second = second.node;

                if (counter == index - 1)
                {
                    second = first;
                }

                next = next.node;
                counter++;
            }

            if (second != null)
            {
                Console.WriteLine($"{index} node from last is {second.value}");
                return second.value;
            }
            else
            {
                Console.WriteLine("index out of range");
                return -1;
            }
        }

        // 1 2 3 4 5
        // 3
        public int KthNodeFromEndMosh(int index)
        {
            if (first == null)
                throw new NullReferenceException("Linked List is empty");
            else if (index <= 0)
                throw new IndexOutOfRangeException("index out of range in negative");

            Node next = null;
            var second = first;

            for (int i = 0; i < index; i++)
            {
                if (i == 0)
                    next = first;
                else
                    next = next.node;

                if (next == null)
                    throw new NullReferenceException("index out of range");
            }

            while (next.node != null)
            {
                second = second.node;
                next = next.node;
            }

            Console.WriteLine($"{index} node from last is {second.value}");
            return second.value;
        }

        // Revese using array
        public void Reverse()
        {
            Node next = first;
            Node[] n = new Node[count];
            int index = 0;
            while (next != null)
            {
                n[index] = next;
                next = next.node;
                index++;
            }

            for (int i = n.Length - 1; i >= 0; i--)
            {
                if (i == n.Length - 1)
                    first = n[i];

                if (i == 0)
                {
                    n[i].node = null;
                    break;
                }
                last = n[i - 1];
                n[i].node = last;
            }

            Display();
        }

        //in place reversal
        // 10   20  30
        //  p   c   n
        public void ReverseMosh()
        {
            var previous = first;
            var current = first.node;
            while (current != null)
            {
                var next = current.node;
                current.node = previous;
                //previous.node = null;
                previous = current;
                current = next;
            }

            last = first;
            last.node = null;
            first = previous;

            Display();
        }

        public void AddFirst(int val)
        {
            Node node = new Node
            {
                value = val,
                node = null
            };

            if (first == null)
            {
                first = node;
                last = node;
                Console.WriteLine($"added {val}");
            }
            else
            {
                last.node = node;
                last = node;
                Console.WriteLine($"added {val}");
            }

            ++count;
        }

        public void AddLast(int val)
        {
            Node node = new Node
            {
                value = val,
                node = null
            };

            if (first == null)
            {
                first = node;
                last = node;
                Console.WriteLine($"added {val}");
            }
            else
            {
                last.node = node;
                last = node;
                Console.WriteLine($"added {val}");
            }
            ++count;
        }

        public void DeleteFirst()
        {
            if (first == null)
                throw new DllNotFoundException();

            if (first == last)
                return;

            Node toBeDeleted = first;
            first = first.node;
            Console.WriteLine($"Deleted {toBeDeleted.value}");
            toBeDeleted.node = null;

            --count;
        }

        public void DeleteLast()
        {
            if (first == null)
                throw new DllNotFoundException();

            if (first == last)
                return;

            Node next = first;
            Node previous = null;
            while (next.node != null)
            {
                previous = next;
                next = next.node;
            }

            Console.WriteLine($"deleted {next.value}");
            previous.node = null;
            last = previous;

            --count;
        }

        public int IndexOf(int val)
        {
            Node next = first;
            int count = 0;

            while (next != null)
            {
                if (next.value == val)
                    break;
                else
                    count++;

                next = next.node;
            }

            Console.WriteLine($"The index of {val} is {count}");
            return count;
        }

        public bool Contains(int val)
        {
            Node next = first;

            while (next != null)
            {
                if (next.value == val)
                    return true;
                else
                    next = next.node;
            }

            //do
            //{
            //    if (next.value == val)
            //        return true;
            //    else
            //        next = next.node;
            //}
            //while(next.node != null);

            return false;
        }

        public void Display()
        {
            Console.WriteLine($"first node -> {first.value}");
            Console.WriteLine($"last node -> {last.value}");
            Console.Write("---> ");

            Node next = first;

            //way 1
            //while (!object.ReferenceEquals(next, last))
            //{
            //    Console.Write($"{next.value} ");
            //    next = next.node;
            //}

            //way 2
            //while (next.node != null)
            //{
            //    Console.Write($"{next.value} ");
            //    next = next.node;
            //}

            //way 3
            //do
            //{
            //    Console.Write($"{next.value} ");
            //    next = next.node;
            //}
            //while (next.node != null);

            while (next != null)
            {
                Console.Write($"{next.value} ");
                next = next.node;
            }
            Console.WriteLine();
        }

        public int Count()
        {
            Console.WriteLine($" >>>>>>>>> The count is {count}");
            return count;
        }

        public int[] ToArray()
        {
            int[] arr = new int[count];
            var index = 0;
            Node next = first;

            while (next != null)
            {
                arr[index++] = next.value;
                next = next.node;
            }

            Console.WriteLine("Array is -> {0}", string.Join(" ", arr));
            return arr;
        }
    }
}
