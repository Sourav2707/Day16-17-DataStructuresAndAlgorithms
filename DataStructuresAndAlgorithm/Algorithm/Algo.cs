﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Algo
    {
        public static int[] bubbleSort(int[] array)                     //bubble sort an integer array
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tempo = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempo; ;
                    }
                }
            }
            return array;
        }
    }
}