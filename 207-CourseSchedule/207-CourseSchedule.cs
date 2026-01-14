// Last updated: 1/13/2026, 8:03:18 PM
1public class Solution {
2    Dictionary<int, IList<int>> adjList;
3    HashSet<int> visitedCourse;
4    public bool CanFinish(int numCourses, int[][] prerequisites) {
5        adjList = new();
6        visitedCourse = new();
7        for(int i=0; i<prerequisites.Length; i++)        
8        {
9            adjList.TryAdd(prerequisites[i][0], new List<int>());
10            adjList[prerequisites[i][0]].Add(prerequisites[i][1]);
11        }
12
13        bool result = false;
14        for(int i=0; i<numCourses; i++)
15        {
16            result = DFS(i);
17            if(!result)
18            {
19                break;
20            }
21        }
22        return result;
23    }
24    private bool DFS(int course)
25    {
26        if(!adjList.ContainsKey(course))
27        {
28            return true;
29        }
30        if(visitedCourse.Contains(course))
31        {
32            return false;
33        }
34        visitedCourse.Add(course);
35        bool result = false;
36        for(int i=0; i<adjList[course].Count; i++)
37        {
38            result = DFS(adjList[course][i]);
39            if(!result)
40            {
41                break;
42            }
43        }
44        visitedCourse.Remove(course);
45        adjList.Remove(course);
46        return result;
47    }
48}