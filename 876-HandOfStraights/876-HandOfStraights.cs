// Last updated: 12/11/2025, 8:00:36 PM
public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length % groupSize != 0)
        {
            return false;
        }
        Dictionary<int, int> handMap = new();
        for(int i=0; i<hand.Length; i++)
        {
            handMap.TryAdd(hand[i], 0);
            handMap[hand[i]] += 1;
        }
        PriorityQueue<int, int> pq = new();
        foreach(var key in handMap.Keys)
        {
            pq.Enqueue(key, key);
        }
        int num=0;
        while(pq.Count > 0)
        {
            num = pq.Peek();
            for(int k=num; k<(num+groupSize); k++)
            {
                if(handMap.ContainsKey(k))
                {
                    handMap[k] -= 1;
                    if(handMap[k] == 0)
                    {
                        if(pq.Peek() == k)
                        {
                            handMap.Remove(k);
                            pq.Dequeue();
                        }
                        else
                        {
                            //Console.WriteLine("k = " + k + " handMap[k] = " + handMap[k] + " pq = " + pq.Peek());
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
                
            }
        }
        return true;
    }
}