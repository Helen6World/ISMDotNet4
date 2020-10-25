using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyClassLibrary
    {
        public static double SumOfNegativeArrayElements(double[] arr)
        {
            double sum = 0;
            foreach (double el in arr)
            {
                if (el < 0)
                {
                    sum += el;
                }
            }
            return sum;
        }

        public static double MaxArrayElement(double[] arr)
        {
            double maxElement = Double.MinValue;
            foreach (double el in arr)
            {
                if (el > maxElement)
                {
                    maxElement = el;
                }
            }
            return maxElement;
        }

        public static int IndexOfMaxArrayElement(double[] arr)
        {
            int maxElementIndex = 0;
            double maxElement = Double.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                    maxElementIndex = i;

                }
            }
            return maxElementIndex;
        }

        public static double MaxModuleArrayElement(double[] arr)
        {
            double maxModuleElement = 0;
            foreach (double el in arr)
            {
                if (Math.Abs(el) > maxModuleElement)
                {
                    maxModuleElement = Math.Abs(el);
                }
            }
            return maxModuleElement;
        }

        public static int IndexesSumOfPositiveArrayElements(double[] arr)
        {
            int sumOfPositiveElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sumOfPositiveElements += i;
                }
            }
            return sumOfPositiveElements;
        }

        public static int QuantityOfIntegerArrayElements(double[] arr)
        {
            int quantityOfIntegerElements = 0;
            foreach (double el in arr)
            {
                if (el == Convert.ToInt32(el))
                {
                    quantityOfIntegerElements++;
                }
            }
            return quantityOfIntegerElements;
        }

        public static double[] SortArrayByDecreasing(double[] arr)
        {
            double[] arr2 = new double[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            double temp = 0;
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] < arr2[j])
                    {
                        temp = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = temp;
                    }
                }
            }
            return arr2;
            
        }

        public static double[] DeleteNegativeArrayElements(double[] arr)
        {
            int quantityOfNegativeElements = 0;
            double[] arr2 = new double[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            foreach (double el in arr2)
            {
                if (el < 0)
                {
                    quantityOfNegativeElements++;
                }
            }

            double[] arrResult = new double[arr2.Length - quantityOfNegativeElements];
            for (int i = 0, j = 0; i < arr2.Length; i++)
            {
                if (arr2[i] > 0)
                {
                    arrResult[j] = arr[i];
                    j++;
                }
            }

            return arrResult;
        }
    }
}
