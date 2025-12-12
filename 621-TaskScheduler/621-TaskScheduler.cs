// Last updated: 12/11/2025, 8:00:56 PM
public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        PriorityQueue<char, int> pq = new();
        Queue<(char task, int time)> queue = new();
        Dictionary<char, int> hashMap = new();

        for(int i=0; i<tasks.Length; i++)
        {
            hashMap.TryAdd(tasks[i], 0);
            hashMap[tasks[i]] += 1;
        }

        foreach(var item in hashMap)
        {
            pq.Enqueue(item.Key, -item.Value);
        }
        int time=0;
        char task;
        while(pq.Count > 0 || queue.Count > 0)
        {
            time++;
            if(pq.Count > 0)
            {
                task = pq.Dequeue();
                hashMap[task] -= 1;
                if(hashMap[task] > 0)
                {
                    queue.Enqueue((task, time + n));
                }
            }
            while(queue.Count > 0 && queue.Peek().time <= time)
            {
                task = queue.Dequeue().task;
                pq.Enqueue(task, -hashMap[task]);
            }
        }
        return time;
    }
}