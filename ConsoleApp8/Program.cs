using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = InputValue("Введите длину массива x: ");
            var x = SetDataInArray(n);

            int m = InputValue("Введите длину массива y: ");
            var y = SetDataInArray(m);

            int a = InputValue("Введите a: ");

            int c = InputValue("Введите c: ");

            Console.WriteLine(Sum1(x, y, m, n) + Sum2(y, n, m, a, c));
        }

        static int InputValue(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static float[] SetDataInArray(int length)
        {
            var array = new float[length];

            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (float)random.NextDouble();
            }

            return array;
        }

        static float Sum1(in float[] arrayX, in float[] arrayY, int end, int n)
        {
            float sum = 0;

            for (int i = 0;i < end; i++)
            {
                sum += Pow(arrayX[i] + arrayY[i], n);
            }

            return sum;
        }
        
        static float Sum2(in float[] arrayY, int end, int m, int a, int c)
        {
            float sum = 0;

            for (int i = 0; i < end; i++)
            {
                sum += a * arrayY[i] / Pow(c, m);
            }

            return sum;
        }

        static float Pow(float value, int level)
        {
            float pow = 1;
            for (int i = 0; i < level; i++)
            {
                pow *= value;
            }

            return pow;
        }

        //static void PrintArray(in float[] array)
        //{
        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.WriteLine();
        //}
    }
}
