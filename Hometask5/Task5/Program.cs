using System;
using System.Linq.Expressions;

namespace HomeTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 13 };
            int num = 5;
            AddNewNumToArray(ref arr, newNum);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            static void AddNewNumToArray(ref int[] arr,int num)
            {
                int[] new Array = new int[arr.Length + 1];
                int j = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    newArray[j] = arr[i];
                    j++;
                    
                }
                newArray[newArray.Length - 1] = newNum;
                arr = newArray;
            }
        }

    }
}
