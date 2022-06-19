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
    
    public static void RotateOld(int[] nums, int k) {
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

    public static int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                Console.WriteLine($"I {i} J {j}");
                if (j < nums.Length && i < nums.Length && nums[i] + nums[j] == target)
                    return new int[] {j, i};
            }
        }
        return null;
    }

    public static int SearchInsert(this int[] nums, int target)
    {
        int low = 0, height = nums.Length, mid = (low + height) / 2;
        
        while (mid >= 0 && mid < nums.Length) {
            Console.WriteLine($"test IN LOW {low} HEIGHT {height} MID {mid} |=> {nums[mid]}");
            if (nums[mid] == target)
                return mid;
            if (mid + 1 == height && mid - 1 == low)
                return nums[mid] < target ? mid : height;
            if (nums[mid] > target)
                height = mid;
            else if (nums[mid] < target)
                low = mid;
            mid = (low + height) / 2;
        }
        return 0;
    }

        public static int[] SortedSquares(this int[] nums) {
        int[] result = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++) {
            result[i] = nums[i] * nums[i];
        }
        return result.OrderBy(n => n).ToArray();
    }

    private static int[] endString(int[] nums, int k) {
        int[] array = new int[k];
        int j = 0;

        for (int i = nums.Length - k; i < nums.Length; i++) {
            array[j++] = nums[i];
        }
        return array;
    }
    private static int[] startString(int[] nums, int k) {
        int[] array = new int[nums.Length - k];

        for (int i = 0; i < nums.Length - k; i++) {
            array[i] = nums[i];
        }
        return array;
    }

    public static void Rotate(this int[] nums, int k) {
        int[] endOfArray = endString(nums, k);
        int[] startOfArray = startString(nums, k); 

        for (int i = 0; i < nums.Length - k; i++) {
            nums[i + k] = startOfArray[i];
        }
        for (int i = 0; i < k; i++) {
            nums[i] = endOfArray[i];
        }
    }

    private static int CountZero(int[] nums, int index) {
        int count = 0;
        
        while (index < nums.Length && nums[index] == 0) {
            count++;
            index++;
        }
        return count;
    } 
    
    public static void MoveZeroes(this int[] nums) {
        if (nums.Length <= 1)
            return ;
        int count = 0;
        
        for (int i = 0; i + count < nums.Length; i++) {
            if (nums[i + count] != 0) {
                nums[i] = nums[i + count];
                continue ;
            }
            int countZero = CountZero(nums, i + count);
            count += countZero;
            Console.WriteLine($"test {count} < {nums.Length}");
            nums[i] = nums[i + count];
        }
        for (int i = nums.Length - count; i < nums.Length; i++)
            nums[i] = 0;
    }

}