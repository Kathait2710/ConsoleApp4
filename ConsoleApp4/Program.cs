using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = { 1265, 8754, 1964, 8259 };
            int[] arr = { 12652, 87544, 19642, 82591 };
            //int temp=0;
             int temp = 1;
            for (int i = 0; i < arr.Length; i++)
            {
               var stng= arr[i].ToString();
               char[] arr1 =stng.ToCharArray();
                Array.Sort(arr1);
               Array.Reverse(arr1);
                string st = new string(arr1);
                arr[i] =Convert.ToInt32(st);
               // Console.WriteLine(st);


            }
           
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j=i+1; j < arr.Length; j++)
                {
                    if (arr[i]<arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }

            Console.WriteLine("CHanges by me as SK");
        }
    }
}
