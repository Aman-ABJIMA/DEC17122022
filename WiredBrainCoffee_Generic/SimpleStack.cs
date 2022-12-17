using System.Reflection;
using System.Xml.Linq;

namespace STACK_APP
{
    public class SimpleStack<T>
    {

        private readonly T[] elements;
        private int pointer = -1;

        //Constructor
        public SimpleStack()=>elements = new T[10];
        public int count => pointer + 1;
        public void Push(T item)
        {
            elements[++pointer] = item;
        }
        public T Pop() => elements[pointer--];

    }
    //BY USING THIS TECHNIQUE NOW WE CAN WORK WITH BOTH DOUBLE AND STRING TYPE ELEMENTS, SO THERE FOR IT INHANCES CODE REUSABILITY.

    //Now We don't need for this (SimpleStackString) class given below!!!!  
    
    
    //public class SimpleStackString
    //{
    //    private readonly string[] elements;
    //    private int pointer = -1;

    //    Constructor
    //    public SimpleStackString() => elements = new string[10];
    //    public int count => pointer + 1;
    //    public void Push(string item)
    //    {
    //        elements[++pointer] = item;
    //    }
    //    public string Pop() => elements[pointer--];
    //}
}