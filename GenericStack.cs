using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
    public class GenericStack<T>
    {
        private T[] stack;
        int top;

        public GenericStack(int size)
        {
            stack = new T[size];
            top = -1;
        }

        public void push(T item)
        {
            if (top == stack.Length-1)
            {
                throw new StackOverflowException("Stack is full");
            }
            else
            {
                top++;
                stack[top] = item;
            }
        }

        public T pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            
            return stack[top--];
        }

        public T peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stack[top];
        }

        public bool IsEmpty()
        {
            return stack.Length == 0;
        }
    }
}
