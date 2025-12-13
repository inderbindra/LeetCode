// Last updated: 12/12/2025, 8:23:17 PM
1public class Solution {
2    public int[] TopKFrequent(int[] nums, int k) {
3        PriorityQueue<int, int> pq = new();
4        Dictionary<int, int> hashMap = new();
5        for(int i=0; i<nums.Length; i++)
6        {
7            hashMap.TryAdd(nums[i], 0);
8            hashMap[nums[i]] += 1;
9        }
10        foreach(var item in hashMap)
11        {
12            pq.Enqueue(item.Key, item.Value);
13            while(pq.Count > 0 && pq.Count > k)
14            {
15                pq.Dequeue();
16            }
17        }
18        List<int> result = new();
19        while(pq.Count > 0)
20        {
21            result.Add(pq.Dequeue());
22        }
23        return result.ToArray();
24    }
25}