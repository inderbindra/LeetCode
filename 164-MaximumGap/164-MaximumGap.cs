// Last updated: 12/11/2025, 8:02:32 PM
public class Solution {
    public int MaximumGap(int[] nums) {
        
        if(nums.Length < 2)
        {
            return 0;
        }
        PriorityQueue<int, int> pq = new();
        for(int i=0; i<nums.Length; i++)
        {
            pq.Enqueue(nums[i], nums[i]);
        }
        int diff=0, maxDiff=0, n1=0;
        while(pq.Count > 1)
        {
            n1 = pq.Dequeue();
            diff = pq.Peek() - n1;
            maxDiff = Math.Max(maxDiff, diff);
        }
        return maxDiff;
    }
}
