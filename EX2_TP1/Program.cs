using System;

namespace EXERCICE2
{
    class Program
    {

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[" + arr[i] + "] ");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************");
            int[] arr = { 5, 20, 25, 34, 35 };
            Print(arr);
            Array.Resize(ref arr, arr.Length + 1);
            int size = arr.Length;
            arr[size - 1] = n;
            Console.WriteLine("\n*******************");
            for (int i = size - 1; i > 0; i--)
            {
                int m;
                if (n < arr[i - 1])
                {
                    m = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = m;
                }
            }
            Print(arr);
        }
    }
}