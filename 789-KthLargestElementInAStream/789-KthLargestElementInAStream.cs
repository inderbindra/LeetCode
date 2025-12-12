// Last updated: 12/11/2025, 8:00:48 PM
public class KthLargest {
    PriorityQueue<int, int> pq;
    int limit;
    public KthLargest(int k, int[] nums) {
        pq = new();
        limit = k;
        for(int i=0; i<nums.Length; i++)
        {
            Add(nums[i]);
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        if(pq.Count > limit)
        {
            pq.Dequeue();
        }
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */