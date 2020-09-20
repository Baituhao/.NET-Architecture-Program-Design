using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace HW2.EX3
{
    // 委托
    delegate void Func(int i);
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 4, 2, 3, 5, 7, 6 };

            int max = -1;
            int min = 100;
            int sum = 0;
            // lambda表达式赋值给委托
            Action<int> print_all = (i => Console.WriteLine(i));
            Action<int> act_max = (i => max = i > max ? i : max);
            Action<int> act_min = (i => min = i < min ? i : min);
            Action<int> act_sum = (i => sum += i);

            Console.WriteLine("print all");
            list.ForEach(print_all);
            list.ForEach(act_max);
            list.ForEach(act_min);
            list.ForEach(act_sum);

            Console.WriteLine($"max={max}");
            Console.WriteLine($"min={min}");
            Console.WriteLine($"sum={sum}");
        }
    }
}
