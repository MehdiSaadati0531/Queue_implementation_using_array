using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue_Array
    {
        private int[] Queue;
        private int rear;
        private int front;

        public Queue_Array(int SizeQueue)
        {
            Queue = new int[SizeQueue];
            front = 0;
            rear = 0;
        }

        public bool IsEmpty()
        {
            if (rear <= front)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (Queue.Length <= rear)
                return true;
            return false;
        }

        public void De()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue UnderFlow");
            }
            else
            {
                rear--;
                for (int i = 0; i < Queue.Length - 1; i++)
                {
                    Queue[i] = Queue[i + 1];
                }
            }
        }

        public void En(int newnumber)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue OverFlow");
            }
            else
            {
                Queue[rear] = newnumber;
                rear++;
            }
        }

        public void Queue_display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue UnderFlow");
            }
            else
            {
                for (int i = front; i < rear; i++)
                {
                    Console.WriteLine(Queue[i]);
                }
            }
        }
    }
}
