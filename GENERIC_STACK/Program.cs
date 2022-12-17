using System;
using System.Collections.Generic;
namespace GENERIC_STACK
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
            var stack = new Stack<double>();
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
            var stack = new Stack<string>();
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

    public class Stack<T>
    {

        private readonly T[] elements;
        private int pointer = -1;

        //Constructor
        public Stack() => elements = new T[10];
        public int count => pointer + 1;
        public void Push(T item)
        {
            elements[++pointer] = item;
        }
        public T Pop() => elements[pointer--];

    }
}