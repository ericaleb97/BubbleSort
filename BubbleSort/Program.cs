using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            var algo = new Algorithm();
            algo.Inputs(size);
            algo.BubbleSort();
        }
    }
}
