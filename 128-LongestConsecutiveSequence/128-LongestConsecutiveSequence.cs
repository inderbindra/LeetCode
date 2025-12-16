public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new();
        int i=0, seq=0, longestSeq=0, num=0;
        for(i=0; i<nums.Length; i++)
        {
            numSet.Add(nums[i]);
        }
        for(i=0; i<nums.Length; i++)
        {
            num = nums[i];
            // The below condition is the optimization which avoid 
            // iteration at both ends -ve & +ve.
            // Checking this condition means this is the start of the sequence.
            if(!numSet.Contains(num - 1))
            {
                seq = 1;
                num++;
                while(numSet.Contains(num))
                {
                    seq++;
                    num++;
                }
                longestSeq = Math.Max(longestSeq, seq);
            }
            // Added this loop to iterate the same sequence start number like if a list contains multiple 1's, so it will only
            // calculate the sequence only once.
            while(i<nums.Length-1 && nums[i] == nums[i+1])
            {
                i++;
            }
        }
        return longestSeq;
    }
}
