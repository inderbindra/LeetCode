// Last updated: 12/11/2025, 8:02:00 PM
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {

        int l =1, h=n, result = n;

        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(IsBadVersion(mid))
            {
                result = mid;
                h = mid -1;
            }
            else
            {
                l = mid+1;
            }
        }
        return result;
    }
}