using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue s = new CircularQueue(10);

            s.enqueue(-20);
            s.enqueue(69);
            s.enqueue(-14);
            s.enqueue(-93);
            s.enqueue(57);
            s.enqueue(19);
            s.enqueue(-65);
            s.enqueue(83);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Circular Queue Is : ");
            s.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("Circular Queue Is : ");
            //s.dequeue();
            //s.dequeue();
            //s.print();
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //int a = s.Avg();
            //Console.WriteLine("Average Is : ");
            //Console.WriteLine(a);
            //Console.ResetColor();

            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Blue;
            //int am = s.Avgminus();
            //Console.WriteLine("Minus Average Is : ");
            //Console.WriteLine(am);
            //Console.ResetColor();

            Console.ReadKey();
        }
    }
}
