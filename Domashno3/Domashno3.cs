﻿using System;
class RisingSequenece
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayInt = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i+1}: ");
            arrayInt[i] = int.Parse(Console.ReadLine());
        }
        int[] sequenceLength = new int[n];
        int[] previousInd = new int[n];
        int bestEndInd = 0;
        int maxCount = 0;
        for (int i = 0; i < arrayInt.Length; i++)
        {
            int maxBefore = 0;
            for (int j = 0; j < i; j++)
            {
                if (arrayInt[j] < arrayInt[i] && sequenceLength[j] > maxBefore)
                {
                    maxBefore = sequenceLength[j];
                    previousInd[i] = j;
                }
            }
            sequenceLength[i] = maxBefore + 1;
            if (sequenceLength[i] > maxCount)
            {
                maxCount++;
                bestEndInd = i;
            }
        }
        int arrayIntInd = bestEndInd;
        int[] bestSequence = new int[maxCount];
        for (int i = 0; i < maxCount; i++)
        {
            bestSequence[i] = arrayInt[arrayIntInd];
            arrayIntInd = previousInd[arrayIntInd];
        }
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(bestSequence[maxCount - i - 1]);
            if (i < maxCount - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
