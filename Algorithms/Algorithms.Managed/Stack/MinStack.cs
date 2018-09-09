using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Stack
{
    /// <summary>
    /// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time. 
    ///     push(x) -- Push element x onto stack.
    ///     pop() -- Removes the element on top of the stack.
    ///     top() -- Get the top element.
    ///     getMin() -- Retrieve the minimum element in the stack.
    /// </summary>
    public class MinStack
    {
        private readonly Stack<int> stack = new Stack<int>();
        private int min = int.MaxValue;

        public void Push(int x)
        {
            if (x <= min)
            {
                stack.Push(min);
                min = x;
            }
            stack.Push(x);
        }

        public void Pop()
        {
            if (stack.Pop() == min)
            {
                min = stack.Pop();
            }
        }

        public int Top() => stack.Peek();

        public int GetMin() => min;
    }
}
