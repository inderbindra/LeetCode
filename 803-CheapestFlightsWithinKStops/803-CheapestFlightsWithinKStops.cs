// Last updated: 12/11/2025, 8:00:40 PM
public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        
        int[] prices = new int[n];
        int[] tempPrices = new int[n];
        Array.Fill(prices, int.MaxValue);
        Array.Fill(tempPrices, int.MaxValue);
        prices[src] = 0;
        tempPrices[src] = 0;
        int newSrc=0, newDst=0, newPrice=0;
        
        for(int i=0; i< k+1; i++)
        {
            for(int j=0; j<flights.Length; j++)
            {
                newSrc = flights[j][0];
                newDst = flights[j][1];
                newPrice = flights[j][2];

                if(prices[newSrc] != int.MaxValue &&
                 prices[newSrc] + newPrice < tempPrices[newDst])
                {
                    tempPrices[newDst] = prices[newSrc] + newPrice;
                }
            }
            prices = tempPrices.Clone() as int[];
        }
        return (prices[dst] != int.MaxValue ? prices[dst] : -1);
    }
}