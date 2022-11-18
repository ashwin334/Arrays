using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arrays
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //syntax of array in C#
            int[] numbers = new int[5]; // 5 size
                                        // to hold rainfall for a week
            double[] rainfall = new double[7];

            string[] names = new string[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i=0; i < numbers.Length; i++)
            //{
            // Console.Writeline($"numbers[{i}] = {numbers[i]}");
            //}

            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine(rainfall[i]);
            }
            for (int j = 0; j < rainfall.Length; j++)
            {
                Console.Write(rainfall[j]);
            }

        }
    }
}

