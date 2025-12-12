// Last updated: 12/11/2025, 8:02:50 PM
public class Solution {
    public int LongestConsecutive(int[] nums) {
        int seq=0, maxSeq=0, i=0, num=0;

        HashSet<int> hashSet = new();
        for(i=0; i<nums.Length; i++)
        {
            hashSet.Add(nums[i]);
        }
        i=0;
        while(i<nums.Length)
        {
            num = nums[i];
            seq=1;
            if(!hashSet.Contains(num-1))
            {
                num++;
                while(hashSet.Contains(num))
                {
                    seq++;
                    num++;
                }
            }
            maxSeq = Math.Max(maxSeq, seq);
            i++;
        }
        return maxSeq;
    }
}