using System;
using System.Linq;

namespace ProgrammingProblemOne
{
    class Program
    {
        static int[] array;
        static void Main(string[] args)
        {
            Console.Write("Input :");
            int num = int.Parse(Console.ReadLine());
            ToArray(num);

            Console.Write("First Elimination Remains:");
            ToRead(RemoveOddNumbers(array));
            Console.WriteLine("Second Elimination Remains:	");
            GetTheLastNumber();



        }
        static void GetTheLastNumber()
        {
            int sequence = 0;
            while (array.Length != 1)
            {
                if (sequence % 2 == 0)
                {
                    ToRead(RemoveTheHighestNumber(array));
                }
                else
                {
                    ToRead(RemoveTheLowestNumber(array));
                }
                sequence++;
            }
        }
        static void ToRead(int[] num)
        {
            foreach (var item in num)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
        static void ToArray(int num)
        {
            array = new int[num];
            for (int a = 1; a <= num; a++)
            {
                array[a - 1] = a;
            }
        }
        static int[] RemoveOddNumbers(int[] num)
        {
            int newArrayLenght = num.Length / 2;
            array = new int[newArrayLenght];
            int init = 0;
            for (int a = 0; a < num.Length; a++)
            {

                if (num[a] % 2 == 0)
                {
                    array[init] = num[a];
                    init++;
                }
            }
            return array;
        }
        static int[] RemoveTheHighestNumber(int[] num)
        {
            int numLength = num.Length;
            array = new int[numLength - 1];
            for (int a = 0; a < numLength; a++)
            {
                if (num[a] != num.Max())
                {
                    array[a] = num[a];
                }
            }
            return array;
        }
        static int[] RemoveTheLowestNumber(int[] num)
        {
            int numLength = num.Length;
            array = new int[numLength - 1];
            int arrayInit = 0;
            for (int a = 0; a < numLength; a++)
            {

                if (num[a] != num.Min())
                {
                    array[arrayInit] = num[a];
                    arrayInit++;
                }
            }
            return array;
        }

    }
}
