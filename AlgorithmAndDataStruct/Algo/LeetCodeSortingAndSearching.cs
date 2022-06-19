namespace AlgorithmAndDataStruct;

public static class LeetCodeSortingAndSearching
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n) {

        if (m > nums1.Length || n > nums2.Length)
            return ;
        int j = 0;
        int i = 0;
        int[] result = new int[m + n];
        
        for (int resultIndex = 0; resultIndex < m + n; resultIndex++) {
            if (i < m && j < n) {
                if (i < m && nums1[i] < nums2[j])
                    result[resultIndex] = nums1[i++];
                else
                    result[resultIndex] = nums2[j++];
            }
            else if (i < nums1.Length) {
                result[i] = nums1[i++];
            }
            else if (j < nums2.Length) {
                result[j] = nums2[j++];
            }
        }
        for (int index = 0; index < nums1.Length; index++) {
            nums1[index] = result[index];
        }
    }
}
