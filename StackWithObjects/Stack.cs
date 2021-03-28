using System;
using System.Collections;
using System.Threading.Channels;

namespace StackWithObjects
{
    class Stack
    {
        private ArrayList stack = new ArrayList();

        public void Push(object obj)
        {
            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is  empty");
                return null;
            }
            var lastInStack = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return lastInStack;
        }

    }
}