using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StackTest
{
    class Stack
    {
        Stack<int> stack = new Stack<int>();
        int int1 { get; set; }
       public void Push(object obj)
        {
            if (obj == null)
            {
                throw new System.InvalidOperationException("Input was not valid.");
            }
            else
            {
                int1 = Convert.ToInt32(obj);
                stack.Push(int1);
                return;
            }                                 
        }

      public object Pop()
        {
            if (stack == null)
            {
                throw new System.InvalidOperationException("Error: The stack is empty.");
            }
            else
            {

                
                return stack.Pop();
            }
        }

        public void Clear()
        {
            if (stack != null)
            {
                stack.Clear();
            }
        }
    }
}
