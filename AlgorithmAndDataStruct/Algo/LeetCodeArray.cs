using System;

namespace AlgorithmAndDataStruct;

public static class LeetCodeArray
{
    public static int removeDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        int i = 0;
        for (int j = 1; j < nums.Length; j++) {
            if (nums[j] != nums[i]) {
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }

    private static int mustBiggerSize(int[] A, int[] B, int startA, int startB)
    {
        int count = 0;
        
        while (startA < A.Length && startB < B.Length && A[startA] == B[startB]) {
            count++;
            startB++;
            startA++;
        }
        return count;
    }
    
    public static int[] Intersect(int[] nums1, int[] nums2) {
        int start = 0;
        int tmpSize = 0;
        int consecutivNumbers = 0;
        
        for (int i = 0; i < nums2.Length; i++) {
            
            for (int j = 0; j < nums1.Length; j++) {
                if (nums2[i] == nums1[j]) {
                    tmpSize = mustBiggerSize(nums1, nums2, j, i);
                    if (tmpSize > consecutivNumbers) {
                        consecutivNumbers = tmpSize;
                        start = j;
                    }
                }
            }
        }
        
        if (consecutivNumbers == 0)
            return new int[0];
        int[] result = new int[consecutivNumbers];        
        for (int i = 0; i < consecutivNumbers; i++) {
            result[i] = nums1[start++];
        }
        return result;
    }

    private static void Swap(int[] nums, int i, int j)
    {
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
    
    public static void Rotate(int[] nums, int k) {
        if (nums.Length == 0 || nums.Length == 1 || k <= 0 || k < 0)
            return ;
        if (k > nums.Length)
            k %= nums.Length;
        int j = 0;
        int[] tmpArray = new int[k];
        
        for (int i = nums.Length - k; i < nums.Length; i++) {
            tmpArray[j] = nums[i];
            j++;
        }
        for (int i = nums.Length - 1; i >= 0; i--) {
            if (i <= k - 1) {
                nums[i] = tmpArray[i];

            } else {
                nums[i] = nums[i - k];
            }
        }
    }

    public static  int[] PlusOne(int[] digits) {
        Console.WriteLine($"test pos {-12 * -1}");
        List<int> numbers = new List<int>();
        
        foreach (var elem in digits) {
            numbers.Add(elem);
        }
        
        if (numbers.Where(e => e == 9).Count() == numbers.Count()) {
            numbers.Add(0);
            for (int i = 0; i < numbers.Count; i++) {
                numbers[i] = i == 0 ? 1 : 0;
            }
            return numbers.ToArray();
        }
        
        for (int i = numbers.Count() - 1; i > 0; i--) {
            if (numbers[i] == 9)
                numbers[i] = 0;
            else {
                numbers[i]++;
                break ;
            }
        }
        return numbers.ToArray();
    }

}