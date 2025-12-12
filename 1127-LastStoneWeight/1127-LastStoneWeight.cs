// Last updated: 12/11/2025, 8:00:20 PM
public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> pq = new();
        for(int i=0; i<stones.Length; i++)       
        {
            pq.Enqueue(stones[i], -stones[i]);
        }
        int x=0, y=0;
        while(pq.Count > 1)
        {
            y = pq.Dequeue();
            x = pq.Dequeue();
            if(x != y)
            {
                y = y - x;
                pq.Enqueue(y, -y);
            }
        }
        return pq.Count == 1 ? pq.Peek(): 0;
    }
}