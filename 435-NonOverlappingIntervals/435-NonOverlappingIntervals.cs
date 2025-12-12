// Last updated: 12/11/2025, 8:01:35 PM
public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        int counter=0;
        intervals = intervals.OrderBy(i=> i[0]).ToArray();
        int prevEnd = intervals[0][1];
        for(int i=1; i<intervals.Length; i++)
        {
            // If the previous interval end is greater than next interval's start then 
            // we need to increment the counter as there is overlapping and
            // also remove the interval which has max prevEnd by assigning min value to prevEnd.
            if(prevEnd > intervals[i][0])
            {
                counter++;
                prevEnd = Math.Min(prevEnd, intervals[i][1]);
            }
            else
            {
                prevEnd = intervals[i][1];
            }
        }
        return counter;
    }
}