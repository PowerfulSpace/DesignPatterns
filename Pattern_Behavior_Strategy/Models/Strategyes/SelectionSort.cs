﻿namespace Pattern_Behavior_Strategy.Models.Strategyes
{
    class SelectionSort : Strategy
    {
        public override void Sort(ref int[] array)
        {
            Console.WriteLine("SelectionSort");

            for (int i = 0; i < array.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[k] > array[j])
                    {
                        k = j;
                    }
                }
                if (k != i)
                {
                    int temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}
