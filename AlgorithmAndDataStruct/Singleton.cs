// tread safe 
// lazy
// lock free


// int[] Merge(int[] tabA, int[] tabB)  merge

public sealed class Singleton<R> where R: new()
{
    private Singleton()
    {}

    private static readonly Lazy<Singleton<R>> lazy = new Lazy<Singleton<R>>(() => new Singleton<R>()); 
    public static Singleton<R> Instance    
    {    
        get    
        {    
            return lazy.Value;    
        }    
    }

}

public static class MergeTabInt
{
    public static int[] Merge(int[] tabA, int[] tabB)
    {
        int indexA = 0;
        int indexB = 0;
        int[] result = new int[tabA.Length + tabB.Length];

        for (int i = 0; i < result.Length; i++) {
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
}