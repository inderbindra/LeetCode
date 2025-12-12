// Last updated: 12/11/2025, 8:00:35 PM
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        long left =1, right = piles.Max(), mid=0, hours=0, prev=0;
        while(left <= right)     
        {
            mid = left + (right - left)/2;
            hours = 0;
            for(int i=0; i<piles.Length; i++)
            {
                hours += (int) Math.Ceiling(piles[i] / (mid * 1.0));
            }
            if(h >= hours)
            {
                prev = mid;
                right = mid-1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return (int)prev;
    }
}