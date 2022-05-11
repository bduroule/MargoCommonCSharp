
public class test
{
    
    public bool IsPerfectInt(int n) 
    {
        int res = 0;
        int tmpN = n;

        while (tmpN % 10 != 0) {
            res += tmpN % 10;
            tmpN /= 10;
        }
        return res == n;
    }

    List<int> listPrices = new List<int>() {10, 20, 10, 11, 9, 12};

    public int MaxBenefice(List<int> prices)
    {
        int result = 0;

        for (int i = 0; i < prices.Count; i++) {
            for (int j = i + 1; j < prices.Count; j++) {
                if (result < (prices[j] - prices[i]))
                    result = prices[j] - prices[i];
            }
        }
        return result;
    }

     public int MaxBenefice2(List<int> prices)
     {
         int result = 0;
         int minPrice = prices[0];

         foreach (var elem in prices) {
            if (elem < minPrice)
                minPrice = elem;
            if (result < elem - minPrice)
                result = elem - minPrice;
         }
         return result;
     }
}