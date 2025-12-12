// Last updated: 12/11/2025, 8:00:00 PM
public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        
        int l=0, h = arr.Length-1, mid;
        
        // if(arr[h] - (h+1) == 0)
        // {
        //     return arr[h] + k;
        // }

        while(l<=h)
        {
            mid = l + (h-l)/2;
            Console.WriteLine("Low = " + l + " High = " + h);
            Console.WriteLine("Mid = " + mid);
            if((arr[mid] - (mid+1)) < k)
            {
                l = mid+1;
                Console.WriteLine("Low = " + l);
            }
            else
            {
                h = mid -1;
            }
        }
        return l+k;
    }
}