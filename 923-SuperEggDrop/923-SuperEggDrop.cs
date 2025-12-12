// Last updated: 12/11/2025, 8:00:31 PM
public class Solution {
    Dictionary<(int k, int n), int> dp;
    public int SuperEggDrop(int k, int n) {
        dp = new();
        return EggDrop(k, n);
    }
    private int EggDrop(int k, int n)
    {
        if(k==1)
        {
            return n;
        }
        if(n==0 || n==1)
        {
            return n;
        }
        if(dp.ContainsKey((k, n)))
        {
            return dp[(k, n)];
        }
        int minAttempts=int.MaxValue, attempts=0, downAttempts=0, upAttempts=0;
        int left=1, right=n, mid=0;
        while(left <= right)
        {
            mid = (left + right)/2;
            // If Egg breaks, then go down from the current floor
            // for that we are taking (k-1, mid-1) as no. of eggs is reduced by 1.
            downAttempts = EggDrop(k-1, mid-1);

            // If Egg doesn't break, then go up from the current floor
            // for that we are taking (k, n-mid) and no. of eggs remain same.
            upAttempts = EggDrop(k, n-mid);

            // Value 1 is added for the current attempt.
            attempts = 1 + Math.Max(downAttempts, upAttempts);
            
            // If downAttempts is less than the upAttempts, then we need to go up
            // as we need to find the worst case answer
            if(downAttempts < upAttempts)
            {
                left = mid + 1;
            }
            else
            {
                right = mid -1;
            }

            // Min value is assigned as we need to find the minimum attempts in the worst case.
            minAttempts = Math.Min(minAttempts, attempts);
        }
        dp[(k, n)] = minAttempts;
        return minAttempts;
    }
}