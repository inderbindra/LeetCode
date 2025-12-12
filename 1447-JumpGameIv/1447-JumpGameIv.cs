// Last updated: 12/11/2025, 8:00:11 PM
public class Solution {
     public int MinJumps(int[] arr)
        {
            int index = 0, step = 0;
            IDictionary<int, IList<int>> map = new Dictionary<int, IList<int>>();

            for (int j = 0; j < arr.Length; j++)
            {
                if (map.ContainsKey(arr[j]))
                {
                    map[arr[j]].Add(j);
                }
                else
                {
                    map.Add(arr[j], new List<int> { j });
                }
            }

            bool[] visited = new bool[arr.Length];
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            visited[0] = true;  

            int size = 0;
            while (q.Count > 0)
            {
                size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    index = q.Dequeue();
                    if (index == arr.Length - 1)
                    {
                        return step;
                    }
                    
                    
                    if (index + 1 < arr.Length && !visited[index + 1])
                    {
                        q.Enqueue(index + 1);
                        visited[index + 1] = true;
                    }

                    if (index - 1 >= 0 && !visited[index - 1])
                    {
                        q.Enqueue(index - 1);
                        visited[index - 1] = true;
                    }
                    if (map.ContainsKey(arr[index]))
                    {
                        for(int k=0; k < map[arr[index]].Count; k++)
                        {
                            if (!visited[map[arr[index]][k]])
                            {
                                q.Enqueue(map[arr[index]][k]);
                                visited[map[arr[index]][k]] = true;
                            }
                        }
                        map.Remove(arr[index]); // This will remove the TLE -> Remove the map for the visited items
                    }
                }
                step++;
            }
            return step;
        }
    
    
    
    
}