using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Smooth_fence
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min = int.MaxValue;
            int l = 0;
            int r = n - k - 1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            while (r < arr.Length)
            {
                min = Math.Min(arr[r] - arr[l], min);
                r++;
                l++;
            }
            string str = string.Join(",", arr);
            Console.WriteLine("[" + str + "]");
            Console.WriteLine(min);

            Console.ReadLine();
        }
    }
}
