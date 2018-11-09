using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sort
{
    class Program
    {
        public static void Sort_Arr(int[] arr)
        {
            int i, j, tmp, min;
            int index = 0;
            int flag = 0;

            for (i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for (j = i + 1; j < arr.Length - 1; j++)
                {

                    if (arr[j] < min)
                    {
                        flag = 1;
                        min = arr[j];
                        index = j;

                    }
                }

                if (flag == 1)
                {
                    tmp = arr[i];
                    arr[i] = arr[index];
                    arr[index] = tmp;
                    flag = 0;

                }
            }
        }
        public static void Main(string[] args)
        {
            int i;
            int[] array = new int[5];
            int[] test = { 4, 3, 2, 1, 5 };

            for (i = 0; i < test.Length; i++)
            {
                Console.Write(" " + test[i]);
            }
            Console.WriteLine("");
            Sort_Arr(test);

            for (i = 0; i < test.Length; i++)
            {
                Console.Write(" " + test[i]);
            }

            Console.WriteLine("");
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }



    }



}


