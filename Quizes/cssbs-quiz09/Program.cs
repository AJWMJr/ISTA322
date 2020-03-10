using System;
using System.Collections.Generic;

namespace cssbs_quiz09
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Dic = new Dictionary<string, int>();
            Dic.Add("One", 1);
            Dic.Add("Two", 2);
            Dic.Add("Three", 3);
            Stack<string> stack = new Stack<string>();
            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            Queue<string> q = new Queue<string>();
            q.Enqueue("One");
            q.Enqueue("Two");
            q.Enqueue("Three");
            Console.WriteLine("Here is the Queue:");
            foreach (string s in q)
                Console.WriteLine(s);
            Console.WriteLine("Here is the Stack:");
            foreach (string s in stack)
                Console.WriteLine(s);
            Console.WriteLine("Here is the Dictionary:");
            foreach (KeyValuePair<string, int> e in Dic)
            {
                string str = e.Key;
                int i = e.Value;
                Console.WriteLine($"{str}: {i}");
            }
        }
    }
}
