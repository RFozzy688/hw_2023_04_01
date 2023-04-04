﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2023_04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array1D array = new Array1D(10);

            Random random = new Random();

            for (int i = 0; i < array.Size; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            foreach (var item in array)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();
        }
    }
}
