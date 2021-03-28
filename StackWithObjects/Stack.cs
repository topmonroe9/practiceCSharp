using System.Collections;

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
            var lastInStack = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return lastInStack;
        }

    }
}