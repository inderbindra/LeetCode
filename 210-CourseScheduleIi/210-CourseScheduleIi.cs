// Last updated: 12/11/2025, 8:02:20 PM
public class Solution {
    HashSet<int> result;
    HashSet<int> visitedSet;
    Dictionary<int, IList<int>> adjMap;
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        result = new();
        visitedSet = new();
        adjMap = new();

        for(int i=0; i<prerequisites.Length; i++)
        {
            adjMap.TryAdd(prerequisites[i][0], new List<int>());
            adjMap[prerequisites[i][0]].Add(prerequisites[i][1]);
        }

        for(int i=0; i<numCourses; i++)
        {
            if(!FindOrder(i))
            {
                break;
            }
        }
        return result.Count == numCourses? result.ToArray() : new int[0];
    }
    private bool FindOrder(int course)
    {
        if(!adjMap.ContainsKey(course))
        {
            result.Add(course);
            return true;
        }
        if(visitedSet.Contains(course))
        {
            return false;
        }
        visitedSet.Add(course);
        for(int i=0; i<adjMap[course].Count; i++)
        {
            if(!FindOrder(adjMap[course][i]))
            {
                return false;
            }
        }
        adjMap.Remove(course);
        visitedSet.Remove(course);
        result.Add(course);
        return true;
    }
}