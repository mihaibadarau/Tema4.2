using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue Rand = new Queue();
            //Rand.Enqueue("Mihai");
            //Rand.Enqueue("Badarau");
            //Rand.Enqueue("Andrei");
            //Rand.Enqueue("Florin");
            //Rand.Enqueue("Catalin");

            //Console.WriteLine("Numarul total de elemenete din rand este: ", Rand);
            //Console.WriteLine(Rand.Count);

            //var arr = Rand.ToArray();

            //foreach (object obj in arr)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("Elementul de varf din rand este: ", Rand);
            //Console.WriteLine(Rand.Dequeue());

            //Console.WriteLine("Numarul de elemente din rand este: {0} ", Rand.Count);

            //////////////////////////////

            Queue Q = new Queue(5);

            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.Enqueue(3);
            Q.Enqueue(4);
            Q.printQueue();
            Q.Dequeue();

            Stack myStack = new Stack();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.PrintStack();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();


        }
    }
}
