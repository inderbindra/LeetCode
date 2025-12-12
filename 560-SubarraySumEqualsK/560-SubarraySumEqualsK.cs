// Last updated: 12/11/2025, 8:00:59 PM
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> prefixSumMap = new();
        int count=0, sum=0, prefixSum=0;
        prefixSumMap.Add(0, 1);
        for(int i=0; i<nums.Length; i++)
        {
            sum += nums[i];
            prefixSum = sum - k;
            if(prefixSumMap.ContainsKey(prefixSum))
            {
                count += prefixSumMap[prefixSum];
            }
            prefixSumMap.TryAdd(sum, 0);
            prefixSumMap[sum] += 1;
        }
        return count;
    }
}