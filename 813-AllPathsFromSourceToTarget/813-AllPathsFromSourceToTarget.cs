// Last updated: 12/11/2025, 8:00:43 PM
public class Solution {
    
    IList<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        FindAllPaths(graph, new List<int>(), 0);
        return result;
    }

    public void FindAllPaths(int[][] graph, IList<int> currentList, int index)
    {
        currentList.Add(index); // Add the current Index in the list.
        if(graph.Length == 0)   // Base case if the graph array has no elements.
        {
            return;
        }
        if(index == graph.Length - 1)    // Another base case, if the index is equal to graph.Length-1 that means we reached n-1 node, then only add the currentList object to result.
        {
            int[] copyList = new int[currentList.Count()];  // This array is needed to copy the currentList data, as currentList object is by reference which updates our result by reference on removing items from it.
            currentList.CopyTo(copyList, 0);
            result.Add(copyList);
            return;
        }

        for(int i=0; i< graph[index].Length; i++)
        {
            FindAllPaths(graph, currentList, graph[index][i]);
            currentList.RemoveAt(currentList.Count -1);         //Backtracking
        }
    }
}