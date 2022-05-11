

namespace AlgorithmAndDataStruct
{
    public class SortNumberTab
    {
        public int[] tab { get; set; }

        public SortNumberTab(int[] tab) {
            this.tab = tab;
        }

        private void MergerSort(int[] array)
        {
            if (array.Length <= 1)
                return array;
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