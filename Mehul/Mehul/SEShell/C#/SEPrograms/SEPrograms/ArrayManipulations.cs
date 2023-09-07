using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPrograms
{
    internal class ArrayManipulations
    {
        public void disp1d()
        {

            int[] numbers = new int[4];

            numbers[0] = 5;
            numbers[1] = 67;
            numbers[2] = 23;
            numbers[3] = 99;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[3]);


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }

        public void disp2d()
        {
            int[,] numbers = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine(numbers[1, 1]);
            Console.WriteLine(numbers[0, 1]);


            for (int i = 0; i < 2; i++)
            {
                Console.Write("Row({0}): ", i);
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", numbers[i, j]);
                }
                Console.WriteLine();
            }
        }


        public void dispJA()
        {

            int[][] numbers = new int[4][];

            numbers[0] = new int[] { 1, 2, 3, 4 };
            numbers[1] = new int[] { 11, 34, 67 };
            numbers[2] = new int[] { 89, 23 };
            numbers[3] = new int[] { 0, 45, 78, 53, 99 };

            Console.WriteLine(numbers[1][2]);
            Console.WriteLine(numbers[3][2]);


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Row({0}): ", i);
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write("{0} ", numbers[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
