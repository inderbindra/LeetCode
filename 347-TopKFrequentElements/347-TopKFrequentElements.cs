// Last updated: 12/11/2025, 8:01:47 PM
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> hashMap = new();
        PriorityQueue<int, int> pq = new();
        List<int> result = new();
        for(int i=0; i<nums.Length; i++)
        {
            hashMap.TryAdd(nums[i], 0);
            hashMap[nums[i]] += 1;
        }
        foreach(var item in hashMap)
        {
            pq.Enqueue(item.Key, item.Value);
            if(pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        while(pq.Count > 0)
        {
            result.Add(pq.Dequeue());
        }
        return result.ToArray();
    }
}