using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAssignment
{
    class MergeSort
    {
        public static void sort<T>(T[] a)
    where T : IComparable<T>
        {
            sort(a, 0, a.Length);
        }

        public static void sort<T>(T[] a, int low, int high)
            where T : IComparable<T>
        {
            int N = high - low;
            if (N <= 1)
                return;

            int mid = low + N / 2;

            sort(a, low, mid);
            sort(a, mid, high);

            T[] aux = new T[N];
            int i = low, j = mid;
            for (int k = 0; k < N; k++)
            {
                if (i == mid) aux[k] = a[j++];
                else if (j == high) aux[k] = a[i++];
                else if (a[j].CompareTo(a[i]) < 0) aux[k] = a[j++];
                else aux[k] = a[i++];
            }

            for (int k = 0; k < N; k++)
            {
                a[low + k] = aux[k];
            }
        }
       
        //static void Main(string[] args)
        //{
        //    int[] input = { 1, 2, 3 };
        //    int n = input.Length;
        //    // Power set contains 2^N subsets.
        //    int powerSetCount = 1 << n;
        //    var ans = new List<string>();

        //    for (int setMask = 0; setMask < powerSetCount; setMask++)
        //    {
        //        var s = new StringBuilder();
        //        for (int i = 0; i < n; i++)
        //        {
                    
        //            if ((setMask & (1 << i)) > 0)
        //            {
        //                s.Append(input[i]);
        //            }
        //        }
        //        ans.Add(s.ToString());
        //    }




            //Double[] MyArray = { 80, 10, 52, 7, 36, 7, 67, 1, 8, 54 };
            //Console.WriteLine("first array is: \n");
            //for (int k = 0; k < MyArray.Length; k++)
            //{
            //    Console.Write(MyArray[k]);
            //    if (k < 9)
            //        Console.Write(" , ");
            //}
            //sort(MyArray);
            //Console.WriteLine("\n");
            //Console.WriteLine("\nsorted array is: \n ");
            //for (int k = 0; k < MyArray.Length; k++)
            //{
            //    Console.Write(MyArray[k]);
            //    if (k < 9)
            //        Console.Write(" , ");
            //}
            //Console.ReadLine();
        }
    }


