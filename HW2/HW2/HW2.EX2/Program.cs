using System;
using System.Drawing;

namespace HW2.EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            // here take 10 randomly generated shapes
            Console.WriteLine("Here takes 10 randomly generated shapes, and sum the area");
            Console.WriteLine(factory.SumOfArea(10));
        }
    }
}
