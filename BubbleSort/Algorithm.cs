using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class Algorithm
    {
        public int[] unsortedArray { get; set; }

        public void Inputs(int size)
        {
            Console.WriteLine("How big do you want the array to be?");
            Console.WriteLine();

            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter your array:");

            Console.WriteLine();

            unsortedArray = new int[size];

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void BubbleSort()
        {
            int unsortedArrayLength = unsortedArray.Length;

            for (int i = 0; i < unsortedArrayLength - 1; i++)
            {

                for (int j = 0; j < unsortedArrayLength - i - 1; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        int temp = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sorted array:");

            foreach (int num in unsortedArray)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
