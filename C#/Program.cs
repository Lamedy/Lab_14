using System;
using System.Collections;

namespace Lab_14
{
    public abstract class one
    {
        public abstract void print();
    };
    class two : one {
        public int x;
        public two() { x = 0; }
        public two(int a) { x = a; }

        public override void print() {
            System.Console.WriteLine("X = " + x);
        } 
    };
    class three : one
    {
        public int x;
        public int y;
        public three() { x = 0; y = 0; }
        public three(int a, int b) { x = a; y = b; }
        public override void print()
        {
            System.Console.WriteLine("X = " + x + "\tY = " + y);
        }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            two a = new two(1);
            three b = new three(2, 3);
            arr.Add(a);
            arr.Add(b);
            
            Console.ReadLine();
        }
    }
};
