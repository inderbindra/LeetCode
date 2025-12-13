// Last updated: 12/12/2025, 8:17:25 PM
1public class Solution {
2    public int[] TopKFrequent(int[] nums, int k) {
3        List<int> result = new();
4        PriorityQueue<int, int> pq = new();
5        Dictionary<int, int> dict = new();
6        int i=0;
7        for( i=0; i<nums.Length; i++)
8        {
9            dict.TryAdd(nums[i], 0);
10            dict[nums[i]] += 1;
11        }
12        foreach(var item in dict)
13        {
14            pq.Enqueue(item.Key, item.Value);
15            if(pq.Count>0 && pq.Count > k)
16            {
17                pq.Dequeue();
18            }
19        }
20        while(pq.Count > 0)
21        {
22            result.Add(pq.Dequeue());
23        }
24        return result.ToArray();
25    }
26}