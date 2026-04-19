using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgo
{

    public static class SortingAlgos
    {//алгоритми сортування
        public static void DoSort(ref int[] ArrayToSort, string AlgoName)
        {

            switch (AlgoName)
            {
                case "bubble":
                    Bubble(ref ArrayToSort);
                    break;
                case "shaker":
                    Shaker(ref ArrayToSort);
                    break;
                case "comb":
                    Comb_sort(ref ArrayToSort);
                    break;
                case "insertion":
                    Insertion_sort(ref ArrayToSort);
                    break;
                case "shell":
                    Shellsort(ref ArrayToSort);
                    break;
                case "counting":
                    CountingSort(ref ArrayToSort);
                    break;
                case "selection":
                    SelectSort(ref ArrayToSort);
                    break;
                case "merge":
                    MargeSort(ref ArrayToSort);
                    break;
                case "quick":
                    QuickSort(ArrayToSort, 0, ArrayToSort.Length - 1);
                    break;
                case "radix LCD":
                    RadixSort.RadixLCD(ref ArrayToSort);
                    break;
                    //case "radix MCD":
                    //    SortingAlgos.RadixSort.RadixMCD(ref ArrayToSort);
                    //    break;                       
            }



        }
        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
        private static void Bubble(ref int[] arrForSort)
        {
            //int ctr = 0;
            bool sorted = false;
            for (int i = 0; i < arrForSort.Length - 1; i++)
            {
                if (arrForSort[i] > arrForSort[i + 1])
                {
                    Swap(arrForSort, i, i + 1);
                    sorted = false;
                }
                if (i == arrForSort.Length - 2 && !sorted)
                {
                    i = -1;
                    //ctr++;
                    sorted = true;
                }
            }
            ////Console.WriteLine("Cycles (Bubble): " + ctr);
        }
        private static void Shaker(ref int[] arrForSort)
        {

            int left = 0,
                right = arrForSort.Length - 1;
            //count = 0;

            while (left < right)
            {

                for (int i = left; i < right; i++)
                {

                    if (arrForSort[i] > arrForSort[i + 1])
                        Swap(arrForSort, i, i + 1);

                    // if (i == right - 1) count++;

                }
                right--;

                for (int i = right; i > left; i--)
                {

                    if (arrForSort[i - 1] > arrForSort[i])
                        Swap(arrForSort, i - 1, i);
                    // if (i == left + 1) count++;

                }
                left++;


            }
            //Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());
        }

        private static void Comb_sort(ref int[] arrForSort)
        {
            //int ctr = 0;
            int distanece = arrForSort.Length - 1;
            double k = 1.247d;
            while (distanece > 1)
            {
                for (int i = 0; i + distanece < arrForSort.Length; i++)
                    if (arrForSort[i] > arrForSort[i + distanece])
                    {
                        Swap(arrForSort, i, i + distanece);
                        //ctr++;
                    }

                if (distanece == Convert.ToInt32(Math.Ceiling(Convert.ToDouble(distanece) / k)))
                    distanece--;
                else
                    distanece = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(distanece) / k));
            }
            Bubble(ref arrForSort);
            //Console.WriteLine("swapped (Comb_sort) : " + ctr);
        }
        private static void Insertion_sort(ref int[] arrForSort)
        {
            int n = arrForSort.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arrForSort[i];
                int j = i - 1;

                // Move elements of arr[0..i-1] that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && arrForSort[j] > key)
                {
                    arrForSort[j + 1] = arrForSort[j];
                    j--;
                }
                arrForSort[j + 1] = key;
            }
        }

        private static void Shellsort(ref int[] arrForSort)
        {
            int n = arrForSort.Length;
            // Start with a big gap, then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already
                // in gapped order keep adding one more element
                // until the entire array is gap sorted
                for (int i = gap; i < n; i += 1)
                {
                    // add a[i] to the elements that have
                    // been gap sorted save a[i] in temp and
                    // make a hole at position i
                    int temp = arrForSort[i];

                    // shift earlier gap-sorted elements up until
                    // the correct location for a[i] is found
                    int j;
                    for (j = i; j >= gap && arrForSort[j - gap] > temp; j -= gap)
                        arrForSort[j] = arrForSort[j - gap];

                    // put temp (the original a[i])
                    // in its correct location
                    arrForSort[j] = temp;
                }
            }
        }

        private static void CountingSort(ref int[] arrForSort)
        {
            int max = arrForSort.Max();
            int min = arrForSort.Min();
            int range = max - min + 1;
            int[] count = new int[range];
            for (int i = 0; i < arrForSort.Length; i++)
            {
                count[arrForSort[i] - min]++;
            }
            for (int i = 0, j = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    arrForSort[j] = i + min;
                    j++;
                    count[i]--;
                    i--;
                }
            }
        }
        private static void SelectSort(ref int[] arrForSort)
        {
            int pointer = 0;
            while (pointer < arrForSort.Length)
            {
                Swap(arrForSort, findMin(arrForSort, pointer, arrForSort.Length), pointer);
                pointer++;
            }
            int findMin(int[] arr, int begin, int end)
            {
                int min = arr[begin];
                int index = begin;
                for (int i = begin + 1; i < end; i++)
                    if (min > arr[i])
                    {
                        min = arr[i];
                        index = i;
                    }


                return index;
            }


        }
        private static void MargeSort(ref int[] arrForSort)
        {
            List<List<int>> buffer = new List<List<int>>();
            // merge arr to moment when remain arr Length = 2 and swap elem of thise arr to do it sorted
            for (int j = 0; j < arrForSort.Length; j += 2)  
            {
                try
                {
                    if (arrForSort[j] > arrForSort[j + 1])
                    {
                        Swap(arrForSort, j, j + 1);
                        buffer.Add(new List<int> { arrForSort[j], arrForSort[j + 1] });
                    }

                    else
                        buffer.Add(new List<int> { arrForSort[j], arrForSort[j + 1] });
                }
                catch (IndexOutOfRangeException)
                {
                    buffer.Add(new List<int> { arrForSort[j] });
                }

            }
            // unite arrs
            int g = buffer.Count;
            int i = 0;
            while (g > 1)
            {
                buffer.Add(new List<int>());
                int j = 0;

                while (true)
                {
                    if (buffer[i].Count == 0)
                    {
                        Cocktail_Sort(buffer[i + 1].ToArray());
                        buffer[buffer.Count - 1].AddRange(buffer[i + 1]);
                        buffer.RemoveAt(i);
                        buffer.RemoveAt(i);
                        break;
                    }
                    else if (buffer[i + 1].Count == 0)
                    {
                        Cocktail_Sort(buffer[i].ToArray());
                        buffer[buffer.Count - 1].AddRange(buffer[i]);
                        buffer.RemoveAt(i);
                        buffer.RemoveAt(i);
                        break;
                    }
                    if (buffer[i][j] < buffer[i + 1][j])
                    {
                        buffer[buffer.Count - 1].Add(buffer[i][j]);
                        buffer[i].RemoveAt(j);
                    }
                    else
                    {
                        buffer[buffer.Count - 1].Add(buffer[i + 1][j]);
                        buffer[i + 1].RemoveAt(j);
                    }
                }
                g = buffer.Count;
            }
            buffer[0].CopyTo(arrForSort);
        }

        static void Cocktail_Sort(int[] arrForSort)  //func for Merge Sort
        {
            //int ctr = 0;
            bool sorted = false;
            for (int i = 0; i < arrForSort.Length - 1; i++)
            {
                if (arrForSort[i] > arrForSort[i + 1])  // [i] [0] -> [0] [i] 
                {
                    //Console.WriteLine($"Swapping Left {arrForSort[i]} and {arrForSort[i + 1]}\n");
                    Swap(arrForSort, i, i + 1);
                    sorted = false;
                }
                if (arrForSort[arrForSort.Length - i - 1] < arrForSort[arrForSort.Length - i - 2])
                {

                    //Console.WriteLine($"Swapping Right {arrForSort[arrForSort.Length - i - 1]} and {arrForSort[arrForSort.Length - i - 2]}\n");
                    Swap(arrForSort, arrForSort.Length - i - 1, arrForSort.Length - i - 2);
                    sorted = false;
                }

                if (i == arrForSort.Length - 2 && !sorted)
                {
                    i = -1;
                    //ctr++;
                    sorted = true;
                }
            }


            //Console.WriteLine("Cycles: " + ctr);
        }

        // Bogo Sort and Permutation Sort - Sorting => generate random seq (=Arr.Length) of numbers (that == numbers of arr) till it will be sorted (Dumb sorting)
        // PS with duplicates time of sorting will be longer (∞ in worst case)
        private static void QuickSort(int[] arrForSort, int _low, int _high)
        {
            //low-- > Starting index, high-- > Ending index */
            if (_low < _high)
            {
                /* pi is partitioning index,
                arr[p] is now at right place */
                int pi = partition(arrForSort, _low, _high);

                //Separately sort elements before
                //partition and after partition
                QuickSort(arrForSort, _low, pi);
                QuickSort(arrForSort, pi + 1, _high);
            }

            int partition(int[] arr, int low, int high)
            {
                int pivot = arr[low];
                int i = low - 1, j = high + 1;

                while (true)
                {
                    // Find leftmost element greater than or equal to pivot
                    do
                    {
                        i++;
                    } while (arr[i] < pivot);

                    //Find rightmost element smaller than or equal to pivot
                    do
                    {
                        j--;
                    } while (arr[j] > pivot);

                    // If two pointers met.
                    if (i >= j)
                        return j;
                    Swap(arr, i, j);
                    //swap(arr[i], arr[j]);
                }
            }


            /* StackOverFlowEx on BackSorted pattern ???   fix on free time                  
            
                //int startIndx = _low, endIndx = _high;
            if (startIndx < endIndx)
            {
                int Chosen = endIndx - 1;
                int pointer = startIndx;

                for (int j = startIndx; j < Chosen; j++)
                {
                    if (arrForSort[Chosen] > arrForSort[j])
                    {
                        ////Console.WriteLine("Swaped");
                        
                        Swap(arrForSort, pointer, j);
                        pointer++;
                    }

                }
                Swap(arrForSort, pointer, Chosen);   //StackOverFlow Ex
              
                ////Console.WriteLine("Swaped");
                QuickSort(arrForSort, startIndx, pointer);
                QuickSort(arrForSort, pointer + 1, endIndx);
             
            }
            */
        }
        public static class RadixSort
        {
            /* TO DO
            //Fix it: its broken
            private static void RadixMCD(ref int[] arrForSort)
            {

                int Radix = GetRad(arrForSort);

                CountSort_Changed(ref arrForSort, Radix);

                void CountSort_Changed(ref int[] arrFSort, int radix)
                {


                    int R = (int)Math.Pow(10d, Convert.ToDouble(radix));
                    int[] arr = new int[arrFSort.Length];
                    arrFSort.CopyTo(arr, 0);
                    for (int i = 0; i < arr.Length; i++)
                        arr[i] = (arr[i] / (R / 10)) % 10;



                    int min = 0;
                    if (arrFSort.Min() < 0)
                        min = Math.Abs(arrFSort.Min());

                    int range = arrFSort.Max() - arrFSort.Min() + 1;

                    List<List<int>> Count = new List<List<int>>();
                    for (int i = 0; i < range; i++)
                        Count.Add(new List<int>());

                    for (int i = 0; i < arrFSort.Length; i++)
                        Count[min + arr[i]].Add(arrFSort[i]);

                    List<int> list = new List<int>();
                    for (int i = 0; i < Count.Count; i++)
                    {
                        if (i != min || radix == 1)
                        {
                            for (int j = 0; j < Count[i].Count; j++)
                            {
                                list.Add(Count[i][j]);
                            }
                        }
                        else if (radix != 1)
                        {
                            int[] buf = Count[i].ToArray();
                            CountSort_Changed(ref buf, radix - 1);
                            Count[i].Clear();
                            Count[i].AddRange(buf);
                            radix--;
                            i--;
                        }
                    }

                    list.CopyTo(arrFSort);
                }
          

                int GetRad(int[] arr)
                {
                    int Rad = 1;
                    int absoluteMax = arr.Select(x => Math.Abs(x)).Max();
                    absoluteMax = absoluteMax / 10;
                    while (absoluteMax > 0)
                    {
                        absoluteMax = absoluteMax / 10;
                        Rad++;
                    }
                    return Rad;
                }

            }
             */

            public static void RadixLCD(ref int[] arrForSort)
            {

                int Radix = GetRad(arrForSort);
                for (int i = 1; i <= Radix; i++)
                {
                    CountSort_Changed(ref arrForSort, i);
                }

            }
            static void CountSort_Changed(ref int[] arrForSort, int radix)
            {

                List<int> list = new List<int>();
                int R = (int)Math.Pow(10d, Convert.ToDouble(radix));
                int[] arr = new int[arrForSort.Length];
                arrForSort.CopyTo(arr, 0);
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = (arr[i] / (R / 10)) % 10;


                int min = 0;
                if (arrForSort.Min() < 0)
                    min = Math.Abs(arr.Min());

                List<List<int>> Count = new List<List<int>>();
                for (int i = 0; i < 19; i++)
                    Count.Add(new List<int>());

                for (int i = 0; i < arrForSort.Length; i++)
                    Count[min + arr[i]].Add(arrForSort[i]);

                for (int i = 0; i < Count.Count; i++)
                    for (int j = 0; j < Count[i].Count; j++)
                        list.Add(Count[i][j]);

                list.CopyTo(arrForSort);
            }
            static int GetRad(int[] arrForSort)
            {
                int Rad = 1;
                int absoluteMax = arrForSort.Select(x => Math.Abs(x)).Max();
                absoluteMax = absoluteMax / 10;
                while (absoluteMax > 0)
                {
                    absoluteMax = absoluteMax / 10;
                    Rad++;
                }
                return Rad;
            }

        }
                


    }


}


