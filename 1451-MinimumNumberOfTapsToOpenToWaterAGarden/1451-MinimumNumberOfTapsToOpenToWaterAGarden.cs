// Last updated: 12/11/2025, 8:00:08 PM
public class Solution {
    public int MinTaps(int n, int[] ranges) {
        int[] startEnd = new int[n+1];

        int start=0, end=0;
        for(int i=0; i<ranges.Length; i++)
        {
            start = Math.Max(0, i - ranges[i]);
            end = Math.Min(n, i + ranges[i]);
            startEnd[start] = Math.Max(startEnd[start], end);
        }

        int maxEnd=0, currEnd=0, taps=0;
        for(int i=0; i<startEnd.Length; i++)
        {
            if(i > maxEnd)
            {
                return -1;
            }
            else if(i > currEnd)
            {
                taps++;
                currEnd = maxEnd;
            }
            maxEnd = Math.Max(maxEnd, startEnd[i]);
        }
        return taps;
    }
}