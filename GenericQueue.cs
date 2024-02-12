using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
    public class GenericQueue<T>
    {
        private T[] queue;
        private int size;
        private int front;
        private int rear;

        public GenericQueue(int capacity)
        {
            queue = new T[capacity];
            rear = -1;
        }

        public void Enqueue(T item)
        {
            if (rear == queue.Length -1)
            {
                throw new Exception("Queue is full");
            }
            queue[++rear] = item;
            size++;
        }

        public T Dequeue()
        {
            if(size == 0)
            {
                throw new Exception("queue is empty");
            }
            size--;
            return queue[front++];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
        public bool IsFull()
        {
            return size == queue.Length;
        }

    }
        
}
