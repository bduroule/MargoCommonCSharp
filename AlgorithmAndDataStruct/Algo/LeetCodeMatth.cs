

public static class LeetCodeMatth
{
    public static IList<string> FizzBuzz(int n) {
        List<string> numbers = new List<string>();

        for (int i = 1; i <= n; i++) {
            if (i % 3 == 0 && i % 5 == 0)
                numbers.Add("FizzBuzz");
            else if (i % 3 == 0)
                numbers.Add("Fizz");
            else if (i % 5 == 0)
                numbers.Add("Buzz");
            else
                 numbers.Add(i.ToString());
        }
        return numbers;
    }

    public static int FiboncciIterative(int n)
    {
        if (n == 1 || n == 0)	return n;
        int tmp1 = 1;
        int tmp2 = 0;
        int res = 0;
  
	    for (int i = 1; i < n; i++) {
            res = tmp1 + tmp2;
            tmp2 = tmp1;
            tmp1 = res;
        }
        return res;
    }

    public static int LenLongestFib(int[] arr) {
        int maxSize = 0;
        
        foreach (var elem in arr) {
            if (maxSize < elem)
                maxSize = elem;
        }
        int tmp1 = 1, tmp2 = 0, res = 0, count = 0;

        for (int i = 0; i < maxSize; i++) {
            res = tmp1 + tmp2;
            tmp2 = tmp1;
            tmp1 = res;
            if (arr.Contains(res))
                count++;
        }
        return count;
    }

    private static int seqLength(int[] arr, List<int> fibonacci, int startnum, int startFibb)
    {
        Console.WriteLine($"test IN {startnum} {startFibb}");
        int count = 0;

        while (startnum < arr.Length && startFibb < fibonacci.Count() && arr[startnum] == fibonacci[startFibb]) {
            count++;
            startnum++;
            startFibb++;
        }
        return count;
    }
    public static int LenLongestFibSubseq(int[] arr) {
        if (arr.Length <= 2)
            return 0;
        int maxSize = 0;
        foreach (var elem in arr) {
            if (maxSize < elem)
                maxSize = elem;
        }
        List<int> fibonacciList = new List<int>() {arr[0], arr[1]};
        int tmp1 = arr[0], tmp2 = arr[1], res = 0, result = 0;

        while (res < maxSize) {
            res = tmp1 + tmp2;
            tmp1 = tmp2;
            tmp2 = res;
            fibonacciList.Add(res);
        }

        #region print 
        foreach (var test in fibonacciList) {
            Console.WriteLine($"test fibonacci {test}");
        }
        #endregion

        for (int i = 0; i < arr.Length; i++) {
            if (fibonacciList.Contains(arr[i])) {
                int seqSize = seqLength(arr, fibonacciList, i, fibonacciList.FindIndex(n => n == arr[i]));
                result = seqSize > result ? seqSize : result;
                i += seqSize;
            }
        }
        return result;
    }

    public static int Tribonacci(int n) {
        if (n == 1 || n == 0)
            return n;
        return Tribonacci(n - 1) + Tribonacci(n - 2);
    }

}