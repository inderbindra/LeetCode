// Last updated: 12/11/2025, 8:01:45 PM
public class Solution {
    public bool IsPerfectSquare(int num) {
        long start =1, end = num, mid, sqr;
        bool result = false;

        while(start<=end)
        {
            mid = start + (end - start) /2;
            sqr = mid * mid;
            if(sqr == num)
            {
                result = true;
                break;
            }

            if(sqr < num)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return result;
    }
}