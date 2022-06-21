using System;
using System .Collections;

namespace AlgorithmAndDataStruct;

static public  class SortNumberTab
{ 
    public static int[] Merge(int[] tabA, int[] tabB)
    {
        int indexA = 0;
        int indexB = 0;
        int[] result = new int[tabA.Length + tabB.Length];

        for (int i = 0; i < result.Length; ++i) {
            if (indexA < tabA.Length && indexB < tabB.Length) {
                if (tabA[indexA] < tabB[indexB]) {
                    result[i] = tabA[indexA++];
                } else {
                    result[i] = tabB[indexB++];
                }
            }
            else if (indexA < tabA.Length) {
                result[i] = tabA[indexA++];
            }
            else if (indexB < tabB.Length) {
                result[i] = tabB[indexB++];
            }
        }
        return result;
    }

    static public int[] bubbleSort(int[] tab)
    {
        for (int i = tab.Length; i > 0; i--) {
            for (int j = 0; j < i - 1; j++) {
                if (tab[j + 1] < tab[j]) {
                    int tmp = tab[j + 1];
                    tab[j + 1] = tab[j];
                    tab[j] = tmp;
                }
            }
        }
        return tab;
    }


    public static int MaxProfit(int[] prices) {
        int result = 0;
        int lastProfilt = -1;
        int tmpResult = 0;
        
        for (int i = 0; i < prices.Length; i++) {
            for (int j = i; j < prices.Length; j++) {
                if (prices[j] - prices[i] > 0 && tmpResult < (prices[j] - prices[i])) {
                    tmpResult = prices[j] - prices[i];
                    Console.WriteLine($"i {prices[i]}; j {prices[j]}; res {tmpResult}");
                }
            }
            if (tmpResult > lastProfilt && lastProfilt != -1) {
                Console.WriteLine($" IN tmpResult {tmpResult} | lastProfilt {lastProfilt} | result {result}");
                result -= lastProfilt;
                result += tmpResult;
                Console.WriteLine($" OUT tmpResult {tmpResult} | lastProfilt {lastProfilt} | result {result}");
            } else
                result += tmpResult;
            lastProfilt = tmpResult;
            Console.WriteLine($"last {lastProfilt}");
            tmpResult = 0;
        }
        return result;
    }


// for each (unsorted) partition
// set first element as pivot
//   storeIndex = pivotIndex+1
//   for i = pivotIndex+1 to rightmostIndex
//     if ((a[i] < a[pivot]) or (equal but 50% lucky))
//       swap(i, storeIndex); ++storeIndex
//   swap(pivot, storeIndex-1)

    static private void swap(int[] array, int i, int j)
    {
        int tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }

    public static int[] QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }
        
            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                swap(array, i, j);
                i++;
                j--;
            }
        }
    
        if (leftIndex < j)
            QuickSort(array, leftIndex, j);
        if (i < rightIndex)
            QuickSort(array, i, rightIndex);
        return array;
    }

    public static string MoreLonger(ArrayList array)
    {
        int tmp = -1;
        string tmpStr = null;
        string result = null;

        for (int i = 0; i < array.Count; i++) {
            if (array[i] is string) {
                tmpStr = array[i] as string;
                if (tmpStr.Length > tmp) {
                    tmp = tmpStr.Length;
                    result = tmpStr;
                }
            }
        }
        return result;
    }
    
}

