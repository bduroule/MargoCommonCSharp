using System;
namespace AlgorithmAndDataStruct;


public static class SetOfSet
{
    private static int[] fellArray(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < n; i++) {
            array[i] = i;
        }
        return array;
    }
    public static void result(int n, int k)
    {
        int[] array = fellArray(n);

        for (int i = 0; i < n; i++) {
            for (int j = i; j < n; j++) {
                Console.Write($"({array[i]}, ");
                for (int l = j; l < k; l++) {
                    // Console.Write($"l = {l}|");
                    Console.Write($"{array[l]}, ");  
                }
                Console.Write("), ");
            }
        }
        Console.WriteLine($"test base condition {24 / 100}");
    }

    public static void result2(int n, int k)
    {
        int res = 0;
        for (int i = 0; i < 1 * Math.Pow(10, k); i++) {
            res += res % 10 + 1 >= n ? (10 - n) : 1;
            Console.WriteLine($"resr ({res})");
        }
        Console.WriteLine($"test base condition {487367 % 10}");
    }
    
    public static void result3(int n, int k)
    {
        int[] array = fellArray(n);
        foreach (var e in array) {
            Console.WriteLine($"    e = {e}");
        }

        for (int i = 0; i < array.Length; i++) {
            
            Console.Write("(");
            for (int j = 0; j < k; j++) {
                //Console.WriteLine($" test = {i + j % (array.Length - 1)}");
                var test = (i + j) % array.Length;
                 Console.Write($"{array[test == array.Length ? 0 : test]}, ");
            }
            Console.Write("), ");
        }    
    }

}