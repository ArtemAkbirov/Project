using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Arrayes
    {
       public static int [] CreateArray(int quantity)
        {
            if (quantity < 0)
            {
                throw new Exception("quantity must be > 0");
            }
            int [] array = new int[quantity];
            Random r = new Random();
            for (int i = 0; i < quantity; i++)
            {
                array[i] = r.Next(-100, 101);
            }
            return array;
        }
        public static void WriteArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
       public static int FindMin(int [] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public static int FindMax(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public static int FindMinIndex(int [] a)
        {
            int minIndex = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public static int FindMaxIndex(int[] a)
        {
            int maxIndex = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > a[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public static int FindSummOddIndex(int [] a)
        {
            int summ = 0;
            for (int i = 1; i < a.Length; i+=2)
            {
                summ+=a[i];
            }
            return summ;
        }
        public static int FindQuantityOddEllementsArray(int[] a)
        {
            int quantity = 0;
            for (int i = 0; i < a.Length; i ++)
            {
                if (a[i] % 2 !=0)
                {
                    quantity++;
                }
            }
            return quantity;
        }

    }
}
