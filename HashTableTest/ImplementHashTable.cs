using System;
using System.Collections.Generic;

namespace seriesone.HashTableTest
{
    class ImplementHashTable
    {
        private LinkedList<Entry>[] htable;

        public ImplementHashTable(int size)
        {
            htable = new LinkedList<Entry>[5];
        }

        private int Hash(int key)
        {
            return key % htable.Length;
        }

        public void Put(int key, string value)
        {
            var index = Hash(key);
            var node = new Entry(key, value);
            if(htable[index] == null)
            {
                LinkedList<Entry> first = new LinkedList<Entry>();
                first.AddFirst(node);
                htable[index] = first;
            }
            else
            {
                var nodes = htable[index];

                // iterate and see if key exist and if so, update the value and return.
                foreach(var nod in nodes)
                {
                    if (nod.Key == key)
                    {
                        nod.Value = value;
                        return;
                    }
                }

                //if the key doesn't exist, just add the new node at the end.
                nodes.AddLast(node);
            }
        }

        public string Get(int key)
        {
            var index = Hash(key);
            var nodes = htable[index];

            if (nodes == null)
            {
                //throw new NullReferenceException($"Empty Index {index}");
                return null;
            }
            else
            {
                //return htable[index];
                foreach (var node in nodes)
                {

                    if (node.Key == key)
                    {
                        //Console.Write($"k:{node.Key},v:{node.Value} ||");
                        return node.Value;
                    }
                }
                return null;
            }
        }

        public void Remove(int key)
        {
            var index = Hash(key);
            var nodes = htable[index];
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    
                    if (node.Key == key)
                    {
                        nodes.Remove(node);
                        return;
                    }
                }
                htable[index] = null;
            }
            else
                throw new NullReferenceException($"the index {index} has no value");
        }

        public void Iterate()
        {
            foreach(var node in htable)
            {
                //var node = index;
                if(node != null)
                {
                    var en = node.GetEnumerator();
                    while(en.MoveNext())
                    {
                        var val = en.Current;
                        Console.Write($"k:{val.Key},v:{val.Value} ||");
                    }
                }
                else
                {
                    Console.Write("Empty");
                }
                Console.WriteLine();
            }
        }
    }

    public class Entry
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public Entry(int key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}


//code to test this class
//ImplementHashTable ht = new ImplementHashTable(5);
//ht.Put(6, "A");
//ht.Put(8, "B");
//ht.Put(11, "C");
//ht.Put(6, "A+");

//ht.Iterate();

//Console.WriteLine("\nGetting value at index 11");
//Console.Write($"k:{11},v:{ht.Get(11)} \n");

//ht.Remove(6);
//Console.WriteLine("\nafter removing 6, the Hashtable is");
//ht.Iterate();