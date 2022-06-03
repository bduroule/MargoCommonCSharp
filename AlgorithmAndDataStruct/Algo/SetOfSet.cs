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

// List<int> {1, 2, 3, ..., n} , int k => all substes of size k
// {1, 2}, k = 2          =>  {1, 2}
// {1, 2 , 3}, k = 2      =>  {1, 2}, {1, 3}, {2, 3}
// {1, 2, 3, 4}, k = 2    =>  {1, 2}, {1, 3}, {1, 4}, {2, 3}, {2, 4}, {3, 4}
// {1, 2, 3, 4, 5}, k = 2

// public List<List<int>> Soulist(int n, int k)
// {
// 	if (n < k)
//   	return null;
//   if (k == 1) {
//   	var resultK1 = new List<List<int>>();
//     for (int i = 1; i < n; i++) {
//     	resultK1.Add(new List<int> {i});
//     }
//   	return resultK1;
//   }
//   if (n == k){ 
//   	var currentResult = new List<int>();
//   	for (int i = 1; i <= k; i++){
//     	currentResult.Add(i);
//     }
//     return new List<List<int>>{currentResult};
//   }
  	
// 	var result = new List<List<int>>();
  
// 	List<List<int>> partialResult = SouList(n - 1, k);
  
//   // 
  
//   foreach(List<int> subList in partialResult){
//   	result.Add(subList);
//   }
  
  
//   return result;
// }