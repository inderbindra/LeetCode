// Last updated: 12/11/2025, 8:02:22 PM
public class Solution {
    Dictionary<int, List<int>> adjMap;
    HashSet<int> visitedSet;
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        adjMap = new();
        visitedSet = new();
        for(int i=0; i<prerequisites.Length; i++)
        {
            adjMap.TryAdd(prerequisites[i][0], new List<int>());
            adjMap[prerequisites[i][0]].Add(prerequisites[i][1]);
        }
        bool result = false;
        for(int i=0; i<numCourses; i++)
        {
            result = DFS(i);
            if(!result)
            {
                break;
            }
        }
        return result;
    }
    private bool DFS(int course)
    {
        if(!adjMap.ContainsKey(course))
        {
            return true;
        }
        if(visitedSet.Contains(course))
        {
            return false;
        }
        visitedSet.Add(course);
        bool result = false;
        for(int i=0; i<adjMap[course].Count; i++)
        {
            result = DFS(adjMap[course][i]);
            if(!result)
            {
                break;
            }
        }
        visitedSet.Remove(course);
        adjMap.Remove(course);
        return result;
    }
}