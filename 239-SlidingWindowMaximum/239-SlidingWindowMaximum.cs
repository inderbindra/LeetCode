// Last updated: 12/11/2025, 8:02:02 PM
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        LinkedList<int> deque = new();

        List<int> result = new();
        int right=0;
        while(right < nums.Length)    
        {
            while(deque.Count > 0 && (right - deque.First.Value) >= k)
            {
                deque.RemoveFirst();
            }
            while(deque.Count > 0 && nums[deque.Last.Value] < nums[right])
            {
                deque.RemoveLast();
            }
            deque.AddLast(right);

            if(right + 1 >= k)
            {
                result.Add(nums[deque.First.Value]);
            }
            right++;
        }
        return result.ToArray();
    }
}