

namespace AlgorithmAndDataStruct
{
    public class SortNumberTab
    {
        public int[] tab { get; set; }

        public SortNumberTab(int[] tab) {
            this.tab = tab;
        }

        public int[] MergerSort(int[] array)
        {
            if (array.Length <= 1)
                return array;
            
            return new int[0];
        }

        public static class MergeTabInt
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
}
        public void bubbleSort()
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
        }
    }
}