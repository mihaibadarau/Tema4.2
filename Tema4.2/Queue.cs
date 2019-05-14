using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4._2
{
    class Queue
    {
        private int[] elemente;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            elemente = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                elemente[++rear] = item;
            }

        }

        public int Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine(elemente[front] + " dequeued from queue");
                int p = elemente[front++];
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", elemente[front]);
                Console.WriteLine("Rear item is {0} ", elemente[rear]);
                return p;
            }

        }

        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(elemente[i] + " enqueued to queue");
                }
            }

        }
    }
}
