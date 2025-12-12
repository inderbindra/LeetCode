// Last updated: 12/11/2025, 8:01:33 PM
public class Solution {
    public int ArrangeCoins(int n) {
      
      long start =1, end = n, row, currentRowCoins;

      while(start <= end)
      {
        row = start + (end - start)/2;
        currentRowCoins = row * (row+1)/2;
        if(currentRowCoins == n)
        {
            return (int)row;
        }
        else if(currentRowCoins < n)
        {
          start = row +1;
        }
        else
        {
          end = row -1;
        }
      }
      return (int) end;
    }
}