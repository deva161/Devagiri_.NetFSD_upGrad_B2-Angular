using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day2
{
    internal class Stackdemo
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Type A");
            stack.Push("Type B");
            stack.Push("Type C");
            stack.Pop();
            stack.Pop();
            Console.WriteLine("The Remaining Stack Values : ");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
        }
    }
}
