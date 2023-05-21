using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Example_3
{
    class CircularQueue
    {
        public int[] q;
        public int front;
        public int rear;
        public int max;

        public CircularQueue(int size)
        {
            q = new int[size];
            max = size;
            rear = -1;
            front = -1;
        }
        public void print()
        {
            if (front == -1)
            {
                Console.WriteLine("Circular Queue Is Empty !");
                return;
            }
            if (rear >= front)
            {
                for (int i = front; i <= rear; i++)
                    Console.Write($"{q[i]} . ");
            }
            else
            {
                for (int i = front; i < max; i++)
                    Console.Write($"{q[i]} . ");

                for (int i = 0; i <= rear; i++)
                    Console.Write($"{q[i]} . ");
            }
        }
        public void enqueue(int data)
        {
            if ((front == 0 && rear == max - 1) || (rear == (front - 1) % (max - 1)))
            {
                Console.Write("Circular Queue Is Full !");
                return;
            }

            else if (front == -1)
            {
                front = 0;
                rear = 0;
                q[rear] = data;
            }

            else if (rear == max - 1 && front != 0)
            {
                rear = 0;
                q[rear] = data;
            }

            else
            {
                q[++rear] = data;
            }
        }
        public int dequeue()
        {
            if (front == -1)
            {
                Console.WriteLine("Circular Queue Is Empty !");
                return -1;
            }

            int data = q[front];
            Console.WriteLine($"{q[front]} Is Deleted...");
            q[front] = -1;
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == max - 1)
                front = 0;
            else
                front++;

            return data;
        }
        public int Avg()
        {
            int k;
            int l = front;
            int sum = 0;
            int Avg;
            int c = 0;
            for (k = front; l < max - 1;)
            {
                sum += q[k];
                c++;
                k = (k + 1) % max;
                l++;
            }
            Console.Write($"Sum Is : {sum}");
            Console.Write($"\nCount Is : {c}\n");
            Avg = sum / c;
            return Avg;
        }
        public int Avgminus()
        {
            int k;
            int l = front;
            int sum = 0;
            int Avg;
            int c = 0;
            Console.WriteLine("Minus Items Are : ");
            for (k = front; l < max - 1;)
            {
                if (q[k] < 0)
                {
                    sum += q[k];
                    Console.WriteLine(q[k]);
                    c++;
                }
                k = (k + 1) % max;
                l++;
            }
            Avg = sum / c;
            return Avg;
        }
    }
}
