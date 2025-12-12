// Last updated: 12/11/2025, 7:59:54 PM
public class Solution {
    public bool IsCovered(int[][] ranges, int left, int right) {
        
        int[] a = new int[right+1];
        
        for(int i=0; i< ranges.Length; i++)
        {
            for(int j=ranges[i][0]; j<= ranges[i][1]; j++)
            {
                if(j > right)
                {
                    break;
                }
                a[j] = 1;
            }
        }
        
        for(int i=left; i<=right; i++)
        {
            if(a[i] == 0)
            {
                return false;
            }
        }
        return true;
        
    }
}