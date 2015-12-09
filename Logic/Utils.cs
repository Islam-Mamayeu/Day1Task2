using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Utils
    {

        public static void Choice(int[][] jaggedArray, Func<int[], int> UniFunc,int k)
        {
            for (int i = 0; i < jaggedArray.Length-1 ; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {
                    if ((UniFunc(jaggedArray[j]) < UniFunc(jaggedArray[j + 1]))&&k==0)//Desc
                    {
                        Sort(jaggedArray,j);
                    }
                    else if ((UniFunc(jaggedArray[j]) > UniFunc(jaggedArray[j + 1])) && k == 1)//Asec
                    {
                        Sort(jaggedArray, j);
                    }
                }
            }
        }
        public static void Sort(int[][] jaggedArray,int j)
        {
            int[] x = jaggedArray[j];
            jaggedArray[j] = jaggedArray[j + 1];
            jaggedArray[j + 1] = x;
        }
        public static int Sum(int[] Array)
        {
            int sum=0;

            for(int i=0;i<Array.Length;i++)
            {
                sum += Array[i];
            }
            return sum;
        }
        public static int Max(int[] Array)
        {
            int max = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > max)
                    max = Array[i];
            }
            return max;
        }
        public static int Min(int[] Array)
        {
            int min = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] < min)
                    min = Array[i];
            }
            return min;
        }
    }

    
}
