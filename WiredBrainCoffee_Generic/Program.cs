using System;
using System.Diagnostics.CodeAnalysis;

namespace STACK_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
        }
        private static void StackDoubles()
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.1);
            stack.Push(2.6);
            //stack.Push(true);    it is type safe.
           
            
            double sum = 0.0;

            while (stack.count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine(item);
                sum += item;
            }
            Console.WriteLine(sum);
        }
        private static void StackStrings()
        {
            var stack = new SimpleStack<string>();
            stack.Push("stack");
            stack.Push("string");
            stack.Push("is");
            stack.Push("This");
            stack.Push("Hii");
            // stack.Push(true);   it is type safe.
            while (stack.count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }
}