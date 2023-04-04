using System;
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
                array[i] = random.Next(-20, 20);
            }

            foreach (var item in array)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            Console.WriteLine($"Количество чисел < 4: {array.Less(4)}");
            Console.WriteLine($"Количество чисел > 10: {array.Greater(10)}");

            Console.WriteLine();

            Console.WriteLine("Четные элементы");
            array.ShowEven();
            Console.WriteLine();

            Console.WriteLine("Не четные элементы");
            array.ShowOdd();
            Console.WriteLine();
        }
    }
}
